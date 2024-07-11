namespace UszoversenyKL
{
    partial class VersenyForm
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
            this.tavValaszto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.uszasNemValaszto = new System.Windows.Forms.ComboBox();
            this.btnVerseny = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVersenyzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKovi = new System.Windows.Forms.Button();
            this.datumValaszto = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tavValaszto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Táv:";
            // 
            // tavValaszto
            // 
            this.tavValaszto.Location = new System.Drawing.Point(56, 9);
            this.tavValaszto.Name = "tavValaszto";
            this.tavValaszto.Size = new System.Drawing.Size(59, 20);
            this.tavValaszto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "m";
            // 
            // uszasNemValaszto
            // 
            this.uszasNemValaszto.FormattingEnabled = true;
            this.uszasNemValaszto.Location = new System.Drawing.Point(174, 8);
            this.uszasNemValaszto.Name = "uszasNemValaszto";
            this.uszasNemValaszto.Size = new System.Drawing.Size(121, 21);
            this.uszasNemValaszto.TabIndex = 0;
            // 
            // btnVerseny
            // 
            this.btnVerseny.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVerseny.Location = new System.Drawing.Point(317, 6);
            this.btnVerseny.Name = "btnVerseny";
            this.btnVerseny.Size = new System.Drawing.Size(75, 23);
            this.btnVerseny.TabIndex = 4;
            this.btnVerseny.Text = "Verseny";
            this.btnVerseny.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Versenyző:";
            // 
            // txtVersenyzo
            // 
            this.txtVersenyzo.Location = new System.Drawing.Point(124, 43);
            this.txtVersenyzo.Name = "txtVersenyzo";
            this.txtVersenyzo.ReadOnly = true;
            this.txtVersenyzo.Size = new System.Drawing.Size(191, 20);
            this.txtVersenyzo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Időeredmény:";
            // 
            // btnKovi
            // 
            this.btnKovi.Enabled = false;
            this.btnKovi.ForeColor = System.Drawing.Color.Black;
            this.btnKovi.Location = new System.Drawing.Point(317, 84);
            this.btnKovi.Name = "btnKovi";
            this.btnKovi.Size = new System.Drawing.Size(75, 23);
            this.btnKovi.TabIndex = 9;
            this.btnKovi.Text = "Következő";
            this.btnKovi.UseVisualStyleBackColor = true;
            this.btnKovi.Click += new System.EventHandler(this.btnKovi_Click);
            // 
            // datumValaszto
            // 
            this.datumValaszto.CustomFormat = "00:00:00";
            this.datumValaszto.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datumValaszto.Location = new System.Drawing.Point(124, 84);
            this.datumValaszto.Name = "datumValaszto";
            this.datumValaszto.ShowUpDown = true;
            this.datumValaszto.Size = new System.Drawing.Size(73, 20);
            this.datumValaszto.TabIndex = 0;
            this.datumValaszto.Value = new System.DateTime(2024, 7, 10, 0, 0, 0, 0);
            // 
            // VersenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(404, 122);
            this.Controls.Add(this.datumValaszto);
            this.Controls.Add(this.btnKovi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVersenyzo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerseny);
            this.Controls.Add(this.uszasNemValaszto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tavValaszto);
            this.Controls.Add(this.label1);
            this.Name = "VersenyForm";
            this.Text = "Verseny";
            ((System.ComponentModel.ISupportInitialize)(this.tavValaszto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tavValaszto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uszasNemValaszto;
        private System.Windows.Forms.Button btnVerseny;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVersenyzo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKovi;
        private System.Windows.Forms.DateTimePicker datumValaszto;
    }
}