using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace finalExam
{
    public partial class Form2 : Form
    {
        public string studentData = ""; //defines a global variable to be used in the form1
        public Form2()
        {
            InitializeComponent();
        }

        //global variables
        string dir = @"./CSW23";
        string pathTxt = "./CSW23/Exam.txt";
        string pathXml = "./CSW23/Exam.xml";
        FGrades grades = new FGrades(); //instantiate the object

        private void Form2_Load(object sender, EventArgs e)
        {
            Reset();

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
        private void btn_validate_Click(object sender, EventArgs e)
        {
            try
            {
                Validator validator = new Validator(); //instantiate the object
                if (txt_midterm.Text == "" || txt_project.Text == "" || txt_final.Text == "") //check if the text box are empty
                {
                    MessageBox.Show("Please enter the values", "Grades empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    //convert from string to double
                    double midterm = Convert.ToDouble(txt_midterm.Text.Trim());
                    double project = Convert.ToDouble(txt_project.Text.Trim());
                    double final = Convert.ToDouble(txt_final.Text.Trim());

                    //validate the grades
                    if (validator.validateGrades(txt_midterm.Text) && midterm <= 100 && midterm >= 0)
                    {
                        if (validator.validateGrades(txt_project.Text) && project <= 100 && project >= 0)
                        {
                            if (validator.validateGrades(txt_final.Text) && final <= 100 && final >= 0)
                            {
                                //save the values into the fields and put in the textbox
                                grades.Midterm = midterm;
                                grades.Project = project;
                                grades.Final = final;
                                txt_total.Text = grades.Total().ToString();
                                txt_grade_midterm.Text = grades.midterm_percentage().ToString();
                                txt_grade_project.Text = grades.project_percentage().ToString();
                                txt_grade_final.Text = grades.final_percentage().ToString();
                                txt_letter.Text = grades.letter();
                                txt_midterm.ReadOnly = true;
                                txt_project.ReadOnly = true;
                                txt_final.ReadOnly = true;
                            }
                            else
                            {
                                MessageBox.Show("Wrong final value. Please insert one up to three digits, between 0 and 100", "Wrong final value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_final.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong project value. Please insert one up to three digits, between 0 and 100", "Wrong project value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txt_project.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong midterm value. Please insert one up to three digits, between 0 and 100", "Wrong midterm value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_midterm.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.\n" + ex.Message);
            }
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Close();
            }
        }

        public void Reset()
        {
            //put everything to its default
            txt_midterm.ReadOnly = false;
            txt_project.ReadOnly = false;
            txt_final.ReadOnly = false;
            txt_midterm.Text = "";
            txt_project.Text = "";
            txt_final.Text = "";
            txt_total.Text = "0";
            txt_grade_midterm.Text = "0";
            txt_grade_project.Text = "0";
            txt_grade_final.Text = "0";
            txt_letter.Text = "0";
            grades.Midterm = 0;
            grades.Project = 0;
            grades.Final = 0;
        }

        private void btn_writeTxt_Click(object sender, EventArgs e)
        {
            //check if the data is validated
            if (txt_midterm.ReadOnly == true && txt_project.ReadOnly == true && txt_final.ReadOnly == true)
            {
                FileStream fileStream = null;
                try
                {
                    //get the data
                    string midterm = txt_midterm.Text;
                    string project = txt_project.Text;
                    string final = txt_final.Text;
                    string total = txt_total.Text;
                    string gradeMidterm = txt_grade_midterm.Text;
                    string gradeProject = txt_grade_project.Text;
                    string gradeFinal = txt_grade_final.Text;
                    string letter = txt_letter.Text;

                    //create and write in the text file
                    fileStream = new FileStream(pathTxt, FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fileStream);
                    writer.WriteLine($"{studentData} | Midterm: {midterm} | {gradeMidterm}% | Project: {project} | {gradeProject}%" +
                        $" Final: {final} | {gradeFinal}% | Total: {total} | {letter}");
                    writer.Close();
                    fileStream.Close();

                    MessageBox.Show("Data entered to the text file", "Data saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured, try again. \n" + ex.Message);
                }
                finally
                {
                    if (fileStream != null) fileStream.Close();
                }
            } else
            {
                MessageBox.Show("Please validate your data before write into text file", "Data not validated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void btn_writeXml_Click(object sender, EventArgs e)
        {
            try
            {
                //check if the text file exists
                if (!File.Exists(pathTxt))
                {
                    MessageBox.Show("Create your text file first.", "Text file is not created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //write in the xml what is inside the txt
                    XmlWriterSettings settings = new XmlWriterSettings();
                    settings.Indent = true; settings.IndentChars = (" ");
                    XmlWriter xmlOut = XmlWriter.Create(pathXml, settings);
                    xmlOut.WriteStartDocument();
                    xmlOut.WriteStartElement("Grades");

                    FileStream fs2 = new FileStream(pathTxt, FileMode.Open, FileAccess.Read);
                    StreamReader objR = new StreamReader(fs2);

                    while (objR.Peek() != -1)
                    {
                        string line = objR.ReadLine();
                        xmlOut.WriteElementString("Grade", line);
                    }

                    objR.Close();
                    fs2.Close();
                    xmlOut.WriteEndElement();
                    xmlOut.Close();

                    MessageBox.Show("Data entered to the Xml file", "Data saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Reset();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.\n" + ex.Message, "Error");
            }
        }

        private void btn_readXml_Click(object sender, EventArgs e)
        {
            try
            {
                //check if xml exists
                if (!File.Exists(pathXml))
                {
                    MessageBox.Show("Create your Xml file first.", "Xml file is not created", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //read from xml file
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreWhitespace = true;
                    settings.IgnoreComments = true;
                    XmlReader xmlIn = XmlReader.Create(pathXml, settings);
                    string tempStr = "", Grade = "";
                    if (xmlIn.ReadToDescendant("Grade"))
                    {
                        do
                        {
                            xmlIn.ReadStartElement("Grade");
                            Grade = xmlIn.ReadContentAsString();
                            tempStr += Grade + "\n";
                        }
                        while (xmlIn.ReadToNextSibling("Grade"));
                    }
                    xmlIn.Close();
                    MessageBox.Show(tempStr, "Read XML");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.\n" + ex.Message, "Error");
            }
        }
    }
}
