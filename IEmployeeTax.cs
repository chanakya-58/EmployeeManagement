﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal interface IEmployeeTax
    {
        public void CalculateEmployeeTaxSchema(Employees employee);
    }
}
