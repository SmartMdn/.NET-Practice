using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public List<int> indexes = new List<int>();
        public int i = 0, d = 0;
        bool flag = true;

        public Form2()
        {
            InitializeComponent();
        }



        private void окноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            i++;

            Form1 newMDIChild = new Form1();
            indexes.Add(i);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            newMDIChild.FormClosing += newMDIChild_Closed;
            ToolStripMenuItem fileItem = new ToolStripMenuItem(Convert.ToString(i));
            fileItem.Click += fileItem_Click;

            DeleteOkno.DropDownItems.Add(fileItem);
        }

        void fileItem_Click(object sender, EventArgs e)
        {
            d = int.Parse(Convert.ToString(sender));
            Form myform = Application.OpenForms[d];
            myform.Close();
            flag = true;

        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= DeleteOkno.DropDownItems.Count; i++)
            {
                Form myform = Application.OpenForms[i];
                myform.WindowState = FormWindowState.Normal;
            }
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void разместитьВОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= DeleteOkno.DropDownItems.Count; i++)
            {
                Form myform = Application.OpenForms[i];
                myform.WindowState = FormWindowState.Normal;
            }
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void свернутьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= DeleteOkno.DropDownItems.Count; i++)
            {
                Form myform = Application.OpenForms[i];
                myform.WindowState = FormWindowState.Minimized;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кол-во открытых форм=" + (Application.OpenForms.Count - 1).ToString());
        }

        private void Formss_Click(object sender, EventArgs e)
        {

        }

        void newMDIChild_Closed(object sender, FormClosingEventArgs e)
        {
            if (flag)
            {
                DialogResult result = MessageBox.Show("Вы действительно хотите закрыть окно?",
                "Уведомление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result != DialogResult.Yes)
                    e.Cancel = true;

                //d = int.Parse(Convert.ToString(sender));
                DeleteOkno.DropDownItems.RemoveAt(DeleteOkno.DropDownItems.Count - 1);

                for (int i = 0; i < DeleteOkno.DropDownItems.Count; i++)
                {
                    DeleteOkno.DropDownItems[i].Text = (i + 1).ToString();
                }
                i--;
                flag = false;

            }
        }

    }


}

