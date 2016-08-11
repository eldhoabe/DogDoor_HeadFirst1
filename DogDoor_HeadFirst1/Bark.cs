using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoor_HeadFirst1
{
    class Bark
    {
        private string sound;

        public Bark(string bark)
        {
            this.sound = bark;
        }


        public string GetBark()
        {
            return sound;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Bark))
            {
                Bark otherBark = obj as Bark;
                return sound.Equals(otherBark.sound, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.sound.GetHashCode();
        }
    }
}
