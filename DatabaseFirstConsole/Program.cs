using DatabaseFirstConsole.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace DatabaseFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleContext db = new ConsoleContext(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

            List<Client> clientes = db.Clients.ToList();

            foreach (var item in clientes)
            {
                Console.WriteLine("Cliente: " + item.Name);
            }

            Console.ReadKey();
        }
    }
}
