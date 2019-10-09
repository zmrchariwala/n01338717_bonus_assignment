using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01338717_bonus_assignment
{
    public partial class problem_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                Page.Validate();
                if(Page.IsValid)
                {
                    int X_axis = Convert.ToInt32(x_axis.Text.ToString());
                    int Y_axis = Convert.ToInt32(y_axis.Text.ToString());
                    graph_summary.InnerHtml = "";
                    //Check where your co-ordinates lies
                    if (X_axis > 0 && Y_axis > 0)
                    {
                        graph_summary.InnerHtml += "("+X_axis + "," + Y_axis + ") fall in Quadrant 1"; 
                    }
                    else if(X_axis < 0 && Y_axis > 0)
                    {
                        graph_summary.InnerHtml += "(" + X_axis + "," + Y_axis + ") fall in Quadrant 2";
                    }
                    else if (X_axis < 0 && Y_axis < 0)
                    {
                        graph_summary.InnerHtml += "(" + X_axis + "," + Y_axis + ") fall in Quadrant 3";
                    }
                    else if (X_axis > 0 && Y_axis < 0)
                    {
                        graph_summary.InnerHtml += "(" + X_axis + "," + Y_axis + ") fall in Quadrant 4";
                    }
                    else if(X_axis == 0 && Y_axis != 0)
                    {
                        graph_summary.InnerHtml += "Your X point lies on X axis";
                    }
                    else if(Y_axis == 0 && X_axis !=0)
                    {
                        graph_summary.InnerHtml += "Your Y point lies on Y axis";
                    }
                    else if(X_axis == 0 && Y_axis == 0)
                    {
                        graph_summary.InnerHtml += "Both your point are 0 so its ambiguos";
                    }
                    else
                    {
                        graph_summary.InnerHtml += "Oops something went wrong";
                    }
                }
            }
        }
    }
}