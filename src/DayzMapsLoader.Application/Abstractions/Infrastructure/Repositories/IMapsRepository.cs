﻿using DayzMapsLoader.Domain.Entities;

namespace DayzMapsLoader.Application.Abstractions.Infrastructure.Repositories;

public interface IMapsRepository : IBaseRepository<Map>
{
    Task<IEnumerable<Map>> GetAllMapsAsync();

    Task<Map> GetMapByIdAsync(int id);
}