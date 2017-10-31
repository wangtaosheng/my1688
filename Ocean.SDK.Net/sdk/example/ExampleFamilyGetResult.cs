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
    public class ExampleFamilyGetResult
    {

        [DataMember(Order = 1)]
        private ExampleFamily result;

        public ExampleFamily getResult()
        {
            return result;
        }

        public void setResult(ExampleFamily result)
        {
            this.result = result;
        }


    }
}