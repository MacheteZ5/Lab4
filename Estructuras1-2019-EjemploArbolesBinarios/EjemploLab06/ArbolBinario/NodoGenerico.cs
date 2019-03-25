using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class NodoGenerico<T>
    {
        //Propiedades
        public T valor { get; set; }
        public NodoGenerico<T> izquierdo { get; set; }
        public NodoGenerico<T> derecho { get; set; }
        public NodoGenerico<T> padre { get; set; }

        //Constructores
        public NodoGenerico()
        {

        }
        public NodoGenerico(T valor)
        {
            this.valor = valor;
        }
        public NodoGenerico(T valor, NodoGenerico<T> padre)
        {
            this.valor = valor;
            this.padre = padre;
        }
        public NodoGenerico(T valor, NodoGenerico<T> padre, NodoGenerico<T> izquierdo, NodoGenerico<T> derecho)
        {
            this.valor = valor;
            this.padre = padre;
            this.izquierdo = izquierdo;
            this.derecho = derecho;
        }

        //Algunas herramientas
        public bool existePadre()
        {
            if (padre != null)
                return true;
            return false;
        }
        public bool existeIzquierdo()
        {
            if (izquierdo != null)
            {
                return true;
            }
            return false;
        }
}
}
