namespace mju23h_dtp_genrep_FAS1
{
    internal class Program
    {
        static List<Todo> todolist;
        class Todo
        {
            static public int waiting = 0, active = 1, done = 2, deleted = 3;
            DateTime start;
            string description;
            int status;
            public Todo(string description)
            {
                start = DateTime.Now;
                this.description = description;
                status = waiting;
            }
            public string Status()
            {
                if (status == 0) return "waiting";
                else if (status == 1) return "active";
                else if (status == 2) return "done";
                else if (status == 3) return "deleted";
                else return "(invalid status)";
            }
            public void Print()
            {
                Console.WriteLine($"{start,-10} {Status(),-9} {description,-40}");
            }
        }
        static void Main(string[] args)
        {
            todolist = new List<Todo>();
            todolist.Add(new Todo("Byt till vinterdäck"));
            todolist.Add(new Todo("Plugga inför hemtentamen"));
            todolist.Add(new Todo("Dra stockar från skogen"));

            string command;
            do
            {
                Console.Write("> ");
                command = Console.ReadLine();
                if (command == "quit")
                {
                    break;
                }
                else if (command == "list")
                {
                    foreach (Todo task in todolist)
                    {
                        if (task.Status() == "waiting" || task.Status() == "active")
                        {
                            task.Print();
                        }
                    }
                }
                else if (command == "list all")
                {
                    foreach(Todo task in todolist)
                    {
                        task.Print();
                    }
                }
                else if(command == "new")
                {
                    Console.Write("Add new task: ");
                    string addNewTask = Console.ReadLine();
                    todolist.Add(new Todo(addNewTask));
                    Console.WriteLine($"'{addNewTask}' added to todolist");
                }
                else
                {
                    Console.WriteLine("Unknown command");
                }
            } while (command != "quit");
            //  5. Add 'new' that enables you to add new tasks
            //  6. Add 'start' to start an existing todo item (from waiting to active)
            //  7. Add 'stop' to stop an existing todo item (from active to waiting)
            //  8. Add 'done' to mark a todo item as done (from active/waiting to done)
            //  9. Add 'delete' to remove an item (from active/waiting to deleted)
            // 10. Add 'help' to list all available commands
        }
    }
}