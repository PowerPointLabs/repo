﻿using System.Windows;

using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.Enabled.PasteLab
{
    [ExportEnabledRibbonId("PasteAndReplace", "PasteAndReplaceFreeform", "PasteAndReplacePicture")]
    class PasteLabReplaceEnabledHandler : EnabledHandler
    {
        protected override bool GetEnabled(string ribbonId)
        {
            return Clipboard.GetDataObject() != null;
        }
    }
}