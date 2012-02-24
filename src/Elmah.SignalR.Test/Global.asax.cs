﻿using System;
using System.Web;

namespace Elmah.SignalR.Test
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ErrorsStore.Store.LoadSourcesFromConfig(HttpContext.Current);

            //ErrorsStore .Store
            //            .AddSource(
            //            "ElmahR sample erratic application 1",  "The Fool on the Hill")
            //            .AddSource(
            //            "ElmahR sample erratic application 2",  "Lucy in the Sky with Diamonds")
            //            .AddSource(
            //            "ElmahR sample erratic application 3",  "Strawberry Fields Forever");
        }
    }
}