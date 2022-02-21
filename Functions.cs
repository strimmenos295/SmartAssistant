using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartAssistant
{
    class Functions
    {
        //database search start
        public List<Plano> DataBaseSelectAll(SQLiteConnection conn)
        {
            List<Plano> list = new List<Plano>();
            Plano p2;
            conn.Open();
            String SelectQuery = "SELECT * FROM plano";
            SQLiteCommand cmd = new SQLiteCommand(SelectQuery, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            StringBuilder builder = new StringBuilder();
            while (reader.Read())
            {
                p2 = new Plano();
                p2.apo = reader.GetString(1);
                 p2.eos = reader.GetString(2);
                p2.topos = reader.GetString(3);
                list.Add(p2);
            }

            conn.Close();
            return list;
        }
        //database Search end
    }
}
