using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;

namespace True_Random_Rolls
{
    public partial class Form1 : Form
    {
        RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();

        //class has no use?
        public Form1()
        {
            InitializeComponent();
        }

        //Get TrueRandom through RNGCryptoServiceProvider
        public Int32 Roll(Int32 minValue, Int32 maxValue)
        {
            //Create bytes
            var byteArray = new byte[4];

            //Exceptions if min greater than max
            if (minValue > maxValue)
                throw new ArgumentOutOfRangeException("minValue");

            //Return min if equal val
            if (minValue == maxValue) return minValue;

            //difference min and max
            Int64 diff = maxValue - minValue;

            while (true)
            {
                //Fill bytes with random numbers from RNGCryptoServiceProvider
                provider.GetBytes(byteArray);
                UInt32 rand = BitConverter.ToUInt32(byteArray, 0);

                Int64 max = (1 + (Int64)UInt32.MaxValue);
                if (rand < max)
                {
                    return (Int32)(minValue + (rand % diff));
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Single D20
            var minRoll = 1;
            var maxRoll = 20;
            //Rolls 1 - 20
            results1D20.Text = Roll(minRoll, maxRoll + 1).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Single D12
            var minRoll = 1;
            var maxRoll = 12;
            //Rolls 1 - 12
            results1D12.Text = Roll(minRoll, maxRoll + 1).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Single D10
            var minRoll = 1;
            var maxRoll = 10;
            //Rolls 1 - 10
            results1D10.Text = Roll(minRoll, maxRoll + 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Single D8
            var minRoll = 1;
            var maxRoll = 8;
            //Rolls 1 - 8
            results1D8.Text = Roll(minRoll, maxRoll + 1).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Single D6
            var minRoll = 1;
            var maxRoll = 6;
            //Rolls 1 - 6
            results1D6.Text = Roll(minRoll, maxRoll + 1).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Single D4
            var minRoll = 1;
            var maxRoll = 4;
            //Rolls 1 - 4
            results1D4.Text = Roll(minRoll, maxRoll + 1).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Roll all single dice
            results1D20.Text = Roll(1, 21).ToString();
            results1D12.Text = Roll(1, 13).ToString();
            results1D10.Text = Roll(1, 11).ToString();
            results1D8.Text = Roll(1, 9).ToString();
            results1D6.Text = Roll(1, 7).ToString();
            results1D4.Text = Roll(1, 5).ToString();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Clear All Rolls
            results1D20.Text = "";
            results1D12.Text = "";
            results1D10.Text = "";
            results1D8.Text = "";
            results1D6.Text = "";
            results1D4.Text = "";

            //Multi Dice
            resultsMD20.Text = "";
            resultsMD12.Text = "";
            resultsMD10.Text = "";
            resultsMD8.Text = "";
            resultsMD6.Text = "";
            resultsMD4.Text = "";

            //Multi Dice Amount
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 1;
            numericUpDown4.Value = 1;
            numericUpDown5.Value = 1;
            numericUpDown6.Value = 1;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Multi D20
            var result = 0;
            // In case values are invalid use an if statement
            if (numericUpDown1.Value <= 0)
            {
                resultsMD20.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown1.Value; i++)
                {
                    result += Roll(1, 21);
                }
                // Output result
                resultsMD20.Text = result.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Multi D12
            var result = 0;
            // In case values are invalid use an if statement
            if (numericUpDown2.Value <= 0)
            {
                resultsMD12.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown2.Value; i++)
                {
                    result += Roll(1, 13);
                }
                // Output result
                resultsMD12.Text = result.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Multi D10
            var result = 0;
            // In case values are invalid use an if statement
            if (numericUpDown3.Value <= 0)
            {
                resultsMD10.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown3.Value; i++)
                {
                    result += Roll(1, 11);
                }
                // Output result
                resultsMD10.Text = result.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Multi D8
            var result = 0;
            // In case values are invalid use an if statement
            if (numericUpDown4.Value <= 0)
            {
                resultsMD8.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown4.Value; i++)
                {
                    result += Roll(1, 9);
                }
                // Output result
                resultsMD8.Text = result.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Multi D6
            var result = 0;
            // In case values are invalid use an if statement
            if (numericUpDown5.Value <= 0)
            {
                resultsMD6.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown5.Value; i++)
                {
                    result += Roll(1, 7);
                }
                // Output result
                resultsMD6.Text = result.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Multi D4
            var result = 0;
            // In case values are invalid use an if statement
            if (numericUpDown6.Value <= 0)
            {
                resultsMD4.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown6.Value; i++)
                {
                    result += Roll(1, 5);
                }
                // Output result
                resultsMD4.Text = result.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var D20result = 0;
            var D12result = 0;
            var D10result = 0;
            var D8result = 0;
            var D6result = 0;
            var D4result = 0;
            //Copied all multi rolls into one click

            //D20
            if (numericUpDown1.Value <= 0)
            {
                resultsMD20.Text = "0";
            }
            else
            {
                for (var i = 0; i < numericUpDown1.Value; i++)
                {
                    D20result += Roll(1, 21);
                }
                resultsMD20.Text = D20result.ToString();
            }

            //D12
            if (numericUpDown2.Value <= 0)
            {
                resultsMD12.Text = "0";
            }
            else
            {
                for (var i = 0; i < numericUpDown2.Value; i++)
                {
                    D12result += Roll(1, 13);
                }
                resultsMD12.Text = D12result.ToString();
            }

            //D10
            if (numericUpDown3.Value <= 0)
            {
                resultsMD10.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown3.Value; i++)
                {
                    D10result += Roll(1, 11);
                }
                // Output result
                resultsMD10.Text = D10result.ToString();
            }

            //D8
            if (numericUpDown4.Value <= 0)
            {
                resultsMD8.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown4.Value; i++)
                {
                    D8result += Roll(1, 9);
                }
                // Output result
                resultsMD8.Text = D8result.ToString();
            }

            //D6
            if (numericUpDown5.Value <= 0)
            {
                resultsMD6.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown5.Value; i++)
                {
                    D6result += Roll(1, 7);
                }
                // Output result
                resultsMD6.Text = D6result.ToString();
            }

            //D4
            if (numericUpDown6.Value <= 0)
            {
                resultsMD4.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown6.Value; i++)
                {
                    D4result += Roll(1, 5);
                }
                // Output result
                resultsMD4.Text = D4result.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Roll ALL Dice

            //Single Rolls
            results1D20.Text = Roll(1, 21).ToString();
            results1D12.Text = Roll(1, 13).ToString();
            results1D10.Text = Roll(1, 11).ToString();
            results1D8.Text = Roll(1, 9).ToString();
            results1D6.Text = Roll(1, 7).ToString();
            results1D4.Text = Roll(1, 5).ToString();

            //Multi Rolls
            var D20result = 0;
            var D12result = 0;
            var D10result = 0;
            var D8result = 0;
            var D6result = 0;
            var D4result = 0;
            //Copied all multi rolls into one click

            //D20
            if (numericUpDown1.Value <= 0)
            {
                resultsMD20.Text = "0";
            }
            else
            {
                for (var i = 0; i < numericUpDown1.Value; i++)
                {
                    D20result += Roll(1, 21);
                }
                resultsMD20.Text = D20result.ToString();
            }

            //D12
            if (numericUpDown2.Value <= 0)
            {
                resultsMD12.Text = "0";
            }
            else
            {
                for (var i = 0; i < numericUpDown2.Value; i++)
                {
                    D12result += Roll(1, 13);
                }
                resultsMD12.Text = D12result.ToString();
            }

            //D10
            if (numericUpDown3.Value <= 0)
            {
                resultsMD10.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown3.Value; i++)
                {
                    D10result += Roll(1, 11);
                }
                // Output result
                resultsMD10.Text = D10result.ToString();
            }

            //D8
            if (numericUpDown4.Value <= 0)
            {
                resultsMD8.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown4.Value; i++)
                {
                    D8result += Roll(1, 9);
                }
                // Output result
                resultsMD8.Text = D8result.ToString();
            }

            //D6
            if (numericUpDown5.Value <= 0)
            {
                resultsMD6.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown5.Value; i++)
                {
                    D6result += Roll(1, 7);
                }
                // Output result
                resultsMD6.Text = D6result.ToString();
            }

            //D4
            if (numericUpDown6.Value <= 0)
            {
                resultsMD4.Text = "0";
            }
            else
            {
                // Loop x amount of dice rolls
                for (var i = 0; i < numericUpDown6.Value; i++)
                {
                    D4result += Roll(1, 5);
                }
                // Output result
                resultsMD4.Text = D4result.ToString();
            }
        }
    }
}
