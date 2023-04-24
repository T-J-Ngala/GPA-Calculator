using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int toupper = 1;
        public Form1()
        {
            InitializeComponent();
         
    
    }

         string[] Grades = { "A", "A-", "B+", "B","B-","C+", "C","C-", "D+", "D", "D-", "F" };
         double[] gradesPoint = {4,3.70,3.5,3,2.75,2.5,2,1.75,1.5,1,0.75,0};

        string[] courses = { "Phy445* 4", "Comp234 *3", "French343 *2", "Econs456 *3" };
        public string[] courseName = { "Phy445", "Comp234", "French343", "Econs456" };
        string courseN;
        double[] coursesGrades = {4,3,2,3};
        double GPA;
        double totalCredit;
        double totalPoint;

        public double creditPoint1=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBoxCourseandGrade.Enabled = false;


            for (int i = 0; i < courses.Length; i++)
                comboBox1.Items.Add(courses[i]);

            for(int i=0; i<Grades.Length; i++)
           
                comboBox2.Items.Add(Grades[i]);
          
        }
        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text != "" && txtNameLastName.Text != "")
            {
                groupBoxCourseandGrade.Enabled = true;
            }
            else
                groupBoxCourseandGrade.Enabled = false;
        }

        private void txtNameLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentNumber.Text != "" && txtNameLastName.Text != "")
            {
                groupBoxCourseandGrade.Enabled = true;
            }
            else
                groupBoxCourseandGrade.Enabled = false;

        }


        private void txtStudentNumber_KeyDown(object sender, KeyEventArgs e)
        {

            if (txtStudentNumber.Text != "" && txtNameLastName.Text != "")
            {
                groupBoxCourseandGrade.Enabled = true;
            }
            else
                groupBoxCourseandGrade.Enabled = false;

            if (e.KeyCode == Keys.Space)
                txtNameLastName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNameLastName.Text);
            txtNameLastName.Select(txtNameLastName.Text.Length, 0);


            if (e.KeyCode == Keys.Enter)
                txtNameLastName.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double creditEqual = 3;
            string selectedG = comboBox2.SelectedItem.ToString();

            for (int i = 0; i <Grades.Length; i++)
            {
                if (selectedG == Grades[i].ToString())
                {
                    creditPoint1 = gradesPoint[i];
                }
            }
            for (int i = 0; i < courses.Length; i++)
            {
                if (comboBox1.Text == courses[i])
                {
                    creditEqual = coursesGrades[i];
                }
            }

            for (int i = 0; i < courses.Length; i++)
            {
                if (comboBox1.Text == courses[i])
                {
                 courseN = courseName[i];
                }
            }

            double calculatedPoint = creditEqual * creditPoint1;

            string[] bilgiler = {courseN, creditEqual.ToString(),comboBox2.Text, creditPoint1.ToString(),calculatedPoint.ToString()};
           ListViewItem item = new ListViewItem(bilgiler);
            listView1.Items.Add(item);

            totalPoint += calculatedPoint;
            totalCredit += creditEqual;

            GPA = totalPoint / totalCredit;

            txtGpa.Text = Math.Round(GPA, 2).ToString();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            double deletedCredit=0;
            double deletedPoint=0;
            int selectedlist = listView1.SelectedItems.Count;

            foreach (ListViewItem selectedd in listView1.SelectedItems)
            {
                selectedd.Remove();

                deletedCredit = Convert.ToDouble(selectedd.SubItems[1].Text);
                deletedPoint = Convert.ToDouble(selectedd.SubItems[4].Text);

            }
           

            totalPoint -= deletedPoint;
            totalCredit -= deletedCredit;

            GPA = totalPoint / totalCredit;

            txtGpa.Text = Math.Round(GPA, 2).ToString();
        }

        private void txtNameLastName_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void txtNameLastName_Leave(object sender, EventArgs e)
        {

            txtNameLastName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtNameLastName.Text);
            txtNameLastName.Select(txtNameLastName.Text.Length, 0);

        }

        private void txtNameLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(toupper==1)
            {
                e.KeyChar = Convert.ToChar(e.KeyChar.ToString().ToUpper());
                toupper = 0;
            } 
            if (e.KeyChar == 32)
                toupper = 1;

        }

        private void groupBoxCourseandGrade_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
