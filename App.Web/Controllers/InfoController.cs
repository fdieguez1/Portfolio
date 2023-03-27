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
					Title = "Proyecto sin nombre, Oculus quest 2",
					Text = "Al interesarme la realidad virtual incursione en el desarrollo para la misma, principalmente con el Oculus Quest 2, siendo el headset con mas prescencia en el mercado en la actualidad",
					Technologies = new List<string>(){
						"Unity, C#",
						"Oculus XR Plugin",
						"Android"
					},
					ImageSourceName = "oculusquest.png",
					Type = ProyectTypeEnum.VirtualReality,
					Url = "https://play.google.com/store/apps/details?id=com.otherguys.journeys"
				},
				new DevelopmentViewModel()
                {
                    Title = "The other guys - Gameloft",
                    Text = "Journeys Interactive Histories / Linda Brown - Trabajando en el equipo de Tech quality, nuestro objetivo era mejorar el código existente, bug fixing, análisis y seguimiento de métricas e incidencias y la creación de features para expandir la aplicacion",
                    Technologies = new List<string>(){
						"Unity, C#",
						"Amplitude",
                        "Firebase",
                        "Android / iOS"
                    },
                    ImageSourceName = "theotherguys.png",
                    Type = ProyectTypeEnum.Unity,
                    Url = "https://play.google.com/store/apps/details?id=com.otherguys.journeys"
                },
                new DevelopmentViewModel()
                {
                    Title = "RatkidGames",
                    Text = "Juegos y apps de entretenimiento para dispositivos android, publicados en Google Play Store, siendo el mas exitoso \"Sonidos Random Memes\" con mas de 1 millon de descargas, es una botonera con sonidos pedidos por los usuarios, de humor absurdo basados en toda la cultura meme",
                    Technologies = new List<string>(){
						"Unity, C#",
						"ASP.NET Core",
                        "Admob",
                        "Android / iOS"
                    },
                    ImageSourceName = "ratkidgames.png",
                    Type = ProyectTypeEnum.Unity,
                    Url = "https://play.google.com/store/apps/developer?id=RatKid+Games"
                },
                new DevelopmentViewModel()
                {
                    Title = "Inari Apps",
                    Text = "Segunda cuenta para la publicación de aplicaciones de entretenimiento y juegos, apuntando a crear juegos mas serios y complejos. De momento solo posee un juego publicado \"Kawaii Color Block\"",
                    Technologies = new List<string>(){
						"Unity, C#",
						"ASP.NET",
                        "Entity framework, Sql server",
                        "Admob",
                        "Android / iOS"
                    },
                    ImageSourceName = "inari.png",
                    Type = ProyectTypeEnum.Unity,
                    Url = "https://play.google.com/store/apps/developer?id=Inari"
                },
                new DevelopmentViewModel()
                {
                    Title = "AAG",
                    Text = "Sistema de gestión de matriculados, tarjetas, torneos, clubes y otros. Solución realizada en .Net Framework para la Asociación Argentina de Golf, utilizando ASP.NET para la interfaz de gestión web y Xamarin para la app móvil, se utilizaron los servicios de azure para la publicación de las Api y las bases de datos para los distintos ambientes",
                    Technologies = new List<string>(){
                        ".NET Framework, ASP.NET",
                        "Xamarin",
                        "Entity framework, Sql server",
                        "Lectura de Códigos QR",
                        "Android / iOS"
                    },
                    ImageSourceName = "aag.png",
                    Type = ProyectTypeEnum.NET
				},
                new DevelopmentViewModel()
                {
                    Title = "MutualAlas",
                    Text = "Sistema de otorgamiento y gestión de microcreditos. Solución realizada en .Net Core para Mutual Alas, utilizando ASP.NET Core para la interfaz de gestion web y Blazor WebAssembly para la generación de la webapp móvil, se utilizaron los servicios de azure para la publicación de las Api y las bases de datos para los distintos ambientes",
                    Technologies = new List<string>(){
                        ".NET Core 6",
                        "ASP.NET Core",
                        "Blazor",
                        "Entity framework, Sql server",
                    },
                    ImageSourceName = "mutualalas.png",
                    Type = ProyectTypeEnum.NET
				},
                new DevelopmentViewModel()
                {
                    Title = "Shopping Las Terrazas",
                    Text = "Aplicación realizada con Unity, con mapas generados a partir de ubicaciones reales y trasladados a un Unity terrain, información sobre el clima segun la altura de la montaña, ubicación por gps y referencia de distancia a puntos de interés por realidad virtual",
                    Technologies = new List<string>(){
                        "Unity, C#",
                        "Google VR SDK",
                        "Blender",
                        "Sketch up",
                        "Mapbox"
                    },
                    ImageSourceName = "terrazas.png",
                    Type = ProyectTypeEnum.VirtualReality
                },
                new DevelopmentViewModel()
                {
                    Title = "Sophenia",
                    Text = "Applicación promocional para la deteccion por etiqueta de los distintos varietales de vinos por medio de los servicios cognitivos de Azure y marcas de la firma Sophenia y sistema de gestion web. Se realizo con ASP.NET, Xamarin, Sql server utilizando los servicios cognitivos de azure para la identificación de las etiquetas",
                    Technologies = new List<string>(){
                        "ASP.NET",
                        "Xamarin",
                        "Entity framework, Sql server",
                        "Azure cognitive services",
                        "Android / iOS"
                    },
                    ImageSourceName = "sophenia.png",
                    Type = ProyectTypeEnum.NET
				},
                new DevelopmentViewModel()
                {
                    Title = "UniversalCred",
                    Text = "Sistema de gestion de mensajes de promocion, utilizando whatsapp para contactar a los socios del cliente. Solución realizada en .Net Core para Mutual Alas, utilizando ASP.NET Core para la interfaz de gestion web y Xamarin para la app móvil, se utilizaron los servicios de azure para la publicación de las Api y las bases de datos para los distintos ambientes",
                    Technologies = new List<string>(){
                        "ASP.NET",
                        "Xamarin",
                        "Entity framework, Sql server",
                        "Android / iOS"
                    },
                    ImageSourceName = "universalcred.png",
                    Type = ProyectTypeEnum.NET
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
