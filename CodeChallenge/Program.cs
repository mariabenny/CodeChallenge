// See https://aka.ms/new-console-template for more information
//string[] Names = new string[10];
//string Arr = string.Empty;
//Console.WriteLine("Enter the names: ");
//for(int i = 0; i < 5; i++)
//{
//    Names[i] = Console.ReadLine().ToLower();
//}


//AscendingOrder
//Array.Sort(Names);
//Console.WriteLine("Ascending Order is: ");
//Console.WriteLine(String.Join("  ", Names));


//for (int i = 0; i < 10; i++)
//{
//    for (int j = i+1; j < 10-i-1; j++)
//    {
//        if ((string.Compare(Names[j], Names[j+1])) > 0)
//            {
//                temp = Names[j];
//                Names[j] = Names[j+1];
//                Names[j+1] = temp;
//            }     
//    }

//}

//for (int i = 0; i < 10; i++)
//{
//    for (int j = i + 1; j < 10 ; j++)

//    {
//        for (int k = 0; k < 10; k++)
//        {
//            if (Names[i][k]> Names[j][k])
//            {
//                Arr = Names[i];
//                Names[i] = Names[j];
//                Names[j] = Arr;
//            }
//        }
//    }
//    Console.WriteLine(Names[i]);

//}
//Console.WriteLine("ascending order is :");
//foreach (var item in Names)
//{
//    Console.WriteLine(item);
//}



var Names = new string[10];
var ArrayA = new string[10];
var ArrayD = new string[10];
string temp;
string search;
var dup = new bool[5];
Boolean Found = false;

Console.WriteLine("Enter 10 Names : ");
for (int i = 0; i < Names.Length; i++)
{
    Names[i] = Console.ReadLine();
}
Ascending();
Descending();
Search();
Length();
Split();
Duplicate();



void Ascending()
{

    for (int i = 0; i < Names.Length; i++)
    {
        for (int j = i + 1; j < Names.Length; j++)
        {
            if (Names[i][0] > Names[j][0])
            {
                temp = Names[i];
                Names[i] = Names[j];
                Names[j] = temp;
            }
        }

    }
    Console.WriteLine("Ascending Order : ");

    for (int j = 0; j < Names.Length; j++)
    {
        Console.WriteLine(Names[j]);
    }
}

void Descending()
{

    for (int i = 0; i < Names.Length; i++)
    {
        for (int j = i + 1; j < Names.Length; j++)
        {
            if (Names[i][0] < Names[j][0])
            {
                temp = Names[i];
                Names[i] = Names[j];
                Names[j] = temp;
            }
        }

    }
    Console.WriteLine("Descending Order : ");

    for (int j = 0; j < Names.Length; j++)
    {
        Console.WriteLine(Names[j]);
    }
}



void Search()
{
    Console.WriteLine("Enter to search : ");
    search = Console.ReadLine();
    for (int i = 0; i < Names.Length; i++)
    {
        if (Names[i] == search)
        {
            Console.WriteLine("Element Found at  position : " + i);
            Found = true;
            break;
        }
    }
    if (!Found)
    {
        Console.WriteLine("Element Not Found");

    }
}

void Length()
{
    foreach (var item in Names)
    {
        Console.WriteLine($"Length of {item} is {item.Length}");
    }
}

void Split()
{
    Console.WriteLine("Names having First and last name : ");

    foreach (var item in Names)
    {
        for (int i = 0; i < item.Length; i++)
        {
            if (item[i] == ' ')
            {
                Console.Write($"First name of {item} is : ");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(item[j]);
                }
                Console.WriteLine();
                Console.Write($"Last name of {item} is : ");
                for (int j = i + 1; j < item.Length; j++)
                {
                    Console.Write(item[j]);
                }
                Console.WriteLine();

            }
        }
    }
}

void Duplicate()
{
    Console.WriteLine("Duplicate Names : ");

    for (int i = 0; i < Names.Length; i++)
    {
        for (int j = 0; j < Names.Length; j++)
        {
            if (Names[i] == Names[j] && i != j && dup[i] == false)
            {
                
                Console.WriteLine($" {Names[i]} ");

                dup[i] = true;
                dup[j] = true;


            }
        }
    }
}








