﻿using System;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Common;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "OrderRequest", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public partial class OrderRequest : IExtensibleDataObject
    {
        [DataMember(Order = 1)]
        public ClientCustomer SellTo { get; set; }
        [DataMember(Order = 2)]
        public ClientCustomer BillTo { get; set; }
        [DataMember(Order = 3)]
        public ClientCustomer ShipTo { get; set; }
        [DataMember(Order = 4)]
        public string SalesContactCode { get; set; }
        [DataMember(Order = 5)]
        public string SalesContactDivision { get; set; }
        [DataMember(Order = 6)]
        public bool DoHold { get; set; }
        [DataMember(Order = 7)]
        public string ClientOrderRef { get; set; }
        [DataMember(Order = 8)]
        public string ErpOrderNo { get; set; }
        [DataMember(Order = 9)]
        public string CustomerOrderRef { get; set; }
        [DataMember(Order = 10)]
        public string CustomerOrderComment { get; set; }
        [DataMember(Order = 11)]
        public DateTime SubmitDate { get; set; }
        [DataMember(Order = 12)]
        public string CurrencyCode { get; set; }
        [DataMember(Order = 13)]
        public int? ReferId { get; set; }
        [DataMember(Order = 14)]
        public Payments Payments { get; set; }
        [DataMember(Order = 15)]
        public Discounts Discounts { get; set; }
        [DataMember(Order = 16)]
        public ShippingAdvice ShippingAdvice { get; set; }
        [DataMember(Order = 17)]
        public OrderItems Items { get; set; }
        [DataMember(Order = 18)]
        public Fees Fees { get; set; }
        [DataMember(Order = 19)]
        public CodeValues AdditionalInfo { get; set; }
        [DataMember(Order = 20)]
        public Header Header { get; set; }
        [DataMember(Order = 21)]
        public OrderTypes OrderType { get; set; }

        public virtual ExtensionDataObject ExtensionData { get; set; }
    }
}
