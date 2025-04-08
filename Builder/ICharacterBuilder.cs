using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetHeight(double height);
        ICharacterBuilder SetBodyType(string bodyType);
        ICharacterBuilder SetHairColor(string hairColor);
        ICharacterBuilder SetEyeColor(string eyeColor);
        ICharacterBuilder SetClothes(string clothes);
        ICharacterBuilder SetInventory(List<string> inventory);
        Character Build();
    }

}
