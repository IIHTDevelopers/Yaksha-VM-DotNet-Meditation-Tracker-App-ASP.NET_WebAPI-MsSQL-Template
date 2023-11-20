using MeditationTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MeditationTrackerApp.DAL.Services.Repository
{
    public class MeditationTrackerRepository : IMeditationTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public MeditationTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Meditation> CreateMeditation(Meditation expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteMeditationById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Meditation> GetAllMeditations()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Meditation> GetMeditationById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        

        public async Task<Meditation> UpdateMeditation(Meditation model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}