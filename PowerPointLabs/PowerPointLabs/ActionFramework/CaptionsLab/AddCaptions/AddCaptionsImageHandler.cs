﻿using System.Drawing;
using PowerPointLabs.ActionFramework.Common.Attribute;
using PowerPointLabs.ActionFramework.Common.Interface;

namespace PowerPointLabs.ActionFramework.CaptionsLab
{
    [ExportImageRibbonId(TextCollection.AddCaptionsTag)]
    class AddCaptionsImageHandler : ImageHandler
    {
        protected override Bitmap GetImage(string ribbonId)
        {
            return new Bitmap(Properties.Resources.AddCaption);
        }
    }
}
