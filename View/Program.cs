using System;
using System.Collections.Generic;
using System.Drawing;
using Model;

namespace View
{
    class Program
    {
        static void Main()
        {
            var car = new Car("LADA", "o777oo", Category.D) {Color = Color.DarkViolet};
            try
            {
                Console.WriteLine(car.CarPassport.Owner.Name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var driver = new Driver("Voldemar",new DateTime(2015,4,15));
            driver.Categories.Add(Category.B);
            driver.Categories.Add(Category.C);
            driver.OwnCar(car);
            driver.Categories.Add(Category.D);
            driver.OwnCar(car);
            Console.WriteLine(driver.Car.CarNumber);
            Console.WriteLine(car.CarPassport.Owner.Name);

            Console.ReadLine();
        }
    }
}
