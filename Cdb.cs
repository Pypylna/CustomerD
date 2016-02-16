using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace CustomerD
{
    public class Cdb
    {
        private SqlConnection polaczenie;
        private string tableName;
        private string nazwaBazy;
            

        /// <summary>
        /// Konstruktor do laczenia z autoryzacją SQL Server
        /// </summary>
        /// <param name="user">nazwa uzytkownika</param>
        /// <param name="pass">haslo</param>
        /// <param name="instance">instancja</param>
        /// <param name="dbdir">nazwa bazy</param>
        public Cdb(string user, string pass, string instance, string dbdir, string tn)
        {
            polaczenie = new SqlConnection();
            polaczenie.ConnectionString = "user id=" + user +
                ";password=" + pass + ";Data Source=" + instance +
                ";Trusted_Connection=no" +
                ";database=" + dbdir +
                ";connection timeout=5";
            polaczenie.Open();

            nazwaBazy = dbdir;
            tableName = tn;
        }

        /// <summary>
        /// Kontruktor do laczenia z autoryzacja windows
        /// </summary>
        /// <param name="instance">nazwa instancji</param>
        /// <param name="dbdir">nazwa bazy</param>
        public Cdb(string instance, string dbdir,string tn)
        {
            polaczenie = new SqlConnection();
            polaczenie.ConnectionString = "Data Source=" + instance +
                ";Trusted_Connection=yes;" +
                "database=" + dbdir +
                ";connection timeout=3";
            polaczenie.Open();

            nazwaBazy = dbdir;
            tableName = tn;
        }

        /// <summary>
        /// pobiera dane do obiektu DataTable
        /// </summary>
        /// <param name="q">zapytanie sql</param>
        public DataTable pobierzDane()
        {
            string q = "select * from " + tableName;
            DataTable dt = new DataTable();
            SqlDataReader dr;
            SqlCommand com;

            com = new SqlCommand(q);
            com.Connection = this.polaczenie;
            dr = com.ExecuteReader();
            dt.Load(dr);

            return dt;
        }

        /// <summary>
        /// usuwa z bazy danych wiersz
        /// </summary>
        /// <param name="index">indeks wiersza</param>
        public void usunWiersz(string index)
        {
            string q;
            q = "DELETE FROM " + tableName + " WHERE id=" + index;


            SqlCommand com = new SqlCommand(q);
            com.Connection = polaczenie;
            com.ExecuteNonQuery();

        }

        /// <summary>
        /// Dodaje wiersz do bazy danych
        /// </summary>
        /// <param name="name">wartość w kolumnie name</param>
        /// <param name="sname">wartość w kolumnie  surname</param>
        /// <param name="tn">wartość w kolumnie  teephonenumber</param>
        /// <param name="a">wartość w kolumnie caddress</param>
        public void dodajWiersz(string name, string sname, string tn, string a)
        {
            string q;
            q = "INSERT INTO " + tableName + " (name,surname,telephonenumber,caddress) VALUES ('" +
                    name + "','" +
                    sname + "','" +
                    tn + "','" +
                    a + "');";

            SqlCommand com = new SqlCommand(q);
            com.Connection = polaczenie;
            com.ExecuteNonQuery();
        }

        /// <summary>
        /// Aktualizuje w bazie danych zmienione przez użytkownica komórki
        /// </summary>
        /// <param name="colname">nazwa kolumny, w której ma być zmieniona wartość</param>
        /// <param name="newValue">nowa wartość</param>
        /// <param name="id">id zmienianego wpisu</param>
        public void updateData(string colname, string newValue, string id)
        {
            string q;
            q = "UPDATE " + tableName + " set " + colname + " = '" + newValue + "' WHERE id =" +id;

            SqlCommand com = new SqlCommand(q);
            com.Connection = polaczenie;
            com.ExecuteNonQuery();
        }

        /// <summary>
        /// zamyka połączenie z bazą
        /// </summary>
        public void closeConnection()
        {
            polaczenie.Close();
        }
    }

}
