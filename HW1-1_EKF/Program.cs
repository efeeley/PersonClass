using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 7/2/2012
 * Assignment: HW1-1_EKF (Test Person)
 * Resources: N/A
 * ***********************************/

namespace HW1_1_EKF
{
    public class Person
    {
        //Attributes
        private String strName;
        private String strAddress;


        //Methods
        public Person()
        {
            strAddress = "I don't know";
        }//end constructor

        public String Name
        {
            get { return strName; }
            set { strName = value; }
        }//public String Name

        public String Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }//end public String Address

    }//end class Person

}//end namespace HW1-1_EKF
