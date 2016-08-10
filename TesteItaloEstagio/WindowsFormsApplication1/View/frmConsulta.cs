using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmConsulta : Form
    {
        CodSQL codSql = new CodSQL();
        Conexao con = new Conexao();
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            ds = codSql.consultarGeral(txtCod.Text);
            dgvResultados.DataSource = ds.Tables[0];
            
        }

        private void btnBuscarTudo_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = codSql.consultarGeral();
            dgvResultados.DataSource = ds.Tables[0];
        }

        

        

        
    }
}
