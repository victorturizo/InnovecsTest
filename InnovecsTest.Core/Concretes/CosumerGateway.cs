using InnovecsTest.Core.Interfaces;
using InnovecsTest.Core.Logic;
using InnovecsTest.Core.Models;
using InnovecsTest.Core.Models.Response;

namespace InnovecsTest.Core.Concretes
{
    public class CosumerGateway : ICosumerGateway
    {
       public static List<int> ListData = new List<int>() { 100, 200, 300, 400, 500, 250, 145 };

        public ResponseAPIS ConsumerAPI1(InputAPI1 inputAPI1)
        {

            return new ResponseAPIS() { Exitoso = true, Mensaje = $" Total = " + ListData.Min(x => x) };
        }

        public ResponseAPIS ConsumerAPI2(InputAPI2 inputAPI1)
        {

            return new ResponseAPIS() { Exitoso = true, Mensaje = $" Tmount = " + ListData.Min(x => x) };
        }

        public ResponseAPIS ConsumerAPI3(InputAPI3 inputAPI1)
        {
            return new ResponseAPIS() { Exitoso = true, Mensaje = $" Quote = " + ListData.Min(x => x) };
        }
    }
}
