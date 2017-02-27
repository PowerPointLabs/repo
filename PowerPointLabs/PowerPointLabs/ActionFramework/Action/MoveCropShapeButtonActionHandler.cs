﻿using Microsoft.Office.Interop.PowerPoint;
using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Extension;
using PowerPointLabs.ActionFramework.Common.Interface;
using PowerPointLabs.CropLab;


namespace PowerPointLabs.ActionFramework.Action
{
    [ExportActionRibbonId("MoveCropShapeButton")]
    class MoveCropShapeButtonActionHandler : CropLabActionHandler
    {
        private static readonly string FeatureName = "Crop To Shape";

        protected override void ExecuteAction(string ribbonId)
        {
            CropLabErrorHandler errorHandler = CropLabErrorHandler.InitializeErrorHandler(CropLabUIControl.GetSharedInstance());
            if (!VerifyIsSelectionValid(this.GetCurrentSelection()))
            {
                HandleErrorCodeIfRequired(CropLabErrorHandler.ErrorCodeSelectionIsInvalid, FeatureName, errorHandler);
                return;
            }
            ShapeRange shapeRange = this.GetCurrentSelection().ShapeRange;
            if (shapeRange.Count < 1)
            {
                HandleErrorCodeIfRequired(CropLabErrorHandler.ErrorCodeSelectionCountZero, FeatureName, errorHandler);
                return;
            }
            if (!IsShapeForSelection(shapeRange))
            {
                HandleErrorCodeIfRequired(CropLabErrorHandler.ErrorCodeSelectionMustBeShape, FeatureName, errorHandler);
                return;
            }
            try
            {
                CropToShape.Crop(this.GetCurrentSlide(), this.GetCurrentSelection());
            }
            catch (CropLabException)
            {
                HandleErrorCodeIfRequired(CropLabErrorHandler.ErrorCodeUndefined, FeatureName, errorHandler);
            }
        }
    }
}