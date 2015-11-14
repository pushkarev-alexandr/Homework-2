using System;
using System.Collections.Generic;

namespace Model
{
    public class Driver
    {
        public readonly DateTime LicenceDate;
        public readonly string Name;

        public Driver(string name, DateTime licenceDate)
        {
            Name = name;
            LicenceDate = licenceDate;
            Categories = new List<Category>();
        }

        public int Experience
        {
            get { return (DateTime.Now - LicenceDate).Days / 365; }
        }

        public List<Category> Categories { get; set; }

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            try
            {
                if (Categories.Contains(car.Category))
                {
                    Car = car;
                    Car.CarPassport.Owner = this;
                }
                else
                    throw new Exception("Can't drive this type of car");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
