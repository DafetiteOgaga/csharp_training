using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NewLoginReg.Pages.Forms;

namespace NewLoginReg.Pages;

public class IndexModel : PageModel
{
    public string LoginName { get; set; } = string.Empty;
    public List<RegisterDetails> SavedRegistrations { get; set; } = new();

    public void OnGet()
    {
        if (SharedClass.SharedLoginEmailName != "")
        {
            LoginName = SharedClass.SharedLoginEmailName;
        }
        if (SharedClass.SharedRegisterObject.Count > 0)
        {
            SavedRegistrations = SharedClass.SharedRegisterObject;
        }
    }
}
