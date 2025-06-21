using System;
//Delegado es un tipo de dato que permite pasar metodos como parámetros
//1.1

namespace Delegado
{
    //Declaramos un delegado
    public delegate void MostrarMensaje(string mensaje);

    class Program
    {
        // Este es el método que se asignará al delegado
        public static void MensajePantalla(string texto)
        {
            Console.WriteLine("\n Mostrando mensaje en pantalla: " + texto); 
        }

        // Este método también se asignará al delegado y se ejecutará cuando se invoque el delegado
        public static void MensajeMayuscula(string texto)
        {
            Console.WriteLine("\n En Mayusculas: " + texto.ToUpper());
        }

        static void Main(string[] args)
        {
            MostrarMensaje delegado1 = new MostrarMensaje(MensajePantalla); // Inicialización del delegado con un método específico

            delegado1("Hola Probando Esto "); //Llamada al delegado con un método asignado
            delegado1 = MensajeMayuscula; // Asignación directa de un método al delegado
            delegado1("Esto es un Delegado "); 

            MostrarMensaje delegadoCompuesto = MensajePantalla; // Inicialización del delegado con un método
            // += se utiliza para agregar métodos al delegado...
            // Esto permite que el delegado invoque múltiples métodos en una sola llamada, ejecutándolos en el orden en que fueron agregados.
            delegadoCompuesto += MensajeMayuscula;  

            Console.WriteLine("\n Llamando al Delegado Compuesto:  "); 
            delegadoCompuesto("Prueba Compuesto");
            Console.ReadKey();

        }
    }
}
