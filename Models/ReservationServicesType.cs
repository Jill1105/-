﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class ReservationServicesType
{
    public int Id { get; set; }

    public string ServicesTypeName { get; set; }

    public string Description { get; set; }

    public string ServicesTypeImageUrl { get; set; }

    public virtual ICollection<ReservationServiceDetail> ReservationServiceDetails { get; set; } = new List<ReservationServiceDetail>();
}