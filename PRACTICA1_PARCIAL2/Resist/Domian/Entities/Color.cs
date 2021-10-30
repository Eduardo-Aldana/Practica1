using System;
using Resist.Domian.Interfaces;
namespace Resist.Domian.Entities
{
    public class Color : ICalculos
    {
        private string _C1,_C2,_C3,_C4,value1,value2, _result;
        private int valor = 0;
        public double suma = 0.0;
         public double _result2 = 0.0;
        public double _result3 = 0.0;
        public double ResultadOMAST=0.0;
         public double RESULTADOMENOST=0.0;
        
        public void Bandeja1 (string C1)
        {
            _C1 = C1;
            switch(C1){
                case "Negro":
                value1="0";
                break;
                case "Cafe":
                value1 = "1";
                break;
                case "Rojo":
                value1 = "2";
                break;
                case "Naranja":
                value1 = "3";
                break;
                case "Amarillo":
                value1 = "4";
                break;
                case "Verde":
                value1 = "5";
                break;
                case "Azul":
                value1 = "6";
                break;
                case "Violeta":
                value1 = "7";
                break;
                case "Gris":
                value1 = "8";
                break;
                case "Blanco":
                value1 = "9";
                break;
        
                
            }
        }
        public void Bandeja2 (string C2)
        {
            _C2 = C2;
            switch(C2){
                case "Negro":
                value2="0";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Cafe":
                value2 = "1";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Rojo":
                value2 = "2";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Naranja":
                value2 = "3";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Amarillo":
                value2 = "4";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Verde":
                value2 = "5";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Azul":
                value2 = "6";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Violeta":
                value2 = "7";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Gris":
                value2 = "8";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
                case "Blanco":
                value2 = "9";
                _result = value1 + value2;
                valor = int.Parse(_result);
                break;
               
            }
        }
        public void Bandeja3 (string C3)
        {
            _C3 = C3;
            switch(C3){
                case "Negro":
                _result2 = 1;
                suma = valor * _result2;
                break;
                case "Cafe":
                _result2 = 10;
                suma = valor * _result2;
                break;
                case "Rojo":
                _result2 = 100;
                suma = valor * _result2;
                break;
                case "Naranja":
                _result2 = 1000;
                suma = valor * _result2;
                break;
                case "Amarillo":
                _result2 = 1000;
                suma = valor * _result2;
                break;
                case "Verde":
                _result2 = 10000;
                suma = valor * _result2;
                break;
                case "Azul":
                _result2 = 100000;
                suma = valor * _result2;
                break;
                case "Violeta":
                _result2 = 1000000;
                suma = valor * _result2;
                break;
                case "Gris":
                _result2 = 10000000;
                suma = valor * _result2;
                break;
                case "Blanco":
                _result2 = 100000000;
                suma = valor * _result2;
                break;
               
            }
        }
        public void Bandeja4 (string C4)
        {
            _C4 = C4;

                if(C4 == "Dorado"){
                _result3 = (suma * 5)/100;
                }
                if(C4 == "Plata"){
                _result3 = suma * 10/100;
                }
    
            
         ResultadOMAST= suma + _result3;
         RESULTADOMENOST= suma - _result3;  
        }

        public string RetornaCalculo()
        {
             return $"el valor es {suma} y la tolerancia + o - {_result3} El rango de toleracia si tiene mas el {_result3} es de: {ResultadOMAST} El rango de tolerancia si tiene menos el {_result3} es de : {RESULTADOMENOST}  ";
        }

        
    }

    
}
    