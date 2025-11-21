namespace Recicla_
{
    partial class Atividade
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
            button1 = new Button();
            label1 = new Label();
            LblImage = new Label();
            linkVoltar = new LinkLabel();
            LblTexAtividade = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(235, 355);
            button1.Name = "button1";
            button1.Size = new Size(135, 59);
            button1.TabIndex = 1;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(235, 143);
            label1.Name = "label1";
            label1.Size = new Size(532, 188);
            label1.TabIndex = 2;
            label1.Text = "Pequenos gestos geram grandes impactos! Recicle 1.000 tampinhas e ajude a transformar resíduos em esperança. Você ainda recebe 1.000 pontos pela sua boa ação!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblImage
            // 
            LblImage.Image = Properties.Resources.atividade1;
            LblImage.Location = new Point(12, 143);
            LblImage.Name = "LblImage";
            LblImage.Size = new Size(217, 271);
            LblImage.TabIndex = 9;
            // 
            // linkVoltar
            // 
            linkVoltar.AutoSize = true;
            linkVoltar.Location = new Point(707, 571);
            linkVoltar.Name = "linkVoltar";
            linkVoltar.Size = new Size(37, 15);
            linkVoltar.TabIndex = 10;
            linkVoltar.TabStop = true;
            linkVoltar.Text = "Voltar";
            linkVoltar.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LblTexAtividade
            // 
            LblTexAtividade.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblTexAtividade.Location = new Point(185, 9);
            LblTexAtividade.Name = "LblTexAtividade";
            LblTexAtividade.Size = new Size(432, 47);
            LblTexAtividade.TabIndex = 11;
            LblTexAtividade.Text = "Atividade do Mês por Tampinhas do Bem";
            LblTexAtividade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Atividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(LblTexAtividade);
            Controls.Add(linkVoltar);
            Controls.Add(LblImage);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximumSize = new Size(816, 657);
            MinimumSize = new Size(816, 657);
            Name = "Atividade";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atividade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label LblImage;
        private LinkLabel linkVoltar;
        private Label LblTexAtividade;
    }
}