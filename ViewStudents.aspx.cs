using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AttendanceMonitoringSystem
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BIZView ViewStudents = new BIZView();
            gv.DataSource = ViewStudents.view();
            gv.DataBind();
        }
    }
}