using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class ArbolBinario<T> : ICollection<T>, IEnumerable<T>
    {
        public Nodo Raiz { get; set }
        public Nodo SubarbolIzq { get; set; }
        public Nodo SubarbolDer { get; set; }

        public bool EsVacio()
        {
            if (Raiz == null)
                return true;
            return false; 
        }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();
        /// <summary>
        /// Para hacer un add sin que sea genérico tenemos dos opciones
        /// la primera es hacer una sobrecarga del método ADD y enviarle el tipo que queremos agregar
        /// </summary>
        /// <param name="item"></param>
        public void Add(Nodo item)
        {
            if (Raiz != null)
            {
            }
        }
        /// <summary>
        /// La segunda forma de hacerlo de forma es hacer el cast correspondiente
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            Nodo nodo = (Nodo)(Object)item; //Cast necesario para que se pueda convertir
            nodo.Derecho = null; 

        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

       
    }
}
