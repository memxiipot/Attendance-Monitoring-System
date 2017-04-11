using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendanceMonitoringSystem
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BIZView ViewStudent = new BIZView();
            gv.DataSource = ViewStudent.view();
            gv.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ex1.Text = "";
            int num = 0;

            BIZDelete DeleteStudent = new BIZDelete();

            try
            {
                DeleteStudent.check(input.Text);
                num = 1;
            }
            catch (Exception ex)
            {
                ex1.Text = ex.Message;
                num = 0;
            }

            if (num == 1)
            {
                DeleteStudent.Delete();
            }

            BIZView ViewStudent = new BIZView();
            gv.DataSource = ViewStudent.view();
            gv.DataBind();

        }
    }
}