using System;
using Microsoft.AspNetCore.Identity;

namespace synnex_mvc_app_auth.Models
{
	public class ApplicationUser:IdentityUser
	{
		public DateOnly DOB { get; set; }
	}
}

