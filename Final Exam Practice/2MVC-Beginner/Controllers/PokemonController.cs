using _2MVC_Beginner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace _2MVC_Beginner.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            PokiAPI pokemon;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon?offset=0&limit=1100").Result;
                pokemon = JsonConvert.DeserializeObject<PokiAPI>(json);


            }
            return View(pokemon.results);
        }

        
        public ActionResult Info(string id)
        {
            Pokidetails pokiinformation;

            using (var client = new HttpClient())
            {
                var json = client.GetStringAsync($"https://pokeapi.co/api/v2/pokemon/{id}").Result;
                pokiinformation = JsonConvert.DeserializeObject<Pokidetails>(json);
            }

            return View(pokiinformation);

        }
    }
}