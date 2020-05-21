using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MetallTrainingPlatform.Helpers
{
	public class AuthOptions
    {
		public const string ISSUER = "TrainingPortal";
		public const string AUDIENCE = "TrainingPortalUser";
		const string KEY = "authentification_security_key!trainPortal12";
		public const int LIFETIME = 60;
		public static SymmetricSecurityKey GetSymmetricSecurityKey()
		{
			return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
		}
	}
}
