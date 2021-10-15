
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Formss = new System.Windows.Forms.ToolStripMenuItem();
            this.NewForm = new System.Windows.Forms.ToolStripMenuItem();
            this.NewOkno = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteForm = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteOkno = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свернутьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разместитьВОкнеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Formss,
            this.упорядочитьToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Formss
            // 
            this.Formss.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewForm,
            this.DeleteForm});
            this.Formss.Name = "Formss";
            this.Formss.Size = new System.Drawing.Size(74, 24);
            this.Formss.Text = "Формы";
            this.Formss.Click += new System.EventHandler(this.Formss_Click);
            // 
            // NewForm
            // 
            this.NewForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewOkno});
            this.NewForm.Name = "NewForm";
            this.NewForm.Size = new System.Drawing.Size(224, 26);
            this.NewForm.Text = "Новое";
            // 
            // NewOkno
            // 
            this.NewOkno.Name = "NewOkno";
            this.NewOkno.Size = new System.Drawing.Size(128, 26);
            this.NewOkno.Text = "Окно";
            this.NewOkno.Click += new System.EventHandler(this.окноToolStripMenuItem_Click);
            // 
            // DeleteForm
            // 
            this.DeleteForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteOkno});
            this.DeleteForm.Name = "DeleteForm";
            this.DeleteForm.Size = new System.Drawing.Size(224, 26);
            this.DeleteForm.Text = "Закрыть";
            // 
            // DeleteOkno
            // 
            this.DeleteOkno.Name = "DeleteOkno";
            this.DeleteOkno.Size = new System.Drawing.Size(128, 26);
            this.DeleteOkno.Text = "Окно";
            // 
            // упорядочитьToolStripMenuItem
            // 
            this.упорядочитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.свернутьВсеToolStripMenuItem,
            this.разместитьВОкнеToolStripMenuItem});
            this.упорядочитьToolStripMenuItem.Name = "упорядочитьToolStripMenuItem";
            this.упорядочитьToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.упорядочитьToolStripMenuItem.Text = "Упорядочить";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // свернутьВсеToolStripMenuItem
            // 
            this.свернутьВсеToolStripMenuItem.Name = "свернутьВсеToolStripMenuItem";
            this.свернутьВсеToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.свернутьВсеToolStripMenuItem.Text = "Свернуть все";
            this.свернутьВсеToolStripMenuItem.Click += new System.EventHandler(this.свернутьВсеToolStripMenuItem_Click);
            // 
            // разместитьВОкнеToolStripMenuItem
            // 
            this.разместитьВОкнеToolStripMenuItem.Name = "разместитьВОкнеToolStripMenuItem";
            this.разместитьВОкнеToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.разместитьВОкнеToolStripMenuItem.Text = "Разместить в окне";
            this.разместитьВОкнеToolStripMenuItem.Click += new System.EventHandler(this.разместитьВОкнеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Главная форма";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Formss;
        private System.Windows.Forms.ToolStripMenuItem NewForm;
        private System.Windows.Forms.ToolStripMenuItem NewOkno;
        private System.Windows.Forms.ToolStripMenuItem DeleteForm;
        private System.Windows.Forms.ToolStripMenuItem DeleteOkno;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свернутьВсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разместитьВОкнеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}