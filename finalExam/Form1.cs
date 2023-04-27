using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//CODED BY KATHLEEN FORGIARINI DA SILVA
// 2023-04-27
// FINAL EXAM OOP

namespace finalExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            //Enter to the second form

            Validator validator = new Validator();
            string year = txt_year.Text.Trim();
            string session = txt_session.Text.Trim();
            if (validator.validateYear(year)) //validate year between 2020 and 2029
            {
                if (validator.validateSession(session)) //validade session Winter, Fall or Summer
                {
                    Form2 form2 = new Form2();
                    form2.studentData = txt_student.Text; //put the string inside the variable in the form
                    form2.ShowDialog(); //open the form

                } else
                {
                    MessageBox.Show("The session is incorrect. The options are Fall, Winter or Summer", "Incorrect Session", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("The year is incorrect. Please insert a year between 2020 and 2029", "Incorrect Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_student.Text = "Kathleen Forgiarini da Silva - 2234126"; //write in the text box
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_year.Text = "2023";
            txt_session.Text = "Winter";
        }
    }
}
