using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetallTrainingPlatform.Domain.Entities
{
    public class Role
    {
        public enum Roles
        {
            User = 1,
            Manager,
            Admin
        }
    }
}
