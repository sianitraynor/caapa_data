using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    public class UserSettings: EntityData
    {
    
        public int UserSettingsId { get; set; }
        public int UserId { get; set; }
        public int GuiSettingsId { get; set; }
        public int UiSettingsJSON { get; set; }



    }
}
