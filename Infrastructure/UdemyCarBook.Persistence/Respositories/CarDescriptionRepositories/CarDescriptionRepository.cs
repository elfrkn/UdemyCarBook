﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Respositories.CarDescriptionRepositories
{
    public class CarDescriptionRepository : ICarDescriptionRepository
    {
        private readonly CarBookContext _context;

        public CarDescriptionRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task<CarDescription> GetCarDescription(int carId)
        {
            var values = await _context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefaultAsync();
            return values;
        }
    }

}
