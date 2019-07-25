using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data;

namespace MarathonSkills2015
{
    class Db
    {
        MySqlConnection conn;
        public Db()
        {
            string connectionString = "server=localhost;user id=root;database=marathonskills2015";
            conn = new MySqlConnection(connectionString);
        }

        public void execute(String sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, this.conn);
            this.conn.Open();
            cmd.ExecuteNonQuery();
            this.conn.Close();
        }

        public DataTable executeQuery(String sql)
        {
            DataTable dt = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand(sql))
            {
                cmd.Connection = this.conn; ;
                this.conn.Open();
                using (MySqlDataAdapter a = new MySqlDataAdapter(cmd))
                {
                    a.Fill(dt);
                }
                this.conn.Close();
            }
            return dt;
        }
    }
}
