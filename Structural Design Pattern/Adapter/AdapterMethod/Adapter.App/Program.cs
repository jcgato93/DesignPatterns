using System;

namespace Adapter.App
{
    /*
    * ITarget define la interface esperada por el cliente    
    */
    interface ITarget
    {
        string GetRequest();
    }

    /*
    * El Adaptee contiene algún comportamiento útil, pero su
    La interfaz es incompatible / con el código de cliente existente. El Adaptee
    Necesita alguna adaptación antes de que el código del cliente pueda usarlo.
     */
    class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Request especifico";
        }
    }


    /*
      el adaptador hace compatible la interfaz de Adaptee con la interfaz de ITarget  
    */
    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            // Realiza el proceso de adaptacion de los datos y retorna el resultado
            // esperado por el cliente

            return $"This is '{_adaptee.GetSpecificRequest()}'";
        }
    }



    class Client
    {
        public void Main()
        {
            Adaptee adaptee = new Adaptee();

            ITarget target = new Adapter(adaptee);

            Console.WriteLine("La interfaz de Adaptee es incompatible con el cliente");
            Console.WriteLine("Pero con el adaptador el cliente puede llamar el metodo");

            Console.WriteLine(target.GetRequest());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
