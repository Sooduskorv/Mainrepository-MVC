﻿using System.ComponentModel.DataAnnotations;

namespace Sooduskorv_MVC.Aids.HTTP
{
    public class Filters
    {
        public string SearchString { get; set; }
        public string CurrentFilter { get; set; }
        public string FixedFilter { get; set; }
        [Range(0, 100)]// ?
        public int PageNumber { get; set; }
        public string FixedValue { get; set; }
        public string OrderBy { get; set; }
        public string MainCategory { get; set; }
        public string SubCategory { get; set; }
    }
}