﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.HighlightLab
{
    [ExportSupertipRibbonId(TextCollection1.HighlightTextTag)]
    class HighlightTextSupertipHandler : SupertipHandler
    {
        protected override string GetSupertip(string ribbonId)
        {
            return TextCollection1.HighlightTextFragmentsButtonSupertip;
        }
    }
}
