﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.CropLab
{
    [ExportSupertipRibbonId(TextCollection1.CropToSlideTag)]
    class CropToSlideSupertipHandler : SupertipHandler
    {
        protected override string GetSupertip(string ribbonId)
        {
            return TextCollection1.CropToSlideButtonSupertip;
        }
    }
}
