using NewLoginReg.Pages.Forms;

namespace NewLoginReg.Pages;

public static class SharedClass
{
	// public static bool SharedLoginVariable { get; set; }
	public static string SharedLoginEmailName { get; set; } = string.Empty;

	public static List<RegisterDetails> SharedRegisterObject { get; set; } = new();
	public static bool SharedRegisterSubmissionVariable { get; set; }
}
