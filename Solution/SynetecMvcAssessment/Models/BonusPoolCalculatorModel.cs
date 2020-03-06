﻿using SynetecDatabase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Models
{
    public class BonusPoolCalculatorModel
    {

        public int BonusPoolAmount { get; set; }
        public List<HrEmployee> AllEmployees { get; set; }        
        public int SelectedEmployeeId { get; set; }

    }
}