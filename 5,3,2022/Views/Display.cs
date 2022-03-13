using _5_3_2022.Controller;
using _5_3_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_2022.Views
{
    class Display
    {
#pragma warning disable CS0649 // Field 'Display.closeOperationID' is never assigned to, and will always have its default value 0
        private int closeOperationID;
#pragma warning restore CS0649 // Field 'Display.closeOperationID' is never assigned to, and will always have its default value 0

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all entries");
            Console.WriteLine("2. Add new entry");
            Console.WriteLine("3. Update entry");
            Console.WriteLine("4. Fetch entry");
            Console.WriteLine("5. Delaete entry by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;

                }
            } while (operation != closeOperationID);
        }

        public  Display()
        {
            Input();
        }
        private void Add()
        {
            Kniga books = new Kniga();
            Console.WriteLine("Id: ");
            books.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: ");
            books.Име = Console.ReadLine();
            Console.WriteLine("Author: ");
            books.Автор = Console.ReadLine();
            Console.WriteLine("Publisher: ");
            books.Издател = Console.ReadLine();
            Console.WriteLine("Price: ");
            books.Цена = (int?)decimal.Parse(Console.ReadLine());
            
        }

        private void ListAll()
        {
            BooksBusiness books = new BooksBusiness();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "KNIGI" + new string(' ', 16));
            Console.WriteLine(new string(' ', 40));
            var bookslist = books.GetAll();
            foreach (var item in bookslist )
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", item.Id, item.Име, item.Автор, item.Издател, item.Цена );
            }
        }

        private void Update()
        {
            BooksBusiness bookscontroler = new BooksBusiness();
            Console.WriteLine("Enter Id for change: ");
            int id = int.Parse(Console.ReadLine());
            Kniga kniga = bookscontroler.Get(id);
            if (kniga != null)
            {
                Kniga books = new Kniga();
                Console.WriteLine("Id: ");
                books.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                books.Име = Console.ReadLine();
                Console.WriteLine("Author: ");
                books.Автор = Console.ReadLine();
                Console.WriteLine("Publisher: ");
                books.Издател = Console.ReadLine();
                Console.WriteLine("Price: ");
                books.Цена = (int?)decimal.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        private void Fetch()
        {
            BooksBusiness bookscontroler = new BooksBusiness();
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Kniga product = bookscontroler.Get(id);
            if (product != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + product.Id);
                Console.WriteLine("Name:" + product.Име);
                Console.WriteLine("Author: " + product.Автор);
                Console.WriteLine("Publisher: " + product.Издател);
                Console.WriteLine("Price: " + product.Цена);
                
                Console.WriteLine(new string('-', 40));
            }

        }

        private void Delete()
        {
            BooksBusiness bookscontroler = new BooksBusiness();
            Console.WriteLine("Enter ID to delete : ");
            int id = int.Parse(Console.ReadLine());
            bookscontroler.Delete(id);
            Console.WriteLine("Done.");
        }

    }
}


