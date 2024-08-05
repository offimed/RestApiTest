using Microsoft.AspNetCore.Mvc;
using RestApiTest.Models;


namespace RestApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private static List<Patient> patients = new List<Patient>
        {
            new Patient { Niss = 1, PatientName = "Moi Meme", PatientCity = "Bruxelles" },
            new Patient { Niss = 2, PatientName = "Un autre", PatientCity = "Mons" },
            new Patient { Niss = 3, PatientName = "Un nouveau", PatientCity = "Namur" }
        };

        // GET: api/<PatientController>
        [HttpGet]
        public List<Patient> Get()
        {
            return patients;
        }

        // GET api/<PatientController>/5
        [HttpGet("{Niss}")]
        public ActionResult<Patient> Get(int Niss)
        {
            Patient patient = patients.FirstOrDefault(p => p.Niss == Niss);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }

        //// POST api/<PatientController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<PatientController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<PatientController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
