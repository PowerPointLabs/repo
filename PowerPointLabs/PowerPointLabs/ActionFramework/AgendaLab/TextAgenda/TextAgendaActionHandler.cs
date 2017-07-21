﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Extension;
using PowerPointLabs.ActionFramework.Common.Interface;
using PowerPointLabs.AgendaLab;

namespace PowerPointLabs.ActionFramework.AgendaLab
{
    [ExportActionRibbonId(TextCollection1.TextAgendaTag)]
    class TextAgendaActionHandler : ActionHandler
    {
        protected override void ExecuteAction(string ribbonId)
        {
            this.StartNewUndoEntry();

            AgendaLabMain.GenerateAgenda(Type.Bullet);
        }
    }
}
