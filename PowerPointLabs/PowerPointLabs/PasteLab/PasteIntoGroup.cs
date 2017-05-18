﻿using System.Collections.Generic;

using Microsoft.Office.Interop.PowerPoint;

using PowerPointLabs.Models;
using PowerPointLabs.Utils;

namespace PowerPointLabs.PasteLab
{
    internal class PasteIntoGroup
    {
        public static Shape Execute(PowerPointPresentation presentation, PowerPointSlide slide,
                                    ShapeRange selectedShapes, ShapeRange pastingShapes,
                                    float? posLeft = null, float? posTop = null)
        {
            Shape firstSelectedShape = selectedShapes[1];
            ShapeRange newSelectedShapes = slide.CloneShapeFromRange(selectedShapes, firstSelectedShape);

            // Calculate the center to paste at if not specified
            float selectionLeft = newSelectedShapes[1].Left;
            float selectionTop = newSelectedShapes[1].Top;
            float selectionWidth = newSelectedShapes[1].Width;
            float selectionHeight = newSelectedShapes[1].Height;
            if (newSelectedShapes.Count > 1)
            {
                Shape selectionGroup = newSelectedShapes.Group();
                selectionLeft = selectionGroup.Left;
                selectionTop = selectionGroup.Top;
                selectionWidth = selectionGroup.Width;
                selectionHeight = selectionGroup.Height;
                newSelectedShapes.Ungroup();
            }
            
            if (pastingShapes.Count > 1)
            {
                Shape pastedGroup = pastingShapes.Group();
                pastedGroup.Left = posLeft ?? (selectionLeft + (selectionWidth - pastedGroup.Width) / 2);
                pastedGroup.Top = posTop ?? (selectionTop + (selectionHeight - pastedGroup.Height) / 2);
                pastedGroup.ZOrder(Microsoft.Office.Core.MsoZOrderCmd.msoBringToFront);
                pastingShapes.Ungroup();
            }
            else
            {
                pastingShapes[1].Left = posLeft ?? (selectionLeft + (selectionWidth - pastingShapes[1].Width) / 2);
                pastingShapes[1].Top = posTop ?? (selectionTop + (selectionHeight - pastingShapes[1].Height) / 2);
                pastingShapes[1].ZOrder(Microsoft.Office.Core.MsoZOrderCmd.msoBringToFront);
            }

            List<Shape> newGroupShapeList = new List<Shape>();
            for (int i = 1; i <= newSelectedShapes.Count; i++)
            {
                newGroupShapeList.Add(newSelectedShapes[i]);
            }
            for (int i = 1; i <= pastingShapes.Count; i++)
            {
                newGroupShapeList.Add(pastingShapes[i]);
            }

            Shape newGroup = slide.ToShapeRange(newGroupShapeList).Group();
            Graphics.MoveZToJustInFront(newGroup, firstSelectedShape);
            slide.TransferAnimation(firstSelectedShape, newGroup);

            firstSelectedShape.Delete();
            return newGroup;
        }
    }
}
