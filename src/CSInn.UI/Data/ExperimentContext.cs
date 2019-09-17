﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CSInn.Models;

namespace CSInn.UI.Models
{
    public class ExperimentContext : DbContext
    {
        public ExperimentContext (DbContextOptions<ExperimentContext> options)
            : base(options)
        {
        }

        public DbSet<CSInn.Models.ExperimentModel> ExperimentModel { get; set; }
    }
}
