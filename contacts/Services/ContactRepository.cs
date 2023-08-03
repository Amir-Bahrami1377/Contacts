using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using contacts.Repository;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace contacts.Services
{
    internal class ContactRepository : IContactsRepository
    {
        private string connectionString = "Server=.,1433;Database=Contact_DB;User ID=sa;Password=AmirDudu77";
        public bool Delete(int contactId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From MyContacts where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", contactId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
            finally 
            {
                connection.Close();
            }
        }

        public bool Insert(string name, string family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try 
            {
                string query = "Insert Into MyContacts (Name,Family,Mobile,Age,Email,Address) values (@Name,@Family,@Mobile,@Age,@Email,@Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            } 
            catch 
            {
                
                return false;
            }
            finally { connection.Close(); }
        }

        public DataTable Search(string parameter)
        {
            string query = "select * from MyContacts where Name like @parameter or Family like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            string query = "select * from MyContacts";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int contactId)
        {
            string query = "select * from MyContacts where ContactID="+contactId;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update MyContacts Set Name=@Name,Family=@Family,Mobile=@Mobile,Email=@Email,Age=@Age,Address=@Address where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", contactId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Family", family);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
