using System;
using System.Collections;




namespace Practica_Hash_1
{
    using System;

    using System;

    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Programa
    {
        static void Main(string[] args)
        {
            // Crear la tabla hash
            Hashtable tablaHash = new Hashtable();

            // Inicializar la tabla hash con listas ligadas vacías
            for (int i = 1; i <= 5; i++)
            {
                tablaHash.Add(i, new List<string>());
            }

            // Función para agregar un nombre a una clave específica
            void AgregarValor(int key, string value)
            {
                if (tablaHash.ContainsKey(key))
                {
                    List<string> lista = (List<string>)tablaHash[key];
                    lista.Add(value);
                }
            }

            // Agregar valores iniciales a las claves
            AgregarValor(1, "Alice");
            AgregarValor(2, "Bob");
            AgregarValor(3, "Charlie");
            AgregarValor(4, "David");
            AgregarValor(5, "Eve");

            // Agregar más valores aleatorios a las mismas claves
            AgregarValor(1, "Zoe");
            AgregarValor(2, "Oscar");
            AgregarValor(3, "Mallory");
            AgregarValor(4, "Trent");
            AgregarValor(5, "Victor");

            // Mostrar los valores en la tabla hash
            Console.WriteLine("Valores en la tabla hash:");
            foreach (DictionaryEntry entry in tablaHash)
            {
                Console.Write($"Clave: {entry.Key}, Valores: ");
                List<string> lista = (List<string>)entry.Value;
                Console.WriteLine(string.Join(", ", lista));
            }

            // Buscar valores asociados a una clave específica
            int claveBuscada = 3;
            if (tablaHash.ContainsKey(claveBuscada))
            {
                List<string> lista = (List<string>)tablaHash[claveBuscada];
                Console.WriteLine($"\nValores asociados a la clave {claveBuscada}: {string.Join(", ", lista)}");
            }
            else
            {
                Console.WriteLine($"\nClave {claveBuscada} no encontrada en la tabla hash.");
            }

            // Eliminar un valor específico de una lista en una clave
            int claveEliminar = 2;
            string valorEliminar = "Oscar";
            if (tablaHash.ContainsKey(claveEliminar))
            {
                List<string> lista = (List<string>)tablaHash[claveEliminar];
                if (lista.Remove(valorEliminar))
                {
                    Console.WriteLine($"\nValor '{valorEliminar}' eliminado de la clave {claveEliminar}.");
                }
                else
                {
                    Console.WriteLine($"\nValor '{valorEliminar}' no encontrado en la clave {claveEliminar}.");
                }
            }

            // Mostrar los valores en la tabla hash después de eliminar
            Console.WriteLine("\nValores en la tabla hash después de eliminar:");
            foreach (DictionaryEntry entry in tablaHash)
            {
                Console.Write($"Clave: {entry.Key}, Valores: ");
                List<string> lista = (List<string>)entry.Value;
                Console.WriteLine(string.Join(", ", lista));
            }

            Console.ReadLine();
        }
    }

}


