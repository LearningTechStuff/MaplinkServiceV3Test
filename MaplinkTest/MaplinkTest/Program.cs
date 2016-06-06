using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaplinkTest
{
    class Program
    {
        static void Main(string[] args)
        {
	        var address1 = new AddressInfo()
	        {
		        Address = "Rua das Baunilhas",
		        City = "São Paulo",
		        District = "",
		        Number = "33",
		        State = "SP",
		        Zipcode = "03146020"
	        };

            var service = new MaplinkAddressFinder();
	        var coords = service.GetCoordinates(address1);
            Console.WriteLine(coords.Latitude + ";" + coords.Longitude);
        }
    }
}
