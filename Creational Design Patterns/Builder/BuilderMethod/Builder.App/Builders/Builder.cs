using Builder.App.Cars;
using Builder.App.Components;

namespace Builder.App.Builders
{
    public interface Builder
    {
         void setType(Type type);
         void setSeats(int seats); //asientos
         void setEngine(Engine engine);//motor
         void setTransmission(Transmission transmission);// tipo de transmision
         void setTripComputer(TripComputer tripComputer);
         void setGPSNavigator(GPSNavigator gPSNavigator);
    }
}