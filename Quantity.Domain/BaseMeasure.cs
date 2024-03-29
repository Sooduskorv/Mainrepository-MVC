﻿
using Quantity.Data;

namespace Quantity.Domain {

    public sealed class BaseMeasure : Measure {


        public BaseMeasure(MeasureData data = null) : base(data) { }

        protected override Measure multiply(BaseMeasure m, string n = null, string c = null, string d = null) {
            createMeasure(n, c, d);
            addTerm(this, 1);
            addTerm(m, 1);

            return measure;
        }
        protected override Measure multiply(DerivedMeasure m, string n = null, string c = null, string d = null) {
            createMeasure(n, c, d);
            addTerm(this, 1);

            foreach (var t in m.Terms) addTerm(t.TermMeasure, t.Power);
            
            return measure;
        }

        protected override Measure power(in int power, string n = null, string c = null, string d = null) {
            createMeasure(n, c, d);
            addTerm(this, power);

            return measure;
        }

        protected override string formula(bool isLong = false) => isLong ? Name : Code;
        protected override Measure toSqrt(string n = null, string c = null, string d = null) {
            createMeasure(n, c, d);

            return measure;
        }

    }

}