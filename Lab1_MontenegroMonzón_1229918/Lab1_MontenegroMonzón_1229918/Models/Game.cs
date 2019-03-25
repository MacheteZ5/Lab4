using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1_MontenegroMonzón_1229918.Models
{
    public class Game
    {
        public string nombre { get; set; }
        public int Id { get; set; }
        public float puntuacion { get; set; }
        public string categoria { get; set; }
        public string estudio { get; set; }
        public int año { get; set; }

        public string resultadoTiempo { get; set; }
        public string resultadoTiempoPID { get; set; }
        
    }
    public struct LInfo
    {
        public string nombre { get; set; }
        public int Id { get; set; }
        public float puntuacion { get; set; }
        public string categoria { get; set; }
        public string estudio { get; set; }
        public int año { get; set; }
    }
    class LNodo
    {
         public LInfo elementose;
         public LNodo siguiente;
    }
    public class Lista
    {
        LNodo inicial;
        LNodo finales;

        public Lista()
        {
            inicial = null;
            finales = null;
        }
        public void Ingresar(LInfo Com)
        {
            LNodo Aux = new LNodo();
            Aux.elementose = Com;
            Aux.siguiente = null;
            if (inicial == null)
            {
                inicial = Aux;
                finales = Aux;
            }
            else
            {
                finales.siguiente = Aux;
                finales = Aux;
            }
        }
    };
}