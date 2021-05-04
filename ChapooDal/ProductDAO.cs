using ChapooModel;
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
            string query = "USE dbchapoo202104 SELECT ProductID, ProductNaam, Prijs, InkoopPrijs, Aantal, IsAlcohol, IsDrinken FROM [Product]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
