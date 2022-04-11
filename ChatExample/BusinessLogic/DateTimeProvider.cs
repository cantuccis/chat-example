using System;

namespace BusinessLogic
{
    /*
    Esta clase solo sirve como wrapper de DateTime para fijar el valor de DateTime.Now.
    Fijar el valor de DateTime.Now es necesario para algunos tests.
    A este tipo de clases se les conoce como "Mock", son usadas para facilitar el unit testing.
     */
    public abstract class DateTimeProvider
    {
        private static DateTime? _fixedValue = null; //El signo ? en el tipo de la variable significa que _fixedValue puede ser null. https://docs.microsoft.com/en-us/learn/modules/csharp-null-safety/
        public static DateTime Now
        {
            get => _fixedValue ?? DateTime.Now; // ?? es un operador que devuelve _fixedValue si _fixedValue != null, sino devuelve el valor de la derecha.
            set => _fixedValue = value;
        }

        public static void Reset() => _fixedValue = null;
    }
}