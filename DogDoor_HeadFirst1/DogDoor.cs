using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoor_HeadFirst1
{
    class DogDoor
    {
        private bool isOpen;
        private List<Bark> allowedBarks;

        public void Open()
        {
            if (!isOpen)
            {
                Console.WriteLine("Door opened");
                isOpen = true;
            }

            Thread.Sleep(3);
            Close();
        }

        public void Close()
        {
            if (isOpen)
                Console.WriteLine("Door Closed"); isOpen = false;

        }

        public bool IsOpen()
        {
            return isOpen;
        }

        public List<Bark> GetAllowedBarks()
        {
            return allowedBarks;
        }

        /// <summary>
        /// Add allowed bark
        /// </summary>
        /// <param name="bark">The bark</param>
        public void AddAllowedBark(Bark bark)
        {
            if (allowedBarks == null)
                allowedBarks = new List<Bark>();

            allowedBarks.Add(bark);
        }
    }
}
