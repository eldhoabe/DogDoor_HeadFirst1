using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoor_HeadFirst1
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            door.AddAllowedBark(new Bark("Bow"));
            door.AddAllowedBark(new Bark("Bow bow"));
            door.AddAllowedBark(new Bark("Bobo"));
            door.AddAllowedBark(new Bark("Bowwwww"));

            BarkRecogizer recgonizer = new BarkRecogizer(door);
            Remote remote = new Remote(door);


            //Mock barking
            Console.WriteLine("Dog start barking");
            recgonizer.Recognize(new Bark("bobo"));

            Console.WriteLine("Dog went out");
            Thread.Sleep(3);

            Console.WriteLine("Dog all done");

            //Mock another dog
            Bark newbk = new Bark("bha");
            recgonizer.Recognize(newbk);

            Console.WriteLine("Bruce is barkinh");
            recgonizer.Recognize(new Bark("bow bow"));
            

            Console.ReadLine();
        }
    }
}
