﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.ShapesLab
{
    [ExportLabelRibbonId(TextCollection1.AddCustomShapeTag)]
    class AddShapeLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection1.AddCustomShapeShapeLabel;
        }
    }
}
