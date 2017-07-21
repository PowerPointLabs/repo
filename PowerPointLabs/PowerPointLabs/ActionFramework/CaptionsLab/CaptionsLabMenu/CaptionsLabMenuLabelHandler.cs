﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.CaptionsLab
{
    [ExportLabelRibbonId(TextCollection1.CaptionsLabMenuId)]
    class CaptionsLabMenuLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection1.CaptionsLabMenuLabel;
        }
    }
}
