﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.ShortcutsLab
{
    [ExportLabelRibbonId(TextCollection1.EditNameTag)]
    class EditNameLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection1.EditNameShapeLabel;
        }
    }
}
