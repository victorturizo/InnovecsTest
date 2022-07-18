using InnovecsTest.Core.Interfaces;
using InnovecsTest.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Xml.Serialization;

namespace InnovecsTest.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesConsumerController : ControllerBase
    {
        private readonly ICosumerGateway _cosumerGateway;
        public CompaniesConsumerController(ICosumerGateway cosumerGateway)
        {
            _cosumerGateway = cosumerGateway;
        }
        [HttpPost("API1")]
        public IActionResult ConsumerAPI1(InputAPI1 model)
        {
            return Ok(_cosumerGateway.ConsumerAPI1(model));
        }

        [HttpPost("API2")]
        public IActionResult ConsumerAPI2(InputAPI2 model)
        {
            return Ok(_cosumerGateway.ConsumerAPI2(model));

        }

        [HttpPost("API3")]
        [Consumes("application/xml")]
        public async Task<ActionResult> ConsumerAPI3()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(InputAPI3));
            var modelApi = new InputAPI3();
            string xml;
            using (System.IO.StreamReader reader = new System.IO.StreamReader(Request.Body, Encoding.UTF8))
            {
               xml =  await reader.ReadToEndAsync();
            
            }
            using (TextReader reader = new StringReader(xml))
            {
                modelApi = (InputAPI3)deserializer.Deserialize(reader);
            }
 
            return Ok(_cosumerGateway.ConsumerAPI3(modelApi));

        }
    }
}
