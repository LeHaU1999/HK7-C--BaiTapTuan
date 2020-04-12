using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPostgreSQL_CRUD
{
    class CRUD
    {
        private static NpgsqlConnection con = default;
        private static NpgsqlCommand cmd = default;
        private static string sql = string.Empty;
        private static NpgsqlDataAdapter da = default;
        private static DataTable dt = default;
        private static string GetConnectionString()
        {
            string server = "localhost";
            string port = "5432";
            string user_id = "postgres;";
            string pass = "suong123;";
            string db = "db_crud";

            string conString = string.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            server, port, user_id, pass, db);

            return conString;
        }
        private static void OpenConnection()
        {
            con = new NpgsqlConnection(GetConnectionString());
            con.Open();
        }
        private static void CloseConnection()
        {
            con.Close();
        }
        public static int CreateData(string first_name, string last_name, string gender)
        {
            int result = -1;
            sql = "insert into crud(first_name, last_name, gender) values(@first_name, @last_name, @gender)";
            try
            {
                OpenConnection();
                cmd = new NpgsqlCommand
                {
                    Connection = con,
                    CommandText = sql,
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@first_name", first_name);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                cmd.Parameters.AddWithValue("@gender", gender);
                result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
                CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                CloseConnection();
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
        }
        public static DataTable ReadData()
        {
            sql = "select id, first_name, last_name, concat(first_name, ' ', last_name) as full_name, gender from crud order by id asc";
            try
            {
                OpenConnection();
                cmd = new NpgsqlCommand
                {
                    Connection = con,
                    CommandText = sql,
                    CommandType = CommandType.Text
                };
                da = new NpgsqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
                CloseConnection();
                return dt;
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                CloseConnection();
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public static int UpdateData(int id, string first_name, string last_name, string gender)
        {
            int result = -1;
            sql = "UPDATE public.crud SET first_name = @first_name, last_name = @last_name, gender = @gender WHERE id = @id;";
            try
            {
                OpenConnection();
                cmd = new NpgsqlCommand
                {
                    Connection = con,
                    CommandText = sql,
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@first_name", first_name);
                cmd.Parameters.AddWithValue("@last_name", last_name);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@id", id);
                result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
                CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                CloseConnection();
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
        }
        public static int DeleteData(int id)
        {
            int result = -1;
            sql = "DELETE FROM public.crud WHERE id = @id; ";
            try
            {
                OpenConnection();
                cmd = new NpgsqlCommand
                {
                    Connection = con,
                    CommandText = sql,
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@id", id);
                result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.Dispose();
                CloseConnection();
                return result;
            }
            catch (Exception ex)
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                CloseConnection();
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return result;
            }
        }
    }
}
