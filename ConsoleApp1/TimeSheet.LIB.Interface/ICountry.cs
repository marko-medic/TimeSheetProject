﻿using System;

namespace TimeSheet.Shared.Models.Interfaces
{
    public interface ICountry
    {
       Guid Id { get; }
       String Name { get; }
    }
}
