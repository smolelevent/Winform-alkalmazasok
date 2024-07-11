namespace UszoversenyKL
{
    partial class InditoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InditoForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versenyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eredmenyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nevjegyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.versenyMenuItem,
            this.eredmenyMenuItem,
            this.nevjegyMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitasMenuItem,
            this.mentesMenuItem,
            this.kilepesMenuItem});
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // megnyitasMenuItem
            // 
            this.megnyitasMenuItem.Name = "megnyitasMenuItem";
            this.megnyitasMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megnyitasMenuItem.Text = "Megnyitás";
            // 
            // mentesMenuItem
            // 
            this.mentesMenuItem.Name = "mentesMenuItem";
            this.mentesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mentesMenuItem.Text = "Mentés";
            this.mentesMenuItem.Click += new System.EventHandler(this.mentesMenuItem_Click);
            // 
            // kilepesMenuItem
            // 
            this.kilepesMenuItem.Name = "kilepesMenuItem";
            this.kilepesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kilepesMenuItem.Text = "Kilépés";
            // 
            // versenyMenuItem
            // 
            this.versenyMenuItem.Enabled = false;
            this.versenyMenuItem.Name = "versenyMenuItem";
            this.versenyMenuItem.Size = new System.Drawing.Size(59, 20);
            this.versenyMenuItem.Text = "Verseny";
            // 
            // eredmenyMenuItem
            // 
            this.eredmenyMenuItem.Enabled = false;
            this.eredmenyMenuItem.Name = "eredmenyMenuItem";
            this.eredmenyMenuItem.Size = new System.Drawing.Size(72, 20);
            this.eredmenyMenuItem.Text = "Eredmény";
            // 
            // nevjegyMenuItem
            // 
            this.nevjegyMenuItem.Name = "nevjegyMenuItem";
            this.nevjegyMenuItem.Size = new System.Drawing.Size(62, 20);
            this.nevjegyMenuItem.Text = "Névjegy";
            this.nevjegyMenuItem.Click += new System.EventHandler(this.nevjegyMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "versenyzok.txt";
            // 
            // InditoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "InditoForm";
            this.Text = "Úszóverseny";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versenyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eredmenyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nevjegyMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}