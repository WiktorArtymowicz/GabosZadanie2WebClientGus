using System;
using System.Dynamic;
using System.Threading.Tasks;
using GUSService;

namespace GabosZadanie2WebClientGus
{
    class Program
    {
        public static void Main()
        { 
            UslugaBIRzewnPublClient uslugaBIRzewnPublClient = new UslugaBIRzewnPublClient();
            uslugaBIRzewnPublClient.ZalogujAsync("abcde12345abcde12345");
            Task <DaneSzukajPodmiotyResponse> response = uslugaBIRzewnPublClient.DaneSzukajPodmiotyAsync(new ParametryWyszukiwania { Nip = "6452521870" });

            Console.WriteLine(response.Result.DaneSzukajPodmiotyResult);
        }
    }
}
