using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : HeroBuilder
    {
        private List<string> evilDeeds = new List<string>();

        public EnemyBuilder AddEvilDeed(string deed)
        {
            evilDeeds.Add(deed);
            return this;
        }

        public override Character Build()
        {
            _character.Alignment = "Evil";
            _character.Actions = evilDeeds;
            return _character;
        }
    }

}
