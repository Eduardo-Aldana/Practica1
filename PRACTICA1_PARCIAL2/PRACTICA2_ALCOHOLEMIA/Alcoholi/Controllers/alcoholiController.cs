 /*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Joel Ivan Chuc Uc
    Nombre de la actividad: Actividad 1, Ejercicio 2: Alcohol
    Nombre del alumno:Brahim Eduardo Aldana Chuc
    Cuatrimestre: 4
    Grupo: A
    Parcial: 2
    */

using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Alcoholi.Domian.Entities;

namespace Alcoholi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class alcoholiController : ControllerBase
    {
        
         [Route("Calcula")]
        
        public IActionResult Obtener(string Bebida,int cant, int Peso)
        {
            
            var resultado = new SerAlcohol();
            resultado.AlcoholConsumidoPers(Bebida,cant);
            if(Bebida.ToLower()!= "cerveza" && Bebida.ToLower()!="vino" && Bebida.ToLower()!="cava" &&Bebida.ToLower()!="vermu" && Bebida.ToLower()!="licor" && Bebida.ToLower()!="brandy")
            {
                return Ok("ERROR: La bebida que ingreso es incorrecta, intente de nuevo.");
            }
            resultado.PasaSangre(Peso);
            
            return Ok(resultado.Resultado());
        }
        
    }
}