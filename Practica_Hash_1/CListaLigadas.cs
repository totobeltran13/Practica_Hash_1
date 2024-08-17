using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Hash_1
{
    public class CListaLigada
    {
        private CNodo cabeza;

        public CListaLigada()
        {
            cabeza = null;
        }

        // Agregar un nuevo nodo a la lista
        public void Agregar(int key, string value)
        {
            CNodo nuevoNodo = new CNodo(key, value);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                CNodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
        }

        // Buscar un nodo por la clave
        public string Buscar(int key)
        {
            CNodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Key == key)
                    return actual.Value;
                actual = actual.Siguiente;
            }
            return null;
        }

        // Eliminar un nodo por la clave
        public void Eliminar(int key)
        {
            if (cabeza == null) return;

            if (cabeza.Key == key)
            {
                cabeza = cabeza.Siguiente;
                return;
            }

            CNodo actual = cabeza;
            CNodo anterior = null;
            while (actual != null && actual.Key != key)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }

            if (actual != null)
            {
                anterior.Siguiente = actual.Siguiente;
            }
        }
    }

}
