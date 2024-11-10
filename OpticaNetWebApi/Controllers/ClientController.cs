using Microsoft.AspNetCore.Mvc;
using OpticaNetWebApi.Repositories.Dto;
using System;

namespace OpticaNetWebApi.Controllers
{
    using System.Text.Json;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private static readonly string JsonClients = @"
    [
        {
            ""FirstName"": ""Jos�"",
            ""LastName"": ""P�rez"",
            ""BirthDay"": ""1985-03-15""
        },
        {
            ""FirstName"": ""Mar�a"",
            ""LastName"": ""Gonz�lez"",
            ""BirthDay"": ""1990-07-22""
        },
        {
            ""FirstName"": ""Carlos"",
            ""LastName"": ""Rodr�guez"",
            ""BirthDay"": ""1978-11-30""
        },
        {
            ""FirstName"": ""Ana"",
            ""LastName"": ""Mart�nez"",
            ""BirthDay"": ""1995-01-10""
        },
        {
            ""FirstName"": ""Luis"",
            ""LastName"": ""S�nchez"",
            ""BirthDay"": ""1982-09-05""
        }
    ]";

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetClients")]
        public IEnumerable<Client> Get()
        {
            var clients = JsonSerializer.Deserialize<List<Client>>(JsonClients, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return clients ?? new List<Client>();
        }
    }

    
}
