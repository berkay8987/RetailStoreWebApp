﻿using System;
using System.Collections.Generic;

namespace RetailStoreWebApp.Core.Entities.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public int IsActive { get; set; }

    public int IsDeleted { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
