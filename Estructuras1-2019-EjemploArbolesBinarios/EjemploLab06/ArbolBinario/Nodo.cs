using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class Nodo
    {
        //Propiedades
        public Medicamento Medicamento { get; set; }
        public Nodo Padre { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }

        //Constructor
        public Nodo()
        {

        }

        public Nodo(Medicamento Medicamento)
        {
            this.Medicamento = Medicamento; 
        }
        public Nodo(Medicamento medicamento, Nodo izquierdo, Nodo derecho, Nodo padre)
        {
            this.Medicamento = medicamento;
            this.Izquierdo = izquierdo;
            this.Derecho = derecho;
            this.Padre = padre; 
        }
        public bool EsRaiz()
        {
            if (Padre != null)
                return false;
            return true; 
        }
        public bool ExisteIzquierdo()
        {
            if (Izquierdo != null)
                return true;
            return false; 
        }
        public bool ExisteDerecho()
        {
            if (Derecho != null)
                return true;
            return false; 
        }
        public bool TieneMedicamento()
        {
            if (Medicamento != null)
                return true;
            return false; 
        }
    }
}
