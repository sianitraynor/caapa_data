using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    class Locations
    {
        public int LocationId { get; set; }
        public String LocationName{ get; set; }
        public String LocationDesc { get; set; }
        public int BeaconId { get; set; }
        public int UserId { get; set; }
    }
}
