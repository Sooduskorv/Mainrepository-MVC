﻿using Quantity.Data;
using Quantity.Domain;
using Sooduskorv_MVC.Aids.Methods;

namespace Quantity.Facade {

    public static class MeasureTermViewFactory {

        public static MeasureTerm Create(MeasureTermView v) {
            var d = new MeasureTermData();
            Copy.Members(v, d);

            return new MeasureTerm(d);
        }

        public static MeasureTermView Create(MeasureTerm o) {
            var v = new MeasureTermView();
            Copy.Members(o.Data, v);

            return v;
        }

    }

}
