﻿using Pronia.Models;

namespace Pronia.Services.Interfaces
{
    public interface ISliderService
    {
        Task<List<Slider>> GetAll();
        Task<Slider> GetById(int? id);
    }
}
