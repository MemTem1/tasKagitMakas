using System.Drawing.Printing;

namespace TaşKağıtMakas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int random, secilensayi = 0, computerScore = 0, playerScore = 0;

        private void kazandinizYazisi()
        {
            label1.Text = "KAZANDINIZ";
            label1.ForeColor = Color.Green;
            playerScore += 1;
            labelPlayer.Text = playerScore.ToString();
            if (playerScore == 3)
            {
                DialogResult yenidenBaslasınmı = MessageBox.Show("Kazandınız Yeniden Başlamak İster misiniz?", "TEBRİKLER", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (yenidenBaslasınmı == DialogResult.Yes)
                {
                    pictureBoxComputer.Image = null;
                    pictureBoxPlayer.Image = null;
                    computerScore = 0;
                    playerScore = 0;
                    labelPlayer.Text = "0";
                    labelComputer.Text = "0";
                    label1.Text = "";
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private void berabereYazisi()
        {
            label1.Text = "BERABERE";
            label1.ForeColor = Color.Black;
        }
        private void kaybettinizYazisi()
        {
            label1.Text = "KAYBETTİNİZ";
            label1.ForeColor = Color.Red;
            computerScore += 1;
            labelComputer.Text = computerScore.ToString();
            if (computerScore == 3)
            {
                DialogResult yenidenBaslasınmı = MessageBox.Show("Kaybettiniz Yeniden Başlamak İster misiniz?", "TEBRİKLER", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (yenidenBaslasınmı == DialogResult.Yes)
                {
                    pictureBoxComputer.Image = null;
                    pictureBoxPlayer.Image = null;
                    computerScore = 0;
                    playerScore = 0;
                    labelPlayer.Text = "0";
                    labelComputer.Text = "0";
                    label1.Text = "";
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void buttonTas_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer.Image = Properties.Resources.Tas;
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            secilensayi = 2;
        }


        private void buttonKagit_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer.Image = Properties.Resources.Kagit;
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            secilensayi = 1;
        }

        private void buttonMakas_Click(object sender, EventArgs e)
        {
            pictureBoxPlayer.Image = Properties.Resources.Makas;
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            secilensayi = 3;
        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            random = rnd.Next(0, 4);

            switch (random)
            {
                case 1:
                    pictureBoxComputer.Image = Properties.Resources.Kagit;
                    break;
                case 2:
                    pictureBoxComputer.Image = Properties.Resources.Tas;
                    break;
                case 3:
                    pictureBoxComputer.Image = Properties.Resources.Makas;
                    break;
                default:
                    break;
            }



            if (pictureBoxPlayer.Image == null)
            {
                MessageBox.Show("Lütfen Seçim Yapın");
            }
            else if (secilensayi == random)
            {

                berabereYazisi();
            }
            else if (secilensayi == 1 && random == 3)
            {
                kaybettinizYazisi();
            }
            else if (secilensayi == 1 && random == 2)
            {
                kazandinizYazisi();
            }
            else if (secilensayi == 2 && random == 1)
            {
                kaybettinizYazisi();
            }
            else if (secilensayi == 2 && random == 3)
            {
                kazandinizYazisi();
            }
            else if (secilensayi == 3 && random == 2)
            {
                kaybettinizYazisi();
            }
            else if (secilensayi == 3 && random == 1)
            {
                kazandinizYazisi();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
