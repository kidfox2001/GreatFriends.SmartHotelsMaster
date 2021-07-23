using GreatFriends.SmartHoltel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GreatFriends.SmartHoltel.Services.Data
{
    // todo install dotnet-ef
    //dotnet tool list -g (เช็คโปรแกรมในระดับเครื่อง)
    //dotnet tool install dotnet-ef --global (ลงโปรแกรม)


    // todo dotnet ef migrations
    // -s คือการบอกตำแหน่งของ startup file (คำสั่งนี้ควรใช้กับ project ที่มี DbContext) -o ออกไปที่ folder
    // dotnet ef migrations add update01 -s ..\GreatFriends.SmartHotel.APIs\GreatFriends.SmartHotel.APIs.csproj -o Data\Migrations
    // dotnet ef database update -s ..\GreatFriends.SmartHotel.APIs\GreatFriends.SmartHotel.APIs.csproj

    public class AppDb : DbContext
  {
    public AppDb(DbContextOptions<AppDb> options) : base(options)
    {
      //
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Reservation> Reservations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<RoomType>().Property(x => x.Price)
        .HasColumnType("decimal")
        .HasPrecision(18, 2);
    }
  }
}
