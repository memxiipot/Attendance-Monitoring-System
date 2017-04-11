using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AttendanceMonitoringSystem
{
    //Add Student
    public class BIZAddStudent
    {
        
        private string lname, gname, mname;
        private int idnum;
        
        public void setGName(string GName)
        {
            if (GName.Length > 30)
            {
                Exception tmpex = new Exception("Maximum length of 30 characters");
                throw tmpex;
            }
            this.gname = GName;        
        }

        public string getGName()
        {
            return this.gname;
        }

        public void setMName(string MName)
        {
            if (MName.Length > 30)
            {
                Exception tmpex = new Exception("Maximum length of 30 characters");
                throw tmpex;
            }
            this.mname = MName;
        }

        public string getMName()
        {
            return this.mname;
        }

        public void setLName(string LName)
        {
            if (LName.Length > 30)
            {
                Exception tmpex = new Exception("Maximum length of 30 characters");
                throw tmpex;
            }
            this.lname = LName;
        }

        public string getLName()
        {
            return this.lname;
        }

        public void setIDNum(string IDNum)
        {
            int id = 0;
            if (IDNum.Length > 8)
            {
                Exception tmpex = new Exception("Maximum length is 8");
                throw tmpex;
            }
            else
            {
                try
                {
                    id = int.Parse(IDNum);
                }
                catch
                {
                    Exception tmpex = new Exception("Invalid Input");
                    throw tmpex;
                }

                if (id <= 0)
                {
                    Exception tmpex = new Exception("Input positive values for ID Number");
                }

                this.idnum = id;
            }
        }

        public void Add()
        {
            DATAddStudents.AddStudents(idnum, lname, gname, mname);
        }
        
    }

    public class BIZView
    {
        public DataTable view()
        {
            return DATViewStudents.ViewStudents();
        }
    }

    public class BIZDelete
    {
        private int id;
        public void check(string id)
        {
            int ID = 0;
            if (id.Length > 8)
            {
                Exception tmpex = new Exception("Maximum length is 8");
                throw tmpex;
            }
            else 
            {
                try
                {
                    ID = int.Parse(id);
                    if (ID <= 0)
                    {
                        Exception tmpex = new Exception("Input must not be negative");
                        throw tmpex;
                    }
                    this.id = ID;
                }
                catch
                {
                    Exception tmpex = new Exception("Invalid Input");
                    throw tmpex;
                }
            }

        }

        public void Delete()
        {
            DATDeleteStudents.DeleteStudents(id);
        }
    }


}