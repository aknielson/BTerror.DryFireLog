﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTerror.DryFireLog.DataLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new DryFireLogModelContext();

            var aaa = ctx.Books.ToList();
            Console.WriteLine(aaa.FirstOrDefault().Title);

            //will this make it to github?
            //will this also make it to github?
            //add one more time


        }
    }
}
