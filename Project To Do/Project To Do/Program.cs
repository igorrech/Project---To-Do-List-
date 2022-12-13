using System;
using System.Globalization;

namespace ToDoList
{

    // nome da task
    // descrição da task
    // data e hora da task
    // - data
    // - hora
    // prioridade (1 a 5)
    // categoria das tarefas 
    // localização
    // - latitude 
    // - longitude

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our ToDo List!");
            Console.WriteLine("=======================");
            Console.Write("Please, enter you name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Olá, {name}");
            Console.WriteLine("=======================");
            Console.WriteLine("1. List: ToDos");
            Console.WriteLine("2. Add a new ToDo");
            Console.WriteLine("3. Update a ToDo");
            Console.WriteLine("4. Delete a ToDo");
            Console.WriteLine("5. Change name");
            Console.WriteLine("6. Exit");
            Console.WriteLine("=======================");
            Console.WriteLine(name + ", enter a choise: ");
            Console.WriteLine("=======================");
            string input = Console.ReadLine();

            while(input != "6")
            {        
              switch (input)
              {
                case "1":
                    Console.WriteLine("List: ToDo");
                    break;
                case "2":
                    Console.WriteLine("Add a new ToDo");
                    Todo[] toDo = new Todo[100];
                    for (int i = 0; i < 1; i++)
                    {
                        Todo firstTodo = new Todo();
                        Console.Write("Enter your task: ");
                        firstTodo.task = Console.ReadLine();
                        Console.Write("Description of task: ");
                        firstTodo.description = Console.ReadLine();
                    }
                    
                    break;
                case "3":
                    Console.WriteLine("3. Update a ToDo");
                    break;
                case "4":
                    Console.WriteLine("4. Delete a ToDo");
                    break;
                case "5":
                    Console.WriteLine("5. Change name");
                    break;
                case "6":
                    Console.WriteLine("6. Exit");
                    break;
              }
            }






        }
    }
}

class Name
{
    public string firstName;
    public string middleName;
    public string lastName;
}


class Todo
{
    public string task;
    public string description;
    public DateTime deadline;
}

