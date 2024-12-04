namespace TaşKağıtMakas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxPlayer = new PictureBox();
            pictureBoxComputer = new PictureBox();
            buttonTas = new Button();
            buttonKagit = new Button();
            buttonMakas = new Button();
            label1 = new Label();
            buttonBasla = new Button();
            label2 = new Label();
            labelPlayer = new Label();
            label4 = new Label();
            labelComputer = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputer).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.BackColor = Color.Transparent;
            pictureBoxPlayer.Location = new Point(129, 77);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(188, 194);
            pictureBoxPlayer.TabIndex = 0;
            pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxComputer
            // 
            pictureBoxComputer.BackColor = Color.Transparent;
            pictureBoxComputer.Location = new Point(490, 77);
            pictureBoxComputer.Name = "pictureBoxComputer";
            pictureBoxComputer.Size = new Size(188, 194);
            pictureBoxComputer.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxComputer.TabIndex = 1;
            pictureBoxComputer.TabStop = false;
            // 
            // buttonTas
            // 
            buttonTas.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTas.Location = new Point(129, 305);
            buttonTas.Name = "buttonTas";
            buttonTas.Size = new Size(188, 29);
            buttonTas.TabIndex = 2;
            buttonTas.Text = "Taş";
            buttonTas.UseVisualStyleBackColor = true;
            buttonTas.Click += buttonTas_Click;
            // 
            // buttonKagit
            // 
            buttonKagit.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKagit.Location = new Point(129, 340);
            buttonKagit.Name = "buttonKagit";
            buttonKagit.Size = new Size(188, 29);
            buttonKagit.TabIndex = 3;
            buttonKagit.Text = "Kağıt";
            buttonKagit.UseVisualStyleBackColor = true;
            buttonKagit.Click += buttonKagit_Click;
            // 
            // buttonMakas
            // 
            buttonMakas.Font = new Font("Modern No. 20", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMakas.Location = new Point(129, 375);
            buttonMakas.Name = "buttonMakas";
            buttonMakas.Size = new Size(188, 29);
            buttonMakas.TabIndex = 4;
            buttonMakas.Text = "Makas";
            buttonMakas.UseVisualStyleBackColor = true;
            buttonMakas.Click += buttonMakas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 24);
            label1.Name = "label1";
            label1.Size = new Size(232, 37);
            label1.TabIndex = 5;
            label1.Text = "Bekleniyor...";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // buttonBasla
            // 
            buttonBasla.Font = new Font("Snap ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBasla.Location = new Point(344, 223);
            buttonBasla.Name = "buttonBasla";
            buttonBasla.Size = new Size(117, 48);
            buttonBasla.TabIndex = 6;
            buttonBasla.Text = "T-K-M";
            buttonBasla.UseVisualStyleBackColor = true;
            buttonBasla.Click += buttonBasla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(141, 34);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 8;
            label2.Text = "SKOR :";
            // 
            // labelPlayer
            // 
            labelPlayer.AutoSize = true;
            labelPlayer.BackColor = Color.Transparent;
            labelPlayer.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayer.Location = new Point(243, 33);
            labelPlayer.Name = "labelPlayer";
            labelPlayer.Size = new Size(26, 27);
            labelPlayer.TabIndex = 9;
            labelPlayer.Text = "0";
            labelPlayer.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(520, 34);
            label4.Name = "label4";
            label4.Size = new Size(96, 27);
            label4.TabIndex = 10;
            label4.Text = "SKOR :";
            label4.Click += label4_Click;
            // 
            // labelComputer
            // 
            labelComputer.AutoSize = true;
            labelComputer.BackColor = Color.Transparent;
            labelComputer.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComputer.Location = new Point(622, 34);
            labelComputer.Name = "labelComputer";
            labelComputer.Size = new Size(26, 27);
            labelComputer.TabIndex = 11;
            labelComputer.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(labelComputer);
            Controls.Add(label4);
            Controls.Add(labelPlayer);
            Controls.Add(label2);
            Controls.Add(buttonBasla);
            Controls.Add(label1);
            Controls.Add(buttonMakas);
            Controls.Add(buttonKagit);
            Controls.Add(buttonTas);
            Controls.Add(pictureBoxComputer);
            Controls.Add(pictureBoxPlayer);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxComputer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPlayer;
        private PictureBox pictureBoxComputer;
        private Button buttonTas;
        private Button buttonKagit;
        private Button buttonMakas;
        private Label label1;
        private Button buttonBasla;
        private Label label2;
        private Label labelPlayer;
        private Label label4;
        private Label labelComputer;
    }
}
