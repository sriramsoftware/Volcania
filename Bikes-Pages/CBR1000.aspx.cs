﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Bikes_Pages_CBR1000 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Session["a"] = Label1.Text;
        Session["a1"] = Label2.Text;
        Response.Redirect("http://localhost:49347/volcania/BikeBooking.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Panel3.BackImageUrl = "http://localhost:49347/volcania/BikeImages/nonsports/CBR1000RR-PearlWhiteBlueRed.jpg";
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Panel3.BackImageUrl = "http://localhost:49347/volcania/BikeImages/nonsports/CBR1000RR-Black.jpg";
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Panel3.BackImageUrl = "http://localhost:49347/volcania/BikeImages/nonsports/CBR1000RR-Red.jpg";
    }
}