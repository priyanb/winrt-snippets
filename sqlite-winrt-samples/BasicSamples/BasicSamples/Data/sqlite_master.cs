﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSamples.Data
{
    public class sqlite_master
    {
        public string type { get; set; }
        public string name { get; set; }
        public string tbl_name { get; set; }
        public int rootpage { get; set; }
        public string sql { get; set; }
    }
}
