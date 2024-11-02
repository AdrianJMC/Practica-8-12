using System;
using System.Collections.Generic;

namespace PilaReemplazo
{
    public class Pila
    {
        // La pila interna para almacenar los enteros
        private Stack<int> pila = new Stack<int>();

        // Método para agregar un valor a la pila
        public void Apilar(int valor)
        {
            pila.Push(valor);
        }

        // Método para reemplazar valores en la pila
        public void Reemplazar(int nuevo, int viejo)
        {
            Stack<int> pilaTemporal = new Stack<int>();
            bool reemplazado = false;  // Bandera para indicar si ya se hizo el reemplazo

            // Recorremos la pila para hacer el reemplazo solo del último valor igual
            while (pila.Count > 0)
            {
                int valor = pila.Pop();

                if (valor == viejo && !reemplazado)
                {
                    pilaTemporal.Push(nuevo);
                    reemplazado = true;  // Marcamos que ya hemos hecho el reemplazo
                }
                else
                {
                    pilaTemporal.Push(valor);
                }
            }

            // Restauramos el orden original en la pila
            while (pilaTemporal.Count > 0)
            {
                pila.Push(pilaTemporal.Pop());
            }
        }

        // Método para obtener la pila como una lista para mostrarla
        public List<int> ObtenerElementos()
        {
            return new List<int>(pila);
        }
    }
}
