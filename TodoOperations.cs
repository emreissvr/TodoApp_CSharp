using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject
{
    class TodoOperations
    {


        public void ListBoard(List<Todo> todoList)
        {
            Console.WriteLine();
            FindProcess(todoList, 0); // "Todo"
            FindProcess(todoList, 1); // "In Progress"
            FindProcess(todoList, 2); // "Done"
        }

        public void FindProcess(List<Todo> todoList, int status)
        {

            List<Todo> results = todoList.FindAll(todo => todo.GetStatus() == status);
            if (status == 0)
            {
                Console.WriteLine("TODO line");
                Console.WriteLine("*****************************");

            }
            else if (status == 1)
            {
                Console.WriteLine("IN PROGRESS line");
                Console.WriteLine("*****************************");
            }
            else if (status == 2)
            {
                Console.WriteLine("DONE line");
                Console.WriteLine("*****************************");
            }

            if (results.Count == 0)
            {
                Console.WriteLine("BOŞ");
                Console.WriteLine("*****************************");
            }
            else
            {
                foreach (var todo in results)
                {
                    todo.TodoDetails();
                    Console.WriteLine();
                }
            }
        }

        public void AddCardToBoard(List<Todo> todoList)
        {
            Console.WriteLine();
            Console.Write("Başlık Giriniz                                 :");
            string title = Console.ReadLine();
            Console.WriteLine();
            Console.Write("İçerik Giriniz                                 :");
            string content = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int size = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Kişi Seçiniz                                   :");

            try
            {
                int person = int.Parse(Console.ReadLine());
                todoList.Add(new Todo(title, content, size, person));
                Console.WriteLine();
                ListBoard(todoList);
            }
            catch
            {

                Console.WriteLine("Hatalı girişler yaptınız!");
            }
        }


        public void RemoveCardFromBoard(List<Todo> todoList)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();
            List<Todo> results = todoList.FindAll(x => x.GetTitle() == input);

            if (results.Count != 0)
            {
                foreach (Todo item in results)
                {
                    todoList.Remove(item);
                }
                Console.WriteLine("Silme işlemi gerçekleşti");
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    RemoveCardFromBoard(todoList);
                }
                else
                {
                    Console.WriteLine("Silme işlemi iptal edildi.");
                }
            }
        }


        public void MoveCard(List<Todo> todoList)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string input = Console.ReadLine();
            List<Todo> result = todoList.FindAll(x => x.GetTitle() == input);

            if (result.Count != 0)
            {

                Console.WriteLine();
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("**************************************");
                Console.WriteLine();

                foreach (Todo item in result)
                {
                    item.TodoDetails();
                    if (item.GetStatus() == 0) { Console.WriteLine("Line        :" + "TODO"); }
                    else if (item.GetStatus() == 1) { Console.WriteLine("Line        :" + "IN PROGRESS"); }
                    else if (item.GetStatus() == 2) { Console.WriteLine("Line        :" + "DONE"); }
                }

                Console.WriteLine();
                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine("(1) TODO");
                Console.WriteLine("(2) IN PROGRESS");
                Console.WriteLine("(3) DONE");
                int option = int.Parse(Console.ReadLine());

                if (option == 1 || option == 2 || option == 3)
                {
                    option--;
                    todoList.Find(x => x.GetTitle() == input).SetStatus((option));
                    Console.WriteLine("Taşıma işlemi tamamlandı");
                    ListBoard(todoList);
                }

                else
                {
                    Console.WriteLine("Hatalı bir seçim yaptınız!");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                int option = int.Parse(Console.ReadLine());
                if (option == 2)
                {
                    MoveCard(todoList);
                }
                else { Console.WriteLine("Taşıma işlemi iptal edildi."); }
            }
        }



    }
}
