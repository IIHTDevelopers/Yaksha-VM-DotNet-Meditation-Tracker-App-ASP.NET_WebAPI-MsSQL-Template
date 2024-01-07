using MeditationTrackerApp.DAL.Interrfaces;
using MeditationTrackerApp.DAL.Services.Repository;
using MeditationTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MeditationTrackerApp.DAL.Services
{
    public class MeditationTrackerService : IMeditationTrackerService
    {
        private readonly IMeditationTrackerRepository _repository;

        public MeditationTrackerService(IMeditationTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Meditation> CreateMeditation(Meditation expense)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteMeditationById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Meditation> GetAllMeditations()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Meditation> GetMeditationById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Meditation> UpdateMeditation(Meditation model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}