using System.Text;
using System.Threading.Tasks;
using OLXResaleDALLibrary;
using OLXResale;

namespace OLXResaleUserBLLLibrary
{
    public class UserBLL
    {
        OLXResaleDAL userdal;
        public UserBLL()
        {
            userdal = new OLXResaleDAL();
        }
        public string checkLogin(string un, string pswrd)
        {
            string usid = null;
            if (un == null || pswrd == null)
                usid = null;
            else
                usid=userdal.CheckLogin(un,pswrd);
            return usid;
        }
        public bool InsertUser(OLXModel user)
        {
            bool bResult = userdal.InsertUserToDatabase(user);
            return bResult;
        }
    }
}