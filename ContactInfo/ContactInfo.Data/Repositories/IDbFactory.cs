﻿using ContactInfo.Data.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInfo.Data.Repositories
{
   public interface IDbFactory : IDisposable
    {
        ContactInfoEFModel Init();
    }
}
