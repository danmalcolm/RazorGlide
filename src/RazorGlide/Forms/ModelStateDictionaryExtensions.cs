using System.Linq;
using System.Web.Mvc;

namespace RazorGlide.Forms
{
    public static class ModelStateDictionaryExtensions
    {
        /// <summary>
        /// Determines whether there are model errors for a given field. ModelStateDictionary already has an
        /// IsValidField method, which always considers a field invalid if any child objects or collection
        /// items (prefixed by the key) are invalid. This extension adds an extra parameter to control whether 
        /// a field is considered invalid if child values have errors.
        /// </summary>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <param name="includeChildren"></param>
        /// <returns></returns>
        public static bool IsValidField(this ModelStateDictionary dictionary, string key, bool includeChildren)
        {
            if (includeChildren)
            {
                return dictionary.IsValidField(key);
            }
            var modelState = dictionary[key];
            return (modelState == null) || !modelState.Errors.Any();
        }
    }
}