using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    public class Reminder: EntityData
    {
        public int ReminderId { get; set; }
        public int UserId { get; set; }
        public String ReminderName { get; set; }
        public String ReminderDesc { get; set; }
        public DateTime DurationStartDatetime { get; set; }
        public DateTime DurationEndDatetime { get; set; }
        public String ImageURI { get; set; }
        public String MediaURI { get; set; }


    }
}
