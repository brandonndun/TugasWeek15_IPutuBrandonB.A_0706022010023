using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class NamaItem : Form
    {
        public NamaItem()
        {
            InitializeComponent();
        }

        public string [] MenuMakanan = new string[20];
        public string[] MenuMinuman = new string[20];

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxName1.Items.Add(BoxItem.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (boxName2.SelectedItems.Count == 0)
            {
                boxName2.Items.Clear();
            }
            else
            {
                for (int i = boxName2.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    boxName2.Items.Remove(boxName2.SelectedItems[i]);
                }
            }
            boxName2.ClearSelected();
        }

        private void MakananCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void boxName1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true && BoxItem.Text != "" || radioButton2.Checked == true && BoxItem.Text != "")
            {
                if (radioButton1.Checked == true)
                {
                    boxName1.Items.Add(BoxItem.Text);

                }
                else if (radioButton2.Checked == true)
                {
                    boxName1.Items.Add(BoxItem.Text);

                }

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                BoxItem.Text = "";
            }
            else
            {
                MessageBox.Show("NGETIK YANG BENER BISA GA SI ?!?");
            }


        }
           

        private void NamaItem_Load(object sender, EventArgs e)
        {
            boxName1.Items.Add("Mie Instan");
            boxName1.Items.Add("Telor");
            boxName1.Items.Add("Susu Sapi");
            boxName1.Items.Add("Kopi");
            boxName1.Items.Add("Roti");
            boxName1.Items.Add("Keju");
            boxName1.Items.Add("Daging Giling");
            boxName1.Items.Add("Teh");
            boxName1.Items.Add("Bir");

            MenuMakanan[0] = "Nasi Goreng";
            MenuMakanan[1] = "Telor";
            MenuMakanan[2] = "Roti";
            MenuMakanan[3] = "Keju";
            MenuMakanan[4] = "Daging Giling";
            MenuMinuman[0] = "Susu Sapi";
            MenuMinuman[1] = "Kopi";
            MenuMinuman[2] = "Teh";
            MenuMinuman[3] = "Bir";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

       private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= boxName1.SelectedIndices.Count - 1; i++)
            {
                if (boxName2.Items.Contains(boxName1.SelectedItems[i]))
                {

                }
                else
                {
                    boxName2.Items.Add(boxName1.SelectedItem);
                }
            }
            boxName1.ClearSelected();
            MakananCheck.Checked = false;
            MinumanCheck.Checked = false;

        }

        private void BoxItem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

