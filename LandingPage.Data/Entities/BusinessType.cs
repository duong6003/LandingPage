﻿using LandingPage.Kernel.Commons;
using System;
using System.Collections.Generic;

#nullable disable

namespace LandingPage.Data.Entities
{
    public partial class BusinessType : DomainEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
