﻿using Quantity.Data;

namespace Quantity.Domain.Common {

    public abstract class BaseRelationshipType<TType, TData> : DefinedEntity<TData> where TData: RelationshipTypeData, new(){

        protected BaseRelationshipType(TData d = null) : base(d) {}

        public string ConsumerTypeId => Data?.ConsumerTypeId ?? Unspecified;

        public string ProviderTypeId => Data?.ProviderTypeId ?? Unspecified;

    }

}