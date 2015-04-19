using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace RazorGlide.Forms
{
    /// <summary>
    /// Contains information used to render EditorControlGroup partial view, containing
    /// data about labels, valid state and options that control how the editor is
    /// displayed
    /// </summary>
    public class EditorControlGroupProperties
    {
        private ModelMetadata modelMetadata;

        public EditorControlGroupProperties(string expression, ViewDataDictionary viewData, IHtmlString editorHtml)
        {
            Expression = expression;
            ViewData = viewData;
            EditorHtml = editorHtml;
        }
        public string Expression { get; private set; }

        public ViewDataDictionary ViewData { get; private set; }

        /// <summary>
        /// Contains the HTML for the editor elements - this is rendered in advance for 
        /// display within the control group template
        /// </summary>
        public IHtmlString EditorHtml { get; private set; }

        public string Label
        {
            get { return LabelFormatter.LabelText(ModelMetadata); }
        }

        public ModelMetadata ModelMetadata
        {
            get
            {
                if (modelMetadata == null)
                {
                    modelMetadata = ModelMetadata.FromStringExpression(Expression, ViewData);
                }
                return modelMetadata;
            }
        }

        /// <summary>
        /// Indicates whether the current property (or any of its child properties
        /// if it is a complex object) is invalid
        /// </summary>
        public bool IsValid
        {
            get
            {
                return ViewData.ModelState.IsValidField(Expression);
            }
        }

        /// <summary>
        /// Indicates whether there are any validation errors for the current property itself
        /// </summary>
        public bool IsPropertyValid
        {
            get
            {
                var modelState = ViewData.ModelState[Expression];
                return modelState == null || !modelState.Errors.Any();
            }
        }
    }
}
