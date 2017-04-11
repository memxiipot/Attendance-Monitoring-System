using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendanceMonitoringSystem
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ex1.Text = "";
            ex2.Text = "";
            ex3.Text = "";
            ex4.Text = "";
            ex5.Text = "";

            int num1, num2, num3, num4, total;
            num1 = 0;
            num2 = 0;
            num3 = 0;
            num4 = 0;

            BIZAddStudent AddStudents = new BIZAddStudent();
            try
            {
                AddStudents.setIDNum(id.Text);
                num1 = 1;
            }
            catch (Exception ex)
            {
                ex1.Text = ex.Message;
                num1 = 0;
            }

            try
            {
                AddStudents.setGName(gname.Text);
                num2 = 1;
            }
            catch (Exception ex)
            {
                ex2.Text = ex.Message;
                num2 = 0;
            }

            try
            {
                AddStudents.setMName(mname.Text);
                num3 = 1;
            }
            catch (Exception ex)
            {
                ex3.Text = ex.Message;
                num3 = 0;
            }

            try
            {
                AddStudents.setLName(lname.Text);
                num4 = 1;
            }
            catch (Exception ex)
            {
                ex4.Text = ex.Message;
                num4 = 0;
            }

            total = num1 + num2 + num3 + num4;
            if (total == 4)
            {
                AddStudents.Add();
                ex5.Text = "Record Added!";
            }

            else
            {
                ex5.Text = "Record NOT Added!";

            }        
        }
    }
}