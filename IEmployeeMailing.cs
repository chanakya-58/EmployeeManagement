﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal interface IEmployeeMailing
    {
        public Task<Employees> AddEmployeeToMailingServer(Employees employee);
    }
}
