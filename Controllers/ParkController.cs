using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationParkAPI.Models;



namespace NationParkAPI.Controllers
{

    // [ApiController]
    //make it ControllerBase again
    public class ParkController : Controller
    {

        private readonly NationParkContext _db;
        

        public ParkController(NationParkContext db)
        {
            _db = db;
        }


        
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get()
        {
            return _db.Parks.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }


        public ActionResult Index()
        {
            return View();
        }
    }
}