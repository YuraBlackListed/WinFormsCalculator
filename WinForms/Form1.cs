using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var numbers = GetNumbers();
                int result = numbers.Item1 + numbers.Item2;
                string message = $"Result: {result}";
                MessageBox.Show(message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var numbers = GetNumbers();
                int result = numbers.Item1 * numbers.Item2;
                string message = $"Result: {result}";
                MessageBox.Show(message, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private (int, int) GetNumbers()
        {
            int x, y;
            if (!int.TryParse(textBox1.Text, out x))
            {
                throw new ArgumentException("Invalid input for first number. Please enter a valid number.");
            }

            if (!int.TryParse(textBox2.Text, out y))
            {
                throw new ArgumentException("Invalid input for second number. Please enter a valid number.");
            }

            return (x, y);
        }
    }
}
