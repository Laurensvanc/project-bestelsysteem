﻿using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace ChapooDAL
{
    public class ProductDAO : Base
    {
        public List<Product> Db_Get_All_Products()
        {
            string query = "USE dbchapoo202104 SELECT ProductID, ProductNaam, Prijs, InkoopPrijs, Aantal, IsAlcohol, IsDrinken FROM [Product]; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddProduct(Product product)
        {
            // Data gets written to database, primary key is automatically made
            string query = "USE dbchapoo202104 INSERT INTO Product (ProductNaam, Prijs, InkoopPrijs, Aantal, IsAlcohol, IsDrinken) VALUES(@ProductNaam, @Prijs, @InkoopPrijs, @Aantal, @IsAlcohol, @IsDrinken); ";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@ProductNaam", product.ProductNaam);
            sqlParameters[1] = new SqlParameter("@Prijs", product.Prijs);
            sqlParameters[2] = new SqlParameter("@InkoopPrijs", product.InkoopPrijs);
            sqlParameters[3] = new SqlParameter("@Aantal", product.Aantal); 
            sqlParameters[4] = new SqlParameter("@IsAlcohol", Convert.ToInt32(product.IsAlcohol));
            sqlParameters[5] = new SqlParameter("@IsDrinken", Convert.ToInt32(product.IsDrinken));
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ChangeProduct(Product product)
        {
            // Data gets changed in database
            string query = "USE dbchapoo202104 UPDATE Product SET ProductNaam = @ProductNaam, Prijs = @Prijs, InkoopPrijs = @InkoopPrijs, Aantal = @Aantal, IsAlcohol = @IsAlcohol, IsDrinken = @IsDrinken WHERE ProductId = @ProductId; ";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@ProductNaam", product.ProductNaam);
            sqlParameters[1] = new SqlParameter("@Prijs", product.Prijs);
            sqlParameters[2] = new SqlParameter("@InkoopPrijs", product.InkoopPrijs);
            sqlParameters[3] = new SqlParameter("@Aantal", product.Aantal);
            sqlParameters[4] = new SqlParameter("@IsAlcohol", Convert.ToInt32(product.IsAlcohol));
            sqlParameters[5] = new SqlParameter("@IsDrinken", Convert.ToInt32(product.IsDrinken));
            sqlParameters[6] = new SqlParameter("@ProductId", product.ProductId);

            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteProduct(Product product)
        {
            // Data gets changed in database
            string query = "USE dbchapoo202104 DELETE FROM Product WHERE ProductId = @ProductId; ";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@productid", product.ProductId);

            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Product> ReadTables(DataTable dataTable)
        {
            List<Product> products = new List<Product>();

            // Check if datatable is null
            if (dataTable == null)
            {
                throw new Exception("Datatable is null");
            }

            foreach (DataRow dr in dataTable.Rows)
            {
                Product product = new Product
                    (
                    (int)dr["ProductID"],
                    (String)dr["ProductNaam"],
                    (double)dr["Prijs"],
                    (double)dr["InkoopPrijs"],
                    (int)dr["Aantal"],
                    (bool)dr["IsAlcohol"],
                    (bool)dr["IsDrinken"]
                    );

                products.Add(product);
            }
            return products;
        }
    }
}