using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorGlide.Forms
{
    public class GroupOptions
    {
        static GroupOptions()
        {
            Default = new GroupOptions { GroupTemplate = "EditorControlGroup" };
        }

        public static GroupOptions Default { get; set; }
        public string GroupTemplate { get; set; }
    }
}