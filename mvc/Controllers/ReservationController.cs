using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc.Controllers
{
    [Route("api/[controller]")]
    public class ReservationController : Controller
    {
        private IRepository reposiory;

        public ReservationController(IRepository repo)
        {
            reposiory = repo;
        }

        [HttpGet]
        public IEnumerable<Reservation> Get()
        {
            return reposiory.Reservations;
        }

        [HttpGet("{id}")]
        public Reservation Get(int id)
        {
            return reposiory[id];
        }

        [HttpPost]
        public IActionResult Post([FromBody]Reservation res)
        {
            Reservation obj = reposiory.AddReservation(new Reservation
            {
                ClientName = res.ClientName,
                Location = res.Location
            });
            return (Json(obj));
        }

        [HttpPut]
        public Reservation Put([FromBody]Reservation res)
        {
           return reposiory.UpdateReservation(res);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            reposiory.DeleteReservation(id);
        }
    }
}
