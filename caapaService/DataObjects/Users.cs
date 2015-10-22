using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    public class Users: EntityData
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String UserFirstName { get; set; }
        public String UserLastName { get; set; }
        public String eMail { get; set; }
        public String Home { get; set; }
        public String Mobile { get; set; }
        public String DeviceMACDongle { get; set; }
    }
}