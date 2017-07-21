﻿using System.Diagnostics;

using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.Help
{
    [ExportActionRibbonId(TextCollection1.FeedbackTag)]
    class FeedbackActionHandler : ActionHandler
    {
        protected override void ExecuteAction(string ribbonId)
        {
            Process.Start(TextCollection1.FeedbackUrl);
        }
    }
}
