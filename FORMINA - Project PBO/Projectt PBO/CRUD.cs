using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Projectt_PBO
{
    class CRUD
    {


        private static string getConnectionString()
        {

            string host = "Host=localhost;";
            string port = "Port=5432;";
            string db = "Database=Project PBO;";
            string user = "Username=postgres;";
            string pass = "Password=aleand16;";
            
            string conString = string.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);

            return conString;

        }
        

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static CommandType CommandType { get; internal set; }

        public static DataTable PerformCRUD(NpgsqlCommand com)
        {

            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {

                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);

                return dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("terjadi kesalahan: " + ex.Message, "Gagal Melakukan Operasi.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }
    }
}
