﻿using Microsoft.EntityFrameworkCore;

namespace E_comerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 
        }
    }
}
