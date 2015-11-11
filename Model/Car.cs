using System.Drawing;

namespace Model
{
    public class Car
    {
        public readonly string Model;
        public readonly string CarNumber;
        public readonly Category Category;
        public readonly CarPassport CarPassport;


        public Car(string model, string carNumber, Category category)
        {
            Model = model;
            CarNumber = carNumber;
            Category = category;
            CarPassport = new CarPassport(this);
            Color = Color.Blue;
        }

        public Color Color { get; set; }
    }
}
