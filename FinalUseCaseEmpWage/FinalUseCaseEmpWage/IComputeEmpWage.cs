﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalUseCaseEmpWage
{
    public interface IComputeEmpWage
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
        void computeEmpWage();

        int getTotalWage(string company);
    }

}
