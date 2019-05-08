using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OLXResaleDALLibrary;
using OLXResale;

namespace OLXResaleItemsBLLLibrary
{
    public class ItemsBLL
    {
        OLXResaleDAL itemdal;
        public ItemsBLL()
        {
            itemdal = new OLXResaleDAL();
        }
        public bool InsertItem(OLXModel item)
        {
            bool bResult = itemdal.InsertItemToDatabase(item);
            return bResult;
        }
    }
}