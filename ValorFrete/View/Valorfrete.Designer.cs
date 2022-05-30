
namespace valorfrete.View
{
    partial class Valorfrete
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
            this.label1 = new System.Windows.Forms.Label();
            this.llbcli = new System.Windows.Forms.Label();
            this.lblval = new System.Windows.Forms.Label();
            this.lblfrete = new System.Windows.Forms.Label();
            this.lbluf = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.comboBoxuf = new System.Windows.Forms.ComboBox();
            this.textBoxcli = new System.Windows.Forms.TextBox();
            this.textBoxval = new System.Windows.Forms.TextBox();
            this.textBoxfrete = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(93, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo do frete";
            // 
            // llbcli
            // 
            this.llbcli.AutoSize = true;
            this.llbcli.Location = new System.Drawing.Point(25, 118);
            this.llbcli.Name = "llbcli";
            this.llbcli.Size = new System.Drawing.Size(53, 15);
            this.llbcli.TabIndex = 1;
            this.llbcli.Text = "Cliente : ";
            // 
            // lblval
            // 
            this.lblval.AutoSize = true;
            this.lblval.Location = new System.Drawing.Point(25, 173);
            this.lblval.Name = "lblval";
            this.lblval.Size = new System.Drawing.Size(39, 15);
            this.lblval.TabIndex = 2;
            this.lblval.Text = "Valor :";
            // 
            // lblfrete
            // 
            this.lblfrete.AutoSize = true;
            this.lblfrete.Location = new System.Drawing.Point(23, 228);
            this.lblfrete.Name = "lblfrete";
            this.lblfrete.Size = new System.Drawing.Size(55, 15);
            this.lblfrete.TabIndex = 3;
            this.lblfrete.Text = "% Frete : ";
            this.lblfrete.Click += new System.EventHandler(this.lblfrete_Click);
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(265, 173);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(27, 15);
            this.lbluf.TabIndex = 5;
            this.lbluf.Text = "UF :";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(275, 216);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(103, 38);
            this.btn.TabIndex = 6;
            this.btn.Text = "Calcular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // comboBoxuf
            // 
            this.comboBoxuf.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxuf.FormattingEnabled = true;
            this.comboBoxuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO\t ",
            "MA",
            "MT",
            "MS ",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.comboBoxuf.Location = new System.Drawing.Point(298, 170);
            this.comboBoxuf.Name = "comboBoxuf";
            this.comboBoxuf.Size = new System.Drawing.Size(80, 21);
            this.comboBoxuf.TabIndex = 7;
            this.comboBoxuf.Text = "Escolha";
            this.comboBoxuf.SelectedIndexChanged += new System.EventHandler(this.comboBoxuf_SelectedIndexChanged);
            // 
            // textBoxcli
            // 
            this.textBoxcli.Location = new System.Drawing.Point(84, 115);
            this.textBoxcli.Name = "textBoxcli";
            this.textBoxcli.Size = new System.Drawing.Size(294, 23);
            this.textBoxcli.TabIndex = 8;
            // 
            // textBoxval
            // 
            this.textBoxval.Location = new System.Drawing.Point(70, 170);
            this.textBoxval.Name = "textBoxval";
            this.textBoxval.Size = new System.Drawing.Size(166, 23);
            this.textBoxval.TabIndex = 9;
            // 
            // textBoxfrete
            // 
            this.textBoxfrete.Location = new System.Drawing.Point(84, 222);
            this.textBoxfrete.Name = "textBoxfrete";
            this.textBoxfrete.Size = new System.Drawing.Size(152, 23);
            this.textBoxfrete.TabIndex = 10;
            this.textBoxfrete.TextChanged += new System.EventHandler(this.textBoxfrete_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 274);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(355, 150);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Valorfrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBoxfrete);
            this.Controls.Add(this.textBoxval);
            this.Controls.Add(this.textBoxcli);
            this.Controls.Add(this.comboBoxuf);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lbluf);
            this.Controls.Add(this.lblfrete);
            this.Controls.Add(this.lblval);
            this.Controls.Add(this.llbcli);
            this.Controls.Add(this.label1);
            this.Name = "Valorfrete";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valorfrete";
            this.Load += new System.EventHandler(this.Valorfrete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label llbcli;
        private System.Windows.Forms.Label lblval;
        private System.Windows.Forms.Label lblfrete;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ComboBox comboBoxuf;
        private System.Windows.Forms.TextBox textBoxcli;
        private System.Windows.Forms.TextBox textBoxval;
        private System.Windows.Forms.TextBox textBoxfrete;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}