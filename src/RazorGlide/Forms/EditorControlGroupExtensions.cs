using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace RazorGlide.Forms
{
    /// <summary>
    /// Contains extension methods for displaying editor elements together with surrounding HTML, labels and validation messages
    /// </summary>
    public static class EditorControlGroupExtensions
    {
        private const string ControlGroupTemplate = "ControlGroup";

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression)
        {
            return html.EditorControlGroup(expression, null, null, null);
        }
        
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression, object additionalViewData)
        {
            return html.EditorControlGroup(expression, null, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression, string templateName)
        {
            return html.EditorControlGroup(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression, string templateName, object additionalViewData)
        {
            return html.EditorControlGroup(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression, string templateName, string htmlFieldName)
        {
            return html.EditorControlGroup(expression, templateName, htmlFieldName, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Editor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroup(this HtmlHelper html, string expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            var templateParams = new InnerTemplateParams
            {
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName
            };
            // additionalViewData used to pass on parameters to EditorSection
            return html.Editor(expression, ControlGroupTemplate, new { TemplateParams = templateParams });
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return html.EditorControlGroupFor(expression, null, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Func<TValue, HelperResult> template)
        {
            return html.EditorControlGroupFor(expression, (object)null, template);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object additionalViewData, Func<TValue,HelperResult> template)
        {
            Func<object, HelperResult> executeTemplate = value => template((TValue) value);
            return html.EditorControlGroupFor(expression, null, null, null, null, executeTemplate);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, MvcHtmlString content)
        {
            return html.EditorControlGroupFor(expression, null, null, null, () => content, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object additionalViewData)
        {
            return html.EditorControlGroupFor(expression, null, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName)
        {
            return html.EditorControlGroupFor(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, object additionalViewData)
        {
            return html.EditorControlGroupFor(expression, templateName, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName)
        {
            return html.EditorControlGroupFor(expression, templateName, htmlFieldName, null);
        }
        
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            var templateParams = new InnerTemplateParams
            {
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName
            };
            // additionalViewData used to pass on parameters to EditorSection
            return html.EditorFor(expression, ControlGroupTemplate, new { TemplateParams = templateParams });
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper EditorFor extension method together with surrounding HTML, labels and validation messages 
        /// </summary>
        public static MvcHtmlString EditorControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData, Func<MvcHtmlString> template, Func<object, HelperResult> executeTemplate)
        {
            var templateParams = new InnerTemplateParams
            {
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName,
                TemplateDelegate = template,
                ExecuteTemplate = executeTemplate
            };
            // additionalViewData used to pass on parameters to EditorSection
            return html.EditorFor(expression, ControlGroupTemplate, new { TemplateParams = templateParams });
        }
    }
}
