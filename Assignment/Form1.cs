using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // On changing the bill amount
        private void Calculate(object sender,EventArgs e)
        {
            Calculate();
        }
        // for subtract button of tip %
        private void SubtractTip_Click(object sender, EventArgs e)
        {
            int val=GetCurrentTipPercent();
            if (val == 0) return;
            val = val - 1;
            TipPercent.Text = val.ToString()+" %";
            Calculate();
        }
        //for add button of tip %
        private void AddTip_Click(object sender, EventArgs e)
        {
            int val=GetCurrentTipPercent()+1;
            TipPercent.Text = val.ToString()+" %";
            Calculate();
        }
        //for subtract button of NO. of People
        private void SubtractPeople_Click(object sender, EventArgs e)
        {
            int val=GetNoOfPeople();
            if(val == 0) return;
            val=val - 1;
            TotalPeople.Text = val.ToString();
            Calculate();
        }
        //for add button of No. of People
        private void AddPeople_Click(object sender, EventArgs e)
        {
            int val=GetNoOfPeople()+1;
            TotalPeople.Text = val.ToString();
            Calculate();
        }
        private int GetCurrentTipPercent()
        {
            string currentTip = TipPercent.ToString(); // getting value of TipPercent
            string[] list = currentTip.Split();        
            int val = int.Parse(list[2]);              // extracting integer value from the string
            return val;
        }
        private int GetNoOfPeople()
        {
            string currentPeople = TotalPeople.ToString();  // getting value of TotalPeople
            string[] list = currentPeople.Split();
            int val = int.Parse(list[2]);                   // extracting integer value from the string
            return val;
        }
        // calculating tip per person and total per person
        private void Calculate()
        {
            Error.Text  =  "";
            try
            {
                double bill  =  double.Parse(BillAmount.ToString().Split()[2]); // extracting bill amount throws format exception
                if ((bill * 100 - (int)(bill * 100)) > 0||bill<0) throw new FormatException(); // for bill amount to be upto 2 decimal places or not to be negative
                int person  =  GetNoOfPeople(),tipPercent=GetCurrentTipPercent();
                if  (person  ==  0)  throw new DivideByZeroException(); // check for valid person
                double billPerPerson = (double)bill / person;
                double tipPerPerson  =  (double)(billPerPerson  *  tipPercent)  /  100;
                TotalPerPerson.Text  =  "$"  + Math.Round((billPerPerson  +  tipPerPerson),2);
                TipPerPerson.Text  =  "$"  + Math.Round(tipPerPerson,2);
            }
            catch (DivideByZeroException)
            {
                Error.Text = "Number of person shoud be more than 0";
            }
            catch (FormatException)
            {
                Error.Text  =  "Input should be a vaild amount";
            }
            catch (Exception)
            {
                Error.Text = "Some error occured";
            }
        }
    }
}
