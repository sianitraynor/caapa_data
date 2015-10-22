using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    class Prompts
    {
        public int promptId { get; set; }
        public String promptName { get; set; }
        public String promptDesc { get; set; }
        public int userId { get; set; }

    }
}
