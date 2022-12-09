// 9/12/2022

/*
$ export DOTNET_ROOT=$HOME/.dotnet
$ export PATH=$PATH:$HOME/.dotnet:$HOME/.dotnet/tools

$ dotnet run

http://localhost:5054/swagger/index.html
*/


using Microsoft.AspNetCore.Mvc;

namespace _02_Proyecto.Controllers;

[ApiController]
[Route("/v1/servicios/mastermind")]
public class MastermindController : ControllerBase
{
    [HttpPost("nuevo")]
    // Guid: identificador univoco de numeros
    public Guid NuevoJuego(ConfiguracionMastermind configuracion)
    {
        return Guid.NewGuid();
    }

    [HttpPost("jugada")]
    // IEnumerable: como el iterador de java, me permite recorrerlo con un foreach
    public IEnumerable<string> Jugada(int[] jugada)
    {
        var r = new Random();
        foreach (var numero in jugada)
        {
            // generamos numeros entre [0,3]
            switch(r.Next(0,4)) 
            {
                case 0: yield return "correcto"; break;
                case 1: yield return "parcial"; goto case 0; // pasame del case1 al case0
                case 2: yield return "fallo"; break;
                case 3: yield return "error"; break;
            }
        }
    }
}
