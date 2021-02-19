using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BuscaCepXML
{
    public partial class Busca_Cep : Form
    {
        public Busca_Cep()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            txt_UF.ReadOnly = true;
        }

        private void Busca_Cep_Load(object sender, EventArgs e)
        {

        }

        private void btn_busca_click(object sender, EventArgs e)
        {
            try
            {
                //Cria um DataSet  baseado no retorno do XML 
                DataSet ds = new DataSet();
                string XML = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txt_cep.Text);

                ds.ReadXml(XML);

                txt_Logradouro.Text =  "Rua " + ds.Tables[0].Rows[0]["logradouro"].ToString();
                txt_bairro.Text = ds.Tables[0].Rows[0]["Bairro"].ToString();
                txt_cidade.Text = ds.Tables[0].Rows[0]["Cidade"].ToString();
                txt_UF.Text = ds.Tables[0].Rows[0]["UF"].ToString();

                if(txt_bairro.Text == "")
                {
                    
                    MessageBox.Show("CEP não encontrado!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
            catch (Exception)
            {
              

            }
        }

        private void btn_Limpar_click(object sender, EventArgs e)
        {

            txt_Logradouro.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_UF.Text = "";
            txt_cep.Text = "";

        }

        private void Github_click(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // abre um link externo no navegador do usuario
            System.Diagnostics.Process.Start("https://github.com/ViniciusLimaSilva");
        }

        private void txt_Logradouro_TextChanged(object sender, EventArgs e)
        {
            //bloquando o usuario de editar a textbox
            txt_Logradouro.ReadOnly = true;
        }

        private void txt_cidade_TextChanged(object sender, EventArgs e)
        {
            txt_cidade.ReadOnly = true;
        }

        private void txt_bairro_TextChanged(object sender, EventArgs e)
        {
            txt_bairro.ReadOnly = true;
        }

        private void txt_cep_TextChanged(object sender, EventArgs e)
        {

            //limitando quantida de caracter
            txt_cep.MaxLength = 9;

            //adicionar um hifen na posicao 5
            if(txt_cep.TextLength == 5)
            {
                txt_cep.SelectedText = "-";
            }
          
        }

        private void cep_keypress(object sender, KeyPressEventArgs e)
        {

            //apenas permite numeros no txtbox
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8){
                e.Handled = true;
            }
        }
    }
}
