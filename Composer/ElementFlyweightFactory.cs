using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Composer
{

    public class ElementFlyweightFactory
    {
        private readonly Dictionary<string, LightElementNode> _cache = new();

        public LightElementNode GetElement(string tagName)
        {
            if (!_cache.ContainsKey(tagName))
            {
                _cache[tagName] = new LightElementNode(tagName);
            }

            // Створюємо новий екземпляр на основі кешованого шаблону
            var template = _cache[tagName];
            return new LightElementNode(template.TagName);
        }
    }

}
