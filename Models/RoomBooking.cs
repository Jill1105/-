﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class RoomBooking
{
    public int BookingId { get; set; }

    public int RoomId { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime CheckOutDate { get; set; }

    public int MemberId { get; set; }

    public string Remark { get; set; }

    public int BookingStatusId { get; set; }

    public DateTime? BookingCancelDate { get; set; }

    public DateTime BookingDate { get; set; }

    public int OrderPirce { get; set; }

    public string Phone { get; set; }
}