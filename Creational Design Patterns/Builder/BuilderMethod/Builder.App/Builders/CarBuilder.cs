using Builder.App.Cars;
using Builder.App.Components;

namespace Builder.App.Builders
{
    /**
    * Concrete builders implement steps defined in the common interface.
    */
    public class CarBuilder : Builder
    {
        private Type type;
        private int seats;
        private Engine engine;
        private Transmission transmission;
        private TripComputer tripComputer;
        private GPSNavigator gpsNavigator;

        public void setEngine(Engine engine)
        {
            this.engine = engine;
        }

        public void setGPSNavigator(GPSNavigator gPSNavigator)
        {
            this.gpsNavigator = gPSNavigator;
        }

        public void setSeats(int seats)
        {
            this.seats = seats;
        }

        public void setTransmission(Transmission transmission)
        {
            this.transmission = transmission;
        }

        public void setTripComputer(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }

        public void setType(Type type)
        {
            this.type = type;
        }

        public Car getResult()
        {
            return new Car(type, seats, engine, transmission, tripComputer, gpsNavigator);
        }
    }
}