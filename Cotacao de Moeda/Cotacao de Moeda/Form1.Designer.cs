namespace Cotacao_de_Moeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDolarCanadense = new System.Windows.Forms.RadioButton();
            this.rbIene = new System.Windows.Forms.RadioButton();
            this.rbEuro = new System.Windows.Forms.RadioButton();
            this.rbDolar = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnDolarCanadense = new System.Windows.Forms.RadioButton();
            this.rbnIene = new System.Windows.Forms.RadioButton();
            this.rbnEuro = new System.Windows.Forms.RadioButton();
            this.rbnDolar = new System.Windows.Forms.RadioButton();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDolarCanadense);
            this.groupBox1.Controls.Add(this.rbIene);
            this.groupBox1.Controls.Add(this.rbEuro);
            this.groupBox1.Controls.Add(this.rbDolar);
            this.groupBox1.Location = new System.Drawing.Point(24, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a Moeda desejada";
            // 
            // rbDolarCanadense
            // 
            this.rbDolarCanadense.AutoSize = true;
            this.rbDolarCanadense.Location = new System.Drawing.Point(7, 101);
            this.rbDolarCanadense.Name = "rbDolarCanadense";
            this.rbDolarCanadense.Size = new System.Drawing.Size(107, 17);
            this.rbDolarCanadense.TabIndex = 3;
            this.rbDolarCanadense.TabStop = true;
            this.rbDolarCanadense.Text = "Dolar Canadense";
            this.rbDolarCanadense.UseVisualStyleBackColor = true;
            this.rbDolarCanadense.CheckedChanged += new System.EventHandler(this.rbDolar_CheckedChanged);
            // 
            // rbIene
            // 
            this.rbIene.AutoSize = true;
            this.rbIene.Location = new System.Drawing.Point(7, 77);
            this.rbIene.Name = "rbIene";
            this.rbIene.Size = new System.Drawing.Size(46, 17);
            this.rbIene.TabIndex = 2;
            this.rbIene.TabStop = true;
            this.rbIene.Text = "Iene";
            this.rbIene.UseVisualStyleBackColor = true;
            this.rbIene.CheckedChanged += new System.EventHandler(this.rbDolar_CheckedChanged);
            // 
            // rbEuro
            // 
            this.rbEuro.AutoSize = true;
            this.rbEuro.Location = new System.Drawing.Point(7, 53);
            this.rbEuro.Name = "rbEuro";
            this.rbEuro.Size = new System.Drawing.Size(47, 17);
            this.rbEuro.TabIndex = 1;
            this.rbEuro.TabStop = true;
            this.rbEuro.Text = "Euro";
            this.rbEuro.UseVisualStyleBackColor = true;
            this.rbEuro.CheckedChanged += new System.EventHandler(this.rbDolar_CheckedChanged);
            // 
            // rbDolar
            // 
            this.rbDolar.AutoSize = true;
            this.rbDolar.Location = new System.Drawing.Point(7, 29);
            this.rbDolar.Name = "rbDolar";
            this.rbDolar.Size = new System.Drawing.Size(50, 17);
            this.rbDolar.TabIndex = 0;
            this.rbDolar.TabStop = true;
            this.rbDolar.Text = "Dolar";
            this.rbDolar.UseVisualStyleBackColor = true;
            this.rbDolar.CheckedChanged += new System.EventHandler(this.rbDolar_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnDolarCanadense);
            this.groupBox2.Controls.Add(this.rbnIene);
            this.groupBox2.Controls.Add(this.rbnEuro);
            this.groupBox2.Controls.Add(this.rbnDolar);
            this.groupBox2.Location = new System.Drawing.Point(278, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecione a moeda desejada";
            // 
            // rbnDolarCanadense
            // 
            this.rbnDolarCanadense.AutoSize = true;
            this.rbnDolarCanadense.Location = new System.Drawing.Point(7, 92);
            this.rbnDolarCanadense.Name = "rbnDolarCanadense";
            this.rbnDolarCanadense.Size = new System.Drawing.Size(107, 17);
            this.rbnDolarCanadense.TabIndex = 3;
            this.rbnDolarCanadense.TabStop = true;
            this.rbnDolarCanadense.Text = "Dolar Canadense";
            this.rbnDolarCanadense.UseVisualStyleBackColor = true;
            this.rbnDolarCanadense.CheckedChanged += new System.EventHandler(this.rbnDolar_CheckedChanged);
            // 
            // rbnIene
            // 
            this.rbnIene.AutoSize = true;
            this.rbnIene.Location = new System.Drawing.Point(7, 68);
            this.rbnIene.Name = "rbnIene";
            this.rbnIene.Size = new System.Drawing.Size(46, 17);
            this.rbnIene.TabIndex = 2;
            this.rbnIene.TabStop = true;
            this.rbnIene.Text = "Iene";
            this.rbnIene.UseVisualStyleBackColor = true;
            this.rbnIene.CheckedChanged += new System.EventHandler(this.rbnDolar_CheckedChanged);
            // 
            // rbnEuro
            // 
            this.rbnEuro.AutoSize = true;
            this.rbnEuro.Location = new System.Drawing.Point(7, 44);
            this.rbnEuro.Name = "rbnEuro";
            this.rbnEuro.Size = new System.Drawing.Size(47, 17);
            this.rbnEuro.TabIndex = 1;
            this.rbnEuro.TabStop = true;
            this.rbnEuro.Text = "Euro";
            this.rbnEuro.UseVisualStyleBackColor = true;
            this.rbnEuro.CheckedChanged += new System.EventHandler(this.rbnDolar_CheckedChanged);
            // 
            // rbnDolar
            // 
            this.rbnDolar.AutoSize = true;
            this.rbnDolar.Location = new System.Drawing.Point(7, 20);
            this.rbnDolar.Name = "rbnDolar";
            this.rbnDolar.Size = new System.Drawing.Size(50, 17);
            this.rbnDolar.TabIndex = 0;
            this.rbnDolar.TabStop = true;
            this.rbnDolar.Text = "Dolar";
            this.rbnDolar.UseVisualStyleBackColor = true;
            this.rbnDolar.CheckedChanged += new System.EventHandler(this.rbnDolar_CheckedChanged);
            // 
            // txtCompra
            // 
            this.txtCompra.Location = new System.Drawing.Point(24, 47);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(100, 20);
            this.txtCompra.TabIndex = 2;
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(278, 47);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(100, 20);
            this.txtVenda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cotação Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cotação Venda:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 291);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cotação de moeda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDolarCanadense;
        private System.Windows.Forms.RadioButton rbIene;
        private System.Windows.Forms.RadioButton rbEuro;
        private System.Windows.Forms.RadioButton rbDolar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnDolarCanadense;
        private System.Windows.Forms.RadioButton rbnIene;
        private System.Windows.Forms.RadioButton rbnEuro;
        private System.Windows.Forms.RadioButton rbnDolar;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

