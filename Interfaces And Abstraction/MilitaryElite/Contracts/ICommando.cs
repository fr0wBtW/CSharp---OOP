﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite
{
    public interface ICommando : ISpecialisedSoldier
    {
        ICollection<IMission> Missions { get; }
    }
}
