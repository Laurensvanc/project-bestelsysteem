﻿using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Product_Service
    {
        private ProductDAO product_db = new ProductDAO();

        public List<Product> GetProducts()
        {
            try
            {
                List<Product> products = product_db.Db_Get_All_Products();
                return products;
            }
            catch (Exception e)
            {
                //ErrorText = e.Message;
                //Error = true;
                // throw new Exception(e.Message);
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Product> products = new List<Product>();
                Product a = new Product(404, "404", 40.4, 4.04, 404, false, false);
                products.Add(a);

                return products;
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                product_db.AddProduct(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ChangeProduct(Product product)
        {
            try
            {
                product_db.ChangeProduct(product);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                product_db.DeleteProduct(product);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}