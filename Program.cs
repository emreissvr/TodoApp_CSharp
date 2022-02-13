using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject
{
    class Program
    {
        static void Main(string[] args)
        {


            TodoOperations operations = new TodoOperations();

            Todo todo1 = new Todo("JavaScript Tutorial", "JS", 2, 1, 1);
            Todo todo2 = new Todo("React Chat App", "React", 1, 2, 2);
            Todo todo3 = new Todo("Node.js tutorial", "Node.js", 1, 2);

            List<Todo> todoList = new List<Todo>();

            todoList.Add(todo1);
            todoList.Add(todo2);
            todoList.Add(todo3);


            int selection = 0;
            Boolean exitStatus = true;

            while (exitStatus)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("********************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                Console.WriteLine("(5) Çıkış yapmak");

                selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        operations.ListBoard(todoList);
                        break;
                    case 2:
                        operations.AddCardToBoard(todoList);
                        break;
                    case 3:
                        operations.RemoveCardFromBoard(todoList);
                        break;
                    case 4:
                        operations.MoveCard(todoList);
                        break;

                    case 5:
                        exitStatus = false;
                        break;
                }
            }





        }
    }
}
