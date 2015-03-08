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
            return TextDisplayHelper.ExpandCamelHumps(label, " ");
        }
    }
}
