using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Die
    {
        //Data Members
        //usually private 
        private int _Side;
        private string _Color;
        

        //Properties
        // are responsible to assigning and retrieving data
        //    to/from their associated data member
        // retrieving data from a data member uses the get{}
        // assigning data to a data member uses the set {}
        // properties need to be exposed to outside users
        // properties will have a return datatype BUT no parameter list
        
        //Fully Implemented Property
        //has a defined Data Member that the developer
        //   can directly access.
        public int Side
        {
            get
            {
                //returns data of a specific datatype
                return _Side;
            }
            set
            {
                //assigns a supplied value to the data member
                //the supplied value is located in the key word: value
                //optionally include data value validation to ensure
                //     an appropriate value has been supplied
                if (value >= 6 && value <= 20 )
                {
                    //this is an acceptable value to keep
                    _Side = value;
                }
                else
                {
                    //this is an unacceptable value
                    //issue a user friendly error messge
                    throw new Exception("Die cannot be " + value.ToString() + " sided. Die must be between 6 and 20 sided.");
                }
                
            }
        }

        //Auto Implemented Property
        //NO Data Member definition
        //the data member is internally created for you
        //the data member datatype is take from your return datatype
        //    specified on the Property header
        //auto implemented properties are usually used when there
        //    is no need to internal validation
        //access to a value managed by an auto implemented property
        //    MUST be done via the property
        public int FaceValue { get; set; } 


    }
}
