using System;

namespace RESTtemperatureConsumer
{
    class Program
    {
        static void Main()
        {
            string uri = "https://simonappservice.azurewebsites.net/api/Temp";
            for (int i = 0; i < 10; i++)
            {
                Temp t = new Temp { Temperatur = "5" + i };
                Temp addedTemp = RESTClient.Post<Temp, Temp>(uri, t).Result;
                Console.WriteLine("temp: " + addedTemp);
                // Pt har jeres REST POST en tom response body.
                // bedre hvis den har Temp objekt i body
            }
        }
    }
}
