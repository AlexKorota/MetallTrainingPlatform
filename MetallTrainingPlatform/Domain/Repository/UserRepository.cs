using MetallTrainingPlatform.Data;
using MetallTrainingPlatform.Domain.Entities;

namespace MetallTrainingPlatform.Domain.Repository
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(TrainingPortalDbContext context) : base(context) { }
    }
}
