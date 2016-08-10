using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class frmCadastrar : Form
    {
        Conexao con = new Conexao();
        CodSQL codSql = new CodSQL();
            
        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            if (txtEndereco.Text == "")
            {
                MessageBox.Show("digite um endereço por favor");
            }
            else
            {
                string endereco = txtEndereco.Text;

                var JSONstring = "http://maps.googleapis.com/maps/api/geocode/json?address=" + endereco + "&sensor=false";
                var resultado = new System.Net.WebClient().DownloadString(JSONstring);
                GoogleGeoCodeResponse informacaoJSON = JsonConvert.DeserializeObject<GoogleGeoCodeResponse>(resultado);

                lblResultado.Text = informacaoJSON.results.First().formatted_address.ToString();
                lblLat.Text = informacaoJSON.results.First().geometry.location.lat.ToString();
                lblLong.Text = informacaoJSON.results.First().geometry.location.lng.ToString();
            
            }
            
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text == "---")
            {
                MessageBox.Show("faça a busca de um endereço por favor");
            }
            else
            {
                try
                {
                    con.conectarBD();
                    codSql.cadGeral(lblResultado.Text, lblLat.Text, lblLong.Text);
                    con.desconectarBD();
                    MessageBox.Show("cadastrado com sucesso!");
                }
                catch
                {
                    MessageBox.Show("erro ao cadastrar");

                }
                finally
                {
                    con.desconectarBD();
                }
            }
            
                
            



        }

        

        
    }
}
