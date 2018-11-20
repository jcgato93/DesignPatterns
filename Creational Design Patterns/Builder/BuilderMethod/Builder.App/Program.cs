using System;
using Builder.App;
using Builder.App.Builders;
using Builder.App.Cars;

namespace Builder.App
{
    class Program
    {
        static void Main(string[] args)
        {
           Builder.App.Director.Director director = new Builder.App.Director.Director();

            // Director gets the concrete builder object from the client
            // (application code). That's because application knows better which
            // builder to use to get a specific product.
            CarBuilder builder = new CarBuilder();
            director.constructCityCar(builder);

            // The final product is often retrieved from a builder object, since
            // Director is not aware and not dependent on concrete builders and
            // products.
            Car car = builder.getResult();
            Console.WriteLine("Car built:\n" + car.getType());


            CarManualBuilder manualBuilder = new CarManualBuilder();

            // Director may know several building recipes.
            director.constructCityCar(manualBuilder);
            Manual carManual = manualBuilder.getResult();
            Console.WriteLine("\nCar manual built:\n" + carManual.print());
        }
    }
}
