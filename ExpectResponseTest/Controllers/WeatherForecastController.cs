using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ExpectResponseTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(FileWrapper), (int)HttpStatusCode.Created)]
        public IActionResult UploadFile([FromForm] FileWrapper file)
        {
            Console.WriteLine("File received");
            string message = "FileReceived";
            return Ok(message);
        }
    }
}