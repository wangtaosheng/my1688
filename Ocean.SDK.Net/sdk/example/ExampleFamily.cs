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
    public class ExampleFamily
    {

        [DataMember(Order = 1)]
        private int? familyNumber;

        /// <summary>
        /// return 家庭编号
        /// </summary>
        /// <returns></returns>
        public int? getFamilyNumber()
        {
            return familyNumber;
        }

        /// <summary>
        /// 设置家庭编号
        /// </summary>
        /// <param name="familyNumber"></param>
        public void setFamilyNumber(int familyNumber)
        {
            this.familyNumber = familyNumber;
        }

        [DataMember(Order = 2)]
        private ExamplePerson father;

        /// <summary>
        /// return 父亲对象，可以为空
        /// </summary>
        /// <returns></returns>
        public ExamplePerson getFather()
        {
            return father;
        }

        /// <summary>
        /// 设置父亲对象，可以为空
        /// </summary>
        /// <param name="father"></param>
        public void setFather(ExamplePerson father)
        {
            this.father = father;
        }

        [DataMember(Order = 3)]
        private ExamplePerson mother;

        /// <summary>
        /// return 母亲对象，可以为空
        /// </summary>
        /// <returns></returns>
        public ExamplePerson getMother()
        {
            return mother;
        }

        /// <summary>
        /// 设置母亲对象，可以为空
        /// </summary>
        /// <param name="mother"></param>
        public void setMother(ExamplePerson mother)
        {
            this.mother = mother;
        }

        [DataMember(Order = 4)]
        private ExamplePerson[] children;
        /// <summary>
        /// return 孩子列表
        /// </summary>
        /// <returns></returns>
        public ExamplePerson[] getChildren()
        {
            return children;
        }

        /// <summary>
        /// 设置孩子列表
        /// </summary>
        /// <param name="children"></param>
        public void setChildren(ExamplePerson[] children)
        {
            this.children = children;
        }

        [DataMember(Order = 5)]
        private ExampleCar[] ownedCars;

        /// <summary>
        /// return 拥有的汽车信息
        /// </summary>
        /// <returns></returns>
        public ExampleCar[] getOwnedCars()
        {
            return ownedCars;
        }

        /// <summary>
        /// 设置拥有的汽车信息
        /// </summary>
        /// <param name="ownedCars"></param>
        public void setOwnedCars(ExampleCar[] ownedCars)
        {
            this.ownedCars = ownedCars;
        }

        [DataMember(Order = 6)]
        private ExampleHouse myHouse;

        /// <summary>
        /// return 所住的房屋信息
        /// </summary>
        /// <returns></returns>
        public ExampleHouse getMyHouse()
        {
            return myHouse;
        }

        /// <summary>
        /// 设置所住的房屋信息
        /// </summary>
        /// <param name="myHouse"></param>
        public void setMyHouse(ExampleHouse myHouse)
        {
            this.myHouse = myHouse;
        }


    }
}