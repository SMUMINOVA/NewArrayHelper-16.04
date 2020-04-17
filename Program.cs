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
            System.Console.WriteLine("Now enter elemets of your array");
            switch(choice){
                case 1: {
                    string [] sarray = new string[size];
                    for (int i = 0; i < size; i++)
                        sarray[i] = Console.ReadLine();
                    start :
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.See yours data\n7.Create another array\n8.End your work");
                    int newchoice = int.Parse(Console.ReadLine());
                    switch(newchoice){
                        case 1:{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<string>.Pop(ref sarray)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 2: {
                            System.Console.Write("Please enter new element: ");
                            string newelement = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<string>.Push(ref sarray, newelement)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 3:{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<string>.Shift(ref sarray)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        };break;
                        case 4: {
                            System.Console.Write("Please enter new element: ");
                            string newelement = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<string>.UnShift(ref sarray, newelement)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 5: {
                            System.Console.WriteLine("please enter from which to which element of the array you want to cut\nFrom: ");
                            int posbegin = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("To: ");
                            int posend = int.Parse(Console.ReadLine());
                            string [] newArray = ArrayHelper<string>.Slice(sarray, posbegin, posend);
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Your sliced array: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            foreach( string s in newArray)
                                   System.Console.WriteLine(s);
                        }; break;
                        case 8: goto end;
                        case 6: ArrayHelper<string>.Show(sarray); break;
                        case 7: goto start1;
                        default: {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto start;
                        }
                    }
                    System.Console.WriteLine("Do you want to continue?y/n");
                    if(Console.ReadLine() == "y")
                      goto start;
                    else goto end;
                }; 
                case 2: {
                    int [] narray = new int[size];
                    for (int i = 0; i < size; i++)
                        narray[i] = int.Parse(Console.ReadLine());
                    start :
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.See yours data\n7.Create another array\n8.End your work");
                    int newchoice = int.Parse(Console.ReadLine());
                    switch(newchoice){
                        case 1:{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<int>.Pop(ref narray)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        };break;
                        case 2: {
                            System.Console.Write("Please enter new element: ");
                            int newelement = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<int>.Push(ref narray, newelement)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 3:{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<int>.Shift(ref narray)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        };break;
                        case 4: {
                            System.Console.Write("Please enter new element: ");
                            int newelement = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<int>.UnShift(ref narray, newelement)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 5: {
                            System.Console.WriteLine("please enter from which to which element of the array you want to cut\nFrom: ");
                            int posbegin = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("To: ");
                            int posend = int.Parse(Console.ReadLine());
                            int [] newArray = ArrayHelper<int>.Slice(narray, posbegin, posend);
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Your sliced array: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            foreach( int s in newArray)
                                   System.Console.WriteLine(s);
                        }; break;
                        case 8: goto end;
                        case 6: ArrayHelper<int>.Show(narray); break;
                        case 7: goto start1;
                        default: {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto start;
                        }
                    }
                    System.Console.WriteLine("Do you want to continue?y/n");
                    if(Console.ReadLine() == "y")
                      goto start;
                    else goto end;
                }; 
                case 3: {
                    double [] darray = new double[size];
                    for (int i = 0; i < size; i++)
                        darray[i] = Convert.ToDouble(Console.ReadLine());
                    start :
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.See yours data\n7.Create another array\n8.End your work");
                    int newchoice = int.Parse(Console.ReadLine());
                    switch(newchoice){
                        case 1:{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<double>.Pop(ref darray)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        };break;
                        case 2: {
                            System.Console.Write("Please enter new element: ");
                            double newelement = double.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<double>.Push(ref darray, newelement)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 3:{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<double>.Shift(ref darray)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        };break;
                        case 4: {
                            System.Console.Write("Please enter new element: ");
                            double newelement = double.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<double>.UnShift(ref darray, newelement)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 5: {
                            System.Console.WriteLine("please enter from which to which element of the array you want to cut\nFrom: ");
                            int posbegin = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("To: ");
                            int posend = int.Parse(Console.ReadLine());
                            double [] newArray = ArrayHelper<double>.Slice(darray, posbegin, posend);
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Your sliced array: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            foreach( double s in newArray)
                                   System.Console.WriteLine(s);
                        }; break;
                        case 8: goto end;
                        case 6: ArrayHelper<double>.Show(darray); break;
                        case 7: goto start1;
                        default: {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto start;
                        }
                    }
                    System.Console.WriteLine("Do you want to continue?y/n");
                    if(Console.ReadLine() == "y")
                      goto start;
                    else goto end;
                }; 
                case 4: {
                    decimal [] marray = new decimal[size];
                    for (int i = 0; i < size; i++)
                        marray[i] = decimal.Parse(Console.ReadLine());
                    start :
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.See yours data\n7.Create another array\n8.End your work");
                    int newchoice = int.Parse(Console.ReadLine());
                    switch(newchoice){
                        case 1:{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<decimal>.Pop(ref marray)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        };break;
                        case 2: {
                            System.Console.Write("Please enter new element: ");
                            decimal newelement = decimal.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<decimal>.Push(ref marray, newelement)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 3:{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<decimal>.Shift(ref marray)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        };break;
                        case 4: {
                            System.Console.Write("Please enter new element: ");
                            decimal newelement = decimal.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<decimal>.UnShift(ref marray, newelement)}");
                            Console.ForegroundColor = ConsoleColor.White;
                        }; break;
                        case 5: {
                            System.Console.WriteLine("please enter from which to which element of the array you want to cut\nFrom: ");
                            int posbegin = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("To: ");
                            int posend = int.Parse(Console.ReadLine());
                            decimal [] newArray = ArrayHelper<decimal>.Slice(marray, posbegin, posend);
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Your sliced array: ");
                            Console.ForegroundColor = ConsoleColor.White;
                            foreach( decimal s in newArray)
                                   System.Console.WriteLine(s);
                        }; break;
                        case 8: goto end;
                        case 6: ArrayHelper<decimal>.Show(marray);break;
                        case 7: goto start1;
                        default: {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
                            Console.ForegroundColor = ConsoleColor.White;
                            goto start;
                        }
                    }
                    System.Console.WriteLine("Do you want to continue?y/n");
                    if(Console.ReadLine() == "y")
                      goto start;
                    else goto end;
                }; 
            }              
            end :
            System.Console.WriteLine("Bye!"); 
        }
    }
}
