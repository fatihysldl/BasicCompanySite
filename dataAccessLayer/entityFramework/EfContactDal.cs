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
    public class EfContactDal : genericRepository<contact> , IContactDal
    {
    }
}
