﻿namespace mju23h_dtp_genrep_FAS1
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
            //  1. Create a REPL with 'quit':
            //  2. Create dummy todo items
            //  3. Add 'list' that lists all active and waiting tasks
            //  4. Add 'list all' that lists all tasks
            //  5. Add 'new' that enables you to add new tasks
            //  6. Add 'start' to start an existing todo item (from waiting to active)
            //  7. Add 'stop' to stop an existing todo item (from active to waiting)
            //  8. Add 'done' to mark a todo item as done (from active/waiting to done)
            //  9. Add 'delete' to remove an item (from active/waiting to deleted)
            // 10. Add 'help' to list all available commands
        }
    }
}