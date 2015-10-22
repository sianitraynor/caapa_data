using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    public class Users: EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }

    }
}