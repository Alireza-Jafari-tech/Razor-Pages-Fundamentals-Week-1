using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using project.Model;

namespace project.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
	public StudentData StudentData { get; set; }
	
	public string Result { get; set; }

    public void OnGet(string result)
    {
		Result = result;
		
    }
	
	public IActionResult OnPostSave()
	{
		if(!ModelState.IsValid)
		{
			return Page();
		}
		return RedirectToPage("/Index");
	}
	
	public IActionResult OnPostShow()
    {
		if(!ModelState.IsValid)
		{
			return Page();
		}
		
		Result= $"StudentName is {StudentData.Name} and the StudentEmail is {StudentData.Email} and the StudentAge is {StudentData.Age}";
		
		return RedirectToPage("/Index", new { result = Result});
    }
}
