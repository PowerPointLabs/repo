﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;
using PowerPointLabs.TextCollection;

namespace PowerPointLabs.ActionFramework.ZoomLab
{
    [ExportLabelRibbonId(TextCollection1.ZoomToAreaTag)]
    class ZoomToAreaLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return ZoomLabText.ZoomToAreaButtonLabel;
        }
    }
}
