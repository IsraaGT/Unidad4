using System;
using System.Runtime.InteropServices;

namespace Unidad4
{
    [Guid("D12F2A97-BF5E-4F8A-B1D0-4E0AE8E1AA1A")]
    [ComVisible(true)]
    public interface IHelloWorld
    {
        string GetMessage();
    }

    [Guid("B21B3C2C-BC76-4D84-9B58-7121F801B39B")]
    [ComVisible(true)]
    public class HelloWorld : IHelloWorld
    {
        public string GetMessage()
        {
            return "¡Hola desde el Servidor DCOM!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Aquí podrías iniciar el servidor DCOM 
            Console.WriteLine("Servidor DCOM en ejecución...");
            // El servidor simplemente imprime un mensaje indicando que está en ejecución
            Console.ReadLine();  
        }
    }
}
