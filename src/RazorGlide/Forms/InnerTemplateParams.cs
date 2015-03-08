using System;
using System.Web.WebPages;

namespace RazorGlide.Forms
{
    /// <summary>
    /// Holds parameters that should be supplied in nested calls to Html.Editor and Html.Display 
    /// within EditorControlGroup and DisplayControlGroup templates
    /// </summary>
    public class InnerTemplateParams
    {
        public string TemplateName { get; set; }
        public string LabelText { get; set; }
        public string HtmlFieldName { get; set; }
        public object AdditionalViewData { get; set; }
        public Func<object> TemplateDelegate { get; set; }
        public Func<object, HelperResult> ExecuteTemplate { get; set; }
    }
}
