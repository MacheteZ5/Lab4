using Lab1_MontenegroMonzón_1229918.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_MontenegroMonzón_1229918.Controllers
{
    public class GamesController : Controller
    {
        
        // GET: Games

        public ActionResult Index()
        {
            return View();
        }

        // metodo 1 Busqueda de ID de 0-5 (en total son 6 juegos)
        List<Game> datos = new List<Game>();
        public GamesController()
        {
            Game obj = new Game();
            obj.Id = 0;
            obj.nombre = "Super Meat Boy";
            obj.año = 2010;
            obj.categoria = "Arcade";
            obj.estudio = "Estudio";
            obj.puntuacion = 2;
            datos.Add(obj);

            Game objs = new Game();
            objs.Id = 1;
            objs.nombre = "Devil May Cry 5";
            objs.año = 2019;
            objs.categoria = "Fantasy";
            objs.estudio = "Capcom";
            objs.puntuacion = 5;
            datos.Add(objs);

            Game obje = new Game();
            obje.Id = 2;
            obje.nombre = "Assassins Creed";
            obje.año = 2010;
            obje.categoria = "Action";
            obje.estudio = "Capcom";
            obje.puntuacion = 3;
            datos.Add(obje);

            Game objet = new Game();
            objet.Id = 3;
            objet.nombre = "Final Fantasy XV";
            objet.año = 2015;
            objet.categoria = "Fantasy";
            objet.estudio = "Square Enix";
            objet.puntuacion = 5;
            datos.Add(objet);

            Game objeto = new Game();
            objeto.Id = 4;
            objeto.nombre = "Super Mario Sunshine";
            objeto.año = 2011;
            objeto.categoria = "Fantasy";
            objeto.estudio = "Nintendo";
            objeto.puntuacion = 5;
            datos.Add(objeto);

            Game objetos = new Game();
            objetos.Id = 5;
            objetos.nombre = "Jump Force";
            objetos.año = 2019;
            objetos.categoria = "Anime";
            objetos.estudio = "Bandai capcom";
            objetos.puntuacion = 1;
            datos.Add(objetos);
        }
        // Al momento de escribir la forma correcta es: url/controlador/Vista1/ID
        // Las variables que se pueden cambiar son las de tipo string como el nombre, categoría y estudio.
        // Las de tipo int si se convirtieran en tipo string sería posible cambiar su valor
        public ViewResult Vista1(int ID,string nombre, string categoría, string estudio)
        {
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);
            string resultado = "Esto tarda " + (stop.TotalMilliseconds - start.TotalMilliseconds) + " Milisegundos";
            Process currentProcces = Process.GetCurrentProcess();
            string pid = "El PID es " + currentProcces.Id.ToString();
            // va a la lista datos y la recorre en busca del valor del Id
            Game objetos = datos[ID];
            objetos.resultadoTiempoPID = pid;
            objetos.resultadoTiempo = resultado;
            // condiciones si el valor de una de las tres variables de tipo string se desea cambiar
            if (nombre != null)
            {
                objetos.nombre = nombre;
            }
            else
            {
                if (categoría != null)
                {
                    objetos.categoria = categoría;
                }
                else
                {
                    if (estudio != null)
                    {
                        objetos.estudio = estudio;
                    }
                }
            }
            return View(objetos);
        }
        public ViewResult Vista3()
        {
            //En la lista 3 se recorre toda la lista llamada características y muestra los datos en la pantalla en forma de tabla
            var model = from puntos in características
                        orderby puntos.Id
                        select puntos;
            return View("Vista3", model);
        }
        List<Game> características = new List<Game>
        {
           new Game
           {
                Id = 0,
                nombre = "Super Meat Boy",
                año = 2010,
                categoria = "Arcade",
                estudio = "Estudio",
                puntuacion = 2,
            },
            new Game
            {
                Id = 6,
                nombre = "Devil May Cry 5",
                 año = 2019,
                 categoria = "Fantasy",
                 estudio = "Capcom",
                 puntuacion = 5,
            },
           new Game
           {
                Id = 30,
                nombre = "Assassins Creed",
                año = 2010,
                categoria = "Action",
                estudio = "Capcom",
                puntuacion = 3,
           },
            new Game
            {
                Id = 32,
                nombre = "Final Fantasy XV",
                año = 2015,
                categoria = "Fantasy",
                estudio = "Square Enix",
                puntuacion = 5,
            },

            new Game
            {
                Id = 4,
                nombre = "Super Mario Sunshine",
                año = 2011,
                categoria = "Fantasy",
                estudio = "Nintendo",
                puntuacion = 5,
            },
            new Game
            {
                Id = 25,
                nombre = "Jump Force",
                año = 2019,
                categoria = "Anime",
                estudio = "Bandai capcom",
                puntuacion = 1,
            },
        };

        public ActionResult MostrarJuegos(string nombre, string categoría, string estudio)
        {
            // Ejercicio que se realizó en clase 
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            Game juego1 = new Game() { Id = 1, nombre = "Super Meat Boy", año = 2010, categoria = "Arcade", estudio = "Estudio", puntuacion = 3 };
            TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);
            string resultado = "Esto tarda " + (stop.TotalMilliseconds - start.TotalMilliseconds) + " Milisegundos";
            juego1.resultadoTiempo = resultado;
            Process currentProcces = Process.GetCurrentProcess();
            string pid = "El PID es " + currentProcces.Id.ToString();
            juego1.resultadoTiempoPID = pid;
            if(nombre != null)
            {
                juego1.nombre = nombre;
            }
            else
            {
                if (categoría !=null)
                {
                    juego1.categoria = categoría;
                }
                else
                {
                    if (estudio != null)
                    {
                        juego1.estudio=estudio;
                    }
                }
            }
            return View(juego1);
        }
        public ActionResult Vista5()
        {
            Game obj = new Game();
            obj.nombre = Request.Form["nombre"].ToString();
            obj.Id = Convert.ToInt32(Request.Form["id"]);
            obj.estudio = Request.Form["estudio"].ToString();
            obj.puntuacion = Convert.ToInt32(Request.Form["puntuacion"]);
            return View(obj);
        }
        public ActionResult MostrarJuego2()
        {
            return View();
        }
        public ActionResult Mostrar()
        {
            return View();
        }
       static Lista generics = new Lista();
        LInfo info = new LInfo();
        public ActionResult Generics()
        {
            info.nombre = Request.Form["nombre"].ToString();
            info.Id = Convert.ToInt32(Request.Form["id"]);
            info.estudio = Request.Form["estudio"].ToString();
            info.puntuacion = Convert.ToInt32(Request.Form["puntuacion"]);
            generics.Ingresar(info);
            return View();
        }
    }
}