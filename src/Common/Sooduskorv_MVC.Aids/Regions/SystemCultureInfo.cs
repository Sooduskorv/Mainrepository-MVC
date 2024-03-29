﻿using System.Globalization;
using Sooduskorv_MVC.Aids.Methods;

namespace Sooduskorv_MVC.Aids.Regions {

    public static class SystemCultureInfo {
        public static CultureInfo[] GetSpecific() {
            return GetCultures(CultureTypes.SpecificCultures);
        }

        public static CultureInfo[] GetCultures(CultureTypes types) {
            return Safe.Run(() => CultureInfo.GetCultures(types),
                new CultureInfo[0]);
        }

        public static RegionInfo ToRegionInfo(CultureInfo info) {
            return info is null
                ? null
                : Safe.Run(() => new RegionInfo(info.LCID), (RegionInfo)null);
        }
    }

}







