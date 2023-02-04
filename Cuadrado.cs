using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInput
{
    public class Cuadrado : Figura
    {
        private decimal _lado;
        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }
        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }
        public override decimal CalcularPerimetro()
        {
            return 4 * _lado;
        }
        public override void ImprimirArea() 
        {
            Console.WriteLine("El Area del cuadrado es: " + CalcularArea());
        }
        public override void ImprimirPerimetro()
        {
            Console.WriteLine("El Perimetro del cuadrado es: " + CalcularPerimetro());
        }
    }

}
