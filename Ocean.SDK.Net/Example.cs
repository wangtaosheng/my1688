using com.alibaba.china.openapi.client.example.param.apiexample;
using com.alibaba.openapi.client;
using com.alibaba.openapi.client.policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean.SDK.Net
{
    public class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example starting....");

            //create the connection information for accessing API server
            ClientPolicy clientPolicy = new ClientPolicy();
            clientPolicy.AppKey = "";
            clientPolicy.SecretKey = "";

            String refreshToken = "ecc43432-87f9-4bd6-b8c0-5a741820c5a2";


            //create an object for handling API request
            SyncAPIClient instance = new SyncAPIClient(clientPolicy);

            //create the API request, here the simple example is retrieve some information from API server. 
            ExampleFamilyGetParam exampleFamilyGetParam = new ExampleFamilyGetParam();
            exampleFamilyGetParam.setFamilyNumber(1);

            //call the API server with request
            ExampleFamilyGetResult exampleFamilyGetResult = instance.send<ExampleFamilyGetResult>(exampleFamilyGetParam);

            //get the result from API server.
            ExampleFamily exampleFamily = exampleFamilyGetResult.getResult();
            Console.WriteLine("exampleFamilyGet:" + exampleFamily.getFather() + " and the name of father is " + exampleFamily.getFather().getName() + ", the birthday of fanther is " + exampleFamily.getFather().getBirthday());



        }
    }
}
