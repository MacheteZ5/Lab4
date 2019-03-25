using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1_Montenegro_1229918.Models;
using System.Diagnostics;

namespace Lab1_Montenegro_1229918.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        List<Game> características = new List<Game>
        {
            new Game
            {
                Id=1,
                nombre="Devil May Cry 5",
                puntuacion=5,
                categoria="T",
                estudio="Capcom",
                año=2019
            },
            new Game
            {
                 Id=2,
                nombre="Final Fantasy",
                puntuacion=5,
                categoria="T",
                estudio="Square Enix",
                año=2015
            },
            new Game
            {
                 Id=3,
                nombre="Mortal Combat",
                puntuacion=3,
                categoria="E",
                estudio="Capcom",
                año=2013
            },
        };
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostrarJuego()
        {
            Game obj = new Game();
            obj.nombre = "Devil May Cry 5";
            obj.Id = 1;
            obj.estudio = "Capcom";
            obj.puntuacion = 4;
            return View(obj);
        }
        //
        public ActionResult MostrarJuego1()
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
        // trabajo hecho durante el laboratorio
        public ActionResult MostrarJuegos()
        {
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            Game juego1 = new Game() { Id = 1, nombre = "Super Meat Boy", año = 2010, categoria = "Arcade", estudio = "Estudio", puntuacion = 3 };
            TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);
            string resultado = "Esto tarda " + (stop.TotalMilliseconds - start.TotalMilliseconds) + " Milisegundos";
            juego1.resultadoTiempo = resultado;
            Process currentProcces = Process.GetCurrentProcess();
            string pid = "El PID es " + currentProcces.Id.ToString();
            juego1.resultadoTiempoPID = pid;
            return View(juego1);
        }
        // Recorre la lista de la parte superior para mostrar todos los datos de los juegos en una lista
        public ActionResult Mostrarses()
        {
            var model = from puntos in características
                        orderby puntos.nombre
                        select puntos;
            return View("Mostrarses", model);
        }


        //parte 4
        List<Game> datos = new List<Game>();
        public GamesController()
        {
            Game obj = new Game();
            obj.Id = 1;
            obj.nombre = "Super Meat Boy";
            obj.año = 2010;
            obj.categoria = "Arcade";
            obj.estudio = "Estudio";
            obj.puntuacion = 3;
            datos.Add(obj);

            Game objs = new Game();
            objs.Id = 1;
            objs.nombre = "Devil May Cry 5";
            objs.año = 2019;
            objs.categoria = "Fantasy";
            objs.estudio = "Capcom";
            objs.puntuacion = 5;
            datos.Add(objs);
        }
        public ViewResult Final(int ID)
        {
            Game obj1 = datos[ID];
            return View(obj1);
        }
        // parte 5
    }
}