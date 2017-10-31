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
    public class ExampleHouse
    {

        [DataMember(Order = 1)]
        private string location;

        public string getLocation()
        {
            return location;
        }

        public void setLocation(string location)
        {
            this.location = location;
        }

        [DataMember(Order = 2)]
        private int? areaSize;

        public int? getAreaSize()
        {
            return areaSize;
        }

        public void setAreaSize(int areaSize)
        {
            this.areaSize = areaSize;
        }

        [DataMember(Order = 3)]
        private bool? rent;

        public bool? getRent()
        {
            return rent;
        }

        public void setRent(bool rent)
        {
            this.rent = rent;
        }

        [DataMember(Order = 4)]
        private int? rooms;

        public int? getRooms()
        {
            return rooms;
        }

        public void setRooms(int rooms)
        {
            this.rooms = rooms;
        }


    }
}