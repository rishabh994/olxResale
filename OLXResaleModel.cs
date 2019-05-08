using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLXResale
{
    public class OLXModel
    {
        string first, last;
        int age; string gender;
        string cn, usid, pswrd, email, adrs;
        string city, sublocation, country, street, pincode;
        int state;
        string itemname;
        string itemcategoryid;
        int yearsofusage;
        int itemid;
        string image;
        string userid;

        public string Last
        {
            get { return last; }
            set { last = value; }
        }

        public string First
        {
            get { return first; }
            set { first = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public string Adrs
        {
            get { return adrs; }
            set { adrs = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Pswrd
        {
            get { return pswrd; }
            set { pswrd = value; }
        }

        public string Usid
        {
            get { return usid; }
            set { usid = value; }
        }

        public string Cn
        {
            get { return cn; }
            set { cn = value; }
        }



        public string Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }

        public int State
        {
            get { return state; }
            set { state = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Sublocation
        {
            get { return sublocation; }
            set { sublocation = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }



        public string Itemname
        {
            get { return itemname; }
            set { itemname = value; }
        }




        public string Itemcategoryid
        {
            get { return itemcategoryid; }
            set { itemcategoryid = value; }
        }



        public int Yearsofusage
        {
            get { return yearsofusage; }
            set { yearsofusage = value; }
        }



        public int Itemid
        {
            get { return itemid; }
            set { itemid = value; }
        }



        public string Image
        {
            get { return image; }
            set { image = value; }
        }


        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }
    }
}