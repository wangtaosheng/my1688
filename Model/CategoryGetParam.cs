using com.alibaba.openapi.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CategoryGetParam : Request
    {
        public CategoryGetParam()
        {
            OceanApiId = new APIId();
            OceanApiId.NamespaceValue = "com.alibaba.product";
            OceanApiId.Name = "alibaba.category.get";
            OceanApiId.Version = 1;
        }
        private int categoryID;
        public int getCategoryID()
        {
            return categoryID;
        }
        public void setCategoryID(int categoryID)
        {
            this.categoryID = categoryID;
        }

        
        private string webSite;
        public string getWebSite()
        {
            return webSite;
        }
        public void setWebSite(string webSite)
        {
            this.webSite = webSite;
        }
    }
}
