namespace AppPrimera
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btinicial = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ctclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctusua = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contadorSS = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.heit = new System.Windows.Forms.TextBox();
            this.sius = new System.Windows.Forms.TextBox();
            this.faren = new System.Windows.Forms.Label();
            this.cel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 280);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btinicial);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ctclave);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ctusua);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IMC";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btinicial
            // 
            this.btinicial.Location = new System.Drawing.Point(134, 119);
            this.btinicial.Name = "btinicial";
            this.btinicial.Size = new System.Drawing.Size(131, 35);
            this.btinicial.TabIndex = 9;
            this.btinicial.Text = "CALCULAR IMC";
            this.btinicial.UseVisualStyleBackColor = true;
            this.btinicial.Click += new System.EventHandler(this.btinicial_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inserte su altura (en Metros):";
            // 
            // ctclave
            // 
            this.ctclave.Location = new System.Drawing.Point(208, 77);
            this.ctclave.Name = "ctclave";
            this.ctclave.Size = new System.Drawing.Size(361, 22);
            this.ctclave.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inserte su peso (en Kg):";
            // 
            // ctusua
            // 
            this.ctusua.Location = new System.Drawing.Point(179, 19);
            this.ctusua.Name = "ctusua";
            this.ctusua.Size = new System.Drawing.Size(390, 22);
            this.ctusua.TabIndex = 5;
            this.ctusua.Text = "\r\n";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.contadorSS);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(652, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contadorSS
            // 
            this.contadorSS.AutoSize = true;
            this.contadorSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contadorSS.Location = new System.Drawing.Point(308, 86);
            this.contadorSS.Name = "contadorSS";
            this.contadorSS.Size = new System.Drawing.Size(35, 38);
            this.contadorSS.TabIndex = 0;
            this.contadorSS.Text = "0";
            this.contadorSS.Click += new System.EventHandler(this.label3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.heit);
            this.tabPage3.Controls.Add(this.sius);
            this.tabPage3.Controls.Add(this.faren);
            this.tabPage3.Controls.Add(this.cel);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(652, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Temperatura";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(237, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Vaciar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // heit
            // 
            this.heit.Location = new System.Drawing.Point(134, 94);
            this.heit.Name = "heit";
            this.heit.Size = new System.Drawing.Size(178, 22);
            this.heit.TabIndex = 3;
            // 
            // sius
            // 
            this.sius.Location = new System.Drawing.Point(134, 30);
            this.sius.Name = "sius";
            this.sius.Size = new System.Drawing.Size(178, 22);
            this.sius.TabIndex = 2;
            // 
            // faren
            // 
            this.faren.AutoSize = true;
            this.faren.Location = new System.Drawing.Point(35, 94);
            this.faren.Name = "faren";
            this.faren.Size = new System.Drawing.Size(70, 16);
            this.faren.TabIndex = 1;
            this.faren.Text = "Fahrenheit";
            // 
            // cel
            // 
            this.cel.AutoSize = true;
            this.cel.Location = new System.Drawing.Point(32, 30);
            this.cel.Name = "cel";
            this.cel.Size = new System.Drawing.Size(51, 16);
            this.cel.TabIndex = 0;
            this.cel.Text = "Celsius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 280);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btinicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctusua;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label contadorSS;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox heit;
        private System.Windows.Forms.TextBox sius;
        private System.Windows.Forms.Label faren;
        private System.Windows.Forms.Label cel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

