using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace RazorGlide.Forms
{
    public class LabelFormatter
    {
        public static string LabelText(ModelMetadata metadata)
        {
            return metadata.DisplayName ?? (metadata.PropertyName != null ? UserFriendlyTitle(metadata.PropertyName) : "");
        }
            
        public static string UserFriendlyTitle(string label)
        {
            return Regex.Replace(label, "([a-z])(?=[A-Z])", "$1" + " ");
        }
    }
}
