namespace Alcoholi.Domian.Entities
{
    public class SerAlcohol
    {
     private int _cant;
        private int Cantliquido;
        private int Peso;
        private double tConsumido;
        private double CantAlcoholDirectoSangre;
        private double etanol = 0.789;
        private double etanoensangre;
        private double volumenDeSangre;
        private double AlcholSangre;
        private double gradoAlcohol;
        private string Bebida;
        public void AlcoholConsumidoPers(string bebida, int cantidad)
        {
            _cant = cantidad;
            Bebida = bebida.ToLower();
            switch (Bebida)
            {
                    case "cerveza":
                     Cantliquido = 330;
                    _cant = _cant *  Cantliquido;
                    gradoAlcohol = 5;
                    tConsumido= gradoAlcohol / 100 * _cant;
                    break;
                    case "vino": 
                    Cantliquido = 100;
                    _cant = _cant * Cantliquido;
                    gradoAlcohol = 12;
                   tConsumido = gradoAlcohol / 100 * _cant;
                    break;
                    case "cava": 
                     Cantliquido = 100;
                    _cant = _cant *  Cantliquido;
                    gradoAlcohol = 12;
                    tConsumido= gradoAlcohol / 100 * _cant;
                    break;
                    case "vermu":
                     Cantliquido = 70;
                    _cant = _cant *  Cantliquido;
                    gradoAlcohol = 17;
                    tConsumido = gradoAlcohol / 100 * _cant;
                    break;
                    case "licor":
                     Cantliquido = 45;
                    _cant = _cant *  Cantliquido;
                    gradoAlcohol = 23;
                    tConsumido = gradoAlcohol / 100 * _cant;
                    break;
                    case "brandy":
                     Cantliquido = 45;
                    _cant = _cant *  Cantliquido;
                    gradoAlcohol = 38;
                    tConsumido = gradoAlcohol / 100 * _cant;
                    break;
                    case "combinado":
                     Cantliquido = 50;
                    _cant = _cant * Cantliquido;
                    gradoAlcohol = 38;
                    tConsumido = gradoAlcohol / 100 * _cant;
                    break;
        }
        }
        public void PasaSangre(int peso)
        {
           Peso = peso;
            CantAlcoholDirectoSangre = 0.15 * tConsumido;
            etanoensangre = etanol * CantAlcoholDirectoSangre;
            volumenDeSangre = 0.8 * Peso;
            AlcholSangre = etanoensangre / volumenDeSangre;
        
        }
        
        public string Resultado()
        {
                if (AlcholSangre >  0.8)
                {
                    return $" Su nivel de alcohol en la sangre es: {AlcholSangre}  es superior al limite que nos propone en el reglamento, no es apto que conduzca";
                }
                    return $" Su nivel de alcohol en la sangre es: {AlcholSangre}  no es superior al limite que nos propone en el reglamento,  es apto para conducir";
               
        }

    }
}