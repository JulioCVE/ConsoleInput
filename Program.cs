namespace ConsoleInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figura f = new Cuadrado(5M);
            
            f.ImprimirArea();
            f.ImprimirPerimetro();

           // Console.WriteLine("Introduce tu nombre");
           // var nombre= Console.ReadLine();
           // Console.WriteLine("Hola "+ nombre);
            
           Console.WriteLine("Presione ENTER para salir");
           Console.ReadLine();
        }
    }
}