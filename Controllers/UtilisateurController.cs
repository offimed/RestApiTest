using Microsoft.AspNetCore.Mvc;
using offimed.tools.structures;
using RestApiTest.Models.Data;
using System.Collections.Generic;
using static offimed.tools.global.MiscTools;
using System.Text;
using offimed.tools.extensions;

namespace RestApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private static List<Utilisateur> Users = new List<Utilisateur>
        {
            new Utilisateur {UserId =1, Niss = "100", UserName = "Moi Meme", Ville = "Bruxelles" },
            new Utilisateur {UserId =2, Niss = "200", UserName = "Un autre", Ville = "Mons" },
            new Utilisateur {UserId =3, Niss = "300", UserName = "Un nouveau", Ville = "Namur" }
        };

        // GET: api/<UtilisateurController>
        [HttpGet]
        public List<Utilisateur> Get()
        {
            return Users;
        }

        // GET api/<UtilisateurController>/5
        [HttpGet("{Niss}")]
        public List<Utilisateur> Get(string Niss)
        {
            List<Utilisateur> newList = Users.FindAll(s => s.Niss.Equals(Niss));

            if (newList.Count ==0)
            {
                return new List<Utilisateur>();
            }

            return newList;
        }

        // POST api/<UtilisateurController>/
        [HttpPost]
        public List<Utilisateur> Post(int id, string niss, string userName, string ville)
        {
            Users.Add(new Utilisateur(id,niss,userName,ville));
            return Users;
        }

        //// PUT api/<UtilisateurController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<UtilisateurController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    //}

    }
}
