using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductMaintenance
{
    /// <summary>
    /// This class creats a connection to the product table of MMABooks database.
    /// It creates methods for updating, adding, and deleting informationg to
    /// and from the database for the products table
    /// Created by Nigel Mansell
    /// Date: 3/20/2017
    /// </summary>
    public static class ProductDB
    {
       /// <summary>
       /// Connects to the database and gets the the information from each 
       /// column for a single row of the products table.
       /// </summary>
       /// <param name="code"> the ProductCode</param>
       /// <returns> returns the product or null </returns>
        public static Product GetProduct(string code)
        {
           
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement = "SELECT ProductCode, Description, UnitPrice "
                + "FROM Products "
                + "WHERE ProductCode = @ProductCode";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductCode", code);
            // Trys to open a connection to the database and reads the data.
            // if its able to read set code, description, and price equal to
            // what is read in, else return null.
            try
            {
                connection.Open();
                SqlDataReader productReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (productReader.Read())
                {
                    Product product = new Product();
                    product.Code = productReader["ProductCode"].ToString();
                    product.Description = productReader["Description"].ToString();
                    product.Price = (decimal)productReader["UnitPrice"];
                    return product;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// This class takes the old product info from the columns and replaces
        /// it with new product info, except for the actual product code.
        /// </summary>
        /// <param name="oldProduct"> Object of product </param>
        /// <param name="newProduct"> Another object for product </param>
        /// <returns> true if it worked, false if it didnt </returns>
        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "Description = @NewDescription, " +
                "UnitPrice = @NewPrice " +
                "WHERE ProductCode = @OldCode " +
                "AND Description = @OldDescription " +
                "AND UnitPrice = @OldPrice";
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewDescription", newProduct.Description);
            updateCommand.Parameters.AddWithValue("@NewPrice", newProduct.Price);
            updateCommand.Parameters.AddWithValue("@OldCode", oldProduct.Code);
            updateCommand.Parameters.AddWithValue("@OldDescription", oldProduct.Description);
            updateCommand.Parameters.AddWithValue("@OldPrice", oldProduct.Price);
            // try to open a connection and sets count equal to
            // updatecommand.executenonquery. If executenonquery returns 1 or
            // more (number represents rows affect by a change) return true
            // else return false(no rows were changed).
            try
            {
                
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// This method takes in a code, description and price from the user,
        /// checks if there is a duplicate code, and if there isnt, adds 
        /// a new code with its description and price to the database.
        /// </summary>
        /// <param name="product"> the object of Product </param>
        /// <returns> true if it adds, false if it doesnt </returns>
        public static bool AddProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertStatement =
                "INSERT Products " +
                "(ProductCode, Description, UnitPrice) " +
                "VALUES (@Code, @Description, @Price)";
            SqlCommand check = new SqlCommand("SELECT ProductCode FROM Products WHERE ProductCode = @ProductCode", connection);
            check.Parameters.AddWithValue("@ProductCode", product.Code);
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@Code", product.Code);
            insertCommand.Parameters.AddWithValue("@Description", product.Description);
            insertCommand.Parameters.AddWithValue("@Price", product.Price);
            // Opens a connection for check.executeScalar(this will return a
            // ProductCode from the database if it exist, null if it doesnt). 
            connection.Open();
            object temp = check.ExecuteScalar();
            if (temp == null)
            {
                // close out the connection used only for check.executeScalar
                // because it was only used to check for a duplicate, not for 
                // any changes.
                connection.Close();

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                return false;
            }
            
        }
        
        /// <summary>
        /// This method deletes a product code and its description and price.
        /// </summary>
        /// <param name="product"> and object of Product </param>
        /// <returns> true if was successful, false if not </returns>
        public static bool DeleteProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProductCode = @Code " +
                "AND Description = @Description " +
                "AND UnitPrice = @UnitPrice";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@Code", product.Code);
            deleteCommand.Parameters.AddWithValue("@Description",
                product.Description);
            deleteCommand.Parameters.AddWithValue("@UnitPrice", product.Price);
            // executenonquery returns number of rows affected. If more than 0,
            // this means rows were successfully deleted, 0 mean nothing was.
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
