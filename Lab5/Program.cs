using Lab5.dao;
using Lab5.entity;
using System;
using System.Data.SqlClient;

namespace Lab5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();    
            program.menu();
        }
        public  void menu()
        {
           
            while (true)
            {
                Console.WriteLine("===========Menu==========");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Update ");
                Console.WriteLine("3.Delete");
                Console.WriteLine("4.View All");
                Console.WriteLine("5.Search");
                Console.WriteLine("6.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        CreateData();
                        break;
                    case 2:
                        UpdateData();
                        break;
                    case 3:
                        DeleteData();
                        break ;
                    case 4:
                        GetData();
                        break ;
                    case 5:
                        searchData();
                        break;
                    case 6:
                        Console.WriteLine("See you again!!!");
                       Environment.Exit(6);
                        break;
                        default:
                        Console.WriteLine("Nhap sai");
                        break ;

                }
            }
        }
        public void GetData()
        {
            ProductDaoImpl product = new ProductDaoImpl();
            Console.WriteLine("name"+ product.getAll());

        }
        public void CreateData()
        {
            Product product = new Product();
            Console.WriteLine("Enter name product:");
            product.proName = Console.ReadLine();
            Console.WriteLine("Enter description:");
            product.proDesc = Console.ReadLine();
            Console.WriteLine("Enter price:");
            product.price =Convert.ToDouble( Console.ReadLine());
            ProductDaoImpl productImpl = new ProductDaoImpl();
            productImpl.createProduct(product);

        }
        public void DeleteData()
        {
            Console.WriteLine("Enter name :");
            string name=Console.ReadLine();
            ProductDaoImpl product = new ProductDaoImpl();
            product.deleteProduct(name);


        }
        public void UpdateData()
        {

            Product product = new Product();
            Console.WriteLine("Enter name product:");
            product.proName = Console.ReadLine();
            Console.WriteLine("Enter description:");
            product.proDesc = Console.ReadLine();
            Console.WriteLine("Enter price:");
            product.price = Convert.ToDouble(Console.ReadLine());
            ProductDaoImpl productimpl = new ProductDaoImpl();
            productimpl.updateProduct(product);

        }
        public void searchData()
        {

          
            Console.WriteLine("Enter name product:");
            string name= Console.ReadLine();
            ProductDaoImpl productimpl = new ProductDaoImpl();
            productimpl.searchProduct(name);

        }
    }
    
}