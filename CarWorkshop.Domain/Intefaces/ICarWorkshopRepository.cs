﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Domain.Intefaces
{
    public interface ICarWorkshopRepository
    {
        Task Create(Domain.Entities.CarWorkshop carWorkshop);
    }
}
