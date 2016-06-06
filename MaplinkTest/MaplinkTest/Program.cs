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
	        char[] separator = {';'};
	        var address = args[0].Split(separator);
	        var addressInfo = new AddressInfo()
	        {
                Address = address[0],
                Number = address[1],
                District = address[2],
                City = address[3],
                State = address[4],
                Zipcode = address[5]
	        };

            var service = new MaplinkAddressFinder();
	        var coords = service.GetCoordinates(addressInfo);
            Console.WriteLine(coords.Latitude + ";" + coords.Longitude);
        }
    }
}
