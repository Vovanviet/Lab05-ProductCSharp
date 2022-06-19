using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Lab5.entity;

namespace Lab5.dao
{
    public interface ProductDao
    {
        public ArrayList getAll();
        public void createProduct(Product product);
        public void updateProduct(Product product);
        public void deleteProduct(string name);
        public void searchProduct(string name);
    }
}
