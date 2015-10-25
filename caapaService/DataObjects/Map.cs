using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    public class Map: EntityData
    {
        public int mapId { get; set; }
        public String LocationAddress{ get; set; }
        public String Longitude { get; set; }
        public String Latitude{ get; set; }
        public String URL { get; set; }

        public Map()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaaPa.Beacons"/> class.
        /// </summary>
        /// <param name="LocationAddress ">LocationAddress .</param>
        /// <param name="Longitude ">Longitude .</param>
        /// <param name="Latitude">Latitude .</param>
        /// <param name="URL" >URL .</param>
        public Map(String LocationAddress, String Longitude, String Latitude, String URL)
        {
            this.LocationAddress = LocationAddress;
            this.LocationAddress = Longitude;
            this.Latitude = Latitude;
            this.URL = URL;
        }

    }
}
