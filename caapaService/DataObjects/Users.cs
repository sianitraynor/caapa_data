﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace caapaService.DataObjects
{
    public class Users: EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }

    }
}