using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxceligentTest
{
    public class Question6
    {
        public void ConstructionGame()
        {
            var myHouse = new Building()
                .AddKitchen()
                .AddBedroom("master")
                .AddBedroom("guest")
                .AddBalcony();

            var normalHouse = myHouse.Build();

            //kitchen, master room, guest room, balcony
            Console.WriteLine(normalHouse.Describe());

            myHouse.AddKitchen().AddBedroom("another");

            var luxuryHouse = myHouse.Build();

            //it only shows the kitchen after build
            //kitchen, master room, guest room, balcony, kitchen, another room
            Console.WriteLine(luxuryHouse.Describe());
        }

        public class Building
        {
            private string home = string.Empty;
            public Building AddKitchen()
            {
                home += home.Length > 0 ? ", kitchen" : "kitchen";
                return this;
            }
            public Building AddBedroom(string roomType)
            {
                home += home.Length > 0 ? ", " + roomType + " room" : roomType + " room";
                return this;
            }
            public Building AddBalcony()
            {
                home += home.Length > 0 ? ", balcony" : "balcony";
                return this;
            }
            public string Describe()
            {
                return home;
            }
            public Building Build()
            {
                return this;
            }
        }

    }
}
