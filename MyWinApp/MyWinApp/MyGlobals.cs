using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWinApp
{
    
      static class MyGlobals
        {
            public const string Prefix = "ID_"; // cannot change
            public const string sOrastr = "User Id=rsrir;Password=101171;Data Source=202.143.125.108/fyldb;";// cannot change
           // public string sUserName { get; set; } // can change because not const
            public static string sFYear = ""; // can change because not const
            public static string sUserName = "";

           

            public static int Total = 5; // can change because not const


            public static string orastr { get; set; }
        }
 
}
