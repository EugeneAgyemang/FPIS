﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reports.Datasets
{
    public class Analytical_Results
    {
        public string ParameterName { get; set; }
        public float Specification { get; set; }
        public float Actual { get; set; }
        public float Variance { get; set; }
    }
}