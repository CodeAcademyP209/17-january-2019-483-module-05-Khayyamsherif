using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()

        {   

            InitializeComponent();
            dataGridView1.DataSource = WorkersData.Employeer;
            dataGridView1.BackgroundColor = Color.White;


            


        }





        private void button2_Click(object sender, EventArgs e)
        {
            int enCoxIsleyen = 0;
            string Name=null;
            foreach (var item in WorkersData.Employeer)
            {

                if(item.isdenCixmaVaxti - item.iseGelmeVaxti > enCoxIsleyen)
                {
                    enCoxIsleyen = item.isdenCixmaVaxti - item.iseGelmeVaxti;
                    Name = item.ad;
                }

                 
            }
            MessageBox.Show(Name);
           
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ortaMaas = 0;
            int maasCem = 0;
            foreach (var item in WorkersData.Employeer)
            {
                maasCem+= item.maas;
                ortaMaas = maasCem / WorkersData.Employeer.Count;

            }


            List<Workers> ortaYuxari = new List<Workers>();

            foreach (var item in WorkersData.Employeer)
            {
                if (item.maas > ortaMaas)
                {
                    ortaYuxari.Add(item);

                }
            }


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ortaYuxari;

        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            int selectedid = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            int  deyisen = Convert.ToInt32(dataGridView1.CurrentCell.Value);

            foreach (var item in WorkersData.Employeer)
            {
                if (item.id == selectedid)
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 4)
                    {

                        foreach (var item1 in WorkersData.Employeer)
                        {
                            item1.iseGelmeVaxti = deyisen;

                        }


                    }
                    else if (dataGridView1.CurrentCell.ColumnIndex == 5)
                    {


                        foreach (var item1 in WorkersData.Employeer)
                        {
                            item1.isdenCixmaVaxti = deyisen;

                        }


                    }
                    else
                    {
                        foreach (var item1 in WorkersData.Employeer)
                        {
                            item1.maas = deyisen;

                        }

                    }


                }

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = WorkersData.Employeer;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form islemeVaxti = new Form();
            DateTimePicker dtp = new DateTimePicker();
            islemeVaxti.Controls.Add(dtp);
            dtp.Left = 15;
            dtp.Top = 15;
            islemeVaxti.Width = 500;
            islemeVaxti.Height = 500;
            islemeVaxti.Show();
            

            

        }
    }
}

