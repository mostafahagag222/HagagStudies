using DataBaseLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayer.Entities_Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservaion>
    {
        public void Configure(EntityTypeBuilder<Reservaion> builder)
        {
            builder.ToTable("Reservations");
            builder.Property(r => r.AprtSuite).IsRequired().HasMaxLength(50);
            builder.Property(r => r.CardCVC).IsRequired().HasMaxLength(10);
            builder.Property(r => r.CardExp).IsRequired().HasMaxLength(50);
            builder.Property(r => r.CardNumber).IsRequired().HasMaxLength(50);
            builder.Property(r => r.CardType).IsRequired().HasMaxLength(10);
            builder.Property(r => r.City).IsRequired().HasMaxLength(50);
            builder.Property(r => r.EmailAddress).IsRequired().HasMaxLength(50);
            builder.Property(r => r.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(r => r.LastName).IsRequired().HasMaxLength(50);
            builder.Property(r => r.PaymentType).IsRequired().HasMaxLength(10);
            builder.Property(r => r.Phone).IsRequired().HasMaxLength(50);
            builder.Property(r => r.RoomNumber).IsRequired().HasMaxLength(10);
            builder.Property(r => r.RoomType).IsRequired().HasMaxLength(10);
            builder.Property(r => r.State).IsRequired().HasMaxLength(50);
            builder.Property(r => r.StreetAddress).IsRequired().HasMaxLength(50);
            builder.Property(r => r.ZipCode).IsRequired().HasMaxLength(10);
            builder.Property(r => r.RoomFloor).IsRequired().HasMaxLength(10);
            builder.Property(e => e.ArrivalTime).HasColumnType("date");
            builder.Property(e => e.LeaveTime).HasColumnType("date");
            builder.Property(e => e.TotalBill).HasColumnType("float");
            builder.Property(p => p.Gender).HasConversion(v => v == Gender.Male, v => v ? Gender.Male : Gender.Female).HasColumnType("bit");
            builder.HasKey(r => r.ReservationtId);

        }
    }
}
