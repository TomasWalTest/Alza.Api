﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Alza.Api.Core.DomainModel
{
    public class Product : IEntity<long>
    {
        List<int> t;
        public long Id { get; set; }
    }
}
