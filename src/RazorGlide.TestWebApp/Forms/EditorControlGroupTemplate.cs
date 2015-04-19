using System;
using System.Web.Mvc;

namespace RazorGlide.Forms
{
    /// <summary>
    /// Base class for partial view templates used to render editor control groups
    /// </summary>
    public abstract class EditorControlGroupTemplate : WebViewPage
    {
        private EditorControlGroupProperties properties;

        protected EditorControlGroupProperties Properties
        {
            get
            {
                if (properties == null)
                {
                    properties = ViewBag.EditorControlGroupProperties as EditorControlGroupProperties;
                    if (properties == null)
                    {
                        throw new Exception("EditorControlGroupProperties not available in ViewBag");
                    }
                }
                return properties;
            }
        }
    }
}