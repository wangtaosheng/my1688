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
    public class ExampleFamilyPostResult
    {

        [DataMember(Order = 1)]
        private ExampleFamily result;

        /// <summary>
        /// @return 返回的接听信息
        /// </summary>
        /// <returns></returns>
        public ExampleFamily getResult()
        {
            return result;
        }

        /// <summary>
        /// 设置返回的接听信息
        /// </summary>
        /// <param name="result"></param>
        public void setResult(ExampleFamily result)
        {
            this.result = result;
        }

        [DataMember(Order = 2)]
        private string resultDesc;

        /// <summary>
        /// @return 返回结果描述
        /// </summary>
        /// <returns></returns>
        public string getResultDesc()
        {
            return resultDesc;
        }

        /// <summary>
        /// 设置返回结果描述
        /// </summary>
        /// <param name="resultDesc"></param>
        public void setResultDesc(string resultDesc)
        {
            this.resultDesc = resultDesc;
        }


    }
}