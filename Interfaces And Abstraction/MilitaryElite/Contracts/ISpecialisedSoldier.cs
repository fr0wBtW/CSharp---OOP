﻿using MilitaryElite.Enums;

namespace MilitaryElite
{
    public interface ISpecialisedSoldier : IPrivate
    {
         Corps Corps { get; }
    }
}
