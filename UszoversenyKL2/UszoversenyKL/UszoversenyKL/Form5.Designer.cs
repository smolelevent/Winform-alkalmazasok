﻿namespace UszoversenyKL
{
    partial class NevjegyForm
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
            this.txtNevjegy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNevjegy
            // 
            this.txtNevjegy.Location = new System.Drawing.Point(144, 39);
            this.txtNevjegy.Name = "txtNevjegy";
            this.txtNevjegy.ReadOnly = true;
            this.txtNevjegy.Size = new System.Drawing.Size(100, 20);
            this.txtNevjegy.TabIndex = 0;
            // 
            // NevjegyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 102);
            this.Controls.Add(this.txtNevjegy);
            this.Name = "NevjegyForm";
            this.Text = "Súgó";
            this.Load += new System.EventHandler(this.NevjegyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNevjegy;
    }
}