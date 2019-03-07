﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        //this static variable is being used in this demo example to hang unto the dummy data
        public static List<DDL> DataCollection;
        protected void Page_Load(object sender, EventArgs e)
        {
            //this event method is executed EACH and EVERY time this page is processed
            //this event is executed BEFORE ANY EVENT method is processed

            //clear out all old messages
            OutputMessage.Text = "";

            //this page is an excellent place ot do page initialization of your controls.
            //there is a property to test for post back of your page called Page.IsPostBack (Razor: IsPost)
            if (!Page.IsPostBack)
            {
                //do 1st page initialization processing
                //create an instance of the data collection list
                DataCollection = new List<DDL>();

                //load the data collection with dummy data, normally this data would come from your database
                DataCollection.Add(new DDL(1, "COMP1008"));
                DataCollection.Add(new DDL(2, "CPSC1517"));
                DataCollection.Add(new DDL(3, "DMIT2018"));
                DataCollection.Add(new DDL(4, "DMIT1508"));

                //to sort a List<T> use the method .Sort()
                //(x,y) x and y represent any two instances in your list at any time
                //x.field compared to y.field : ascending
                //y.field compared to x.field : descending
                DataCollection.Sort((x,y) => x.Displayfield.CompareTo(y.Displayfield));

                //setup the dropdownlist (radiobuttonlist, checkboxlist)
                //a) allign you data to the control
                CollectionList.DataSource = DataCollection;

                //b) assign the data list field names to the appropriate control properties
                // 1) .DataValueField = the value of the select option
                // 2) .DataTextField = the display of the select option
                CollectionList.DataValueField = "ValueField";
                CollectionList.DataTextField = nameof(DDL.Displayfield);

                //c) physically bind the data to the control for show
                CollectionList.DataBind();

                //what about a prompt?
                //one can add a prompt to the start of the BOUND control list
                //one will use the index 0 to position the prompt
                CollectionList.Items.Insert(0, "select ...");
            }
        }

        protected void SubMitButton_Click(object sender, EventArgs e)
        {
            //this method is executed when the submit button is pressed
            //this method is concerned with the actions needed for the submit button

            //to access the data of a control, you use the appropriate control (object) property (get, set) and access technique
            //for TextBox, Label, Literal use .Text
            //for a list (DropDownList, RadioButtonList) use one of
            //      .SelectedIndex  - the physical location of the item in the list
            //      .SelectedValue  - the associated data value of the item in the list
            //      .SelectedItem   - the associated data display text of the item in the list

            //for boolean controls (RadioButton, Checkbox) use .Checked

            //most controls will use strings except for boolean controls 

            string submitChoice = TextBoxNumericChoice.Text;

            //sample validation
            if (string.IsNullOrEmpty(submitChoice))
            {
                OutputMessage.Text = "Enter a course choice of 1 to 4";
            }
            else
            {
                //set the RadioButtonLisrt using the entered data value
                //property: .SelectedValue
                RadioButtonListChoice.SelectedValue = submitChoice;

                //set the checkbox to on if the choice was a programming language
                if (submitChoice.Equals("2") || submitChoice.Equals("3"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }

                //position in the dropdownlist
                //use the entered data value to position
                //property: .SelectedValue
                CollectionList.SelectedValue = submitChoice;

                //demonstrate the 3 different access techniques for a list
                //outpit will be to a label (appearance will be read only)
                DisplayReadOnly.Text = CollectionList.SelectedItem.Text
                    + " at index "
                    + CollectionList.SelectedIndex
                    + " has a value of "
                    + CollectionList.SelectedValue;

            }
        }
    }
}