
OccupationalInfo yemi = new OccupationalInfo(
	"Adebisi", "Goncalves", 32, "Nurse", "Female", "Nigeria"
	);
yemi.display();
public class OccupationalInfo
{
	public string firstName { get; set; }
	public string lastName { get; set; }
	public int age { get; set; }
	public string occupation { get; set; }
	public string gender { get; set; }
	public string country { get; set; }

	public OccupationalInfo(string fname, string lname, int Age, string occupatn, string gendr, string ctry)
	{
		firstName = fname;
		lastName = lname;
		age = Age;
		occupation = occupatn;
		gender = gendr;
		country = ctry;
	}

	public void display()
	{
		Console.WriteLine(
			$"Firstname: {firstName}\n" +
			$"Lastname: {lastName}\n" +
			$"Age: {age}\n" +
			$"Occupation: {occupation}\n" +
			$"Gender: {gender}\n" +
			$"Country: {country}"
			);
	}
}