﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.Label.CropLab
{
    [ExportLabelRibbonId(TextCollection.CropOutPaddingTag)]
    class CropOutPaddingLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection.CropOutPaddingLabel;
        }
    }
}
