﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;
using PowerPointLabs.TextCollection;

namespace PowerPointLabs.ActionFramework.ZoomLab
{
    [ExportSupertipRibbonId(TextCollection1.ZoomLabMenuId)]
    class ZoomLabMenuSupertipHandler : SupertipHandler
    {
        protected override string GetSupertip(string ribbonId)
        {
            return ZoomLabText.ZoomLabMenuSupertip;
        }
    }
}
