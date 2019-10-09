using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01338717_bonus_assignment
{
    public partial class problem_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                Page.Validate();
                if(Page.IsValid)
                {
                    List<int> working_days = new List<int>();
                    //counter variable with decide day is working day or holiday By default its holiday
                    int counter = 0;
                    //Collect the days off from the user and store the in list
                    foreach (ListItem day in week_days.Items)
                    {
                        //Collect all working days
                        if(day.Selected==true)
                        {
                            working_days.Add(Convert.ToInt32(day.Value));
                        }
                   
                       
                    }
                    //This make easy to work with loop
                    working_days.ToArray();
                    //Now we will change holidays to working days according to user input
                    for (int i=0;i<31;i++)
                    {
                        //Couner variable is to check is its a holiday or work day
                        counter = 0;
                        monthly_summary.InnerHtml += "<br>Oct " + (i + 1) + " is a ";
                        if ((i + 1) % 7 == 0)
                        {
                            monthly_summary.InnerHtml += "Monday!";
                        }
                        else if ((i + 1) % 7 == 1)
                        {
                            monthly_summary.InnerHtml += "Tuesday!";
                        }
                        else if((i+1)%7== 2)
                        {
                            monthly_summary.InnerHtml += "Wednesday!";
                        }
                        else if ((i + 1) % 7 == 3)
                        {
                            monthly_summary.InnerHtml += "Thursday!";
                        }
                        else if ((i + 1) % 7 == 4)
                        {
                            monthly_summary.InnerHtml += "Friday!";
                        }
                        else if ((i + 1) % 7 == 5)
                        {
                            monthly_summary.InnerHtml += "Saturday!";
                        }
                        else if ((i + 1) % 7 == 6)
                        {
                            monthly_summary.InnerHtml += "Sunday!";
                        }
                        //Checking what days are holiday or working day
                        for (int j=0;j<working_days.Count();j++)
                        {
                            if ((i + 1) % 7 == working_days[j])
                            {
                                //if its 1 its working day and 0 means holiday
                                counter = 1;
                            }
                            
                        }
                        //According to counter it will decide whats holiday and whats working days
                        if(counter==1)
                        {
                            monthly_summary.InnerHtml += "  Time to<strong> Work</strong>.";
                        }
                        else
                        {
                            monthly_summary.InnerHtml += " Time to have Fun";
                        }
                        
                    }

                }
            }
        }
    }
}