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
    public class ExamplePerson
    {

        [DataMember(Order = 1)]
        private string name;

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        [DataMember(Order = 2)]
        private int? age;

        public int? getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        [DataMember(Order = 3)]
        private string birthday;

        public DateTime? getBirthday()
        {
            if (birthday != null)
            {
                DateTime datetime = DateUtil.formatFromStr(birthday);
                return datetime;
            }
            return null;
        }

        public void setBirthday(DateTime birthday)
        {
            this.birthday = DateUtil.format(birthday);
        }

        [DataMember(Order = 4)]
        private string mobileNumber;

        public string getMobileNumber()
        {
            return mobileNumber;
        }

        public void setMobileNumber(string mobileNumber)
        {
            this.mobileNumber = mobileNumber;
        }


    }
}