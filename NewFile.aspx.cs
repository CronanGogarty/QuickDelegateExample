﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewFile : System.Web.UI.Page
{
   

    protected void Page_Load(object sender, EventArgs e)
    {
        //choose the event handler that will handle the .Click event when fired by cmdClickDelegate
        cmdClickDelegate.Click += cmdClickDelegate_Click;

        //the .Click event subscribes to the anonymous delegate which handles the event inline
        cmdClickAnonymousDelegate.Click += delegate(object s, EventArgs arrrggg)
        {
            lblMessage.Text = "Anonymous delegate example";
        };

        if (!Page.IsPostBack)
        {
            //do some stuff
            List<string> animals = new List<string>();
            animals.Add("Dog");
            animals.Add("Cat");
            animals.Add("Racoon");
        }
    }
    protected void cmdClickDelegate_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "Hellow Worddld - Haouuuww aaaaarrr ya?";
    }

    //protected void cmdClickAnonymousDelegate(object sender, EventArgs e)
    //{
    //    lblMessage.Text = "Anonymous delegate example";
    //}
}