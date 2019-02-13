﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Core.Helper
{
    public class ResultHelper
    {
        public ResultHelper()
        {
        }
        public ResultHelper(bool result, int resultSet, string resultDescription)
        {
            this.Result = result;
            this.ResultSet = resultSet;
            this.ResultDescription = resultDescription;
        }
        public bool Result { get; set; }
        public int ResultSet { get; set; }
        public string ResultDescription { get; set; }
    }
}
