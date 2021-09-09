using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho2.Control;

using Trabalho2.Model;


namespace Trabalho2.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PreencheTabela();
            Controller.LimpaHistorico();
            teste.Items.Clear();
            lblPontosP.Text = "0";
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            var sequencia = tbPalavraChave.Text.ToUpper();

            if (Controller.Verifica(sequencia))
            {
                teste.Items.Clear();
                foreach (var item in Controller.RetornaLista())
                {
                    teste.Items.Add(item);
                }
                lblPontosP.Text = Controller.RetornaPontosP(sequencia).ToString();
                lblPontosG.Text = Controller.RetornaPontosG().ToString();
            }
            else
            {
                
                MessageBox.Show("Deu errado!\r\nEssa sequência já foi utilizada");
            }
            tbPalavraChave.Clear();
        }

        private void PreencheTabela()
        {
            List<string> letras = Controller.PreencheTabela();
            tbA1.Text = letras[0];
            tbA2.Text = letras[1];
            tbA3.Text = letras[2];
            tbB1.Text = letras[3];
            tbB2.Text = letras[4];
            tbB3.Text = letras[5];
            tbC1.Text = letras[6];
            tbC2.Text = letras[7];
            tbC3.Text = letras[8];
        }
    }
}
