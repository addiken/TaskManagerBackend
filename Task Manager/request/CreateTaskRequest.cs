﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Manager.request
{
    public class CreateTaskRequest
    {
        public string Heading { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
    }
}
