using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    class Beacon
    {
        public int BeaconId { get; set; }
        public String BeaconBluetoothKey { get; set; }
        public String BeaconName { get; set; }
        public String BeaconDesc { get; set; }
        public int LocationId { get; set; }


        public Beacon()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaaPa.Beacons"/> class.
        /// </summary>
        /// <param name="BeaconBluetoothKey ">BeaconBluetoothKey .</param>
        /// <param name="BeaconName ">BeaconName .</param>
        /// <param name="BeaconDesc">BeaconDesc.</param>
        ///   /// <param name="LoationId">LocationID.</param>
        public Beacon(int BeaconId, String BeaconBluetoothKey = "", string BeaconName = "", string BeaconDesc = "") { 
            this.BeaconBluetoothKey = BeaconBluetoothKey;
            this.BeaconName = BeaconName;
            this.BeaconDesc = BeaconDesc;
            this.LocationId = LocationId;   
            }
    }

}
