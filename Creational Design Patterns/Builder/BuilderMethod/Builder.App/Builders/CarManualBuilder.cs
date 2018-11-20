using Builder.App.Cars;
using Builder.App.Components;

namespace Builder.App.Builders
{
    /**
    * Unlike other creational patterns, Builder can construct unrelated products,
    * which don't have the common interface.
    *
    * In this case we build a user manual for a car, using the same steps as we
    * built a car. This allows to produce manuals for specific car models,
    * configured with different features.
    */
    public class CarManualBuilder: Builder
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

        public Manual getResult()
        {
            return new Manual (type, seats, engine, transmission, tripComputer, gpsNavigator);
        }
    }
}