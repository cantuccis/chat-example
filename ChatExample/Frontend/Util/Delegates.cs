using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Util
{
    /*
     * Un delegate es un objeto que representa una función.
     * Como C# es fuertemente tipado, las funciones también pueden ser tipos.
     * En este caso, OnError es un tipo de funcion que recibe un string y devuelve void.
     * Funciona como si fuera una clase, se pueden crear variables y parámetros de tipo OnError.
     * De esta forma se pueden crear punteros a funciones (para hacer callbacks por ejemplo).
     */
    public delegate void OnError(string errorMessage);

}
