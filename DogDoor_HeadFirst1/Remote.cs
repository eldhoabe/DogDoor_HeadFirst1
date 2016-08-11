using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogDoor_HeadFirst1
{
    class Remote
    {
        /// <summary>
        /// The door object to deal with
        /// </summary>
        DogDoor door;

        public Remote(DogDoor dogDoor)
        {
            door = dogDoor;
        }

        /// <summary>
        /// Press the remot button
        /// </summary>
        public void PressButton()
        {
            Console.WriteLine("Pressed the remote button");

            if (door.IsOpen())
                door.Close();
        }
    }
}
