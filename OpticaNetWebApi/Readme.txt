Para crear endpoints simples en C# con la intención de desplegarlos en Azure en el futuro, la mejor opción es utilizar ASP.NET Core Web API. Esta tecnología es ideal para su caso de uso por varias razones:

## ASP.NET Core Web API

ASP.NET Core Web API es una excelente elección para crear APIs simples y escalables. Ofrece las siguientes ventajas:

1. **Simplicidad**: Permite crear endpoints de manera rápida y sencilla.

2. **Rendimiento**: Ofrece un alto rendimiento, especialmente importante para APIs.

3. **Compatibilidad con Azure**: Tiene una integración perfecta con Azure, facilitando el despliegue futuro.

4. **Escalabilidad**: Diseñado para ser escalable, lo que es crucial si su API crece en el futuro.

5. **Soporte a largo plazo**: Siendo parte del ecosistema .NET, tiene un soporte continuo y actualizaciones regulares.

## Creación de un proyecto ASP.NET Core Web API

Para comenzar, siga estos pasos:

1. Abra Visual Studio.
2. Cree un nuevo proyecto.
3. Seleccione "ASP.NET Core Web API".
4. Elija la versión más reciente de .NET (actualmente .NET 8.0).
5. Asegúrese de que la opción "Use controllers" esté marcada.

## Ejemplo de un endpoint simple

Aquí tiene un ejemplo de cómo crear un endpoint simple:

```csharp
using Microsoft.AspNetCore.Mvc;

namespace YourApiNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from the Weather API!");
        }
    }
}
```

Este código crea un endpoint simple que responde a solicitudes GET en `/Weather` con un mensaje de saludo[1][2].

## Consideraciones para Azure

Cuando esté listo para desplegar en Azure, podrá utilizar Azure App Service, que es totalmente compatible con ASP.NET Core Web APIs. Azure ofrece una integración sencilla y herramientas para el monitoreo y escalado de su API[3].

## Conclusión

ASP.NET Core Web API es la opción más adecuada para su caso. Le permite crear endpoints simples rápidamente, ofrece un excelente rendimiento y tiene una ruta de actualización clara para cuando necesite características más avanzadas o despliegue en Azure.

Citations:
[1] https://www.c-sharpcorner.com/article/asp-net-core-5-0-web-api/
[2] https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?tabs=visual-studio-code&view=aspnetcore-7.0
[3] https://learn.microsoft.com/es-es/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0
[4] https://bravedeveloper.com/2020/12/05/crear-web-api-practica-y-funcional-con-net-core-y-c/
[5] https://www.youtube.com/watch?v=qBTe6uHJS_Y
[6] https://www.youtube.com/watch?v=L7XyPCvNBg8
[7] https://www.youtube.com/watch?v=eRTmNqUCjXM
[8] https://dotnettutorials.net/course/asp-net-core-web-api-tutorials/