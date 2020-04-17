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
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.Create another array\n7.End your work");
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
                        case 7: goto end;
                        case 6: goto start1;
                        default: {
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
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
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.Create another array\n7.End your work");
                    int newchoice = int.Parse(Console.ReadLine());
                    switch(newchoice){
                        case 1:
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<int>.Pop(ref narray)}");
                            break;
                        case 2: {
                            System.Console.Write("Please enter new element: ");
                            int newelement = int.Parse(Console.ReadLine());
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<int>.Push(ref narray, newelement)}");
                        }; break;
                        case 3:
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<int>.Shift(ref narray)}");
                            break;
                        case 4: {
                            System.Console.Write("Please enter new element: ");
                            int newelement = int.Parse(Console.ReadLine());
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<int>.UnShift(ref narray, newelement)}");
                        }; break;
                        case 5: {
                            System.Console.WriteLine("please enter from which to which element of the array you want to cut\nFrom: ");
                            int posbegin = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("To: ");
                            int posend = int.Parse(Console.ReadLine());
                            int [] newArray = ArrayHelper<int>.Slice(narray, posbegin, posend);
                            System.Console.WriteLine("Your sliced array: ");
                            foreach( int s in newArray)
                                   System.Console.Write(s + "  ");
                        }; break;
                        case 7: goto end;
                        case 6: goto start1;
                        default: {
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
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
                        darray[i] = double.Parse(Console.ReadLine());
                    start :
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.Create another array\n7.End your work");
                    int newchoice = int.Parse(Console.ReadLine());
                    switch(newchoice){
                        case 1:
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<double>.Pop(ref darray)}");
                            break;
                        case 2: {
                            System.Console.Write("Please enter new element: ");
                            double newelement = double.Parse(Console.ReadLine());
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<double>.Push(ref darray, newelement)}");
                        }; break;
                        case 3:
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<double>.Shift(ref darray)}");
                            break;
                        case 4: {
                            System.Console.Write("Please enter new element: ");
                            double newelement = double.Parse(Console.ReadLine());
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<double>.UnShift(ref darray, newelement)}");
                        }; break;
                        case 5: {
                            System.Console.WriteLine("please enter from which to which element of the array you want to cut\nFrom: ");
                            int posbegin = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("To: ");
                            int posend = int.Parse(Console.ReadLine());
                            double [] newArray = ArrayHelper<double>.Slice(darray, posbegin, posend);
                            System.Console.WriteLine("Your sliced array: ");
                            foreach( double s in newArray)
                                   System.Console.Write(s + "  ");
                        }; break;
                        case 7: goto end;
                        case 6: goto start1;
                        default: {
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
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
                    System.Console.WriteLine("Now you can:\n1.Delete last element\n2.Add element to the end\n3.Delete first element\n4.Add element to beginning\n5.Slice part of your array\n6.Create another array\n7.End your work");
                    int newchoice = int.Parse(Console.ReadLine());
                    switch(newchoice){
                        case 1:
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<decimal>.Pop(ref marray)}");
                            break;
                        case 2: {
                            System.Console.Write("Please enter new element: ");
                            decimal newelement = decimal.Parse(Console.ReadLine());
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<decimal>.Push(ref marray, newelement)}");
                        }; break;
                        case 3:
                            System.Console.WriteLine($"Deleted element: {ArrayHelper<decimal>.Shift(ref marray)}");
                            break;
                        case 4: {
                            System.Console.Write("Please enter new element: ");
                            decimal newelement = decimal.Parse(Console.ReadLine());
                            System.Console.WriteLine($"New length of your array: {ArrayHelper<decimal>.UnShift(ref marray, newelement)}");
                        }; break;
                        case 5: {
                            System.Console.WriteLine("please enter from which to which element of the array you want to cut\nFrom: ");
                            int posbegin = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("To: ");
                            int posend = int.Parse(Console.ReadLine());
                            decimal [] newArray = ArrayHelper<decimal>.Slice(marray, posbegin, posend);
                            System.Console.WriteLine("Your sliced array: ");
                            foreach( decimal s in newArray)
                                   System.Console.Write(s + "  ");
                        }; break;
                        case 7: goto end;
                        case 6: goto start1;
                        default: {
                            System.Console.WriteLine("Error such choice wasn'n foresee!!! Try again");
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
