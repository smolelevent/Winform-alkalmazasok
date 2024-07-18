namespace TelefonkonyvKL
{
    partial class MenuForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnListaz = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnKereses = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "**********ÜDVÖZLÖM A TELEFONKÖNYVBEN*************";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENÜ";
            // 
            // btnUj
            // 
            this.btnUj.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUj.ForeColor = System.Drawing.Color.White;
            this.btnUj.Location = new System.Drawing.Point(82, 79);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(89, 39);
            this.btnUj.TabIndex = 2;
            this.btnUj.Text = "Új Hozzáadása";
            this.btnUj.UseVisualStyleBackColor = false;
            this.btnUj.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // btnListaz
            // 
            this.btnListaz.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnListaz.ForeColor = System.Drawing.Color.White;
            this.btnListaz.Location = new System.Drawing.Point(177, 79);
            this.btnListaz.Name = "btnListaz";
            this.btnListaz.Size = new System.Drawing.Size(89, 39);
            this.btnListaz.TabIndex = 3;
            this.btnListaz.Text = "Listázás";
            this.btnListaz.UseVisualStyleBackColor = false;
            this.btnListaz.Click += new System.EventHandler(this.btnListaz_Click);
            // 
            // btnKilep
            // 
            this.btnKilep.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKilep.ForeColor = System.Drawing.Color.White;
            this.btnKilep.Location = new System.Drawing.Point(272, 124);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(89, 39);
            this.btnKilep.TabIndex = 4;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = false;
            this.btnKilep.Click += new System.EventHandler(this.btnKilep_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModosit.ForeColor = System.Drawing.Color.White;
            this.btnModosit.Location = new System.Drawing.Point(82, 124);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(89, 39);
            this.btnModosit.TabIndex = 5;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = false;
            // 
            // btnKereses
            // 
            this.btnKereses.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKereses.ForeColor = System.Drawing.Color.White;
            this.btnKereses.Location = new System.Drawing.Point(177, 124);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(89, 39);
            this.btnKereses.TabIndex = 6;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = false;
            // 
            // btnTorles
            // 
            this.btnTorles.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTorles.ForeColor = System.Drawing.Color.White;
            this.btnTorles.Location = new System.Drawing.Point(272, 79);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(89, 39);
            this.btnTorles.TabIndex = 7;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(445, 175);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnListaz);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuForm";
            this.Text = "Telefonkönyv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnListaz;
        private System.Windows.Forms.Button btnKilep;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Button btnTorles;
    }
}

