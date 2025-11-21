namespace Recicla_
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            BtnAtividade = new Button();
            BtnBeneficio = new Button();
            BtnEmblema = new Button();
            BtnPonto = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            LblImage = new Label();
            SuspendLayout();
            // 
            // BtnAtividade
            // 
            BtnAtividade.Location = new Point(636, 36);
            BtnAtividade.Name = "BtnAtividade";
            BtnAtividade.Size = new Size(124, 80);
            BtnAtividade.TabIndex = 0;
            BtnAtividade.Text = "Atividade";
            BtnAtividade.UseVisualStyleBackColor = true;
            BtnAtividade.Click += BtnAtividade_Click;
            // 
            // BtnBeneficio
            // 
            BtnBeneficio.Location = new Point(636, 174);
            BtnBeneficio.Name = "BtnBeneficio";
            BtnBeneficio.Size = new Size(124, 80);
            BtnBeneficio.TabIndex = 1;
            BtnBeneficio.Text = "Beneficio";
            BtnBeneficio.UseVisualStyleBackColor = true;
            // 
            // BtnEmblema
            // 
            BtnEmblema.Location = new Point(636, 326);
            BtnEmblema.Name = "BtnEmblema";
            BtnEmblema.Size = new Size(124, 80);
            BtnEmblema.TabIndex = 2;
            BtnEmblema.Text = "Emblema";
            BtnEmblema.UseVisualStyleBackColor = true;
            // 
            // BtnPonto
            // 
            BtnPonto.Location = new Point(636, 487);
            BtnPonto.Name = "BtnPonto";
            BtnPonto.Size = new Size(124, 80);
            BtnPonto.TabIndex = 3;
            BtnPonto.Text = "Pontos";
            BtnPonto.UseVisualStyleBackColor = true;
            BtnPonto.Click += BtnPonto_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(471, 37);
            label1.Name = "label1";
            label1.Size = new Size(139, 74);
            label1.TabIndex = 4;
            label1.Text = "Realize atividades por pontos";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(471, 174);
            label2.Name = "label2";
            label2.Size = new Size(125, 77);
            label2.TabIndex = 5;
            label2.Text = "Resgate seus Beneficios";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(471, 333);
            label3.Name = "label3";
            label3.Size = new Size(124, 62);
            label3.TabIndex = 6;
            label3.Text = "Resgate seus Emblemas";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(471, 499);
            label4.Name = "label4";
            label4.Size = new Size(124, 53);
            label4.TabIndex = 7;
            label4.Text = "Verifique seus Pontos";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblImage
            // 
            LblImage.Image = (Image)resources.GetObject("LblImage.Image");
            LblImage.Location = new Point(12, 233);
            LblImage.Name = "LblImage";
            LblImage.Size = new Size(371, 124);
            LblImage.TabIndex = 8;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 618);
            Controls.Add(LblImage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnPonto);
            Controls.Add(BtnEmblema);
            Controls.Add(BtnBeneficio);
            Controls.Add(BtnAtividade);
            MaximumSize = new Size(816, 657);
            MinimumSize = new Size(816, 657);
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "menu";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnAtividade;
        private Button BtnBeneficio;
        private Button BtnEmblema;
        private Button BtnPonto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label LblImage;
    }
}