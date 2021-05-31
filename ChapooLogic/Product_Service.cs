using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Product_Service
    {
        private readonly ProductDAO _productDao = new ProductDAO();

        public List<Product> GetProducts()
        {
            try
            {
                List<Product> products = _productDao.Db_Get_All_Products();
                return products;
            }
            catch (Exception)
            {
                List<Product> products = new List<Product>();
                Product a = new Product(404, "404", 40.4, 4.04, 404, false, false);
                products.Add(a);

                return products;
            }
        }

        public List<Product> GetSpecificProduct(int soortId)
        {
            try
            {
                List<Product> products = _productDao.Db_Get_All_SpecificProduct(soortId);
                return products;
            }
            catch (Exception)
            {
                List<Product> products = new List<Product>();
                Product a = new Product(404, "404", 40.4, 4.04, 404, false, false);
                products.Add(a);

                return products;
            }
        }

        public void OpenBottle(int bottleId, int glasId)
        {
            try
            {
                _productDao.Open_Bottle_Product(bottleId, glasId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                _productDao.AddProduct(product);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ChangeProduct(Product product)
        {
            try
            {
                _productDao.ChangeProduct(product);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                _productDao.DeleteProduct(product);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}