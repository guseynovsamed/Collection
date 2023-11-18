




using HomeWork.Controllers;
using System.Threading.Channels;

PersonController person = new PersonController();


while (true)
{
    Console.WriteLine("1 - Add contanct");
    Console.WriteLine("2 - Delete contact");
    Console.WriteLine("3 - Change number");
    Console.WriteLine("4 - Print all contact");
    Console.WriteLine("5 - Enter text for search");



    Console.WriteLine("\n Please enter operation:");
	string num = Console.ReadLine();
	switch (num)
	{
		case "1":
			person.Add();
			break;
		case "2":
			person.Delete();
			break;
		case "3":

			break;
		case "4":
			person.ShowPersonInfo();
			break;
		case "5":
			person.Search();
			break;

	}
}







