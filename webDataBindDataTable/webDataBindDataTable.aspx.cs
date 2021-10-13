using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace webDataBindDataTable
{
    public partial class webDataBindDataTable : System.Web.UI.Page
    {
        //Static You cannot create Objects of Any static class and cannot access members(properties + methods)
        // using an Object;

        //Why use Static? : The compiler can check to make sure that no instance are accidentally added!




        static DataTable myTb;

       
        protected void Page_Load(object sender, EventArgs e)
        {

            myTb = CreateTable();

            if (!Page.IsPostBack)
            {

                lstCourses.DataTextField = "Number";
                lstCourses.DataSource = myTb;
                lstCourses.DataBind();


                cboTeachers.DataTextField = "Teacher";
                cboTeachers.DataSource = myTb;
                cboTeachers.DataBind();

                gridResults.DataSource = myTb;
                gridResults.DataBind();

            }

        }

        private static DataTable CreateTable()
        {

            //Creating Table
            DataTable myTb = new DataTable("Courses");

            //Creating columns of Table(DB)
            myTb.Columns.Add("Number", typeof(string));
            myTb.Columns.Add("Title", typeof(string));
            myTb.Columns.Add("Duration", typeof(Int32));
            myTb.Columns.Add("Teacher", typeof(string));

            //Creating Rows
            DataRow myRow = myTb.NewRow();
            myRow["Number"] = "420-P16-AS";
            myRow["Title"] = "Structured Programming";
            myRow["Duration"] = 70;
            myRow["Teacher"] = "Quang Hoang Cao";
            myTb.Rows.Add(myRow);

            myRow = myTb.NewRow();
            myRow["Number"] = "420-P25-AS";
            myRow["Title"] = "Object Oriented Programming";
            myRow["Duration"] = 90;
            myRow["Teacher"] = "Houria Houmel";
            myTb.Rows.Add(myRow);

            myRow = myTb.NewRow();
            myRow["Number"] = "420-P36-AS";
            myRow["Title"] = "Advanced Object Oriented Programming";
            myRow["Duration"] = 90;
            myRow["Teacher"] = "Fode Toure";
            myTb.Rows.Add(myRow);

            myRow = myTb.NewRow();
            myRow["Number"] = "420-S101-AS";
            myRow["Title"] = "Information Systems";
            myRow["Duration"] = 90;
            myRow["Teacher"] = "Nariman Mansour";
            myTb.Rows.Add(myRow);

            myRow = myTb.NewRow();
            myRow["Number"] = "420-P69-AS";
            myRow["Title"] = "Structured Programming";
            myRow["Duration"] = 90;
            myRow["Teacher"] = "Mohammed Zaroug";
            myTb.Rows.Add(myRow);

            return myTb;

        }

        protected void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach(DataRow myRow in myTb.Rows)
            {
                if(myRow["Number"].ToString() == lstCourses.SelectedItem.Text)
                {
                    txtNumber.Text = myRow["Number"].ToString();
                    txtTitle.Text = myRow["Title"].ToString();
                    txtDuration.Text = myRow["Duration"].ToString();
                    txtTeacher.Text = myRow["Teacher"].ToString();
                    break;
                }
            }
           
        }

        protected void cboTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable tb = myTb.Clone();

            foreach(DataRow item in myTb.Rows)
            {
                if (item["Teacher"].ToString() == cboTeachers.SelectedItem.Text)
                {
                    tb.ImportRow(item);
                }
            }

            gridResults.DataSource = tb;
            gridResults.DataBind();

        }

        protected void gridResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}