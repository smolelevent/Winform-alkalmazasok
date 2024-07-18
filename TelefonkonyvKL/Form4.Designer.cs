namespace TelefonkonyvKL
{
    partial class TorlesForm
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
            this.txtTorol = new System.Windows.Forms.TextBox();
            this.btnTorol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adja meg a kontaktoknak a nevét:";
            // 
            // txtTorol
            // 
            this.txtTorol.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtTorol.ForeColor = System.Drawing.Color.White;
            this.txtTorol.Location = new System.Drawing.Point(26, 32);
            this.txtTorol.Name = "txtTorol";
            this.txtTorol.Size = new System.Drawing.Size(218, 20);
            this.txtTorol.TabIndex = 1;
            // 
            // btnTorol
            // 
            this.btnTorol.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTorol.ForeColor = System.Drawing.Color.White;
            this.btnTorol.Location = new System.Drawing.Point(284, 9);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(149, 43);
            this.btnTorol.TabIndex = 2;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = false;
            // 
            // TorlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(445, 69);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.txtTorol);
            this.Controls.Add(this.label1);
            this.Name = "TorlesForm";
            this.Text = "Törlés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTorol;
        private System.Windows.Forms.Button btnTorol;
    }
}