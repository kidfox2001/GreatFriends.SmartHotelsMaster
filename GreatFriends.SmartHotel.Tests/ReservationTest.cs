using GreatFriends.SmartHoltel.Models;
using System;
using Xunit;

namespace GreatFriends.SmartHotel.Tests
{

    // todo ชื่อคลาส + Test
  public class ReservationTest
  {
        // todo ชือ method ที่จะเทส
    public class Cancel
    {

      [Fact]
      public void Simple()
      {
        // arrange
        var dt = DateTime.Now;
        var r = new Reservation();

        // act
        r.Cancel(dt, "Blah");

        // assert
        Assert.Equal(dt, r.CanceledDate);
        Assert.True(r.IsCanceled);
        Assert.Contains("Blah", r.CancelReason);
      }

    }

  }
}
