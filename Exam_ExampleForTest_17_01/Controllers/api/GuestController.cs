using Exam_ExampleForTest_17_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Exam_ExampleForTest_17_01.Controllers.api
{
    public class GuestController : ApiController
    {
        public TzagaysHotelsDBC DBC = new TzagaysHotelsDBC();
        // GET: api/Guest
        public IHttpActionResult Get()
        {
            List<Guest> listOfGuests = DBC.Guests.ToList();
            return Ok(new { listOfGuests });
        }

        // GET: api/Guest/5
        public async Task<IHttpActionResult> Get(int id)
        {
            Guest theChosenGuest = await DBC.Guests.FindAsync(id);
            await DBC.SaveChangesAsync();
            return Ok(new { theChosenGuest });
        }

        // POST: api/Guest
        public async Task<IHttpActionResult> Post([FromBody] Guest AddedGuest)
        {
            DBC.Guests.Add(AddedGuest);
            await DBC.SaveChangesAsync();

            return Ok("Added Guest to Table.");
        }

        // PUT: api/Guest/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] Guest EditedGuest)
        {
            Guest guest = await DBC.Guests.FindAsync(id);
            guest.Id = EditedGuest.Id;
            guest.FirstName = EditedGuest.FirstName;
            guest.LastName = EditedGuest.LastName;
            guest.Gender = EditedGuest.Gender;
            guest.CheckedIn = EditedGuest.CheckedIn;
            guest.Birthday = EditedGuest.Birthday;
            await DBC.SaveChangesAsync();

            return Ok("Edited Guest Successfully.");

        }

        // DELETE: api/Guest/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            Guest guest = await DBC.Guests.FindAsync(id);
            DBC.Guests.Remove(guest);
            await DBC.SaveChangesAsync();
            return Ok("Deleted Successfully.");
        }
    }
}
