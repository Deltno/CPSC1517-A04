﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
//the annotations used within the .Data project will require the System.ComponentModel.DataAnnotation assembly
//This assembly is added via your References
#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace NorthwindSystem.Data
{
    //use an annotation to link this class to the appropriate SQL table
    [Table("Products")]
    public class Product
    {
        //mapping of the SQL Table Attribute will be to class properties
        private string _QuantityPerUnit;

        //use an annotation to identify the primary key
        //  1) identity pkey on your sql table
        //      [Key] pkey must end in ID or Id
        //  2) a compound pkey on your sql table
        //      [Key, Column(Order=n)] where n is the natural number indicating the physical order of the attribute in the pkey
        //  3) a user supplied pkey
        //      [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        public string QuantityPerUnit
        {
            get
            {
                return _QuantityPerUnit;
            }
            set
            {
                _QuantityPerUnit = string.IsNullOrEmpty(value.Trim()) ? null : value;
            }
        }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        //sample of a computed field on your SQL
        //To annotate this property to be taken as a sql computed field use
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public decimal Total { get; set; }

        //sample creating a read only property that is NOT an actual field on your SQL field
        //Example: firstname Lastname attributes are often combined into a single field for display purposes: Fullname
        //use the NotMapped annotation to handle this

        //    [NotMapped]
        //public string FullName
        //{
        //    get FirstName + " " + LastName;
        //}

    }
}
