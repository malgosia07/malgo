using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6__Metody_rozszerzające
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textboxExercise1.Text.Length > 0)
            {
                result1.Text = textboxExercise1.Text.ToUpperAndLower();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(textboxExercise2.Text.Length > 0)
            {
                result2.Text = textboxExercise2.Text.UpperEveryFirstLetterOfWord();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (textboxExercise3.Text.Length > 0)
            {
                result3.Text = textboxExercise3.Text.VowelsRemove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textboxExercise4.Text.Length > 0)
            {

                result4.Text = textboxExercise4.Text.WordCount().ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textboxExercise7.Text.Length > 0)
            {

                result7.Text = textboxExercise7.Text.MostAparitionsLetter().ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textboxExercise6.Text.Length > 0)
            {

                result6.Text = textboxExercise6.Text.Sentence().ToString();
            }
        }
    }
}
