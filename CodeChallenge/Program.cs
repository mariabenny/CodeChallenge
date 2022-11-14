// See https://aka.ms/new-console-template for more information


//-------------------Passenger_Names------------------


//using System.Xml.Linq;

//var Names = new string[10];
//var ArrayA = new string[10];
//var ArrayD = new string[10];
//string temp;
//string search;
//int space = 0;
//var dup = new bool[5];
//Boolean Found = false;

//Console.WriteLine("Enter 10 Names : ");
//for (int i = 0; i < Names.Length; i++)
//{
//    Names[i] = Console.ReadLine();
//}
//Ascending();
//Descending();
//Search();
//Length();
//Split();
//Duplicate();



//void Ascending()
//{

//    for (int i = 0; i < Names.Length; i++)
//    {
//        for (int j = i + 1; j < Names.Length; j++)
//        {
//            if (Names[i][0] > Names[j][0])
//            {
//                temp = Names[i];
//                Names[i] = Names[j];
//                Names[j] = temp;
//            }
//        }

//    }
//    Console.WriteLine("Ascending Order : ");

//    for (int j = 0; j < Names.Length; j++)
//    {
//        Console.WriteLine(Names[j]);
//    }
//}

//void Descending()
//{

//    for (int i = 0; i < Names.Length; i++)
//    {
//        for (int j = i + 1; j < Names.Length; j++)
//        {
//            if (Names[i][0] < Names[j][0])
//            {
//                temp = Names[i];
//                Names[i] = Names[j];
//                Names[j] = temp;
//            }
//        }

//    }
//    Console.WriteLine("Descending Order : ");

//    for (int j = 0; j < Names.Length; j++)
//    {
//        Console.WriteLine(Names[j]);
//    }
//}



//void Search()
//{
//    Console.WriteLine("Enter to search : ");
//    search = Console.ReadLine();
//    foreach (var item in Names)
//    {
//        if (search.Equals(item)) 
//        {
//            Found = true;
//            break;
//        }
//    }

//    if (Found)
//    {
//        Console.WriteLine("Element Not Found");

//    }
//    else
//    {
//        Console.WriteLine("Element Found");
//    }
//}

//void Length()
//{
//    foreach (var item in Names)
//    {
//        space = 0;
//        for (int i = 0; i < item.Length; i++)
//        {
//            if (item[i] == ' ')
//            {
//                space = space + 1;
//            }
//        }
//        Console.WriteLine($"Length of {item} is {item.Length-space}");
//    }
//}

//void Split()
//{
//    Console.WriteLine("Names having First and last name : ");

//    foreach (var item in Names)
//    {
//        for (int i = 0; i < item.Length; i++)
//        {
//            if (item[i] == ' ')
//            {
//                Console.Write($"First name of {item} is : ");
//                for (int j = 0; j < i; j++)
//                {
//                    Console.Write(item[j]);
//                }
//                Console.WriteLine();
//                Console.Write($"Last name of {item} is : ");
//                for (int j = i + 1; j < item.Length; j++)
//                {
//                    Console.Write(item[j]);
//                }
//                Console.WriteLine();

//            }
//        }
//    }
//}

//void Duplicate()
//{
//    Console.WriteLine("Duplicate Names : ");

//    for (int i = 0; i < Names.Length; i++)
//    {
//        for (int j = 0; j < Names.Length; j++)
//        {
//            if (Names[i] == Names[j] && i != j && dup[i] == false)
//            {

//                Console.WriteLine($" {Names[i]} ");

//                dup[i] = true;
//                dup[j] = true;


//            }
//        }
//    }
//}




//-------------------Flight_fare_time------------------


//Console.WriteLine("Enter the flight fare");
//float fare = float.Parse(Console.ReadLine());
//Console.WriteLine("Enter the time(railway time)");
//int time = int.Parse(Console.ReadLine());

//if (time >= 0600 && time < 0900)
//{
//    fare = fare + fare * 10 / 100;
//    Console.WriteLine("The fare is" + fare);
//}
//else if (time >= 0900 && time < 1700)
//{
//    fare = fare + fare * 20 / 100;
//    Console.WriteLine("The fare is" + fare);
//}

//else if (time >= 1700 && time < 2300)
//{
//    fare = fare + fare * 7 / 100;
//    Console.WriteLine("The fare is" + fare);
//}

//else
//{
//    fare = fare + fare * 5 / 100;
//    Console.WriteLine("The fare is" + fare);
//}


//-------------------Flight_fare------------------

//int[] Flight = new int[10];
//int temp;
//Console.WriteLine("Enter the fares: ");
//for (int i = 0; i < Flight.Length; i++)
//{
//    Flight[i] = int.Parse(Console.ReadLine());
//}
//var dup = new bool[5];

//Ascending();
//Descending();
//Search();
//MinValue();
//MaxValue();
//Dup();

//void Dup()
//{
//    Console.WriteLine("Duplicate Fares: ");

//    for (int i = 0; i < Flight.Length; i++)
//    {
//        for (int j = 0; j < Flight.Length; j++)
//        {
//            if (Flight[i] == Flight[j] && i != j && dup[i] == false)
//            {

//                Console.WriteLine(Flight[i]);

//                dup[i] = true;
//                dup[j] = true;


//            }
//        }
//    }
//}


//void Ascending()
//{

//    for (int i = 0; i < Flight.Length; i++)
//    {
//        for (int j = i + 1; j < Flight.Length; j++)
//        {
//            if (Flight[i] > Flight[j])
//            {
//                temp = Flight[i];
//                Flight[i] = Flight[j];
//                Flight[j] = temp;
//            }
//        }

//    }
//    Console.WriteLine("Ascending Order : ");

//    for (int j = 0; j < Flight.Length; j++)
//    {
//        Console.WriteLine(Flight[j]);
//    }
//}

//void Descending()
//{

//    for (int i = 0; i < Flight.Length; i++)
//    {
//        for (int j = i + 1; j < Flight.Length; j++)
//        {
//            if (Flight[i] < Flight[j])
//            {
//                temp = Flight[i];
//                Flight[i] = Flight[j];
//                Flight[j] = temp;
//            }
//        }

//    }
//    Console.WriteLine("Ascending Order : ");

//    for (int j = 0; j < Flight.Length; j++)
//    {
//        Console.WriteLine(Flight[j]);
//    }
//}

//void Search()
//{
//    int search;
//    Boolean Found = false;
//    Console.WriteLine("Enter to search : ");
//    search = int.Parse(Console.ReadLine());
//    for (int i = 0; i < Flight.Length; i++)
//    {
//        if (search == Flight[i])
//        {
//            Found = true;
//            break;
//        }
//    }

//    if (!Found)
//    {
//        Console.WriteLine("Element Not Found");

//    }
//    else
//    {
//        Console.WriteLine("Element Found");
//    }
//}

//void MinValue()
//{
//    int small = Flight[0];
//    for (int i = 0; i < Flight.Length; i++)
//    {
//        if (Flight[i] < small)
//        {
//            small = Flight[i];
//        }
//    }
//    Console.WriteLine("Minimum Value : " + small);
//}

//void MaxValue()
//{
//    int large = Flight[0];
//    for (int i = 0; i < Flight.Length; i++)
//    {
//        if (Flight[i] > large)
//        {
//            large = Flight[i];
//        }
//    }
//    Console.WriteLine("Maximum Value : " + large);
//}




//-------------------Date of Birth------------------



Console.WriteLine("Enter your Date of Birth.");
DateOnly dob = DateOnly.Parse(Console.ReadLine());
Console.WriteLine(dob);

Console.WriteLine("Enter the today's date");
DateOnly today = DateOnly.Parse(Console.ReadLine());

var day = today.DayNumber - dob.DayNumber;

int hours = day * 24;
Console.WriteLine($" Age in Hours: {hours}");

int weeks = day / 7;
Console.WriteLine($" Age in Weeks: {weeks}");

int months = day / 30;
Console.WriteLine($" Age in Months: {months}");

int years = day / 365;
Console.WriteLine($" Age in years: {years}");

int Year = dob.Year;
//Console.WriteLine(DateOfYear);

if (!(Year % 100 == 0))
{
    if (Year % 4 == 0) 
    {
        Console.WriteLine("Year of Birth is a leap Year."); 
    }
    Console.WriteLine(" Year of Birth is Not a Leap Year.");
}
else
{
    Console.WriteLine(" Year of Birth is Not a leap year.");
}








