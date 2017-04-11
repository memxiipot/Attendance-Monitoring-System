using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendanceMonitoringSystem
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudents.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddStudents.aspx");
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteStudents.aspx");
        }
    }
}