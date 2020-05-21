using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Web.Helpers;

namespace MetallTrainingPlatform.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        private string _password;
        [JsonIgnore]
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password == null)
                    _password = Crypto.HashPassword(value);
            }
        }
        public string Email { get; set; }
        public string Name { get; set; }
        public string TelegramId { get; set; }

        public virtual List<Role> Role { get; set; }
    }
}
