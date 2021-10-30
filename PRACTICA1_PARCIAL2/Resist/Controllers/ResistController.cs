 /*Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicios
    Nombre del Maestro: Joel Ivan Chuc Uc
    Nombre de la actividad: Actividad 1, Ejercicio 1: Resistencia
    Nombre del alumno:Brahim Eduardo Aldana Chuc
    Cuatrimestre: 4
    Grupo: A
    Parcial: 2
    */

using Microsoft.AspNetCore.Mvc;
using Resist.Domian.Entities;
using System;
namespace Resist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResistController : ControllerBase
    {
         [HttpGet]
        [Route("calculo")]
        public IActionResult Calculo(string C1,string C2,string C3,string C4)
        {
            var resul = new Color();
            resul.Bandeja1(C1);
            resul.Bandeja2(C2);
            resul.Bandeja3(C3);
            resul.Bandeja4(C4);
            resul.RetornaCalculo();
            return Ok(resul.RetornaCalculo());
        }
    }
}
