using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    class PromptSteps
    {
        public int stepId { get; set; }
        public int promptId { get; set; }
        public String stepName{ get; set; }
        public String stepDesc { get; set; }
        public String stepImageURI { get; set; }
        public String stepMediaURI { get; set; }


    }
}
