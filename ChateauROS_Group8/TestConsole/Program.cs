﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Logic;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu_Service menu_Service = new Menu_Service();
            Category_Service category_Service = new Category_Service();
            List<Category> categories = category_Service.GetAllCategories();
            foreach (Category category in categories)
            {
                Console.WriteLine(category.ToString());
            }
            Menu menu1 = menu_Service.GetMenuByID(1);
            Category category1 = category_Service.GetCategoryByID(1);
            Console.WriteLine(menu1);
            Console.WriteLine(category1);
            Console.ReadKey();
        }
    }
}
