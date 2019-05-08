using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using OLXResale;
using System.Configuration;

namespace OLXResaleDALLibrary
{
    public class OLXResaleDAL
    {
        SqlConnection con;
        SqlCommand cmdLogin;
        SqlCommand cmdInsertUser;
        SqlCommand cmdInsertAddress;
        SqlCommand cmdInsertItem;

        public OLXResaleDAL()
        {
            con = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=Olx;Integrated Security=True");

            cmdInsertUser = new SqlCommand("procUser", con);
            cmdInsertUser.Parameters.Add("@first", SqlDbType.Char, 50);
            cmdInsertUser.Parameters.Add("@last", SqlDbType.Char, 50);
            cmdInsertUser.Parameters.Add("@age", SqlDbType.Int);
            cmdInsertUser.Parameters.Add("@gender", SqlDbType.Char);
            cmdInsertUser.Parameters.Add("@cn", SqlDbType.VarChar, 15);
            cmdInsertUser.Parameters.Add("@usid", SqlDbType.VarChar, 15);
            cmdInsertUser.Parameters.Add("@pswrd", SqlDbType.VarChar, 15);
            cmdInsertUser.Parameters.Add("@email", SqlDbType.VarChar, 30);
            cmdInsertUser.Parameters.Add("@adrs", SqlDbType.VarChar, 30);

            cmdInsertAddress = new SqlCommand("procAddress", con);
            cmdInsertAddress.Parameters.Add("@city", SqlDbType.Char, 50);
            cmdInsertAddress.Parameters.Add("@sublocation", SqlDbType.Char, 50);
            cmdInsertAddress.Parameters.Add("@state", SqlDbType.VarChar, 15);
            cmdInsertAddress.Parameters.Add("@pincode", SqlDbType.VarChar, 15);
            cmdInsertAddress.Parameters.Add("@country", SqlDbType.Char, 20);
            cmdInsertAddress.Parameters.Add("@street", SqlDbType.VarChar, 15);

            cmdInsertItem = new SqlCommand("procItem", con);
            cmdInsertItem.Parameters.Add("@itmname", SqlDbType.Char, 25);
            cmdInsertItem.Parameters.Add("@itmctgryid", SqlDbType.VarChar, 15);
            cmdInsertItem.Parameters.Add("@yearsofusage", SqlDbType.Int);
            cmdInsertItem.Parameters.Add("@itmid", SqlDbType.Int);
            cmdInsertItem.Parameters.Add("@itmimage", SqlDbType.VarChar);
            cmdInsertItem.Parameters.Add("@userid", SqlDbType.VarChar, 15);

            cmdLogin = new SqlCommand("procLogin", con);
            cmdLogin.Parameters.Add("@cn", SqlDbType.VarChar, 15);
            cmdLogin.Parameters.Add("@pswrd", SqlDbType.VarChar, 15);

            cmdInsertUser.CommandType = CommandType.StoredProcedure;
            cmdInsertAddress.CommandType = CommandType.StoredProcedure;
            cmdInsertItem.CommandType = CommandType.StoredProcedure;
            cmdLogin.CommandType = CommandType.StoredProcedure;
        }

        public bool InsertUserToDatabase(OLXModel User)
        {
            bool bInserted = false;
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                cmdInsertUser.Parameters[0].Value = User.First;
                cmdInsertUser.Parameters[1].Value = User.Last;
                cmdInsertUser.Parameters[2].Value = User.Age;
                cmdInsertUser.Parameters[3].Value = User.Gender;
                cmdInsertUser.Parameters[4].Value = User.Cn;
                cmdInsertUser.Parameters[5].Value = User.Usid;
                cmdInsertUser.Parameters[6].Value = User.Pswrd;
                cmdInsertUser.Parameters[7].Value = User.Email;
                cmdInsertUser.Parameters[8].Value = User.Adrs;
                if (cmdInsertUser.ExecuteNonQuery() == 1)
                     bInserted = true; 
            }
            catch (SqlException)
            { 
                bInserted = false; 
            }
            finally
            { 
                con.Close(); 
            }
            return bInserted;
        }

        public bool InsertAddressToDatabase(OLXModel Address)
        {
            bool bInserted = false;
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                cmdInsertAddress.Parameters[0].Value = Address.City;
                cmdInsertAddress.Parameters[1].Value = Address.Sublocation;
                cmdInsertAddress.Parameters[2].Value = Address.State;
                cmdInsertAddress.Parameters[3].Value = Address.Pincode;
                cmdInsertAddress.Parameters[4].Value = Address.Country;
                cmdInsertAddress.Parameters[5].Value = Address.Street;
                if (cmdInsertAddress.ExecuteNonQuery() == 1)
                    bInserted = true;
            }
            catch (SqlException)
            {
                bInserted = false;
            }
            finally
            {
                con.Close();
            }
            return bInserted;
        }

        public bool InsertItemToDatabase(OLXModel Item)
        {
            bool bInserted = false;
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                cmdInsertItem.Parameters[0].Value = Item.Itemname;
                cmdInsertItem.Parameters[1].Value = Item.Itemcategoryid;
                cmdInsertItem.Parameters[2].Value = Item.Yearsofusage;
                cmdInsertItem.Parameters[3].Value = Item.Itemid;
                cmdInsertItem.Parameters[4].Value = Item.Image;
                cmdInsertItem.Parameters[5].Value = Item.Userid;
                if (cmdInsertItem.ExecuteNonQuery() == 1)
                    bInserted = true;
            }
            catch (SqlException)
            {
                bInserted = false;
            }
            finally
            {
                con.Close();
            }
            return bInserted;
        }
        public string CheckLogin(string un, string pass)
        {
            string userid = null;
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Open();
            cmdLogin.Parameters[0].Value = un;
            cmdLogin.Parameters[1].Value = pass;
            userid = cmdLogin.ExecuteScalar().ToString();
            return userid;
        }
    }
}