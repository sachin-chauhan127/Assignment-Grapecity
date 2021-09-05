using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This object refering the Tip% textbox 
        private void Tip_TextChanged(object sender, EventArgs e)
        {

        }

        // This object refering the partion of the screen, one for input functionalities
        //  and other showing output functionality.
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        // This object refering the tip minus buttonwhich is uesd for reducing the current tip% 
        private void Tipminus_Click(object sender, EventArgs e)
        {
            // here, I'm storing the float value of textbox tip%,Bill and number of people
            float i = float.Parse(Tip.Text);
            float bl = float.Parse(Bill.Text);
            float np = float.Parse(Persons.Text);

            // tip% can't be less than zero 
            if (i > 0)
            {
                i -= 1;    // this event subtract -1 from tip% .
            }

            // here, I'm calculating the output that has been changed due to change in the value of Tip%
            float tp = ((bl * i) / (float)100) / np;
            float tpp = (bl / np) + tp;

            // Here, Upadating the chenges 
            Tip.Text = i.ToString();
            Tipperperson.Text = tp.ToString();
            Totalperperson.Text = tpp.ToString();
            
        }


        // This object refering the tip plus buttonwhich is uesd for increase the current tip% 
        private void Tipplus_Click(object sender, EventArgs e)
        {
            // here, I'm storing the float value of textbox tip%,Bill and number of people
            float i = float.Parse(Tip.Text);
            float bl = float.Parse(Bill.Text);
            float np = float.Parse(Persons.Text);

            // tip% can't be greater than hundred 
            if (i < 100)
            {
                i += 1;         // this event add +1 to the tip% 
            }

            // here, I'm calculating the output that has been changed due to change in the value of Tip%
            float tp = ((bl * i) / (float)100) / np;
            float tpp = (bl / np) + tp;

            // Here, Upadating the chenges 
            Tip.Text = i.ToString();
            Tipperperson.Text = tp.ToString();
            Totalperperson.Text = tpp.ToString();
        }


        //This object refering the button Nminus which is used to decrease the number of people
        private void Nminus_Click(object sender, EventArgs e)
        {
            // here, I'm storing the float value of textbox tip%,Bill and number of people
            float tipp = float.Parse(Tip.Text);
            float bl = float.Parse(Bill.Text);
            float i = float.Parse(Persons.Text);
            if (i > 0)     // this event subtract -1 from the number of people
            {
                i -= 1;
            }

            // here, I'm calculating the output that has been changed due to change in the value of Tip%
            float tp = ((bl * tipp) / (float)100) / i;
            float tpp = (bl / i) + tp;

            // Here, Upadating the chenges 
            Persons.Text = i.ToString();
            Tipperperson.Text = tp.ToString();
            Totalperperson.Text = tpp.ToString();

        }

        //This object refering the button Nplus which is used to increase the number of people
        private void Nplus_Click(object sender, EventArgs e)
        {
            // here, I'm storing the float value of textbox tip%,Bill and number of people
            float tipp = float.Parse(Tip.Text);
            float bl = float.Parse(Bill.Text);
            float i = float.Parse(Persons.Text);
            i += 1;  // This event add +1 value to the number of people

            // here, I'm calculating the output that has been changed due to change in the value of Tip%
            float tp = ((bl * tipp) / (float)100) / i;
            float tpp = (bl / i) + tp;

            // Here, Upadating the chenges 
            Persons.Text = i.ToString();
            Tipperperson.Text = tp.ToString();
            Totalperperson.Text = tpp.ToString();
        }


        // this object refering the textbox persons which contain the count of number of people
        private void Persons_TextChanged(object sender, EventArgs e)
        {

        }


        // this object refering the textbox Bill which contain the bill amount excluded tip charges
        private void Bill_TextChanged(object sender, EventArgs e)
        {
            // this is special case when the string is empty. to prevent error i did set the default value
            if(Bill.Text=="" || Bill.Text==".")
            {
                Bill.Text = ".00";
            }
            // here, I'm storing the float value of textbox tip%,Bill and number of people
            float tipp = float.Parse(Tip.Text);
            float bl = float.Parse(Bill.Text);
            float i = float.Parse(Persons.Text);

            // here, I'm calculating the output that has been changed due to change in the value of Tip%
            float tp = ((bl * tipp) / (float)100) / i;
            float tpp = (bl / i) + tp;

            // Here, Upadating the chenges 
            Tipperperson.Text = tp.ToString();
            Totalperperson.Text = tpp.ToString();

        }


        // This object refering the textbox Tipperperson which has the information about amount of tip distributed per person 
        private void Tipperperson_TextChanged(object sender, EventArgs e)
        {

        }


        //This object refering the textbox totalperperson which has the record of total bill per person after adding tip charges 
        private void Totalperperson_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
