namespace Recicla_
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LblImage = new Label();
            TxtEmail = new TextBox();
            TxtSenha = new TextBox();
            BtnLogin = new Button();
            BtnCadastro = new Button();
            SuspendLayout();
            // 
            // LblImage
            // 
            LblImage.Image = (Image)resources.GetObject("LblImage.Image");
            LblImage.Location = new Point(12, 77);
            LblImage.Name = "LblImage";
            LblImage.Size = new Size(459, 447);
            LblImage.TabIndex = 0;
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = SystemColors.ControlLight;
            TxtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtEmail.ForeColor = Color.DimGray;
            TxtEmail.Location = new Point(477, 253);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(295, 29);
            TxtEmail.TabIndex = 1;
            TxtEmail.Text = "Email";
            TxtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtSenha
            // 
            TxtSenha.BackColor = SystemColors.ControlLight;
            TxtSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtSenha.ForeColor = Color.DimGray;
            TxtSenha.Location = new Point(477, 311);
            TxtSenha.Name = "TxtSenha";
            TxtSenha.Size = new Size(295, 29);
            TxtSenha.TabIndex = 2;
            TxtSenha.Text = "Senha";
            TxtSenha.TextAlign = HorizontalAlignment.Center;
            TxtSenha.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(513, 381);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(108, 35);
            BtnLogin.TabIndex = 3;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            // 
            // BtnCadastro
            // 
            BtnCadastro.Location = new Point(625, 381);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(108, 35);
            BtnCadastro.TabIndex = 4;
            BtnCadastro.Text = "Cadastre-se";
            BtnCadastro.UseVisualStyleBackColor = true;
            BtnCadastro.Click += BtnRegistro_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(BtnCadastro);
            Controls.Add(BtnLogin);
            Controls.Add(TxtSenha);
            Controls.Add(TxtEmail);
            Controls.Add(LblImage);
            MaximumSize = new Size(816, 657);
            MinimumSize = new Size(816, 657);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recicla+";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblImage;
        private TextBox TxtEmail;
        private TextBox TxtSenha;
        private Button BtnLogin;
        private Button BtnCadastro;
    }
}
