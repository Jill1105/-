﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class CarTaxiOrder
{
    public int Id { get; set; }

    public int EmpId { get; set; }

    public int MemberId { get; set; }

    public DateTime BookingTime { get; set; }

    public decimal Total { get; set; }
}