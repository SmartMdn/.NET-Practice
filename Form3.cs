using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            string[] NamesOfFiles = new string[5];
            string[] AddressOfFiles = new string[5];
            int i = 0;
            InitializeComponent();
            String mypath = @"C:\SomeDir3";
            List<string> listik = new List<string>();
            listik = Directory.GetFiles(mypath).ToList();
            listik.ForEach(delegate (String name)
            {
                NamesOfFiles[i] = Path.GetFileName(name);
                System.IO.FileInfo file = new System.IO.FileInfo(name);
                long size = file.Length;
                AddressOfFiles[i] = size.ToString();
                i++;
            });
            DataTable dt = new DataTable();
            dt.Columns.Add("Имя файла");
            dt.Columns.Add("Размер файла(байт)");

            for (i = 0; i < NamesOfFiles.Length; i++)
            {
                DataRow r = dt.NewRow();
                r["Имя файла"] = NamesOfFiles[i];
                r["Размер файла(байт)"] = AddressOfFiles[i];
                dt.Rows.Add(r);
            }

            dataGridView1.DataSource = dt;

        }







    }
}
