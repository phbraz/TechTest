namespace Domain
{
    public class Car
    {
        public bool CarRunning { get; private set; }

        public void Start(Person passengers)
        {

            if (passengers.PassengersAmount > passengers.MaxPassengers)
            {
                throw new Exception("Too many passengers");
            }

            CarRunning = true;
        }
    }

    public class MotorBike
    {
        public bool MotorBikeRunning { get; private set; }

        public void Start(Person passengers)
        {
            if (passengers.PassengersAmount > passengers.MaxPassengers)
            {
                throw new Exception("Too many passengers");
            }

            MotorBikeRunning = true;
        }
    }

    public class Coach
    {
        public bool CoachRunning { get; private set; }

        public void Start(Person passengers)
        {
            if (passengers.PassengersAmount > passengers.MaxPassengers)
            {
                throw new Exception("Too many passengers");
            }

            CoachRunning = true;
        }

    }


    public class Person
    {
        public int PassengersAmount { get; set; }
        public VehicleType Vehicle { get; set; }

        public int MaxPassengers
        {
            get
            {
                return Vehicle switch
                {
                    VehicleType.Car => 4,
                    VehicleType.MotorBike => 2,
                    VehicleType.Coach => 25,
                    _ => throw new ArgumentException("Wrong Vehicle type")

                };
            }
        }

        public enum VehicleType
        {
            Car,
            MotorBike,
            Coach
        }

    }
}