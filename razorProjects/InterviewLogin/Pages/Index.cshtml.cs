using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewLogin.Pages;

public class IndexModel : PageModel
{
    public string LoggedInEmail = string.Empty;
    public void OnGet()
    {
        string RawString = SharedDataStatClass.SharedEmail;
        string cleanedString = string.Empty;
        for (int i = 0; i < RawString.Length; i++)
        {
            if (RawString[i] == '@')
            {
                break;
            }
            cleanedString += RawString[i];
        }
            LoggedInEmail = cleanedString;
    }
}
