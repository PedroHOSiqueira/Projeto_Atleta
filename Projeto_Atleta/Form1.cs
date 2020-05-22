using ProjetoAtleta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Atleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Atleta obj = new Atleta();

        private void btn_enviar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Nome = txt_nome.Text;
                obj.Altura = Convert.ToDouble(txt_altura.Text);
                obj.Peso = Convert.ToDouble(txt_peso.Text);
                obj.Idade = Convert.ToInt32(txt_idade.Text);
                MessageBox.Show("Dados enviados com sucesso");

            }
            catch (FormatException erro)
            {
                MessageBox.Show("Erro\n" + erro.Message);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            lbl_imc.Text = "IMC: " + obj.CalcularIMC().ToString("0.00");
            lbl_dados.Text = obj.ImprimrirDados().ToString();
        }
    }
}

