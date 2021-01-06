using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
   

        private void button1_Click(object sender, EventArgs e)
        {
            string tcno="", adsoyad="", cinsiyet="", mezuniyet="", diller="", uzmanlık="";
            tcno = textBox1.Text;
            adsoyad = textBox2.Text;
            if (radioButton1.Checked == true)
            {
                cinsiyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                cinsiyet = radioButton3.Text;

            }
            else if (radioButton4.Checked== true)
                mezuniyet = radioButton4.Text;
            else if (radioButton5.Checked==true)
                mezuniyet = radioButton5.Text;
            else if (radioButton6.Checked == true)
                mezuniyet = radioButton6.Text;


            if (checkBox7.Checked == true)
                diller = diller + "," + checkBox7.Text;
            if (checkBox8.Checked == true)
                diller = diller + "," + checkBox8.Text;
            if (checkBox9.Checked == true)
                diller = diller + "," + checkBox9.Text;
            if (checkBox10.Checked == true)
                diller = diller + "," + checkBox10.Text;
            if (checkBox11.Checked == true)
                diller = diller + "," + checkBox11.Text;
            if (checkBox12.Checked == true)
                diller = diller + "," + checkBox12.Text;
            diller = diller.Substring(1);


            if (checkBox1.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox1.Text;
            if (checkBox2.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox2.Text;
            if (checkBox3.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox3.Text;
            if (checkBox4.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox4.Text;
            if (checkBox5.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox5.Text;
            if (checkBox6.Checked == true)
                uzmanlık = uzmanlık + "," + checkBox6.Text;
            uzmanlık = uzmanlık.Substring(1);

            listBox1.Items.Add("TC NO:" + tcno + " - " + adsoyad + " - " + "MEZUNİYETİ"  + mezuniyet + " - " + "CİNSİYETİ:" + cinsiyet + " - " + "DİLLER:" + diller + " - " + "UZMANLIK:" + uzmanlık);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            string sili = listBox1.Text;

            listBox1.Items.Remove(sili);
           
            
            listBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        
    }
}
