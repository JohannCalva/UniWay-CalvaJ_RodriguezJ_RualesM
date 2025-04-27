using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UniWay_WebAppMVC.Models;

    public class SQLServerContextJJM : DbContext
    {
        public SQLServerContextJJM (DbContextOptions<SQLServerContextJJM> options)
            : base(options)
        {
        }

        public DbSet<UniWay_WebAppMVC.Models.Usuario> Usuario { get; set; } = default!;

public DbSet<UniWay_WebAppMVC.Models.Vehiculo> Vehiculo { get; set; } = default!;

public DbSet<UniWay_WebAppMVC.Models.Viaje> Viaje { get; set; } = default!;

public DbSet<UniWay_WebAppMVC.Models.Reserva> Reserva { get; set; } = default!;
    }
