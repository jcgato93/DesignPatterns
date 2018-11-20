using System;
using Builder.App.Cars;

namespace Builder.App.Components
{
    public class TripComputer
    {
        private Car car;

        public void setCar(Car car)
        {
            this.car = car;
        }

        public void showFuelLevel()
        {
            Console.WriteLine("Fuel level: " + car.getFuel());
        }

        public void showStatus()
        {
            if (this.car.getEngine().isStarted())
            {
                Console.WriteLine("Car is started");
            }
            else
            {
                Console.WriteLine("Car isn't started");
            }
        }
    }
}