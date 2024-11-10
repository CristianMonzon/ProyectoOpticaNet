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
            ""FirstName"": ""José"",
            ""LastName"": ""Pérez"",
            ""BirthDay"": ""1985-03-15""
        },
        {
            ""FirstName"": ""María"",
            ""LastName"": ""González"",
            ""BirthDay"": ""1990-07-22""
        },
        {
            ""FirstName"": ""Carlos"",
            ""LastName"": ""Rodríguez"",
            ""BirthDay"": ""1978-11-30""
        },
        {
            ""FirstName"": ""Ana"",
            ""LastName"": ""Martínez"",
            ""BirthDay"": ""1995-01-10""
        },
        {
            ""FirstName"": ""Luis"",
            ""LastName"": ""Sánchez"",
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
