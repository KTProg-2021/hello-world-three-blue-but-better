using System;

namespace MultiFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate start = new Coordinate(12, 23, 34);
            Item trinket = new Item("box","green");
            Person patient = new Person("Joe Smith", "5'11\"", "175 lbs");
            Automobile car = new Automobile("Toyota", "RAV4");
            City location = new City("Framingham", "Massachusetts");
            Appliance kitchenItem = new Appliance("Refrigerator", 799, "black");

            Console.WriteLine("Hello World!");
            start.display();
            trinket.display();
            patient.display();
            car.display();
            location.display();
            kitchenItem.display();
        }
    }
}
