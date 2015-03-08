using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace RazorGlide.Forms
{
    public static class DisplayControlGroupExtensions
    {
        private const string ControlGroupTemplateName = "ControlGroup";

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label
        /// </summary>
        public static MvcHtmlString DisplayControlGroup(this HtmlHelper html, string expression)
        {
            return html.DisplayControlGroup(expression, null, null, null);
        }
        
        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroup(this HtmlHelper html, string expression, object additionalViewData)
        {
            return html.DisplayControlGroup(expression, null, null, additionalViewData);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroup(this HtmlHelper html, string expression, string templateName)
        {
            return html.DisplayControlGroup(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label
        /// </summary>
        public static MvcHtmlString DisplayControlGroup(this HtmlHelper html, string expression, string templateName, object additionalViewData)
        {
            return html.DisplayControlGroup(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label
        /// </summary>
        public static MvcHtmlString DisplayControlGroup(this HtmlHelper html, string expression, string templateName, string htmlFieldName)
        {
            return html.DisplayControlGroup(expression, templateName, htmlFieldName, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper Display extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroup(this HtmlHelper html, string expression, string templateName, string htmlFieldName, object additionalViewData)
        {
            var templateParams = new InnerTemplateParams
            {
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName
            };
            // additionalViewData used to pass on parameters to ControlGroup
            return html.Display(expression, ControlGroupTemplateName, new { TemplateParams = templateParams });
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            return html.DisplayControlGroupFor(expression, null, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label
        /// </summary>
        public static MvcHtmlString DisplayControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, Func<TValue, HelperResult> template)
        {
            Func<object, HelperResult> executeTemplate = value => template((TValue)value);
            return html.DisplayControlGroupFor(expression, null, null, null, null, executeTemplate);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, object additionalViewData)
        {
            return html.DisplayControlGroupFor(expression, null, null, additionalViewData, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName)
        {
            return html.DisplayControlGroupFor(expression, templateName, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, object additionalViewData)
        {
            return html.DisplayControlGroupFor(expression, templateName, null, additionalViewData, null, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, object additionalViewData, string labelText)
        {
            return html.DisplayControlGroupFor(expression, templateName, null, additionalViewData, labelText, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName)
        {
            return html.DisplayControlGroupFor(expression, templateName, htmlFieldName, null);
        }

        /// <summary>
        /// Returns the HTML input elements created by the HtmlHelper DisplayFor extension method together with surrounding HTML and label 
        /// </summary>
        public static MvcHtmlString DisplayControlGroupFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData, string labelText, Func<object, HelperResult> executeTemplate)
        {
            var templateParams = new InnerTemplateParams
            {
                LabelText = labelText,
                TemplateName = templateName,
                AdditionalViewData = additionalViewData,
                HtmlFieldName = htmlFieldName,
                ExecuteTemplate = executeTemplate
            };
            // additionalViewData used to pass on parameters to ControlGroup
            return html.DisplayFor(expression, ControlGroupTemplateName, new { TemplateParams = templateParams });
        }

    }
}
