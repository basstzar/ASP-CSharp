using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace member
{
    public class member
    {
        string oFirst_name, oLast_name, oAddress, oCity, oState, oZip, oPhone, oType_member;
   
        public string first_name
        {
            get
            {
                return oFirst_name;
            }
            set
            {
                oFirst_name = value;
            }
        }

        public string last_name
        {
            get
            {
                return oLast_name;
            }
            set
            {
                oLast_name = value;
            }
        }

        public string address
        {
            get
            {
                return oAddress;
            }
            set
            {
                oAddress = value;
            }
        }

        public string city
        {
            get
            {
                return oCity;
            }
            set
            {
                oCity = value;
            }
        }

        public string state
        {
            get
            {
                return oState;
            }
            set
            {
                oState = value;
            }
        }

        public string zip
        {
            get
            {
                return oZip;
            }
            set
            {
                oZip = value;
            }
        }

        public string phone
        {
            get
            {
                return oPhone;
            }
            set
            {
                oPhone = value;
            }
        }

        public string type_member
        {
            get
            {
                return oType_member;
            }
            set
            {
                oType_member = value;
            }
        }
    }
}
