using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCarService;

namespace TestCarService
{
    class Program
    {
        static void Main(string[] args)
        {
            CarServiceAPI test = new CarServiceAPI();
            Client client = new Client()
            {
                ClientId = 1,
                Nume = "luca",
                Prenume = "gean",
                Adresa = "strada Luca Arbore",
                Localitate = "iasi",
                Judet = "iasi",
                Telefon = "1234567890",
            };
            //test.AddClient(client);

            //var clientUpdate = test.GetClient(6);
            //clientUpdate.ClientId = 1;

            var lista = test.GetAllClients();
            foreach(var list in lista)
            {
                Console.WriteLine(list.Nume);
            }


            //test.DeleteClient(clientUpdate.ClientId);
            //test.DeleteClient(5);
            //test.UpdateClient(client);
            
            //Client x = test.GetClientById(1);
            //Console.WriteLine(x.Nume);
        }
    }
}
