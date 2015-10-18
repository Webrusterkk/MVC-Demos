using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ValidDemo.MyAnnotation
{
    public class DateCheckAttribute: RangeAttribute
    {
        public DateCheckAttribute(string min):base(typeof(DateTime),min, System.DateTime.Now.ToShortDateString().ToString())
        {

        }
    }
}