﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Extension;
using PowerPointLabs.ActionFramework.Common.Interface;
using PowerPointLabs.SyncLab.Views;

namespace PowerPointLabs.ActionFramework.SyncLab
{
    [ExportActionRibbonId(TextCollection1.SyncLabTag)]
    class SyncLabActionHandler : ActionHandler
    {
        protected override void ExecuteAction(string ribbonId)
        {
            this.RegisterTaskPane(typeof(SyncPane), TextCollection1.SyncLabTaskPanelTitle);
            var syncPane = this.GetTaskPane(typeof(SyncPane));
            // toggle pane visibility
            syncPane.Visible = !syncPane.Visible;
        }
    }
}
