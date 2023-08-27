﻿using dataAccessLayer.concrete;
using dataAccessLayer.concrete.repository;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.entityFramework
{
    public class EfCompanyServicesDal : genericRepository<companyServices> , ICompanyServicesDal
    {
    }
}