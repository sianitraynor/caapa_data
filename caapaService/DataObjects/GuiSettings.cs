using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    public class GuiSettings: EntityData
    {
    
        public int GuiSettingsId { get; set; }

        public GuiSettings()
        {
        }
    }
}

