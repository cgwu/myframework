using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceDynamicURLDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //带网址的WebService
            PdaWebSrv.PdaWebSrvSoapClient pda = new PdaWebSrv.PdaWebSrvSoapClient("PdaWebSrvSoap", "http://xxx.com/PdaWebSrv.asmx");

            string member = "jl000";
            string password = "000000";

            string errorMsg = "";
            int agent_id = 0;
            int iRet = pda.ETLoginNoEnc(ref errorMsg, member, password, ref agent_id);

            Console.WriteLine(iRet);

            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
