using System;
using NewArrayHelper;
namespace NewArrayHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello! Here you can work with some information!");
            start1 :
            System.Console.WriteLine("With what type of information do you want to work?");
            System.Console.Write("I can offer you some types of information.\n1.string value\n2.number value\n3.floating-point value\n4.decimal value \nPlease choose one of them:");
            int choice = int.Parse(Console.ReadLine());
            System.Console.Write("Please enter number of your information: ");
            int size = int.Parse(Console.ReadLine());
            switch(choice){
                case 1: {
                    string [] sarray = new string[size];
                    for (int i = 0; i < size; i++)
                        sarray[i] = Console.ReadLine();
                    start :
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.End your work\n7.Create another array");
                    int newchoice = int.Parse(Console.ReadLine());
                    switch(newchoice){
                        case 1:
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<string>.Pop(ref sarray)}");
                            break;
                        case 2: {
                            System.Console.Write("Please enter new element: ");
                            string newelement = Console.ReadLine();
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<string>.Push(ref sarray, newelement)}");
                        }; break;
                        case 3:
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<string>.Shift(ref sarray)}");
                            break;
                        case 4: {
                            System.Console.Write("Please enter new element: ");
                            string newelement = Console.ReadLine();
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<string>.UnShift(ref sarray, newelement)}");
                        }; break;
                        case 5: {
                            System.Console.WriteLine("please enter from which to which element of the array you want to cut\nFrom: ");
                            int posbegin = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("To: ");
                            int posend = int.Parse(Console.ReadLine());
                            string [] newArray = ArrayHelper<string>.Slice(sarray, posbegin, posend);
                            System.Console.WriteLine("Your sliced array: ");
                            foreach( string s in newArray)
                                   System.Console.Write(s + "  ");
                        }; break;
                        case 6: goto end;
                        case 7: goto start1;
                        default: {
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
                            goto start;
                        }
                    }
                }; break; 
                case 2: {
                    int [] narray = new int[size];

                }; break; 
                case 3: {
                    double [] darray = new double[size];

                }; break; 
                case 4: {
                    decimal [] decarray = new decimal[size];
                    
                } ; break; 
            }              
            end :
            System.Console.WriteLine("Bye!"); 
        }
    }
}
