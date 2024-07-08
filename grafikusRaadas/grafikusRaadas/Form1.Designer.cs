namespace grafikusRaadas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtTmPckrDatum = new System.Windows.Forms.DateTimePicker();
            this.dtTmPckrIdo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTalalkozo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAktualis = new System.Windows.Forms.Label();
            this.lblErtekeles = new System.Windows.Forms.Label();
            this.btnErtekel = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtTmPckrIdo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A találkozó ideje:";
            // 
            // dtTmPckrDatum
            // 
            this.dtTmPckrDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTmPckrDatum.Location = new System.Drawing.Point(32, 32);
            this.dtTmPckrDatum.Name = "dtTmPckrDatum";
            this.dtTmPckrDatum.Size = new System.Drawing.Size(128, 20);
            this.dtTmPckrDatum.TabIndex = 1;
            // 
            // dtTmPckrIdo
            // 
            this.dtTmPckrIdo.Location = new System.Drawing.Point(195, 32);
            this.dtTmPckrIdo.Name = "dtTmPckrIdo";
            this.dtTmPckrIdo.Size = new System.Drawing.Size(120, 20);
            this.dtTmPckrIdo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "A találkozó ideje:";
            // 
            // lblTalalkozo
            // 
            this.lblTalalkozo.AutoSize = true;
            this.lblTalalkozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTalalkozo.Location = new System.Drawing.Point(146, 78);
            this.lblTalalkozo.Name = "lblTalalkozo";
            this.lblTalalkozo.Size = new System.Drawing.Size(0, 20);
            this.lblTalalkozo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Aktuális idő:";
            // 
            // lblAktualis
            // 
            this.lblAktualis.AutoSize = true;
            this.lblAktualis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAktualis.Location = new System.Drawing.Point(146, 109);
            this.lblAktualis.Name = "lblAktualis";
            this.lblAktualis.Size = new System.Drawing.Size(0, 20);
            this.lblAktualis.TabIndex = 6;
            // 
            // lblErtekeles
            // 
            this.lblErtekeles.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErtekeles.ForeColor = System.Drawing.Color.Red;
            this.lblErtekeles.Location = new System.Drawing.Point(-11, 145);
            this.lblErtekeles.Name = "lblErtekeles";
            this.lblErtekeles.Size = new System.Drawing.Size(368, 20);
            this.lblErtekeles.TabIndex = 7;
            this.lblErtekeles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnErtekel
            // 
            this.btnErtekel.Location = new System.Drawing.Point(16, 186);
            this.btnErtekel.Name = "btnErtekel";
            this.btnErtekel.Size = new System.Drawing.Size(96, 42);
            this.btnErtekel.TabIndex = 8;
            this.btnErtekel.Text = "Értékel";
            this.btnErtekel.UseVisualStyleBackColor = true;
            this.btnErtekel.Click += new System.EventHandler(this.btnErtekel_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(219, 186);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(96, 42);
            this.btnTorol.TabIndex = 9;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(118, 260);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(96, 42);
            this.btnBezar.TabIndex = 10;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 312);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnErtekel);
            this.Controls.Add(this.lblErtekeles);
            this.Controls.Add(this.lblAktualis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTalalkozo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTmPckrIdo);
            this.Controls.Add(this.dtTmPckrDatum);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTmPckrIdo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTmPckrDatum;
        private System.Windows.Forms.NumericUpDown dtTmPckrIdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTalalkozo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAktualis;
        private System.Windows.Forms.Label lblErtekeles;
        private System.Windows.Forms.Button btnErtekel;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezar;
    }
}

