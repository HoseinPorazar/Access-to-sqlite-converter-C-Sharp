using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
namespace Accsess2SqliteDatabaseConverter
{
   
    public class AccessConnect
    {
        OleDbConnection _con;
        public AccessConnect(string dbPath)
        {
            _con = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=" + dbPath + ";Jet OLEDB:Database Password=h@#%^ein;");
            _con.Open();        
        }
        public List<string> GetTableNames()
        {
            List<string> Res = new List<string>();
            string[] restrictions = new string[4];
            restrictions[3] = "Table";
            DataTable userTables = null;
            

            //getting names of tables
            userTables = _con.GetSchema("Tables", restrictions);
           
            for (int i = 0; i < userTables.Rows.Count; i++)
            {

                Res.Add(userTables.Rows[i][2].ToString());
            }
            return Res;
        }
        public DataTable GetTable(string name)
        {

            DataTable dt = new DataTable();


            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM " + name, _con);
            da.Fill(dt);
            return dt;
        }
        public List<string> GeColumnNames(string tableName)
        {
            List<string> Res = new List<string>();
            using (var cmd = new OleDbCommand("select * from "+tableName, _con))
            using (var reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly))
            {
                var table = reader.GetSchemaTable();
                var nameCol = table.Columns["ColumnName"];
                foreach (DataRow row in table.Rows)
                {
                    Res.Add(row[nameCol].ToString());
                }
            }
            return Res;
        }
    }
}
