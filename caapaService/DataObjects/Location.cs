using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    class Location
    {
        public int LocationId { get; set; }
        public String LocationName{ get; set; }
        public String LocationDesc { get; set; }
        public int BeaconId { get; set; }
        public int UserId { get; set; }

        public Location()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaaPa.Beacons"/> class.
        /// </summary>
        /// <param name="LocationName ">ocationName .</param>
        /// <param name="LocationDesc ">LocationDesc .</param>
        /// <param name="BeaconId">BeaconId.</param>
        /// <param name="UserId" >UserId .</param>
        public Location(String LocationName, String LocationDesc, int BeaconId, int UserId)
        {
            this.LocationName = LocationName;
            this.LocationDesc = LocationDesc;
            this.BeaconId = BeaconId;
            this.UserId = UserId;
        }
    }
}



