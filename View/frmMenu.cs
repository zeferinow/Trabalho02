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
            tbPalavraChave.MaxLength = 9;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criadores:\r\nSara Letícia Faustino Machado" +
                            "\r\nGabriel Zeferino" +
                            "\r\nPaloma Souza Marian\r\n" +
                            "\r\nMuito obrigado por desfrutar do sistema,\r\n Volte sempre!!!");
            Application.Exit();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            PreencheTabela();
            Controller.LimpaHistorico();
            cbHistorico.Items.Clear();
            lblPontosP.Text = "0";
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            var palavraChave = tbPalavraChave.Text.ToUpper();

            if (string.IsNullOrEmpty(tbPalavraChave.Text))
            {
                MessageBox.Show("Favor inserir uma letra");
            }
            else if (Controller.Verifica(palavraChave))
            {
                cbHistorico.Items.Clear();
                foreach (var item in Controller.RetornaLista())
                {
                    cbHistorico.Items.Add(item);
                }
                lblPontosP.Text = Controller.RetornaPontosP(palavraChave).ToString();
                lblPontosG.Text = Controller.RetornaPontosG().ToString();
            }
            else
            {
                
                MessageBox.Show("Deu errado!\r\nEssa sequência já foi utilizada");
            }
            tbPalavraChave.Clear();
        }

        /// <summary>
        /// Preenche a tabelas com as letras sortiadas de acordo com as regras
        /// </summary>
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
