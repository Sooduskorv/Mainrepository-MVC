﻿using System;

namespace Quantity.Domain.Common {

    public abstract class BaseEntity
    {

        public static string Unspecified => Sooduskorv_MVC.Aids.Constants.Word.UnSpecified;
        public static DateTime UnspecifiedValidFrom => DateTime.MinValue;  
        public static DateTime UnspecifiedValidTo => DateTime.MaxValue;  
        public static double UnspecifiedDouble => double.NaN;  
        public static decimal UnspecifiedDecimal => decimal.MaxValue;
        public static int UnspecifiedInteger => 0;


    }

}