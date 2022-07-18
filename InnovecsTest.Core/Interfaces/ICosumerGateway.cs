using InnovecsTest.Core.Models;
using InnovecsTest.Core.Models.Response;

namespace InnovecsTest.Core.Interfaces
{
    public interface ICosumerGateway
    {
        ResponseAPIS ConsumerAPI1(InputAPI1 inputAPI1);
        ResponseAPIS ConsumerAPI2(InputAPI2 inputAPI1);
        ResponseAPIS ConsumerAPI3(InputAPI3 inputAPI1);

    }
}
