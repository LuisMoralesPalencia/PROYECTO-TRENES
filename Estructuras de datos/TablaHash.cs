using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_TRENES.Estructuras_de_datos
{
    public class TablaHash<K, V>
    {
        private int tamanio;
        private K[] claves;
        private V[] valores;

        public TablaHash(int tamanio)
        {
            this.tamanio = tamanio;
            claves = new K[tamanio];
            valores = new V[tamanio];
        }

        private int HashFunction(K clave)
        {
            int hashCode = clave.GetHashCode();
            return Math.Abs(hashCode % tamanio);
        }

        public bool ContieneClave(K clave)
        {
            int indice = HashFunction(clave);

            while (claves[indice] != null)
            {
                if (claves[indice].Equals(clave))
                {
                    return true;
                }
                indice = (indice + 1) % tamanio;
            }
            return false;
        }

        public List<K> ObtenerClaves()
        {
            List<K> listaClaves = new List<K>();
            for (int i = 0; i < tamanio; i++)
            {
                if (claves[i] != null)
                {
                    listaClaves.Add(claves[i]);
                }
            }
            return listaClaves;
        }

        public void InsertarValores(K clave, V valor)
        {
            if (ContieneClave(clave))
            {
                Console.WriteLine("Clave ya existente: " + clave);
                return;
            }

            int indice = HashFunction(clave);

            while (claves[indice] != null && !claves[indice].Equals(clave))
            {
                indice = (indice + 1) % tamanio;
            }

            claves[indice] = clave;
            valores[indice] = valor;

            Console.WriteLine("Valor insertado: Clave=" + clave + ", Valor=" + valor);
        }

        public V BuscarValores(K clave)
        {
            int indice = HashFunction(clave);

            while (claves[indice] != null)
            {
                if (claves[indice].Equals(clave))
                {
                    Console.WriteLine("Valor encontrado para clave " + clave + ": " + valores[indice]);
                    return valores[indice];
                }
                indice = (indice + 1) % tamanio;
            }

            Console.WriteLine("Clave " + clave + " no encontrada.");
            return default(V); 
        }

        public void EliminarValores(K clave)
        {
            int indice = HashFunction(clave);

            while (claves[indice] != null)
            {
                if (claves[indice].Equals(clave))
                {
                    claves[indice] = default(K); 
                    valores[indice] = default(V); 
                    Console.WriteLine("Clave eliminada: " + clave);
                    return;
                }
                indice = (indice + 1) % tamanio;
            }
            Console.WriteLine("Clave " + clave + " no encontrada.");
        }

        public void MostrarValores()
        {
            Console.WriteLine("Contenido de la tabla hash:");
            for (int i = 0; i < tamanio; i++)
            {
                if (claves[i] != null)
                {
                    Console.WriteLine("Índice " + i + ": Clave=" + claves[i] + ", Valor=" + valores[i]);
                }
            }
        }
    }
}
