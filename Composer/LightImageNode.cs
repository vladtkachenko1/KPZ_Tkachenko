using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    public class LightImageNode : LightNode
    {
        private string _href;
        private IImageLoadingStrategy _loadingStrategy;
        private string _targetFolder;

        public LightImageNode(string href, IImageLoadingStrategy loadingStrategy, string targetFolder)
        {
            _href = href;
            _loadingStrategy = loadingStrategy;
            _targetFolder = targetFolder;
        }

        public override string InnerHTML() => string.Empty;

        public override string OuterHTML()
        {
            string finalSrc = _loadingStrategy.LoadImage(_href, _targetFolder);
            return $"<img src=\"{finalSrc}\" />";
        }

        public override void TriggerEvent(string eventType) { }
    }

}
