﻿using Common.Models;
using DataLayer.DbContext;
using DataLayer.Repositories.Abstractions;

namespace DataLayer.Repositories
{
    public class DroneRepository : RepositoryBase<Drone, string>, IDroneRepository
    {
        public DroneRepository(AppDbContext appDbContext)
            : base(appDbContext, appDbContext.Drones) { }
    }
}
