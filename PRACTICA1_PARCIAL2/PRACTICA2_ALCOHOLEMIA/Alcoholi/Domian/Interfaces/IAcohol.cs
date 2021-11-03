
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Alcoholi.Domian.Interfaces
{
    public interface IAcohol
    {
       public  void AlcoholConsumidoPers(string bebida, int cantidad);
        public  void PasaSangre(int peso);
    
          public String Resultado();

    }
}