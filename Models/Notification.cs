﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelFuen31.APIs.Models;

public partial class Notification
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public DateTime PushTime { get; set; }

    public string Image { get; set; }

    public int? LevelId { get; set; }

    public virtual MemberLevel Level { get; set; }

    public virtual ICollection<SendedNotification> SendedNotifications { get; set; } = new List<SendedNotification>();
}