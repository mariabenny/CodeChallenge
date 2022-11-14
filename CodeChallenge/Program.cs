// See https://aka.ms/new-console-template for more information



//using System.Xml.Linq;

//var Names = new string[3];
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





Console.WriteLine("Enter the flight fare");
float fare = float.Parse(Console.ReadLine());
Console.WriteLine("Enter the time(railway time)");
int time = int.Parse(Console.ReadLine());

if (time >= 0600 && time < 0900)
{
    fare = fare + fare * 10 / 100;
    Console.WriteLine("The fare is" + fare);
}
else if (time >= 0900 && time < 1700)
{
    fare = fare + fare * 20 / 100;
    Console.WriteLine("The fare is" + fare);
}

else if (time >= 1700 && time < 2300)
{
    fare = fare + fare * 7 / 100;
    Console.WriteLine("The fare is" + fare);
}

else
{
    fare = fare + fare * 5 / 100;
    Console.WriteLine("The fare is" + fare);
}






