using System.ComponentModel.DataAnnotations;

namespace TestMVC.Models
{
	public class GuestResponse
	{
		[Required(ErrorMessage = "please enter your Name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "please enter your Email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "please enter your Phone")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "please enter your WillAttend")]
		public bool? WillAttend { get; set; }
	}
}