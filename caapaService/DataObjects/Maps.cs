using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    class Maps
    {
        public int mapId { get; set; }
        public String LocationAddress{ get; set; }
        public String Longitude { get; set; }
        public String Latitude{ get; set; }
        public String URL { get; set; }
    }
}
