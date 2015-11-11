namespace Model
{
    public class CarPassport
    {
        public readonly Car Car;

        public CarPassport(Car car)
        {
            Car = car;
            Owner = new Driver("This car doesn't have owner.");
        }

        public Driver Owner { get; set; }
    }
}
