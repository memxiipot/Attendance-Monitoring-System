using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace AttendanceMonitoringSystem
{
    
    public class DATAddStudents
    {
        //last name, given name, mother's maiden name
        public static void AddStudents(int idnum, string lname, string gname, string mname)
        {
            string strcom = "INSERT INTO Students VALUES ('"+ idnum +"', '"+ lname +"', '"+ gname +"', '"+ mname +"') ";

            SqlConnection con = new SqlConnection(GlobalData.strcon);
            con.Open();

            SqlCommand com = new SqlCommand(strcom, con);
            com.ExecuteNonQuery();

            con.Close();
        }
    }


    public class DATViewStudents
    {
        public static DataTable ViewStudents()
        {
            string strcom = "SELECT * FROM Students";

            SqlConnection con = new SqlConnection(GlobalData.strcon);
            con.Open();

            SqlCommand com = new SqlCommand(strcom, con);

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dtb = new DataTable();
            da.Fill(dtb);

            return dtb;
        }
    }

    public class DATDeleteStudents
    {
        public static void DeleteStudents(int idnum)
        {
            string strcom = "DELETE FROM Students Where [ID Number] =" + idnum;

            SqlConnection con = new SqlConnection(GlobalData.strcon);
            con.Open();

            SqlCommand com = new SqlCommand(strcom, con);
            com.ExecuteNonQuery();

            con.Close();
        }
    }

}