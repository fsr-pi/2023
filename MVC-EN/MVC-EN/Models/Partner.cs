﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace MVC_EN.Models;

public partial class Partner
{
    public int PartnerId { get; set; }

    public string PartnerType { get; set; }

    public string VatNumber { get; set; }

    public int? ResidenceCityId { get; set; }

    public string ResidenceAddress { get; set; }

    public int? ShipmentCityId { get; set; }

    public string ShipmentAddress { get; set; }

    public virtual Company Company { get; set; }

    public virtual ICollection<Document> Documents { get; } = new List<Document>();

    public virtual Person Person { get; set; }

    public virtual City ResidenceCity { get; set; }

    public virtual City ShipmentCity { get; set; }
}