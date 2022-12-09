using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2022_Koba_B_O_Ind_2._4
{
    public partial class Form1 : Form
    {
        private Vector vec_1 = new Vector();
        private Vector vec_2 = new Vector();
        private double vec_const;
        int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void first_vecbutton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                vec_1.Data = Array.ConvertAll(first_vector_textBox.Text.Split(' '), Double.Parse);
            }
            catch 
            {
                MessageBox.Show("Неправильне введення");
                vec_1.Data = new double[] { 0, 0, 0, 0 };
            }
        }

        private void sec_vecbutton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                vec_2.Data = Array.ConvertAll(second_vector_textBox.Text.Split(' '), Double.Parse);
            }
            catch 
            {
                MessageBox.Show("Неправильне введення");
                vec_2.Data = new double[] { 0, 0, 0, 0 };
            }
        }
        private void const_textBox_TextChanged(object sender, EventArgs e)
        {
            if (const_textBox.Text == String.Empty)
            {
                vec_const = 0;
                result_textBox.Text = String.Empty;
            }
            else
            {
                vec_const = Double.Parse(const_textBox.Text);
            }
        }
        private void add_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            result_textBox.Text = (vec_1 + vec_2).ToString();
        }

        private void diff_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            result_textBox.Text = (vec_1 - vec_2).ToString();
        }

        private void scalar_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            result_textBox.Text = (vec_1 * vec_2).ToString();
        }

        private void cons_mult_vec1_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            result_textBox.Text = (vec_1 * vec_const).ToString();
        }

        private void show_vec1_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            result_textBox.Text = String.Join(' ', vec_1);
        }

        private void show_vec2_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            result_textBox.Text = String.Join(' ', vec_2);
        }

        private void set_by_index_vec1_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                {
                    MessageBox.Show("Задайте правильний індекс");
                }
                else
                {
                    vec_1.Data[index] = Double.Parse(value_textBox.Text);
                    result_textBox.Text = String.Empty;
                    first_vector_textBox.Text = String.Join(' ', vec_1);
                }
            }
            catch 
            {
                MessageBox.Show("Ви нічого не ввели");
            }
        }
        private void set_by_index_vec2_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (index == -1)
                {
                    MessageBox.Show("Задайте правильний індекс");
                }
                else 
                {
                    vec_2.Data[index] = Double.Parse(value_textBox.Text);
                    result_textBox.Text = String.Empty;
                    second_vector_textBox.Text = String.Join(' ', vec_2);
                }
            }
            catch
            {
                MessageBox.Show("Ви нічого не ввели");
            }
        }
        private void get_by_index_vec1_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Задайте правильний індекс");
            }
            else 
            {
                result_textBox.Text = (vec_1.Data[index]).ToString();
            }
        }

        private void get_by_index_vec2_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Задайте правильний індекс");
            }
            else 
            {
                result_textBox.Text = (vec_2.Data[index]).ToString();
            }
        }

        private void index_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (UInt32.Parse(index_textBox.Text) < vec_1.Data.Length && UInt32.Parse(index_textBox.Text) < vec_2.Data.Length)
                {
                    index = Int32.Parse(index_textBox.Text);
                }
                else if(UInt32.Parse(index_textBox.Text) > vec_1.Data.Length || UInt32.Parse(index_textBox.Text) > vec_2.Data.Length)
                {
                    MessageBox.Show("Індекс за межами масиву");
                    index_textBox.Text = String.Empty;
                    index = -1;
                }
            }
            catch 
            {
                MessageBox.Show("Неправильний формат заданого значення");
                index_textBox.Text = String.Empty;
                result_textBox.Text = String.Empty;
                index = -1;
            }
        }
        private void const_mult_sec_vec_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            result_textBox.Text = (vec_2 * vec_const).ToString();
        }
    }
}
