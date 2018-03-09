using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyData;

namespace TestDisplay
{
    public partial class Form1 : Form
    {
        private FileData _fileData;

        List<DataSummary> _dataSummary;

        public Form1(string[] args)
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

            _dataSummary = new List<DataSummary>() { new DataSummary(), new DataSummary() };
            listBoxDatas.DataSource = _dataSummary;

            //var bList = new BindingList<DataSummary>(_dataSummary);
            //var source = new BindingSource(bList, null);

            dataGridView1.DataSource = _dataSummary;
            dataGridView1.RefreshEdit();

            string msg = "";
            if (args!=null)
            foreach (var arg in args)
            {
                if (Path.GetExtension(arg) == ".toto")
                    msg += $"Should handle file {arg} | ";
                else
                    msg += "Got file {arg} | ";
            }
            textBoxData.Text = msg;

        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                _fileData = new FileData(file);
            textBoxData.Text = _fileData.Text;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("Row header Clicked");
        }
    }
}
