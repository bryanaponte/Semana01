using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace Semana01
{
    public partial class PjConexion3 : Form
    {
        public PjConexion3()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["bryan"].ConnectionString);

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void ListarProductos()
        {
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_ListaProductos_Neptuno", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataSet Da = new DataSet())
                {
                    df.Fill(Da, "Productos");
                    dgProductos.DataSource = Da.Tables["Productos"];
                    lblCantidad.Text = Da.Tables["Productos"].Rows.Count.ToString();
                }
            }
        }
        private void PjConexion3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'neptunoDataSet2.productos' Puede moverla o quitarla según sea necesario.
            ListarProductos();

        }
    }
}
