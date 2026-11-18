using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RegistrationInterviewPage.Pages.Forms;

public class RegistrationModel : PageModel
{
	[BindProperty]
	public RegistrationForm RegistrationProp { get; set; } = new();

	public List<SelectListItem> StateOptions { get; set; } = new();
	public List<SelectListItem> LgaOptions { get; set; } = new();

	public void OnGet()
	{
		LoadDropdowns();

		// Console.WriteLine($"Number of states: {StateOptions.Count}");
		// Console.WriteLine($"Number of lgas: {LgaOptions.Count}");
	}

	public IActionResult OnGetLgas(string state)
	{
		var lgas = NigerianStates.GetLgas(state ?? "");

		return new JsonResult(lgas);
	}

	private void LoadDropdowns()
	{
		StateOptions = NigerianStates.States
			.Select(state => new SelectListItem
			{
				Value = state,
				Text = state
			})
			.ToList();

		// Console.WriteLine($"States: {StateOptions}");
		LgaOptions = NigerianStates.GetLgas(
			RegistrationProp.StateOfOrigin ?? ""
		)
		.Select(lga => new SelectListItem
		{
			Value = lga,
			Text = lga
		})
		.ToList();
	}
}

public class RegistrationForm
{
	[Required(ErrorMessage = "First name is required")]
	[Display(Name = "First name:")]
	[StringLength(100)]
	public string FirstName { get; set; } = string.Empty;

	[Required(ErrorMessage = "Last name is required")]
	[Display(Name = "Last name:")]
	[StringLength(100)]
	public string LastName { get; set; } = string.Empty;

	[Required(ErrorMessage = "Email is required")]
	[Display(Name = "Email:")]
	[EmailAddress(ErrorMessage ="Email address is incorrect")]
	public string Email { get; set; } = string.Empty;

	[Required(ErrorMessage = "Enter your phone number")]
	[StringLength(20, MinimumLength = 7, ErrorMessage = "Enter a valid phone number")]
	[Phone(ErrorMessage = "Enter a valid phone number")]
	[Display(Name = "Phone number:")]
	public string PhoneNo { get; set; } = string.Empty;

	[Required(ErrorMessage = "State of Origin is required")]
	[Display(Name = "State of Origin:")]
	[StringLength(100)]
	public string StateOfOrigin { get; set; } = string.Empty;

	[Required(ErrorMessage = "LGA is required")]
	[Display(Name = "LGA:")]
	[StringLength(100)]
	public string LGA { get; set; } = string.Empty;
}