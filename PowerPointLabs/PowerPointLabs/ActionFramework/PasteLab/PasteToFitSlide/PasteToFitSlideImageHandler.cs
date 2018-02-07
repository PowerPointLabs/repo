﻿using System.Drawing;
using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;
using PowerPointLabs.TextCollection;

namespace PowerPointLabs.ActionFramework.PasteLab
{
    [ExportImageRibbonId(PasteLabText.PasteToFitSlideTag)]
    class PasteToFitSlideImageHandler : ImageHandler
    {
        protected override Bitmap GetImage(string ribbonId)
        {
            // Need a new image for PasteToFitSlide
            return new Bitmap(Properties.Resources.PasteToFitSlide);
        }
    }
}
