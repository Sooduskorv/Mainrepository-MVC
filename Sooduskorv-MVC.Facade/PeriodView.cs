﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sooduskorv_MVC.Facade
{
    public abstract class PeriodView : UniqueEntityView
    {
        [DataType(DataType.Date)]
        [DisplayName("Valid From")]
        public DateTime? ValidFrom { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        [DisplayName("Valid To")]
        public DateTime? ValidTo { get; set; } = DateTime.UtcNow;

        public override string GetId() => Id;
    }
}
