using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Product
    {
        static Product()
        {
            _count = 100;
        }
        static int _count = 100;
        public static int Count => _count;
        public Product(string category)
        {
            Category = category;
            _count++;
            No = category.Substring(0,2).ToUpper()+ _count;
        }

        public string No;
        public string Name;
        public string Category;
        public double Price;

    }
}
