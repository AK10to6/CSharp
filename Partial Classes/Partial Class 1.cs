using System;


namespace Partial_Classes
{
    public partial class Customer               //Partial class Part
    {
        private string _fname;
        private string _lname;

        public string Fname { 
            get { return _fname; }
            set { _fname = value; }
        }

        public string Lname
        {
            get { return _lname; }
            set { _lname = value; }
        }

        partial void PartialMethod();           //Partial Method Declaration
    }
}
