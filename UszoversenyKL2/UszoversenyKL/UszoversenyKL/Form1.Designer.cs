namespace UszoversenyKL
{
    partial class EredmenyForm
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
            this.lblCim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoEredmeny = new System.Windows.Forms.TextBox();
            this.btnResztvevoOrszagok = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.rendezSzempont = new System.Windows.Forms.GroupBox();
            this.eredmenySzerint = new System.Windows.Forms.RadioButton();
            this.nevSorSzerint = new System.Windows.Forms.RadioButton();
            this.rendezSzempont.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCim
            // 
            this.lblCim.AutoSize = true;
            this.lblCim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCim.ForeColor = System.Drawing.Color.Red;
            this.lblCim.Location = new System.Drawing.Point(130, 9);
            this.lblCim.Name = "lblCim";
            this.lblCim.Size = new System.Drawing.Size(0, 24);
            this.lblCim.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(68, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résztvevők:";
            // 
            // lstVersenyzok
            // 
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(29, 81);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(173, 355);
            this.lstVersenyzok.Sorted = true;
            this.lstVersenyzok.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(217, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(217, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(217, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Időeredmény:";
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Location = new System.Drawing.Point(329, 81);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.Size = new System.Drawing.Size(100, 20);
            this.txtRajtszam.TabIndex = 7;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(329, 110);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 8;
            // 
            // txtIdoEredmeny
            // 
            this.txtIdoEredmeny.Location = new System.Drawing.Point(329, 142);
            this.txtIdoEredmeny.Name = "txtIdoEredmeny";
            this.txtIdoEredmeny.Size = new System.Drawing.Size(100, 20);
            this.txtIdoEredmeny.TabIndex = 9;
            // 
            // btnResztvevoOrszagok
            // 
            this.btnResztvevoOrszagok.Location = new System.Drawing.Point(58, 460);
            this.btnResztvevoOrszagok.Name = "btnResztvevoOrszagok";
            this.btnResztvevoOrszagok.Size = new System.Drawing.Size(116, 23);
            this.btnResztvevoOrszagok.TabIndex = 14;
            this.btnResztvevoOrszagok.Text = "Résztvevő országok";
            this.btnResztvevoOrszagok.UseVisualStyleBackColor = true;
            this.btnResztvevoOrszagok.Click += new System.EventHandler(this.btnResztvevoOrszagok_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(283, 460);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(116, 23);
            this.btnBezar.TabIndex = 15;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            // 
            // rendezSzempont
            // 
            this.rendezSzempont.Controls.Add(this.eredmenySzerint);
            this.rendezSzempont.Controls.Add(this.nevSorSzerint);
            this.rendezSzempont.Location = new System.Drawing.Point(221, 370);
            this.rendezSzempont.Name = "rendezSzempont";
            this.rendezSzempont.Size = new System.Drawing.Size(231, 66);
            this.rendezSzempont.TabIndex = 16;
            this.rendezSzempont.TabStop = false;
            this.rendezSzempont.Text = "Rendezési szempont:";
            // 
            // eredmenySzerint
            // 
            this.eredmenySzerint.AutoSize = true;
            this.eredmenySzerint.Location = new System.Drawing.Point(23, 42);
            this.eredmenySzerint.Name = "eredmenySzerint";
            this.eredmenySzerint.Size = new System.Drawing.Size(105, 17);
            this.eredmenySzerint.TabIndex = 18;
            this.eredmenySzerint.TabStop = true;
            this.eredmenySzerint.Text = "Eredmény szerint";
            this.eredmenySzerint.UseVisualStyleBackColor = true;
            this.eredmenySzerint.CheckedChanged += new System.EventHandler(this.eredmenySzerint_CheckedChanged);
            // 
            // nevSorSzerint
            // 
            this.nevSorSzerint.AutoSize = true;
            this.nevSorSzerint.Location = new System.Drawing.Point(23, 19);
            this.nevSorSzerint.Name = "nevSorSzerint";
            this.nevSorSzerint.Size = new System.Drawing.Size(92, 17);
            this.nevSorSzerint.TabIndex = 17;
            this.nevSorSzerint.TabStop = true;
            this.nevSorSzerint.Text = "Névsor szerint";
            this.nevSorSzerint.UseVisualStyleBackColor = true;
            this.nevSorSzerint.CheckedChanged += new System.EventHandler(this.nevSorSzerint_CheckedChanged);
            // 
            // EredmenyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(475, 507);
            this.Controls.Add(this.rendezSzempont);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnResztvevoOrszagok);
            this.Controls.Add(this.txtIdoEredmeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCim);
            this.Name = "EredmenyForm";
            this.Text = "Eredmény";
            this.rendezSzempont.ResumeLayout(false);
            this.rendezSzempont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstVersenyzok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoEredmeny;
        private System.Windows.Forms.Button btnResztvevoOrszagok;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.GroupBox rendezSzempont;
        private System.Windows.Forms.RadioButton eredmenySzerint;
        private System.Windows.Forms.RadioButton nevSorSzerint;
    }
}

