using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using Lab1_GS_Montenegro_1229918.Models;

namespace Lab1_GS_Montenegro_1229918.Controllers
{
    public class GamesController : Controller
    {
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
            new Game
            {
                 Id=4,
                nombre="Jump Force",
                puntuacion=4,
                categoria="M",
                estudio="Square Enix",
                año=2019
            },
            new Game
            {
                 Id=5,
                nombre="Super Mario",
                puntuacion=5,
                categoria="E",
                estudio="Nintendo",
                año=2008
            }
        };
        public ActionResult Index()
        {
            return View();
        }
       public ActionResult Prueba()
        {
            var model = from puntos in características
                        orderby puntos.Id
                        select puntos;
            return View("Prueba", model);
        }
        //public ActionResult MostrarJuego()
        //{
        //    TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
        //    Game juego1 = new Game() { Id = 1, nombre = "Super Meat Boy", año = 2010, categoria = "Arcade", estudio = "Estudio", puntuacion = 3 };
        //    TimeSpan stop = new TimeSpan(DateTime.Now.Ticks);
        //    string resultado = "Esto tarda " + (stop.TotalMilliseconds - start.TotalMilliseconds) + " Milisegundos";
        //    juego1.resultadoTiempo = resultado;
        //    Process currentProcces = Process.GetCurrentProcess();
        //    string pid = "El PID es " + currentProcces.Id.ToString();
        //    juego1.resultadoTiempoPID = pid;
        //    return View(juego1);
        //}
        //public String IngresarUsuario(string nombreUsuario)
        //{
        //    return "El nombre enviado es:" + nombreUsuario;
        //}
    }
}