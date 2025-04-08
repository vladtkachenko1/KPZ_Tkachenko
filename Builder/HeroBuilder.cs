using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HeroBuilder : ICharacterBuilder
    {
        protected Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetHeight(double height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothes(string clothes)
        {
            _character.Clothes = clothes;
            return this;
        }

        public ICharacterBuilder SetInventory(List<string> inventory)
        {
            _character.Inventory = inventory;
            return this;
        }

        public virtual Character Build()
        {
            _character.Alignment = "Good";
            return _character;
        }
    }

}
