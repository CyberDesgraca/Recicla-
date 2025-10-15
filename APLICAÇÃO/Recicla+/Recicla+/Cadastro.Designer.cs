namespace Recicla_
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            BtnVoltar = new Button();
            BtnEnviarCadastro = new Button();
            TxtSenhaCadastro = new TextBox();
            TxtEmailCadastro = new TextBox();
            LblImage2 = new Label();
            TxtNomeCadastro = new TextBox();
            SuspendLayout();
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(625, 381);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(108, 35);
            BtnVoltar.TabIndex = 9;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnEnviarCadastro
            // 
            BtnEnviarCadastro.Location = new Point(513, 381);
            BtnEnviarCadastro.Name = "BtnEnviarCadastro";
            BtnEnviarCadastro.Size = new Size(108, 35);
            BtnEnviarCadastro.TabIndex = 8;
            BtnEnviarCadastro.Text = "Enviar";
            BtnEnviarCadastro.UseVisualStyleBackColor = true;
            BtnEnviarCadastro.Click += BtnEnviarCadastro_Click;
            // 
            // TxtSenhaCadastro
            // 
            TxtSenhaCadastro.BackColor = SystemColors.ControlLight;
            TxtSenhaCadastro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtSenhaCadastro.ForeColor = Color.DimGray;
            TxtSenhaCadastro.Location = new Point(485, 320);
            TxtSenhaCadastro.Name = "TxtSenhaCadastro";
            TxtSenhaCadastro.Size = new Size(295, 29);
            TxtSenhaCadastro.TabIndex = 7;
            TxtSenhaCadastro.Text = "Senha";
            TxtSenhaCadastro.TextAlign = HorizontalAlignment.Center;
            TxtSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // TxtEmailCadastro
            // 
            TxtEmailCadastro.BackColor = SystemColors.ControlLight;
            TxtEmailCadastro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtEmailCadastro.ForeColor = Color.DimGray;
            TxtEmailCadastro.Location = new Point(485, 262);
            TxtEmailCadastro.Name = "TxtEmailCadastro";
            TxtEmailCadastro.Size = new Size(295, 29);
            TxtEmailCadastro.TabIndex = 6;
            TxtEmailCadastro.Text = "Email";
            TxtEmailCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // LblImage2
            // 
            LblImage2.Image = (Image)resources.GetObject("LblImage2.Image");
            LblImage2.Location = new Point(20, 86);
            LblImage2.Name = "LblImage2";
            LblImage2.Size = new Size(459, 447);
            LblImage2.TabIndex = 5;
            // 
            // TxtNomeCadastro
            // 
            TxtNomeCadastro.BackColor = SystemColors.ControlLight;
            TxtNomeCadastro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtNomeCadastro.ForeColor = Color.DimGray;
            TxtNomeCadastro.Location = new Point(485, 201);
            TxtNomeCadastro.Name = "TxtNomeCadastro";
            TxtNomeCadastro.Size = new Size(295, 29);
            TxtNomeCadastro.TabIndex = 10;
            TxtNomeCadastro.Text = "Nome";
            TxtNomeCadastro.TextAlign = HorizontalAlignment.Center;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(TxtNomeCadastro);
            Controls.Add(BtnVoltar);
            Controls.Add(BtnEnviarCadastro);
            Controls.Add(TxtSenhaCadastro);
            Controls.Add(TxtEmailCadastro);
            Controls.Add(LblImage2);
            MaximumSize = new Size(816, 657);
            MinimumSize = new Size(816, 657);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recicla+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnVoltar;
        private Button BtnEnviarCadastro;
        private TextBox TxtSenhaCadastro;
        private TextBox TxtEmailCadastro;
        private Label LblImage2;
        private TextBox TxtNomeCadastro;
    }
}