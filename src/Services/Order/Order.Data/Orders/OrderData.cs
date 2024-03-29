﻿using System;
using Sooduskorv_MVC.Data.CommonData;

namespace Order.Data.Orders
{
    public sealed class OrderData : PeriodData
    {
        public string ShipMethodsOfPartyId { get; set; }
        public string Description { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Id { get; set; }
    }
}