using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    class Prompt
    {
        public int promptId { get; set; }
        public String promptName { get; set; }
        public String promptDesc { get; set; }
        public int userId { get; set; }
        

        public Prompt()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaaPa.Beacons"/> class.
        /// </summary>
        /// <param name="promptName">promptName .</param>
        /// <param name="promptDesc">promptDesc .</param>
        /// <param name="userId">userId .</param>
        public Prompt(String promptName, String promptDesc, int userID)
        {
            this.promptName = promptName;
            this.promptDesc = promptDesc;
            this.userId = userId;
        }
    }
}
