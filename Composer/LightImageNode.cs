using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class LightImageNode : LightNode
    {
        public string Href { get; set; }
        private readonly IImageLoadingStrategy _strategy;

        public LightImageNode(string href, IImageLoadingStrategy strategy)
        {
            Href = href;
            _strategy = strategy;
        }

        public override string OuterHTML()
        {
            return _strategy.LoadImage(Href);
        }

        public override string InnerHTML()
        {
            return string.Empty;
        }
    }
}
