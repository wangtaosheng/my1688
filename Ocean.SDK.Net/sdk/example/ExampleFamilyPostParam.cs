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
    public class ExampleFamilyPostParam : Request
    {

        public ExampleFamilyPostParam()
        {
            OceanApiId.NamespaceValue = "api.example";
            OceanApiId.Name = "example.family.post";
            OceanApiId.Version = 1;
        }

        [DataMember(Order = 1)]
        private ExampleFamily family;

        /// <summary>
        /// @return 上传Family对象信息
        /// </summary>
        /// <returns></returns>
        public ExampleFamily getFamily()
        {
            return family;
        }

        /// <summary>
        /// 设置上传Family对象信息
        /// </summary>
        /// <param name="family"></param>
        public void setFamily(ExampleFamily family)
        {
            this.family = family;
        }

        [DataMember(Order = 2)]
        private string comments;

        /// <summary>
        /// @return 备注信息
        /// </summary>
        /// <returns></returns>
        public string getComments()
        {
            return comments;
        }

        /// <summary>
        /// 设置备注信息
        /// </summary>
        /// <param name="comments"></param>
        public void setComments(string comments)
        {
            this.comments = comments;
        }

        [DataMember(Order = 3)]
        private byte[] houseImg;

        /// <summary>
        /// @return 房屋信息
        /// </summary>
        /// <returns></returns>
        public byte[] getHouseImg()
        {
            return houseImg;
        }

        /// <summary>
        /// 设置房屋信息
        /// </summary>
        /// <param name="houseImg"></param>
        public void setHouseImg(byte[] houseImg)
        {
            this.houseImg = houseImg;
        }


    }
}