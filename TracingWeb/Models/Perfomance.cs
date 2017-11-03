using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TracingWeb.Models
{
    public class Perfomance
    {
        public static long Count;
        public static Stack<string> AvailName;
        public static string[] Names;

        public static void Init()
        {
            Count = 0;
            Names = new string[500];
            for (int i = 0; i < 500; i++)
            {
                Names[i] = "May" + i;
            }
            AvailName = new Stack<string>(Names);
            
        }
    }
}