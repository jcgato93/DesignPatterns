using Builder.App.Components;

namespace Builder.App.Cars
{
    public class Car
    {
        private Type type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;
        private double fuel = 0;

        public Car(Type type, int seats, Engine engine, Transmission transmission,
                       TripComputer tripComputer, GPSNavigator gpsNavigator)
        {
            this.type = type;
            this.seats = seats;
            this.engine = engine;
            this.transmission = transmission;
            this.tripComputer = tripComputer;
            this.gpsNavigator = gpsNavigator;
        }

        public Type getType()
        {
            return type;
        }

        public double getFuel()
        {
            return fuel;
        }

        public void setFuel(double fuel)
        {
            this.fuel = fuel;
        }

        public int getSeats()
        {
            return seats;
        }

        public Engine getEngine()
        {
            return engine;
        }

        public Transmission getTransmission()
        {
            return transmission;
        }

        public TripComputer getTripComputer()
        {
            return tripComputer;
        }

        public GPSNavigator getGpsNavigator()
        {
            return gpsNavigator;
        }


    }
}