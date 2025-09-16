using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace project.Model {
	
	public class StudentData {
		
		[Required(ErrorMessage = "Name field must be filled!")]
		[StringLength(150, MinimumLength= 3, ErrorMessage = "Name must be 2 to 150 chars long")]
		public string Name { get; set; }
		
		[EmailAddress(ErrorMessage = "invalid email!")]
		public string Email { get; set; }
		
		[Range(10, 100, ErrorMessage = "Out of Range! Must be form 10 to 100")]
		public int Age { get; set; }
		
	}
	
}