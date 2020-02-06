using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestFulClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Restful客户端Demo测试";

            RestClient client = new RestClient();
            client.EndPoint = @"http://localhost:8080/changetopinyin";

            client.Method = EnumHttpVerb.PUT;
            string resultGet = client.HttpRequest("?hanzi=沈楷");
            Console.WriteLine("PUT方式获取结果：" + resultGet);

           
        }
    }

    [Serializable]
    public class Info
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}