﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.AgendaLab
{
    [ExportLabelRibbonId(TextCollection1.VisualAgendaTag)]
    class VisualAgendaLabelHandler : LabelHandler
    {
        protected override string GetLabel(string ribbonId)
        {
            return TextCollection1.AgendaLabVisualAgendaButtonLabel;
        }
    }
}
