using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_1229918.Models;

namespace Lab2_1229918.Controllers
{
    public class ListasEmpleadosController : Controller
    {
        // GET: ListasEmpleados
        public ActionResult Index()
        {
            return View();
        }

        static LinkedList<Empleados> listaenlazada = new LinkedList<Empleados>();
        public ActionResult info()
        {
            Empleados objetos = new Empleados();
            try
            {
                Random rnd = new Random();
                int nCitas = rnd.Next(1, 4);
                objetos.nombre = Request.Form["nombre"].ToString();
                objetos.id = Convert.ToInt32(Request.Form["id"]);
                if (Request.Form["oficina"] == "on")
                {
                    objetos.oficina = true;
                }
                else
                {
                    objetos.oficina = false;
                }
                objetos.horas = 3 + (1.5 * nCitas);
                objetos.citas = nCitas;
                objetos.entrada = DateTime.Now;
                objetos.salida = (objetos.entrada).AddHours(objetos.horas);
                //agregar lista
                if (listaenlazada.Count == 0)
                {
                    listaenlazada.AddFirst(objetos);
                    pila.Push(objetos);
                    cola.Enqueue(objetos);
                }
                else
                {
                    listaenlazada.AddAfter(listaenlazada.Last, objetos);
                    pila.Push(objetos);
                    cola.Enqueue(objetos);
                }                
            }
            catch
            {
                return View("mostrar");
            }
            var model = from puntos in listaenlazada
                        orderby puntos.nombre
                        select puntos;
            return View("info", model);
            //return View(objetos);
        }
        public ActionResult mostrar()
        {
            return View();
        }
        static Stack<Empleados> pila = new Stack<Empleados>();
        static Queue<Empleados> cola = new Queue<Empleados>();
        //while(pila.Count!=listaenlazada.Count)
        //    {
        //        if (pila.Count == 0)
        //        {
        //            pila.Push(new Empleados() { nombre = listaenlazada.First.Value.nombre , citas = listaenlazada.First.Value.citas, entrada = listaenlazada.First.Value.entrada, horas = listaenlazada.First.Value.horas, id = listaenlazada.First.Value.id, oficina = listaenlazada.First.Value.oficina, salida = listaenlazada.First.Value.salida, sueldo = listaenlazada.First.Value.sueldo});
        //        }
        //        else
        //        {
        //            pila.Push(new Empleados() { nombre = listaenlazada.First.Next.Value.nombre, citas = listaenlazada.First.Next.Value.citas, entrada = listaenlazada.First.Next.Value.entrada, horas = listaenlazada.First.Next.Value.horas, id = listaenlazada.First.Next.Value.id, oficina = listaenlazada.First.Next.Value.oficina, salida = listaenlazada.First.Next.Value.salida, sueldo = listaenlazada.First.Next.Value.sueldo });
        //        }
        //    }
        public ActionResult apilar()
        {
            var model = from puntos in pila
                        orderby puntos.entrada
                        select puntos;
            return View("apilar", model);
        }
        public ActionResult AgregarALaCola()
        {
            var model = from puntos in cola
                        orderby puntos.entrada
                        select puntos;
            return View("apilar", model);
        }
        public ActionResult eliminarPila()
        {
            Empleados pilaeliminar = pila.Peek();
            pilaeliminar = pila.Pop();
            return View();
        }
        public ActionResult buscar()
        {
            return View();
        }
        public ActionResult busqueda()
        {
            Empleados buscado = new Empleados();
            buscado.id = Convert.ToInt32(Request.Form["id"]);
            buscado.nombre = Request.Form["nombre"].ToString();
            
            LinkedListNode<Empleados> temp = listaenlazada.Find(buscado);
            LinkedListNode<Empleados> current = listaenlazada.Find(buscado);
            
            return View(temp.Value);
        }
    }
}