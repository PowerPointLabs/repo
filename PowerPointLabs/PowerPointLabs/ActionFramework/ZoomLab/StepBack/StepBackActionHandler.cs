﻿using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Extension;
using PowerPointLabs.ActionFramework.Common.Interface;
using PowerPointLabs.ZoomLab;

namespace PowerPointLabs.ActionFramework.ZoomLab
{
    [ExportActionRibbonId(TextCollection1.StepBackTag)]
    class StepBackActionHandler : ActionHandler
    {
        protected override void ExecuteAction(string ribbonId)
        {
            this.StartNewUndoEntry();

            AutoZoom.AddStepBackAnimation();
        }
    }
}
