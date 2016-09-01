namespace _01_cs
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
            this.dtIni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.btnGerar = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtIni
            // 
            this.dtIni.Location = new System.Drawing.Point(100, 8);
            this.dtIni.Name = "dtIni";
            this.dtIni.Size = new System.Drawing.Size(287, 22);
            this.dtIni.TabIndex = 0;
            this.dtIni.Value = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.dtIni.ValueChanged += new System.EventHandler(this.dtIni_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final:";
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(100, 65);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(287, 22);
            this.dtFim.TabIndex = 3;
            this.dtFim.Value = new System.DateTime(2008, 4, 1, 0, 0, 0, 0);
            this.dtFim.ValueChanged += new System.EventHandler(this.dtFim_ValueChanged);
            // 
            // btnGerar
            // 
            this.btnGerar.Enabled = false;
            this.btnGerar.Location = new System.Drawing.Point(423, 8);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(112, 79);
            this.btnGerar.TabIndex = 4;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(13, 104);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            this.lblMsg.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 133);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtIni);
            this.Name = "Form1";
            this.Text = "Relatório Contábil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Label lblMsg;
    }
}

