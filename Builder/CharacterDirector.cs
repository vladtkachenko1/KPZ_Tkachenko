using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CharacterDirector
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder
                .SetName("Aurora")
                .SetHeight(1.75)
                .SetBodyType("Athletic")
                .SetHairColor("Blonde")
                .SetEyeColor("Blue")
                .SetClothes("Armor of Light")
                .SetInventory(new List<string> { "Sword", "Shield", "Potion" })
                .Build();
        }

        public Character CreateEnemy(EnemyBuilder builder)
        {
            return builder
                .SetName("Nightmare")
                .SetHeight(2.0)
                .SetBodyType("Beastly")
                .SetHairColor("Black")
                .SetEyeColor("Red")
                .SetClothes("Dark Cloak")
                .SetInventory(new List<string> { "Claws", "Poison" })
                .Build();
        }
    }

}
