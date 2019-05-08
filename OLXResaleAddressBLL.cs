using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLXResaleDALLibrary;
using OLXResale;

namespace OLXResaleAddressBLLLibrary
{
    public class AddressBLL
    {
        OLXResaleDAL adrsdal;
        public AddressBLL()
        {
            adrsdal = new OLXResaleDAL();
        }
        public bool InsertAddress(OLXModel address)
        {
            bool bResult = adrsdal.InsertAddressToDatabase(address);
            return bResult;
        }
    }
}