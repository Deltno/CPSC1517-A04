using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this class needs to have access to ADD.Net EntityFramework
//The Nuget package EntryFramework has already been added to this project
//this project also needs the assembly System.Data.Entity
//this project will need using clauses that point to
//  a) the System.Data.Entity namespace
//  b) your data project namespace
#region Additional Namespaces
using System.Data.Entity;
using NorthwindSystem.Data;
#endregion
namespace NorthwindSystem.DAL
{
    //the class access internal restricts calls to this class to methods within this project
    //this context class needs to inherit DBContext from Entity framework

    internal class NorthwindContext:DbContext
    {
        //setup your class constructor to supply your connection string name to the DBContext inherit class
        public NorthwindContext():base("NWDB")
        {

        }

        //Create a EntityFramework DBSet<T> for each mapped SQL table
        // <T> is your class in the .Data project
        public DbSet<Product> Products { get; set; }
    }
}
