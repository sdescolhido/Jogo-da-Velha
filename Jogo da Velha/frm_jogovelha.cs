using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class frm_jogovelha : Form
    {

        string njogador1, njogador2, jogada;

        int cont = 0, pjogador1 = 0, pjogador2 = 0, empates = 0;

        public frm_jogovelha()
        {
            InitializeComponent();
        }       

        private void frm_jogovelha_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o jogo da velha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btiniciar_Click(object sender, EventArgs e)
        {
            if ((tbjogador1.Text != "") && (tbjogador2.Text != ""))
            {
                njogador1 = tbjogador1.Text;
                tbjogador1.Visible = false;
                lbjogador1.Text = njogador1 + " joga com ";

                njogador2 = tbjogador2.Text;
                tbjogador2.Visible = false;
                lbjogador2.Text = njogador2 + " joga com ";            

            if (rbx.Checked)
            {
                lbjogador1.Text = lbjogador1.Text + " X ";
            }
            else
            {
                lbjogador1.Text = lbjogador1.Text + " O ";
            }

            if (rbx.Checked)
            {
                lbjogador2.Text = lbjogador2.Text + " O ";
            }
            else
            {
                lbjogador2.Text = lbjogador2.Text + " X ";
            }

            gbopcoes.Enabled = false;
            pnlcorpo.Enabled = true;

            lbpjogador1.Text = "0 - Vitórias";
            lbpjogador2.Text = "0 - Vitórias";

            btiniciar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Informe os nomes dos jogadores!!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btreiniciar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt11_Click(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt11.Text = jogada;
                bt11.Enabled = false;

            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt11.Text = jogada;
                bt11.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt12_Click(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt12.Text = jogada;
                bt12.Enabled = false;
            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt12.Text = jogada;
                bt12.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt13_Click(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt13.Text = jogada;
                bt13.Enabled = false;
            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt13.Text = jogada;
                bt13.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt21_Click_1(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt21.Text = jogada;
                bt21.Enabled = false;
            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt21.Text = jogada;
                bt21.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt22_Click(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt22.Text = jogada;
                bt22.Enabled = false;
            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt22.Text = jogada;
                bt22.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt23_Click(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt23.Text = jogada;
                bt23.Enabled = false;
            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt23.Text = jogada;
                bt23.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt31_Click_1(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt31.Text = jogada;
                bt31.Enabled = false;
            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt31.Text = jogada;
                bt31.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt32_Click_1(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt32.Text = jogada;
                bt32.Enabled = false;
            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt32.Text = jogada;
                bt32.Enabled = false;
            }
            cont++;
            vencedor();
        }

        private void bt33_Click_1(object sender, EventArgs e)
        {
            if (rbx.Checked)
            {
                jogada = rbx.Text;
                rbo.Checked = true;
                bt33.Text = jogada;
                bt33.Enabled = false;
            }
            else
            {
                jogada = rbo.Text;
                rbx.Checked = true;
                bt33.Text = jogada;
                bt33.Enabled = false;
            }
            cont++;
            vencedor();
        }

        public void vencedor()
        {
            if(
                    (bt11.Text == "X") && (bt12.Text == "X") && (bt13.Text == "X") ||
                    (bt21.Text == "X") && (bt22.Text == "X") && (bt23.Text == "X") ||
                    (bt31.Text == "X") && (bt32.Text == "X") && (bt33.Text == "X") ||

                    (bt11.Text == "X") && (bt21.Text == "X") && (bt31.Text == "X") ||
                    (bt12.Text == "X") && (bt22.Text == "X") && (bt32.Text == "X") ||
                    (bt13.Text == "X") && (bt23.Text == "X") && (bt33.Text == "X") ||

                    (bt11.Text == "X") && (bt22.Text == "X") && (bt33.Text == "X") ||
                    (bt13.Text == "X") && (bt22.Text == "X") && (bt31.Text == "X")                    
               )
            {
                MessageBox.Show("GANHOU", "FIM");
                limpar();
                habilitarBotoes();

                    pjogador1 = pjogador1 + 1;
                    lbpjogador1.Text = pjogador1.ToString() + " - Vitória(s)";
                    cont = 0;            
            }

            else if(
                    (bt11.Text == "O") && (bt12.Text == "O") && (bt13.Text == "O") ||
                    (bt21.Text == "O") && (bt22.Text == "O") && (bt23.Text == "O") ||
                    (bt31.Text == "O") && (bt32.Text == "O") && (bt33.Text == "O") ||

                    (bt11.Text == "O") && (bt21.Text == "O") && (bt31.Text == "O") ||
                    (bt12.Text == "O") && (bt22.Text == "O") && (bt32.Text == "O") ||
                    (bt13.Text == "O") && (bt23.Text == "O") && (bt33.Text == "O") ||

                    (bt11.Text == "O") && (bt22.Text == "O") && (bt33.Text == "O") ||
                    (bt13.Text == "O") && (bt22.Text == "O") && (bt31.Text == "O")
                   )
            {
                MessageBox.Show("GANHOU", "FIM");
                limpar();
                habilitarBotoes();

                    pjogador2 = pjogador2 + 1;
                    lbpjogador2.Text = pjogador2.ToString() + " - Vitória(s)";
                    cont = 0;           
            }

            if (cont == 9)
            {
                empates = empates + 1;
                lbempate.Text = empates.ToString() + " - Empate(s)";
                MessageBox.Show("EMPATOU", "FIM");
                cont = 0;
                limpar();
                habilitarBotoes();
            }

        }

        public void limpar()
        {
            bt11.Text = "";
            bt12.Text = "";
            bt13.Text = "";
            bt21.Text = "";
            bt22.Text = "";
            bt23.Text = "";
            bt31.Text = "";
            bt32.Text = "";
            bt33.Text = "";
            pnlcorpo.Enabled = true;
            habilitarBotoes();
            cont = 0;
        }

        public void habilitarBotoes()
        {
            bt11.Enabled = true;
            bt12.Enabled = true;
            bt13.Enabled = true;
            bt21.Enabled = true;
            bt22.Enabled = true;
            bt23.Enabled = true;
            bt31.Enabled = true;
            bt32.Enabled = true;
            bt33.Enabled = true;            
        }



    }
}
 