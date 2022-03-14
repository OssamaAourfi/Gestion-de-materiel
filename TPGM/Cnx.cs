using System.Data;
using System.Data.SqlClient;

namespace TPGM
{
    class Cnx
    {
        public static SqlConnection cnx = new SqlConnection() ;
        public static SqlCommand cmd = new SqlCommand();
        public static SqlDataReader dr;
        public static DataTable dt = new DataTable();
        public static DataSet ds = new DataSet();
        public static SqlDataAdapter da = new SqlDataAdapter();
        public static SqlCommandBuilder cmdb = new SqlCommandBuilder();


         public static void Connecter()
         {
             if(cnx.State==ConnectionState.Broken||cnx.State==ConnectionState.Closed)
             {
                 cnx.ConnectionString = @"Data Source=hpelitebook\SQLEXPRESS;Initial Catalog=TPPS;Integrated Security=True";
                 cnx.Open();

             }
         }
         public static void Deconnecter()
         {
             if( cnx.State==ConnectionState.Open)
             {
                 cnx.Close();
             }
         }
         public static void Afficher(string req)
         {
             cmd.Connection = cnx;
             cmd.CommandText = req;
             dr = cmd.ExecuteReader();
            //dt.Load(dr);
         }
         public static void MiseAjour(string req)
         {
             cmd.Connection = cnx;
             cmd.CommandText = req;
             cmd.ExecuteNonQuery();
         }
      /*  static public void Connect()
        {
            cnx = new SqlConnection(@"Data Source=AOURFI\SQLEXPRESS;Initial Catalog=TPPS;Integrated Security=True");
            cnx.Open();
        }
        static public void MSql(string ch, string tab)
        {
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            ds = new DataSet();
            dt = new DataTable();
            cmd.Connection = cnx;
            cmd.CommandText = ch;
            da.SelectCommand = cmd;
            da.Fill(ds, tab);
            dt = ds.Tables[tab];
            da.Dispose();
            cnx.Close();
        }
        static public void enregistrer()
        {
            da.SelectCommand = cmd;
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
        }*/

    }
}
