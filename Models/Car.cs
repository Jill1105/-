﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class Car
{
    public int Id { get; set; }

    public int Capacity { get; set; }

    public int PlusPrice { get; set; }

    public string Comment { get; set; }

    public string Picture { get; set; }

    public string Description { get; set; }

    public virtual ICollection<CarTaxiOrderItem> CarTaxiOrderItems { get; set; } = new List<CarTaxiOrderItem>();
}