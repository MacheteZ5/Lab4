using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2_1229918.Models
{
    public class Empleados
    {
        public string nombre { get; set; }
        public int id { get; set; }
        public bool oficina { get; set; }
        public double horas { get; set; }
        public double sueldo { get; set; }
        public int citas { get; set; }


        public DateTime entrada { get; set; }
        public DateTime salida { get; set; }
    }
}