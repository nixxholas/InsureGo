using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace team3.DAL
{
    public class ProductDAO
    {

        string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

        //DISPLAYING OF PRODUCTS IN GRIDVIEW
        public List<Product> getProduct()
        {
            List<Product> productList = new List<Product>();
            DataSet ds = new DataSet();
            DataTable tdData = new DataTable();


            StringBuilder sqlStr = new StringBuilder();
            sqlStr.AppendLine("SELECT * From Product");


            SqlConnection myConn = new SqlConnection(DBConnect);
            SqlDataAdapter da = new SqlDataAdapter(sqlStr.ToString(), myConn);

            da.Fill(ds, "TableProduct");

            int rec_cnt = ds.Tables["TableProduct"].Rows.Count;
            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables["TableProduct"].Rows)
                {
                    Product myProduct = new Product();

                    myProduct.productName = row["productName"].ToString();
                    myProduct.productDescription = row["productDescription"].ToString();
                    myProduct.productPremium = row["productPremium"].ToString();
                    myProduct.productType = row["productType"].ToString();
                    myProduct.productPeriod = row["productPeriod"].ToString();
                    //myTD.tdPrincipal = Convert.ToDouble(row["principal"]);
                    //myTD.tdTerm = Convert.ToInt32(row["tdTerm"]);

                    productList.Add(myProduct);
                }
            }
            else
            {
                productList = null;
            }

            return productList;
        }

        public Product getProductById(string productId)
        {

            DataSet ds = new DataSet();
            Product myProduct = new Product();
            DataTable tdData = new DataTable();

            StringBuilder sqlStr = new StringBuilder();
            sqlStr.AppendLine("SELECT * From Product");
            sqlStr.AppendLine("where Id = @paraId");


            SqlConnection myConn = new SqlConnection(DBConnect);
            SqlDataAdapter da = new SqlDataAdapter(sqlStr.ToString(), myConn);


            da.SelectCommand.Parameters.AddWithValue("paraId", productId);

            da.Fill(ds, "TableProduct");

            int rec_cnt = ds.Tables["TableProduct"].Rows.Count;
            if (rec_cnt > 0)
            {
                foreach (DataRow row in ds.Tables["TableProduct"].Rows)
                {

                    myProduct.productName = row["productName"].ToString();
                    myProduct.productDescription = row["productDescription"].ToString();
                    myProduct.productPremium = row["productPremium"].ToString();
                    myProduct.productType = row["productType"].ToString();
                    myProduct.productPeriod = row["productPeriod"].ToString();


                    // myTD.tdPrincipal = Convert.ToDouble(row["principal"]);
                    // myTD.tdTerm = Convert.ToInt32(row["tdTerm"]);


                }
            }
            else
            {
                myProduct = null;
            }

            return myProduct;
        }



        public List<Product> filterProductType(string productType)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("select * from product p");
            sqlCommand.AppendLine("where productType = @paraproductType");

            List<Product> productList = new List<Product>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraproductType", productType);
            da.Fill(ds, "Product");

            int rec_cnt = ds.Tables["Product"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Product"].Rows[i];
                    Product obj = new Product();

                    obj.productId = Convert.ToInt32(row["productId"]);
                    obj.productType = row["productType"].ToString();
                    obj.productName = row["productName"].ToString();
                    obj.productDescription = row["productDescription"].ToString();
                    obj.productPremium = row["productPremium"].ToString();
                    obj.productPeriod = row["productPeriod"].ToString();

                    productList.Add(obj);
                }

                return productList;
            }
            else
            {
                return null;
            }

        }

        public List<Product> recoProducts(string productPremium)
        {
            string DBConnect;
            DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            string productPremium2 = (Convert.ToInt16(productPremium) + 200).ToString();

            StringBuilder sqlCommand = new StringBuilder();
            sqlCommand.AppendLine("select * from Product p");
            sqlCommand.AppendLine("where productPremium BETWEEN @paraproductPremium AND @paraproductPremium2");

            List<Product> productList = new List<Product>();

            SqlConnection myconn = new SqlConnection(DBConnect);
            da = new SqlDataAdapter(sqlCommand.ToString(), myconn);
            da.SelectCommand.Parameters.AddWithValue("paraProductPremium", productPremium);
            da.SelectCommand.Parameters.AddWithValue("paraProductPremium2", productPremium2);
            da.Fill(ds, "Product");

            int rec_cnt = ds.Tables["Product"].Rows.Count;

            if (rec_cnt > 0)
            {
                for (int i = 0; i < rec_cnt; i++)
                {
                    DataRow row = ds.Tables["Product"].Rows[i];
                    Product obj = new Product();

                    obj.productId = Convert.ToInt32(row["productId"]);
                    obj.productType = row["productType"].ToString();
                    obj.productName = row["productName"].ToString();
                    obj.productDescription = row["productDescription"].ToString();
                    obj.productPremium = row["productPremium"].ToString();

                    productList.Add(obj);

                }
            }

            return productList;

        }

    }
}