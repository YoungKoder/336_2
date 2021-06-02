using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Lab1
{
    public partial class Form1 : Form
    {
        string currentTableName = "Events";
        DataSet ds;
        // Класс работы с БД
        Repository rep;
        byte[] ImageData;
        MySqlCommandBuilder commandBuilder;
        public Form1()
        {
            InitializeComponent();
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.RowTemplate.Height = 120;
            initializeGridView();

        }

        //Обработчик смены табов tabControl1
        private void OnTabSelect(object sender, TabControlEventArgs e)
        {
            currentTableName = e.TabPage.Name;
            //rep.connect();
            e.TabPage.Controls.Add(dataGridView2);
            
            initializeGridView();
            //rep.closeConnection();
            
        }

        //Обработчик добавления новой строки в Data Table;
        //И так как мы ранее установили привязку к источнику данных, 
        //то автоматически новая строка также будет добавляться и в dataGridView2
        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].NewRow(); // добавляем новую строку в DataTable
            ds.Tables[0].Rows.Add(row);
        }

        //Обработчик удаления строки;
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row);
            }
        }

        //Обработчик сохранения;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentTableName == "Events")
                {
                    ApiHelper apiHelper = new ApiHelper();
                    ds = apiHelper.tableAction("save", "Events",ds);
                    dataGridView2.DataSource = ds.Tables[0];
                }
                if (currentTableName == "Venus")
                {
                    ApiHelper apiHelper = new ApiHelper();
                    ds = apiHelper.tableAction("save", "Venus",ds);
                    dataGridView2.DataSource = ds.Tables[0];
                }
                if (currentTableName == "Country")
                {
                    ApiHelper apiHelper = new ApiHelper();
                    ds = apiHelper.tableAction("save", "Country", ds);
                    dataGridView2.DataSource = ds.Tables[0];
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Обработчик изменения ячейки с картинкой;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dataGridView2.Columns[columnIndex].Name == "Photo" || dataGridView2.Columns[columnIndex].Name == "Logo" || dataGridView2.Columns[columnIndex].Name == "Flag")
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.png;*.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (Image img = Image.FromFile(openFileDialog1.FileName))
                    {
                        dataGridView2.Rows[rowIndex].Cells[columnIndex].Value = img;
                        FileStream fs = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        ImageData = br.ReadBytes((int)fs.Length);
                        //return;
                    }
                }
            }
        }

        
        //Функция инициализации dataGridView2;
        public void initializeGridView()
        {
            ApiHelper apiHelper = new ApiHelper();
            ds = new DataSet();
            ds = apiHelper.tableAction("select",currentTableName);
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns["Id"].ReadOnly = true;
            if (currentTableName == "Events")
                dataGridView2.Columns["VenueId"].ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            int rowIndex = e.RowIndex;
            if (dataGridView2 != null)
            {
                dataGridView2.Columns[columnIndex].HeaderText = Helper.sourceColumnTextName(dataGridView2.Columns[columnIndex].Name);
            }
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\makst\\OneDrive\\Documents\\Study\\3CURS_2SEMESTR\\metodyStvoreniya\\336_2\\HELP\\UseManual.chm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
