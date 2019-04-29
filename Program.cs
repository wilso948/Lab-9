using System;
using System.Collections.Generic;

namespace Lab_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> newStudent = new List<Student>();

            newStudent.Add(new Student());
            newStudent[0].Name = "";

            newStudent.Add(new Student());
            newStudent[1].Name = "James Washington";
            newStudent[1].Hometown = "Canton";
            newStudent[1].Age = 30;

            newStudent.Add(new Student());
            newStudent[2].Name = "Ian Campbell";
            newStudent[2].Hometown = "Southfield";
            newStudent[2].Age = 25;

            newStudent.Add(new Student());
            newStudent[3].Name = "Sarah Murrell";
            newStudent[3].Hometown = "Farmington Hills";
            newStudent[3].Age = 25;

            newStudent.Add(new Student());
            newStudent[4].Name = "Jason Greene";
            newStudent[4].Hometown = "Auburn Hills";
            newStudent[4].Age = 23;

            newStudent.Add(new Student());
            newStudent[5].Name = "Grace Johnson";
            newStudent[5].Hometown = "Redford";
            newStudent[5].Age = 28;

            newStudent.Add(new Student());
            newStudent[6].Name = "Corey Wilson";
            newStudent[6].Hometown = "Detroit";
            newStudent[6].Age = 28;


            Console.WriteLine("Hello welcome to our class! Which student would you like to know about? Pick 1-6.");

            int userInput = int.Parse(Console.ReadLine());

            string userInput2 = null;
            
            do
            {
                

                if (userInput == 1 )
                {
                    Console.WriteLine("Student name is " + newStudent[1].Name + "." + " Would you like to know more? (Yes/No)");
                    userInput2 = Console.ReadLine();

                    if (userInput2 == "No")
                    {
                        break;
                    }

                    Console.WriteLine("Enter Hometown or Age");
                    string userInput3 = Console.ReadLine();

                    if (userInput3 == "Hometown")
                    {
                        Console.WriteLine(newStudent[1].Name + " is from " + newStudent[1].Hometown + ".");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput4 = Console.ReadLine();
                        if (userInput4 == "Yes")
                        {
                            Console.WriteLine(newStudent[1].Name + " is " + newStudent[1].Age + " years old!");
                        }
                        else 
                        {
                            break;
                        }
                    }
                    if (userInput3 == "Age")
                    {
                        Console.WriteLine(newStudent[1].Name + " is " + newStudent[1].Age + " years old!");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput5 = Console.ReadLine();
                      
                        if (userInput5 == "Yes")
                        {
                            Console.WriteLine(newStudent[1].Name + " is " + newStudent[1].Age + " years old!");
                        }
                        else
                        {
                            break;
                        }

                    }
                }

                if (userInput == 2)
                {
                    Console.WriteLine("Student name is " + newStudent[2].Name + "." + " Would you like to know more? (Yes/No)");
                    userInput2 = Console.ReadLine();

                    if (userInput2 == "No")
                    {
                        break;
                    }

                    Console.WriteLine("Enter Hometown or Age");
                    string userInput3 = Console.ReadLine();

                    if (userInput3 == "Hometown")
                    {
                        Console.WriteLine(newStudent[2].Name + " is from " + newStudent[2].Hometown + ".");
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput4 = Console.ReadLine();
                        if (userInput4 == "No")
                        {
                            break;
                        }
                        else if (userInput4 == "Yes")
                        {
                            Console.WriteLine(newStudent[2].Name + " is " + newStudent[2].Age + " years old!");
                        }
                    }
                    else if (userInput3 == "Age")
                    {
                        Console.WriteLine(newStudent[2].Name + " is " + newStudent[2].Age + " years old!");
                        Console.WriteLine("");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput5 = Console.ReadLine();
                        if (userInput5 != "No")
                        {
                            break;
                        }
                        else if (userInput5 == "Yes")
                        {
                            Console.WriteLine(newStudent[2].Name + " is " + newStudent[2].Age + " years old!");
                        }
                    }
                }

                if (userInput == 3)
                {
                    Console.WriteLine("Student name is " + newStudent[3].Name + "." + " Would you like to know more? (Yes/No)");
                    userInput2 = Console.ReadLine();

                    if (userInput2 == "No")
                    {
                        break;
                    }

                    Console.WriteLine("Enter Hometown or Age");
                    string userInput3 = Console.ReadLine();

                    if (userInput3 == "Hometown")
                    {
                        Console.WriteLine(newStudent[3].Name + " is from " + newStudent[3].Hometown + ".");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput4 = Console.ReadLine();
                        if (userInput4 != "No")
                        {
                            break;
                        }
                        else if (userInput4 == "Yes")
                        {
                            Console.WriteLine(newStudent[3].Name + " is " + newStudent[3].Age + " years old!");
                        }
                    }
                    else if (userInput3 == "Age")
                    {
                        Console.WriteLine(newStudent[3].Name + " is " + newStudent[3].Age + " years old!");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput5 = Console.ReadLine();
                        if (userInput5 != "No")
                        {
                            break;
                        }
                        else if (userInput5 == "Yes")
                        {
                            Console.WriteLine(newStudent[3].Name + " is " + newStudent[3].Age + " years old!");
                        }
                    }
                }

                if (userInput == 4)
                {
                    Console.WriteLine("Student name is " + newStudent[4].Name + "." + " Would you like to know more? (Yes/No)");
                    userInput2 = Console.ReadLine();

                    if (userInput2 == "No")
                    {
                        break;
                    }

                    Console.WriteLine("Enter Hometown or Age");
                    string userInput3 = Console.ReadLine();

                    if (userInput3 == "Hometown")
                    {
                        Console.WriteLine(newStudent[4].Name + " is from " + newStudent[4].Hometown + ".");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput4 = Console.ReadLine();
                        if (userInput4 != "No")
                        {
                            break;
                        }
                        else if (userInput4 == "Yes")
                        {
                            Console.WriteLine(newStudent[4].Name + " is " + newStudent[4].Age + " years old!");
                        }
                    }
                    else if (userInput3 == "Age")
                    {
                        Console.WriteLine(newStudent[4].Name + " is " + newStudent[4].Age + " years old!");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput5 = Console.ReadLine();
                        if (userInput5 != "No")
                        {
                            break;
                        }
                        else if (userInput5 == "Yes")
                        {
                            Console.WriteLine(newStudent[4].Name + " is " + newStudent[4].Age + " years old!");
                        }
                    }
                }

                if (userInput == 5)
                {
                    Console.WriteLine("Student name is " + newStudent[5].Name + "." + " Would you like to know more? (Yes/No)");
                    userInput2 = Console.ReadLine();

                    if (userInput2 == "No")
                    {
                        break;
                    }

                    Console.WriteLine("Enter Hometown or Age");
                    string userInput3 = Console.ReadLine();

                    if (userInput3 == "Hometown")
                    {
                        Console.WriteLine(newStudent[5].Name + " is from " + newStudent[5].Hometown + ".");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput4 = Console.ReadLine();
                        if (userInput4 != "No")
                        {
                            break;
                        }
                        else if (userInput4 == "Yes")
                        {
                            Console.WriteLine(newStudent[5].Name + " is " + newStudent[5].Age + " years old!");
                        }
                    }
                    else if (userInput3 == "Age")
                    {
                        Console.WriteLine(newStudent[5].Name + " is " + newStudent[5].Age + " years old!");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput5 = Console.ReadLine();
                        if (userInput5 != "No")
                        {
                            break;
                        }
                        else if (userInput5 == "Yes")
                        {
                            Console.WriteLine(newStudent[5].Name + " is " + newStudent[5].Age + " years old!");
                        }
                    }
                }

                if (userInput == 6)
                {
                    Console.WriteLine("Student name is " + newStudent[6].Name + "." + " Would you like to know more? (Yes/No)");
                    userInput2 = Console.ReadLine();

                    if (userInput2 == "No")
                    {
                        break;
                    }

                    Console.WriteLine("Enter Hometown or Age");
                    string userInput3 = Console.ReadLine();

                    if (userInput3 == "Hometown")
                    {
                        Console.WriteLine(newStudent[6].Name + " is from " + newStudent[6].Hometown + ".");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput4 = Console.ReadLine();
                        if (userInput4 != "No")
                        {
                            break;
                        }
                        else if (userInput4 == "Yes")
                        {
                            Console.WriteLine(newStudent[6].Name + " is " + newStudent[6].Age + " years old!");
                        }
                    }
                    else if (userInput3 == "Age")
                    {
                        Console.WriteLine(newStudent[6].Name + " is " + newStudent[6].Age + " years old!");
                        Console.WriteLine("Would you like to know more? (Yes/No)");
                        string userInput5 = Console.ReadLine();
                        if (userInput5 != "No")
                        {
                            break;
                        }
                        else if (userInput5 == "Yes")
                        {
                            Console.WriteLine(newStudent[6].Name + " is " + newStudent[6].Age + " years old!");
                        }
                    }
                }
                Console.WriteLine("Goodbye");
            } while (userInput2 == "No");

           

          
        }
    }
}
