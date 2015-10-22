using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    class Beacons
    {
        public int BeaconId { get; set; }
        public String BeaconBluetoothKey { get; set; }
        public String BeaconName { get; set; }
        public String BeaconDesc { get; set; }
        public int LocationId { get; set; }

    }
}
