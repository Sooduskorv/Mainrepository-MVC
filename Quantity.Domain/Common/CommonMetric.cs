﻿using Quantity.Data;

namespace Quantity.Domain.Common {

    public abstract class CommonMetric<TData> : DefinedEntity<TData>
        where TData : CommonMetricData, new() {

        protected CommonMetric(TData data = null) : base(data)  {}

        public override string Code => string.IsNullOrWhiteSpace(Data?.Code)? Name : Data?.Code;
        
        public override string Name => string.IsNullOrWhiteSpace(Data?.Name) ? Id : Data?.Name;

        public override string Id => IsUnspecified || string.IsNullOrWhiteSpace(Data?.Id) ? Unspecified : Data?.Id;

    }

}