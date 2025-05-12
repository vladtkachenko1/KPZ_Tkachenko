using System.Text;

namespace Composer
{
    public class LightElementNode : LightNode
    {
        public string TagName { get; set; }
        public string DisplayType { get; set; }
        public bool IsSelfClosing { get; set; }
        public List<string> CssClasses { get; set; }
        public List<LightNode> Children { get; set; }

        private Dictionary<string, List<Action>> _eventListeners;

        public LightElementNode(string tagName, string displayType = "block", bool isSelfClosing = false)
        {
            TagName = tagName;
            DisplayType = displayType;
            IsSelfClosing = isSelfClosing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
            _eventListeners = new Dictionary<string, List<Action>>();
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

        public void AddEventListener(string eventType, Action listener)
        {
            if (!_eventListeners.ContainsKey(eventType))
            {
                _eventListeners[eventType] = new List<Action>();
            }
            _eventListeners[eventType].Add(listener);
        }

        public void TriggerEvent(string eventType)
        {
            if (_eventListeners.ContainsKey(eventType))
            {
                foreach (var listener in _eventListeners[eventType])
                {
                    listener();
                }
            }
        }

        public ElementIterator GetIterator()
        {
            return new ElementIterator(this);
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
