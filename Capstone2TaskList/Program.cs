using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Capstone2TaskList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Tasks> TaskList = new List<Tasks>();
            TaskList.Add(new Tasks(false, 2,"Ragib", "Laundry"));
            TaskList.Add(new Tasks(false, 30, "Lebron", "Win"));
            TaskList.Add(new Tasks(false, 1, "Kobe", "Trash"));
            TaskList.Add(new Tasks(false, 5, "Kevin", "Snake skinning"));
            TaskList.Add(new Tasks(false, .5, "Steph", "Cook"));

            Console.WriteLine("Welcome to the Task Manager!");

            bool mainMenu = true;


            while (mainMenu)
            {
                Console.WriteLine("1. List tasks");
                Console.WriteLine("2. Add task");
                Console.WriteLine("3. Delete task");
                Console.WriteLine("4. Mark task complete");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do?");
                string input = Console.ReadLine();

               
                int num;
                int.TryParse(input, out num);

               
                    if (num == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Done?\t" + "Due Date\t\t" + "Name\t" + "Description");
                        foreach (Tasks item in TaskList)
                        {                                                     
                            Console.WriteLine(item.complete + "\t" + item.DueDate + "\t" + item.TaskOwner + "\t" + item.TaskName);
                            continue;
                        }
                    }
                    else if (num == 2)
                    {
                        bool toAdd = true;
                        string response = "";

                        while (toAdd)
                        {
                            Console.WriteLine();
                            Console.Write("How many days should it be done by? ");
                            string due = Console.ReadLine();
                            Console.Write("Name of person? ");
                            string newTask = Console.ReadLine();
                            Console.Write("What task does this person have? ");
                            string newJob = Console.ReadLine();

                            int newDue;
                            int.TryParse(due, out newDue);
                            
                            TaskList.Add(new Tasks(false, newDue, newTask, newJob));
                            Console.WriteLine("quit?");
                            response = Console.ReadLine();
                            if (response == "quit")
                                toAdd = false;
                        }
                    }
                    else if (num == 3)
                    {
                   
                        Console.WriteLine();
                        Console.WriteLine($"Which task do you want to delete? (1-{TaskList.Count})");
                        string delete = Console.ReadLine();

                        int erase;
                        int.TryParse(delete, out erase);
                    
                    if (erase > 0 && erase < TaskList.Count)
                    { 
                            Console.Write($"Are you sure you want to delete {TaskList[erase].TaskOwner} {TaskList[erase].TaskName}, type 'y' or any other key returns to menu: ");                         
                            string youSure = Console.ReadLine().ToLower();
                        erase--;

                            if (youSure == "y")
                            {
                                TaskList.RemoveAt(erase);
                            }
                            else
                            {
                                mainMenu = true;
                            }
                        
                    }

                    }
                    else if (num == 4)
                    {
                        Console.WriteLine();
                        Console.Write("Which task do you want to mark complete? ");
                        string flip = Console.ReadLine();

                        int mark;
                        int.TryParse(flip, out mark);

                        if (mark > 0 && mark < TaskList.Count)
                        {
                        Console.Write($"Are you sure you want to mark {TaskList[mark].TaskOwner} {TaskList[mark].TaskName}, type 'y' or any other key returns to menu: ");
                        string youSure = Console.ReadLine().ToLower();
                        mark--;

                        if (youSure == "y")
                        {
                            TaskList[mark].complete=true;
                        }
                        else
                        {
                            mainMenu = true;
                        }

                    }

                }
                    else if (num == 5)
                    {
                        Console.WriteLine();
                        Console.Write("Are you sure you want to quit? (y or n): ");
                        string quit = Console.ReadLine().ToLower();
                        if (quit == "y")
                            {
                                Console.WriteLine("See you Later!");
                                mainMenu = false;
                            }
                        else
                            {
                                mainMenu = true;
                            }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid input");
                        mainMenu = true;
                       
                    }

                } 
            
          
            
        }
    }
}
