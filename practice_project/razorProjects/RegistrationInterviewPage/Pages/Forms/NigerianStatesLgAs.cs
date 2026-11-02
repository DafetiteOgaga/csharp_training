
namespace RegistrationInterviewPage.Pages.Forms;

public static class NigerianStates
{
    public static readonly Dictionary<string, List<string>> LgasByState = new()
        {
            ["Lagos"] = new()
            {
                "Agege",
                "Ajeromi-Ifelodun",
                "Alimosho",
                "Ikeja",
                "Surulere"
            },

            ["Delta"] = new()
            {
                "Aniocha North",
                "Aniocha South",
                "Ethiope East",
                "Oshimili South",
                "Uvwie"
            },

            ["Anambra"] = new()
            {
                "Aguata",
                "Awka North",
                "Awka South",
                "Idemili North",
                "Onitsha North"
            }
        };

    public static List<string> States =>
        LgasByState.Keys.OrderBy(state => state).ToList();

    public static List<string> GetLgas(string state)
    {
		if (LgasByState.TryGetValue(state, out var lgas)) {
			return lgas;
		} else {
			return new List<string>();
		}
    }
}
