
using System;
using System.Configuration;
using MaplinkTest.MaplinkAuth;
using MaplinkTest.MaplinkWS;

namespace MaplinkTest
{
    class MaplinkAddressFinder
    {
	    public GeographicalCoordinates GetCoordinates(AddressInfo address)
	    {
            Console.WriteLine("Calling GetCoordinates");
            Console.WriteLine("Performing authentication - " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
            var auth = new Authentication();
		    auth.Timeout = 1000;
		    var authToken = auth.getToken(ConfigurationManager.AppSettings["MaplinkUser"], ConfigurationManager.AppSettings["MaplinkPassword"]);
            Console.WriteLine("Finished authentication process - " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));

            Console.WriteLine("Starting address finder process - " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));
            var service = new AddressFinder();
		    service.Timeout = 1000;
            
            var addr = new Address();
		    addr.street = address.Address;
		    addr.houseNumber = address.Number;
		    addr.district = address.District;
		    addr.city = new City()
		    {
			    name = address.City,
			    state = address.State
		    };
		    addr.zip = address.Zipcode;

		    var coordinates = service.getXY(addr, authToken);
            Console.WriteLine("Finished service call - " + DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss.fff tt"));

		    var coords = new GeographicalCoordinates();
		    coords.Latitude = coordinates.x;
		    coords.Longitude = coordinates.y;
		    return coords;
	    }
    }
}
