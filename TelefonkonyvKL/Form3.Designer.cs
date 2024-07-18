namespace TelefonkonyvKL
{
    partial class ListaForm
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
            this.Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.Color.DodgerBlue;
            this.Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lista.ForeColor = System.Drawing.Color.White;
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 20;
            this.Lista.Location = new System.Drawing.Point(98, 12);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(244, 424);
            this.Lista.TabIndex = 0;
            // 
            // ListaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.Lista);
            this.Name = "ListaForm";
            this.Text = "Listázás";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista;
    }
}