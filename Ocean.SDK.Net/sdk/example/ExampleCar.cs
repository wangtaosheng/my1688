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
    public class ExampleCar
    {

        [DataMember(Order = 1)]
        private string builtDate;


        public DateTime? getBuiltDate()
        {
            if (builtDate != null)
            {
                DateTime datetime = DateUtil.formatFromStr(builtDate);
                return datetime;
            }
            return null;
        }


        public void setBuiltDate(DateTime builtDate)
        {
            this.builtDate = DateUtil.format(builtDate);
        }

        [DataMember(Order = 2)]
        private string boughtDate;


        public DateTime? getBoughtDate()
        {
            if (boughtDate != null)
            {
                DateTime datetime = DateUtil.formatFromStr(boughtDate);
                return datetime;
            }
            return null;
        }


        public void setBoughtDate(DateTime boughtDate)
        {
            this.boughtDate = DateUtil.format(boughtDate);
        }

        [DataMember(Order = 3)]
        private string name;


        public string getName()
        {
            return name;
        }


        public void setName(string name)
        {
            this.name = name;
        }

        [DataMember(Order = 4)]
        private string builtArea;


        public string getBuiltArea()
        {
            return builtArea;
        }


        public void setBuiltArea(string builtArea)
        {
            this.builtArea = builtArea;
        }

        [DataMember(Order = 5)]
        private string carNumber;


        public string getCarNumber()
        {
            return carNumber;
        }


        public void setCarNumber(string carNumber)
        {
            this.carNumber = carNumber;
        }

        [DataMember(Order = 6)]
        private double? price;


        public double? getPrice()
        {
            return price;
        }


        public void setPrice(double price)
        {
            this.price = price;
        }

        [DataMember(Order = 7)]
        private int? seats;


        public int? getSeats()
        {
            return seats;
        }


        public void setSeats(int seats)
        {
            this.seats = seats;
        }


    }
}