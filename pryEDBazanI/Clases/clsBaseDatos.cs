using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace pryEDBazanI.Clases
{
     class clsBaseDatos
    {
        private OleDbConnection conexion= new OleDbConnection();
        private OleDbCommand comando= new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaDeConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= Libreria.mdb";
        private string CadenaDeConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Libreria.mdb";

        public void Listar(string tabla, DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaDeConexion;   
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;
                
                DataSet ds = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(ds, tabla);

                Grilla.DataSource = null;
                Grilla.DataSource =ds.Tables[tabla];

                conexion.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message); 
                conexion.Close() ;
            }
        }
        
    }
}
