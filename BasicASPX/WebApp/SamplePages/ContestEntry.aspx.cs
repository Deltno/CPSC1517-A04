using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        //if we had a database, the data would be stored there.
        //using this static List<T> is ONLY done in this example because we have no database
        public static List<Entry> ContestEntryCollection;
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            //test Page.IsPostBack to page initialization
            if (!Page.IsPostBack)
            {
                ContestEntryCollection = new List<Entry>();
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //validiate the data coming in
            if (Page.IsValid)
            {

            
            //validate the user checking the terms
                if (Terms.Checked)
                {
                    //  yes: create/load Entry, add to List, display List
                    string firstname = FirstName.Text;
                    string lastname = LastName.Text;
                    string streetaddress1 = StreetAddress1.Text;
                    string streetaddress2 = StreetAddress2.Text;
                    string city = City.Text;
                    string province = Province.Text;
                    string postalcode = PostalCode.Text;
                    string email = EmailAddress.Text;

                    ContestEntryCollection.Add(new Entry(firstname, lastname, streetaddress1, streetaddress2, city, province, postalcode, email));

                    = ContestEntryCollection;
                }
                else
                {
                    //  no: message
                    Message.Text = "You did not agree to the terms of this contest. Entry is denied";
                }            
            }

            

        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            PostalCode.Text = "";
            EmailAddress.Text = "";
            Province.SelectedIndex = 0;
            CheckAnswer.Text = "";
            Terms.Checked = false;


        }
    }
}