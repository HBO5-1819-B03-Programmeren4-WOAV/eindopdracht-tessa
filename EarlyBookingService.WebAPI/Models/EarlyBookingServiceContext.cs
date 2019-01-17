using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EarlyBookingService.WebAPI.Models
{
    public class EarlyBookingServiceContext : DbContext
    {
        public EarlyBookingServiceContext(DbContextOptions<EarlyBookingServiceContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accomodation>()
                .ToTable("Accomodation")
                .HasData(
                new Accomodation
                {
                    Id = 1,
                    Name = "Hotel 't Zonnetje",
                    Country = "Belgium",
                    Email = "tessa.braeke@gmail.com"
                },
                new Accomodation
                {
                    Id = 2,
                    Name = "Hotel aan Zee",
                    Country = "Netherlands",
                    Email = "tessa.braeke@gmail.com"
                },
                new Accomodation
                {
                    Id = 3,
                    Name = "Joly Sailor",
                    Country = "United Kingdom",
                    Email = "tessa.braeke@gmail.com"
                },
                new Accomodation
                {
                    Id = 4,
                    Name = "Hotel am See",
                    Country = "Germany",
                    Email = "tessa.braeke@gmail.com"
                });

            modelBuilder.Entity<Booking>()
                .ToTable("Booking")
                .HasData(
                new Booking
                {
                    Id = 1,
                    ReservationNumber = "A1A1A1",
                    AccomodationId = 1
                },
                new Booking
                {
                    Id = 2,
                    ReservationNumber = "A2A2A2",
                    AccomodationId = 1
                },
                new Booking
                {
                    Id = 3,
                    ReservationNumber = "B1B1B1",
                    AccomodationId = 2
                },
                new Booking
                {
                    Id = 4,
                    ReservationNumber = "B2B2B2",
                    AccomodationId = 2
                },
                new Booking
                {
                    Id = 5,
                    ReservationNumber = "C1C1C1",
                    AccomodationId = 3
                },
                new Booking
                {
                    Id = 6,
                    ReservationNumber = "C2C2C2",
                    AccomodationId = 3
                },
                new Booking
                {
                    Id = 7,
                    ReservationNumber = "C3C3C3",
                    AccomodationId = 3
                },
                new Booking
                {
                    Id = 8,
                    ReservationNumber = "D1D1D1",
                    AccomodationId = 4
                },
                new Booking
                {
                    Id = 9,
                    ReservationNumber = "D2D2D2",
                    AccomodationId = 4
                },
                new Booking
                {
                    Id = 10,
                    ReservationNumber = "D3D3D3",
                    AccomodationId = 4
                });

            modelBuilder.Entity<Participant>()
                .ToTable("Participant")
                .HasData(
                new Participant
                {
                    Id = 1,
                    BookingId = 1,
                    FirstName = "Jan",
                    LastName = "Kapitein",
                    BirthDate = new DateTime(1980, 5, 20),
                },
                new Participant
                {
                    Id = 2,
                    BookingId = 1,
                    FirstName = "Piet",
                    LastName = "Kapitein",
                    BirthDate = new DateTime(1992, 3, 4)
                },
                new Participant
                {
                    Id = 3,
                    BookingId = 2,
                    FirstName = "Joris",
                    LastName = "Kapitein",
                    BirthDate = new DateTime(1995, 6, 12)
                },
                new Participant
                {
                    Id = 4,
                    BookingId = 2,
                    FirstName = "Korneel",
                    LastName = "Kapitein",
                    BirthDate = new DateTime(1960, 5, 31)
                },
                new Participant
                {
                    Id = 5,
                    BookingId = 3,
                    FirstName = "Irma",
                    LastName = "De Bruyne",
                    BirthDate = new DateTime(1918, 5, 4)
                },
                new Participant
                {
                    Id = 6,
                    BookingId = 3,
                    FirstName = "Georges",
                    LastName = "Van Renterghem",
                    BirthDate = new DateTime(1918, 8, 12)
                },
                new Participant
                {
                    Id = 7,
                    BookingId = 4,
                    FirstName = "Lorna",
                    LastName = "Bogaert",
                    BirthDate = new DateTime(1961, 1, 7)
                },
                new Participant
                {
                    Id = 8,
                    BookingId = 4,
                    FirstName = "Daniel",
                    LastName = "Braeke",
                    BirthDate = new DateTime(1955, 3, 28)
                },
                new Participant
                {
                    Id = 9,
                    BookingId = 5,
                    FirstName = "Knabbel",
                    LastName = "Eekhoorn",
                    BirthDate = new DateTime(1990, 12, 21)
                },
                new Participant
                {
                    Id = 10,
                    BookingId = 5,
                    FirstName = "Babbel",
                    LastName = "Eekhoorn",
                    BirthDate = new DateTime(1990, 12, 21)
                },
                new Participant
                {
                    Id = 11,
                    BookingId = 6,
                    FirstName = "Jon",
                    LastName = "Snow",
                    BirthDate = new DateTime(1940, 12, 25)

                },
                new Participant
                {
                    Id = 12,
                    BookingId = 6,
                    FirstName = "Daenerys",
                    LastName = "Targaryen",
                    BirthDate = new DateTime(1941, 2, 28)
                },
                new Participant
                {
                    Id = 13,
                    BookingId = 7,
                    FirstName = "Jaap",
                    LastName = "Vos",
                    BirthDate = new DateTime(2000, 10, 31)

                },
                new Participant
                {
                    Id = 14,
                    BookingId = 7,
                    FirstName = "Jeroen",
                    LastName = "Vos",
                    BirthDate = new DateTime(1999, 9, 3)
                },
                new Participant
                {
                    Id = 15,
                    BookingId = 8,
                    FirstName = "Fatima",
                    LastName = "Baba",
                    BirthDate = new DateTime(1970, 4, 19)
                },
                new Participant
                {
                    Id = 16,
                    BookingId = 8,
                    FirstName = "Ali",
                    LastName = "Baba",
                    BirthDate = new DateTime(1970, 3, 19)
                },
                new Participant
                {
                    Id = 17,
                    BookingId = 9,
                    FirstName = "Thomas",
                    LastName = "Sanders",
                    BirthDate = new DateTime(1990, 9, 12)
                },
                new Participant
                {
                    Id = 18,
                    BookingId = 9,
                    FirstName = "Annelies",
                    LastName = "Sanders",
                    BirthDate = new DateTime(1982, 2, 17)
                },
                new Participant
                {
                    Id = 19,
                    BookingId = 9,
                    FirstName = "Nathalie",
                    LastName = "Sanders",
                    BirthDate = new DateTime(1984, 2, 25)
                },
                new Participant
                {
                    Id = 20,
                    BookingId = 10,
                    FirstName = "Homer",
                    LastName = "Simpson",
                    BirthDate = new DateTime(1950, 8, 7)
                },
                new Participant
                {
                    Id = 21,
                    BookingId = 10,
                    FirstName = "Marge",
                    LastName = "Simpson",
                    BirthDate = new DateTime(1953, 7, 21)
                },
                new Participant
                {
                    Id = 22,
                    BookingId = 10,
                    FirstName = "Lisa",
                    LastName = "Simpson",
                    BirthDate = new DateTime(1985, 6, 23)
                },
                new Participant
                {
                    Id = 23,
                    BookingId = 10,
                    FirstName = "Bart",
                    LastName = "Simpson",
                    BirthDate = new DateTime(1984, 5, 18)
                },
                new Participant
                {
                    Id = 24,
                    BookingId = 10,
                    FirstName = "Maggie",
                    LastName = "Simpson",
                    BirthDate = new DateTime(1989, 2, 6)
                }
                );

            modelBuilder.Entity<PriceDetail>()
                .ToTable("PriceDetail");

            modelBuilder.Entity<PurchaseCost>()
                .ToTable("PurchaseCost");
        }

        public DbSet<Accomodation> Accomodations { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<PriceDetail> PriceDetails { get; set; }
        public DbSet<PurchaseCost> PurchaseCosts { get; set; }
    }
}
