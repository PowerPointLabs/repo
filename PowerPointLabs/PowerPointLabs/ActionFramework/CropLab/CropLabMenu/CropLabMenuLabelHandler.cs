﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.CropLab
{
    [ExportLabelRibbonId(TextCollection1.CropLabMenuId)]
    class CropLabMenuLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection1.CropLabMenuLabel;
        }
    }
}
