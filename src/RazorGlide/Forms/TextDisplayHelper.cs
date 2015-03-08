using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RazorGlide.Forms
{
    public static class TextDisplayHelper
    {
        public static string FormatList(IEnumerable<string> sequence, string separator = "", string lastSeparator = null)
        {
            if (separator == null) throw new ArgumentNullException("separator");
            lastSeparator = lastSeparator ?? separator;

            var result = new StringBuilder();
            var items = sequence.ToArray();
            int lastIndex = items.Length - 1;
            for (int index = 0; index < items.Length; index++)
            {
                if (index > 0)
                {
                    result.Append(index == lastIndex ? lastSeparator : separator);
                }
                result.Append(items[index]);
            }
            return result.ToString();
        }

        /// <summary>
        /// Returns singular or plural term based on quantity
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="singular"></param>
        /// <param name="plural"></param>
        /// <returns></returns>
        public static string Pluralise(int quantity, string singular, string plural = null)
        {
            if (plural == null)
                plural = singular + "s";
            return quantity == 1 ? singular : plural;
        }

        /// <summary>
        /// Adds separator between lowercase and uppercase characters
        /// </summary>
        /// <param name="value"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string ExpandCamelHumps(string value, string separator = " ")
        {
            return Regex.Replace(value, "([a-z])(?=[A-Z])", "$1" + separator);
        }
    }
}
