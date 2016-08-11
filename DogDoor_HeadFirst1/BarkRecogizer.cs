using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoor_HeadFirst1
{
    class BarkRecogizer
    {
        private DogDoor door;

        public BarkRecogizer(DogDoor dogDoor)
        {
            door = dogDoor;
        }

        public void Recognize(Bark bark)
        {
            if (door.GetAllowedBarks().Contains(bark))
                door.Open();
            else
                Console.WriteLine("This bark is not allowed");
        }
    }
}
