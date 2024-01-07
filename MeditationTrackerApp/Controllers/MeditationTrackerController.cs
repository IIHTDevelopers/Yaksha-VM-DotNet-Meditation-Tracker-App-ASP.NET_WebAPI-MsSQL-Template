using MeditationTrackerApp.DAL.Interrfaces;
using MeditationTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MeditationTrackerApp.Controllers
{
    public class MeditationController : ApiController
    {
        private readonly IMeditationTrackerService _service;
        public MeditationController(IMeditationTrackerService service)
        {
            _service = service;
        }
        public MeditationController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Meditation/CreateMeditation")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateMeditation([FromBody] Meditation model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Meditation/UpdateMeditation")]
        public async Task<IHttpActionResult> UpdateMeditation([FromBody] Meditation model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Meditation/DeleteMeditation")]
        public async Task<IHttpActionResult> DeleteMeditation(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Meditation/GetMeditationById")]
        public async Task<IHttpActionResult> GetMeditationById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Meditation/GetAllMeditations")]
        public async Task<IEnumerable<Meditation>> GetAllMeditations()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
