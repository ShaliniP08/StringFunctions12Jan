using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions12Jan
{
    class Program
    {
        static void StringFunc()
        {
            Console.WriteLine("Menu Driven Program for String Functions");
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("\n\tMENU");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Enter your choice of string function to proceed");
                Console.WriteLine("1.Compare");
                Console.WriteLine("2.Concatenate");
                Console.WriteLine("3.Reverse");
                Console.WriteLine("4.Replace");
                Console.WriteLine("5.Split");
                Console.WriteLine("6.CopyTo");
                Console.WriteLine("7.Equals");
                Console.WriteLine("------------------------------\n");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Compare
                        Console.WriteLine("Program to compare 2 strings");
                        Console.WriteLine("Enter first string");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Enter second string");
                        string str2 = Console.ReadLine();

                        Console.WriteLine(String.Compare(str1, str2));
                        Console.ReadLine();
                        break;

                    case 2:
                        //Concatenate 
                        Console.WriteLine("Enter first string");
                        string fName = Console.ReadLine();
                        Console.WriteLine("Enter second string");
                        string lName = Console.ReadLine();

                        string Name = String.Concat(fName, lName);
                        Console.WriteLine($"\nConcatenated string : {Name}");
                        Console.ReadLine();
                        break;

                    case 3:
                        //Reverse
                        string str = "", reverse = "";
                        int Length = 0;
                        Console.WriteLine("Enter string to use reverse function");
                        str = Console.ReadLine();

                        //Calculate length of string str  
                        Length = str.Length - 1;
                        while (Length >= 0)
                        {
                            reverse = reverse + str[Length];
                            Length--;
                        }
                        //Displaying the reverse word  
                        Console.WriteLine("Reverse string is {0}", reverse);
                        Console.ReadLine();
                        break;

                    case 4:
                        //Replace
                        Console.WriteLine("Enter string to use replace function");
                        string rep = Console.ReadLine();
                        Console.WriteLine("OldString : " + rep);

                        //replace the character 'a' with 'K' 
                        Console.WriteLine("NewString: " + rep.Replace('a', 'K'));
                        Console.ReadLine();
                        break;

                    case 5:
                        //Split
                        Console.WriteLine("Enter string to use Split function");
                        string spl = Console.ReadLine();
                        string[] subs = spl.Split(' ', 'u');

                        foreach (var sub in subs)
                        {
                            Console.WriteLine(sub);
                        }
                        Console.ReadLine();
                        break;

                    case 6:
                        //CopyTo
                        Console.WriteLine("Program to use CopyTo function");
                        Console.WriteLine("Enter first string");
                        string sour = Console.ReadLine();
                        char[] destArr = new char[sour.Length];
                        sour.CopyTo(1, destArr, 0, sour.Length - 1);
                        Console.Write(destArr);
                        Console.ReadLine();
                        break;

                    case 7:
                        //String.Equals 
                        Console.WriteLine("Program to compare 2 strings using Equals function");
                        Console.WriteLine("Enter first string");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("Enter second string");
                        string name2 = Console.ReadLine();

                        //Compare strings using String.Equals  
                        Console.WriteLine(String.Equals(name1, name2)); // return type bool
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            StringFunc();
            Console.ReadLine();
        }
    }
}