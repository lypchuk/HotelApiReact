using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyHotelDb : IdentityDbContext<User>
    //public class MyHotelDb : DbContext
    {
        public MyHotelDb()
        {
            //this.Database.EnsureCreated();
        }

        public MyHotelDb(DbContextOptions options) : base(options)
        {
            //this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();
            //this.Database.EnsureDeleted();
        }

        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<NumberOfBeds> NumberOfBeds { get; set; }
        public DbSet<NumberOfSeats> NumberOfSeats { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<TypeRoom> TypeRooms { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string connectionStr = "Data Source=DESKTOP-ASTVPAV;" +
                "Initial Catalog=MyHotelDb;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;" +
                "Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False";

            optionsBuilder.UseSqlServer(connectionStr);
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<Rating>().HasData(new Rating[]
            {
                new Rating(){Id=1, Number = 1},
                new Rating(){Id=2, Number = 2},
                new Rating(){Id=3, Number = 3},
                new Rating(){Id=4, Number = 4},
                new Rating(){Id=5, Number = 5},
            });

            modelBuilder.Entity<NumberOfBeds>().HasData(new NumberOfBeds[]
            {
                new NumberOfBeds(){Id=1, Number = 1},
                new NumberOfBeds(){Id=2, Number = 2},
                new NumberOfBeds(){Id=3, Number = 3},
                new NumberOfBeds(){Id=4, Number = 4},
                new NumberOfBeds(){Id=5, Number = 6},
                new NumberOfBeds(){Id=6, Number = 8},
            });

            modelBuilder.Entity<NumberOfSeats>().HasData(new NumberOfSeats[]
            {
                new NumberOfSeats(){Id=1, Number = 1},
                new NumberOfSeats(){Id=2, Number = 2},
                new NumberOfSeats(){Id=3, Number = 3},
                new NumberOfSeats(){Id=4, Number = 4},
                new NumberOfSeats(){Id=5, Number = 6},
                new NumberOfSeats(){Id=6, Number = 8},
            });

            

            
            modelBuilder.Entity<TypeRoom>().HasData(new TypeRoom[]
            {
                new TypeRoom(){Id=1, Name = "penthouse"},
                new TypeRoom(){Id=2, Name = "luxury"},
                new TypeRoom(){Id=3, Name = "premium"},
                new TypeRoom(){Id=4, Name = "normal"},
                new TypeRoom(){Id=5, Name = "economy"},
            });

            
            modelBuilder.Entity<HotelRoom>().HasData(new HotelRoom[]
            {
                new HotelRoom(){Id=1, Name = "room 1", State = true, TypeRoomId = 5, NumberOfBedsId = 1,
                ImageUrl ="https://cf.bstatic.com/xdata/images/hotel/square240/248195922.webp?k=6b877e663516a32f2bc8ea0650bd8f99c82410492c14970ef50d4d03efd98d3e&o=",
                NumberOfSeatsId = 1, Price = 600, Description = "Ok", Internet = false, Bath = false,
                RatingNumber = 1, },

                new HotelRoom(){Id=2, Name = "room 2", State = true, TypeRoomId = 4, NumberOfBedsId = 2,
                ImageUrl ="https://cf.bstatic.com/xdata/images/hotel/square240/20587801.webp?k=f2bf851dde89ce807cfaee75bfaf553141dc8ded4522a4499622b1d8515ed135&o=",
                NumberOfSeatsId = 2, Price = 800, Description = "Nice", Internet = true, Bath = true,
                RatingNumber = 2, },

                new HotelRoom(){Id=3, Name = "room 3", State = true, TypeRoomId = 3, NumberOfBedsId = 3,
                ImageUrl ="https://cf.bstatic.com/xdata/images/hotel/square240/438603683.webp?k=7c9e443957dc86d5b06967d1e1f42ad04c22bbfac1fdb6df3cfc9a607873f716&o=",
                NumberOfSeatsId = 3, Price = 1000, Description = "Very OK VeryVeryVeryVery Very", Internet = true, Bath = true,
                RatingNumber = 3.5, },

                new HotelRoom(){Id=4, Name = "room 4", State = true, TypeRoomId = 2, NumberOfBedsId = 4,
                ImageUrl ="https://cf.bstatic.com/xdata/images/hotel/square240/174892954.webp?k=c4c4a19bc0f48dbcb5eb746836c198d8aefccd940c5977dc3d3a7824851820fd&o=",
                NumberOfSeatsId = 4, Price = 1200, Description = "Very OK", Internet = true, Bath = true,
                RatingNumber = 4, },

                new HotelRoom(){Id=5, Name = "room 5", State = true, TypeRoomId = 1, NumberOfBedsId = 5,
                ImageUrl ="https://cf.bstatic.com/xdata/images/hotel/square240/479602453.webp?k=607d43a927a0bfb7021e70a93ee55b6be457a8e976f19d34ff3a9091b5b6e4bb&o=",
                NumberOfSeatsId = 5, Price = 2000, Description = "Very OK", Internet = true, Bath = true,
                RatingNumber = 5, },

            });

            modelBuilder.Entity<Response>().HasData(new Response[]
            {
                new Response(){Id=1, RatingId = 1, HotelRoomId = 1,Date = new DateTime(2023,12,6), Description = "Good"},
                new Response(){Id=2, RatingId = 2, HotelRoomId = 2,Date = new DateTime(2024,2,25), Description = "not Good"},
                new Response(){Id=3, RatingId = 3, HotelRoomId = 3,Date = new DateTime(2024,1,5), Description = "Bad"},
                new Response(){Id=4, RatingId = 4, HotelRoomId = 4,Date = new DateTime(2023,12,25), Description = "Good"},
                new Response(){Id=5, RatingId = 5, HotelRoomId = 5,Date = new DateTime(2022,11,25), Description = "Good"},
                new Response(){Id=6, RatingId = 4, HotelRoomId = 1,Date = new DateTime(2024,3,2),  Description = "Very Good"},
            });


        }

    }
}
