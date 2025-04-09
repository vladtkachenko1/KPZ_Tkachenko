using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; }
        public bool IsSelfClosing { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        public LightElementNode(string tagName, string displayType = "block", bool isSelfClosing = false)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public int ChildrenCount()
        {
            return Children.Count;
        }

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in Children)
            {
                sb.Append(child.OuterHTML());
            }
            return sb.ToString();
        }

        public override string OuterHTML()
        {
            string classes = CssClasses.Count > 0 ? $" class=\"{string.Join(" ", CssClasses)}\"" : "";

            if (IsSelfClosing)
            {
                return $"<{TagName}{classes}/>";
            }

            return $"<{TagName}{classes}>{InnerHTML()}</{TagName}>";
        }
    }

}
