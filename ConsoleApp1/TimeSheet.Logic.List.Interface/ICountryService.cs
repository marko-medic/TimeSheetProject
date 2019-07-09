﻿using System.Collections.Generic;
using TimeSheet.Shared.Models.Interfaces;
using TimeSheet.DAL.Repositories.List.Interfaces;

namespace TimeSheet.BLL.Service.Interfaces
{
    public interface ICountryService
    {
        ICountryDAL CountryDAL { get; set; }
        IEnumerable<ICountry> GetCountries();
    }
}