using App.Web.Models;
using App.Web.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
    public class InfoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public InfoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Design()
        {
            return View();
        }
        public IActionResult Development()
        {
            /* Esto esta feo lo se. :)
            Pero no voy a levantar una base de datos y servicio api para estos items, 
            Son a modo de muestra solo para la comunicacion entre el controller y vista.
            Aqui iria el consumo a la api (o a una clase apiclient que se encargue de apuntar a los endpoints) */

            List<QuoteViewModel> quotes = new List<QuoteViewModel>()
            {
                new QuoteViewModel()
                {
                    Text = "\"Things arent always #000000 and #FFFFFF.\"",
                    Author = "Unknown"
                },
                new QuoteViewModel()
                {
                    Text = "\"Whenever someone creates something with all of their heart, then that creation is given a soul.\"",
                    Author = "The Cat Returns | Ghibli"
                },
                new QuoteViewModel()
                {
                    Text = "\"It works on my computer.\"",
                    Author = "Me"
                },
                new QuoteViewModel()
                {
                    Text = "\"Experience is the name everyone gives to their mistakes.\"",
                    Author = "Unknown"
                },
                new QuoteViewModel()
                {
                    Text = "\"Any fool can write code that a computer can understand. Good programmers write code that humans can understand.\"",
                    Author = "Martin Fowler"
                },
                 new QuoteViewModel()
                {
                    Text = "\"First, solve the problem. Then, write the code.\"",
                    Author = "Unknown"
                },
                new QuoteViewModel()
                {
                    Text = "\"Experience is the name everyone gives to their mistakes.\"",
                    Author = "Oscar Wilde"
                },
                new QuoteViewModel()
                {
                    Text = "\"In order to be irreplaceable, one must always be different.\"",
                    Author = "Coco Chanel"
                },
                new QuoteViewModel()
                {
                    Text = "\"Knowledge is power.\"",
                    Author = "Francis Bacon"
                },
                new QuoteViewModel()
                {
                    Text = "\"Perfection is achieved not when there is nothing more to add, but rather when there is nothing more to take away.\"",
                    Author = "Antoine de Saint-Exupery"
                },
                new QuoteViewModel()
                {
                    Text = "\"Make it work, make it right, make it fast.\"",
                    Author = "Kent Beck"
                },
            };
            ViewBag.Quotes = quotes;
            List<DevelopmentViewModel> data = new List<DevelopmentViewModel>() {
                new DevelopmentViewModel()
                {
                    Title = "RatkidGames",
                    Text = "Juegos y apps de entretenimiento para dispositivos android, publicados en Google Play Store, siendo el mas exitoso \"Sonidos Random Memes\" con mas de 1 millon de descargas, es una botonera con sonidos de humor absurdo basados en toda la cultura meme",
                    Technologies = new List<string>(){
                        "Unity",
                        "ASP.NET",
                        "Admob para monetización",
                        "Play store (Android)",
                        "App Store (iOS)"
                    },
                    ImageSourceName = "ratkidgames.png",
                    Type = ProyectTypeEnum.Personal,
                    Url = "https://play.google.com/store/apps/developer?id=RatKid+Games"
                },
                new DevelopmentViewModel()
                {
                    Title = "Inari Apps",
                    Text = "Segunda cuenta para la publicación de aplicaciones de entretenimiento y juegos, apuntando a crear juegos mas serios y complejos. De momento solo posee un juego publicado \"Kawaii Color Block\"",
                    Technologies = new List<string>(){
                        "Unity",
                        "ASP.NET",
                        "Sql server",
                        "Admob para monetización",
                        "Play store (Android)",
                        "App Store (iOS)"
                    },
                    ImageSourceName = "inari.png",
                    Type = ProyectTypeEnum.Personal,
                    Url = "https://play.google.com/store/apps/developer?id=Inari"
                },
                new DevelopmentViewModel()
                {
                    Title = "AAG",
                    Text = "Sistema de gestión de matriculados, tarjetas, torneos, clubes y otros. Solución realizada en .Net Framework para la Asociacion Argentina de Golf, utilizando ASP.NET para la interfaz de gestion web y Xamarin para la app móvil, para la publicacion de servicios se utilizaron los servicios de azure para la publicacion de las Api y las bases de datos para los distintos ambientes",
                    Technologies = new List<string>(){
                        "ASP.NET",
                        "Xamarin",
                        "Sql server",
                        "Códigos QR",
                        "Play store (Android)",
                        "App Store (iOS)"
                    },
                    ImageSourceName = "aag.png",
                    Type = ProyectTypeEnum.BajoContrato
                },
                new DevelopmentViewModel()
                {
                    Title = "MutualAlas",
                    Text = "Sistema de otorgamiento y gestion de microcreditos. Solución realizada en .Net Core para Mutual Alas, utilizando ASP.NET Core para la interfaz de gestion web y Blazor WebAssembly para la generación de la webapp móvil, para la publicacion de servicios se utilizaron los servicios de azure para la publicacion de las Api y las bases de datos para los distintos ambientes",
                    Technologies = new List<string>(){
                        "ASP.NET",
                        "Blazor",
                        "Sql server",
                    },
                    ImageSourceName = "mutualalas.png",
                    Type = ProyectTypeEnum.BajoContrato
                },
                new DevelopmentViewModel()
                {
                    Title = "Shopping Las Terrazas",
                    Text = "Aplicación realizada con Unity, con mapas, información sobre el clima segun la altura de la montaña, ubicación por gps",
                    Technologies = new List<string>(){
                        "Unity VR",
                    },
                    ImageSourceName = "terrazas.png",
                    Type = ProyectTypeEnum.BajoContrato
                },
                new DevelopmentViewModel()
                {
                    Title = "Sophenia",
                    Text = "Applicación promocional para la deteccion por etiqueta de los distintos varietales de vinos y marcas de la firma Sophenia y sistema de gestion web. Se realizo con ASP.NET, Xamarin, Sql server utilizando los servicios cognitivos de azure para la identificacion de las etiquetas",
                    Technologies = new List<string>(){
                        "ASP.NET",
                        "Xamarin",
                        "Sql server",
                        "Azure cognitive services",
                        "Play store (Android)",
                        "App Store (iOS)"
                    },
                    ImageSourceName = "sophenia.png",
                    Type = ProyectTypeEnum.BajoContrato
                },
                new DevelopmentViewModel()
                {
                    Title = "UniversalCred",
                    Text = "Sistema de gestion de mensajes de promocion, utilizando whatsapp para contactar a los socios del cliente. Solución realizada en .Net Core para Mutual Alas, utilizando ASP.NET Core para la interfaz de gestion web y Xamarin para la app móvil, para la publicacion de servicios se utilizaron los servicios de azure para la publicacion de las Api y las bases de datos para los distintos ambientes",
                    Technologies = new List<string>(){
                        "ASP.NET",
                        "Xamarin",
                        "Sql server",
                        "Play store (Android)",
                        "App Store (iOS)"
                    },
                    ImageSourceName = "universalcred.png",
                    Type = ProyectTypeEnum.BajoContrato
                },
            };
            return View(data);
        }
        public IActionResult Others()
        {
            return View();
        }

    }
}
