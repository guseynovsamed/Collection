


using Praktiki.Controllers;
using System.Collections;


#region HomeWork
AuthorController authorController = new AuthorController();
EmployeeController employeeController = new EmployeeController();
AccountContoller accountContoller = new AccountContoller();
ProductController productController = new ProductController();

//authorController.GetAllByAge();
//employeeController.GetCountByFilter();

//var res = accountContoller.Login();

//if (res)
//{
//    while (true)
//    {
//        Console.WriteLine("Options: 1 - GetAllProducts , 2 - Search products by name  ");
//    Start: string option = Console.ReadLine();
//        int resultOption;
//        bool isCorrectFormatOption = int.TryParse(option, out resultOption);

//        if (isCorrectFormatOption)
//        {
//            switch (resultOption)
//            {
//                case 1:
//                    productController.GetAll();
//                    break;
//                case 2:
//                    productController.Search();
//                    break;
//                default:
//                    Console.WriteLine("Option not found , please selecet again");
//                    goto Start;
//            }

//        }
//        else
//        {
//            Console.WriteLine("Option format is wrong , Please select again:");
//            goto Start;
//        }

//    }

//}

#endregion




//ArrayList arrayList = new ArrayList();
//arrayList.Add("Salam");
//arrayList.Add(5);
//arrayList.Add(true);

//foreach (var i in arrayList)
//{
//    Console.WriteLine(i);
//}


//Hashtable hashtable = new Hashtable();

//hashtable.Add(1 , "Salam");
//hashtable.Add(2 , "Sagol");

//foreach (DictionaryEntry item in hashtable.Values)
//{
//    Console.WriteLine(item.Key +" "+item.Value);
//}

//SortedList sortedList = new SortedList();

//sortedList.Add("a" , "Salam");
//sortedList.Add("c" , "Hello");
//sortedList.Add("b" , "Sagol");
//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key+" "+item.Value);
//}


//SortedList<int,string> datas = new SortedList<int,string>();

//datas.Add(1, "Iphone");
//datas.Add(2, "Oynama");
//foreach (KeyValuePair<int,string> item in datas)
//{
//    if (item.Key == 1)
//    {
//        Console.WriteLine(item.Value);
//    }
//}


//Dictionary<int , string> roles = new Dictionary<int , string>();

//roles.Add(1,"Admin");
//roles.Add(2,"Member");

//foreach (KeyValuePair<int , string> i in roles)
//{
//    Console.WriteLine(i.Value);
//}

List<string> roles = new List<string>() { "Admin", "Member", "SuperAdmin" };
List<string> email = new List<string>() { "t@gmail.com", "s@gmail.com", "st@gmail.com" };

Dictionary<string , List<string>> datas = new Dictionary<string , List<string>>();

datas.Add("roles" , roles);
datas.Add("email", email);

foreach (var item in datas)
{
	if (item.Key == "roles")
	{
		foreach (var rol in item.Value)
		{
			if (rol == "Admin")
			{
                Console.WriteLine(rol);
            }
        }
	}
}




