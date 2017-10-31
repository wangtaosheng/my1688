using com.alibaba.openapi.client;
using com.alibaba.openapi.client.primitive;
using com.alibaba.openapi.client.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace com.alibaba.china.openapi.client.example.param.apiexample
{
    [DataContract(Namespace = "com.alibaba.openapi.client")]
    public class ExampleFamilyGetParam : Request
    {

        public ExampleFamilyGetParam()
        {
            OceanApiId = new APIId();
            OceanApiId.NamespaceValue = "api.example";
            OceanApiId.Name = "example.family.get";
            OceanApiId.Version = 1;
        }

        [DataMember(Order = 1)]
        private int? familyNumber;

        /// <summary>
        /// @return 可接受参数1或者2，其余参数无法找到family对象
        /// </summary>
        /// <returns></returns>
        public int? getFamilyNumber()
        {
            return familyNumber;
        }

        /// <summary>
        /// 设置可接受参数1或者2，其余参数无法找到family对象   
        /// </summary>
        /// <param name="familyNumber"></param>
        public void setFamilyNumber(int familyNumber)
        {
            this.familyNumber = familyNumber;
        }


    }
}