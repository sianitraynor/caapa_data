using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    public class UserMaps: EntityData
    {
        public int MapId { get; set; }
        public int UserId { get; set; }
    }
}
