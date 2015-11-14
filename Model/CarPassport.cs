using System;

namespace Model
{
    public class CarPassport
    {
        public readonly Car Car;
        private Driver _owner;

        public CarPassport(Car car)
        {
            Car = car;
        }

        public Driver Owner
        {
            get
            {
                if (_owner != null)
                    return _owner;
                throw new Exception("Car doesn't have owner.");
            }
            set { _owner = value; }
        }
    }
}
