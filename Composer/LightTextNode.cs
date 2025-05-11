using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composer
{
    class LightTextNode : LightNode
    {
        public string Text { get; set; }

        public LightTextNode(string text)
        {
            Text = text;
        }

        public override string InnerHTML()
        {
            return Text;
        }

        public override string OuterHTML()
        {
            return Text;
        }
        public override void TriggerEvent(string eventType)
        {
            // Нічого не робимо, бо текстові вузли не підтримують події
        }

    }
}
