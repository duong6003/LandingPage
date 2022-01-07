using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandingPage.Kernel.Commons
{
    public abstract class DomainEntity<K>
    {
        public K Id { get; set; }
    }
}
