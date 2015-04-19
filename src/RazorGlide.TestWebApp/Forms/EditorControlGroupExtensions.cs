using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace RazorGlide.Forms
{
    /// <summary>
    /// Contains extension methods for displaying editor elements together with surrounding HTML,
    /// labels and validation messages
    /// </summary>
    public static class EditorControlGroupExtensions
    {
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method 
        /// together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression)
        {
            return html.EditorControlGroup(expression, null, null, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method 
        /// together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression, Func<object, HelperResult> templateDelegate)
        {
            return html.EditorControlGroup(expression, null, null, null, templateDelegate);
        }
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method 
        /// together with surrounding HTML, labels and validation messages 
        /// </summary>
        private static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression, string templateName = null, string htmlFieldName = null, object additionalViewData = null, Func<object, HelperResult> templateDelegate = null, GroupOptions options = null)
        {
            var editorHtml = RenderEditor(html, expression, templateName, htmlFieldName, additionalViewData, templateDelegate);
            var properties = new EditorControlGroupProperties(expression, html.ViewData, editorHtml);
            // Make properties available to partial view via ViewBag, retaining ViewData and 
            // model from the current view
            html.ViewBag.EditorControlGroupProperties = properties;

            options = options ?? GroupOptions.Default;
            return html.Partial(options.GroupTemplate);
        }

        private static IHtmlString RenderEditor(HtmlHelper html, string expression, string templateName = null, string htmlFieldName = null, object additionalViewData = null, Func<object, HelperResult> templateDelegate = null)
        {
            if (templateDelegate != null)
            {
                var metaData = ModelMetadata.FromStringExpression(expression, html.ViewData);
                var helperResult = templateDelegate(metaData.Model);
                return new MvcHtmlString(helperResult.ToHtmlString());
            }
            else
            {
                return html.Editor(expression, templateName, htmlFieldName, additionalViewData);
            }
        }
    }
}
