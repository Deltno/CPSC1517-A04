using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class DDL
    {
        public int ValueField { get; set; }
        public string Displayfield { get; set; }
        public DDL()
        {
            //default
        }
        public DDL(int valueField, string displayField)
        {
            ValueField = valueField;
            Displayfield = displayField;
        }
    }
}