﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Menu
    {
        /* Work In Progress
        
        private CustomerCatalogue _customerCatalogue;
        private PizzaCatalogue _pizzaCatalogue;
        public Menu(CustomerCatalogue customerCatalogue, PizzaCatalogue pizzaCatalogue)
        {
            _pizzaCatalogue = pizzaCatalogue;
            _customerCatalogue = customerCatalogue;
        }

        public int ReadUserChoice()
        {
            string choice = Console.ReadLine();
            int input = -1;
            if (int.TryParse(choice, out input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        public int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("\t---------------CRUD Customeroperationer--------------------");
            Console.WriteLine("\t1.\tTilføj Customer til CustomerCatalogue");
            Console.WriteLine("\t2.\tUdskriv alle Customers fra CustomerCatalogue");
            Console.WriteLine("\t3.\tSøg efter en Customer i CustomerCatalogue udfra CID");
            Console.WriteLine("\t4.\tFjern Customer  fra CustomerCatalogue");
            Console.WriteLine("\t5.\tOpdater Customer i CustomerCatalogue");
            Console.WriteLine("\t---------------CRUD Pizzaoperationer--------------------");
            Console.WriteLine("\t6.\tTilføj Pizza til PizzaCatalogue");
            Console.WriteLine("\t7.\tUdskriv alle Pizzaer fra PizzaCatalogue");
            Console.WriteLine("\t8.\tSøg efter en pizza i PizzaCatalogue udfra Nr");
            Console.WriteLine("\t9.\tFjern pizza i PizzaCatalogue");
            Console.WriteLine("\t10.\tOpdater pizza fra PizzaCatalogue");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tTast 0 for afslut");
            Console.WriteLine("\t-----------------------------------");
            Console.Write("\tIndtast dit valg:");
            return ReadUserChoice();
        }

        public void Run()
        {
            int valg = ShowMenu();
            while (valg != 0)
            {
                switch (valg)
                {
                    case 1:
                        Console.Clear();
                        //Metode der indlæser og håndterer add Bog til BookRepositoryList
                        AddBookToList();
                        break;
                    case 2: // todo
                        Console.Clear();
                        Console.WriteLine("Print books");
                        _bookRepositoryList.PrintBooks();
                        break;
                    case 3: // todo
                        Console.Clear();
                        SearchBookList();
                        break;
                    case 4:
                        Console.Clear();
                        //Console.WriteLine("To be implemented!");
                        DeleteBookFromList();
                        break;
                    case 5:
                        Console.Clear();
                        UpdateBookList();
                        break;
                    case 6:
                        // TODO
                        break;
                    case 7:
                        // TODO
                        break;
                    case 8:
                        // TODO
                        break;
                    case 9:
                        // TODO
                        break;
                    case 10:
                        // TODO
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Fejl i input");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
                valg = ShowMenu();

            }

        }



        private void AddBookToList()
        {
            Console.WriteLine("Add book");
            Console.WriteLine("Angiv ISBN");
            string isbn = Console.ReadLine();
            Console.WriteLine("Angiv titel");
            string title = Console.ReadLine();
            Console.WriteLine("Angiv author");
            string author = Console.ReadLine();
            Console.WriteLine("Angiv antal sider");
            int noOfPages = int.Parse(Console.ReadLine());
            Book b = new Book(isbn, title, author, noOfPages);
            _bookRepositoryList.AddBook(b);
        }
        private void DeleteBookFromList()
        {
            Console.WriteLine("Delete book");
            Console.WriteLine("Angiv ISBN");
            string isbn = Console.ReadLine();
            _bookRepositoryList.DeleteBook(isbn);
        }

        private void SearchBookList()
        {
            Console.WriteLine("Search book");
            Console.WriteLine("Angiv ISBN");
            string isbn = Console.ReadLine();
            Book book = _bookRepositoryList.LookupBook(isbn);
            if (book == null)
            {
                Console.WriteLine("Bogen der søges efter eksisterer ikke");
            }
            else
            {
                Console.WriteLine(book);
            }
            Console.ReadLine();
        }

        private void UpdateBookList()
        {
            Console.WriteLine("Update book");
            Console.WriteLine("Angiv ISBN på bog der skal opdateres");
            string isbnOld = Console.ReadLine();
            Book book = _bookRepositoryList.LookupBook(isbnOld);
            if (book == null)
            {
                Console.WriteLine("Bogen der søges efter eksisterer ikke");
            }
            else
            {
                Console.WriteLine("Update book");
                Console.WriteLine("Angiv ISBN");
                string isbn = Console.ReadLine();
                Console.WriteLine("Angiv titel");
                string title = Console.ReadLine();
                Console.WriteLine("Angiv author");
                string author = Console.ReadLine();
                Console.WriteLine("Angiv antal sider");
                int noOfPages = int.Parse(Console.ReadLine());

                Book updatedBook = new Book(isbn, title, author, noOfPages);

                _bookRepositoryList.UpdateBook(isbnOld, updatedBook);
                Console.WriteLine("Bogen er opdateret");
                Console.ReadLine();
            }
        */
        }
}
