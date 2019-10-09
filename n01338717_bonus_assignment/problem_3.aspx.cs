using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01338717_bonus_assignment
{
    public partial class problem_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                Page.Validate();
                if(Page.IsValid)
                {
                    //declare some required variables
                    //for number of tickets purchased
                    int number_of_tickets = Convert.ToInt32(tickets_quantity.Text.ToString());
                    //To calculate total amount of purchased tickets
                    double total_price = 0;
                    //Cost of 1 ticket
                    double individual_ticket_price = 0.25;
                    //This variable is for left over tickets
                    int left_over_tickets = 0;
                    summary.InnerHtml = "";
                    //Check how many purchased tickets
                    if(number_of_tickets > 0 && number_of_tickets <= 50)
                    {
                        for(int i=1;i<=number_of_tickets;i++)
                        {
                            summary.InnerHtml += "<br>You recieved bundle of 1! That's " + i + " Tickect(s)!";
                        }
                        total_price = number_of_tickets * individual_ticket_price;
                        summary.InnerHtml += "<br> Your total ticket(s) is "+number_of_tickets+" and you cost is $"+total_price+"cad";
                    }
                    else if(number_of_tickets >50 && number_of_tickets <= 150)
                    {
                        left_over_tickets = 0;
                        for (int i = 2; i <= number_of_tickets; i=i+2)
                        {
                            summary.InnerHtml += "<br>You recieved bundle of 2! That's " + i + " Tickect(s)!";
                            left_over_tickets = i;
                        }
                        left_over_tickets = number_of_tickets - left_over_tickets;
                        if(left_over_tickets!=0)
                        {
                            summary.InnerHtml += "<br>Your left over is " + left_over_tickets + "thats " + (number_of_tickets) + "ticket(s)";
                        }
                        total_price = number_of_tickets * individual_ticket_price;
                        summary.InnerHtml += "<br> Your total ticket(s) is " + number_of_tickets + " and you cost is $" + total_price+"cad";
                    }
                    else if(number_of_tickets>150 && number_of_tickets <=300)
                    {
                        left_over_tickets = 0;
                        for (int i = 3; i <= number_of_tickets; i = i + 3)
                        {
                            summary.InnerHtml += "<br>You recieved bundle of 3! That's " + i + " Tickect(s)!";
                            left_over_tickets = i;
                        }
                        left_over_tickets = number_of_tickets - left_over_tickets;
                        if (left_over_tickets != 0)
                        {
                            summary.InnerHtml += "<br>Your left over is " + left_over_tickets + " thats " + (number_of_tickets) + "ticket(s)";
                        }
                        total_price = number_of_tickets * individual_ticket_price;
                        summary.InnerHtml += "<br> Your total ticket(s) is " + number_of_tickets + " and you cost is $" + total_price+"cad!";
                    }
                    else if(number_of_tickets>300)
                    {
                        left_over_tickets = 0;
                        for (int i = 5; i <= number_of_tickets; i = i + 5)
                        {
                            summary.InnerHtml += "<br>You recieved bundle of 5! That's " + i + " Tickect(s)!";
                            left_over_tickets = i;
                        }
                        left_over_tickets = number_of_tickets - left_over_tickets;
                        if (left_over_tickets != 0)
                        {
                            summary.InnerHtml += "<br>Your left over is " + left_over_tickets + " thats " + (number_of_tickets) + "ticket(s)";
                        }
                        total_price = number_of_tickets * individual_ticket_price;
                        summary.InnerHtml += "<br> Your total ticket(s) is " + number_of_tickets + " and you cost is $" + total_price + "cad!";
                    }
                    else
                    {
                        //If user enter in negative value or 0
                        summary.InnerHtml += "Entered number of tickets is not valid";
                    }
                }
            }
        }
    }
}