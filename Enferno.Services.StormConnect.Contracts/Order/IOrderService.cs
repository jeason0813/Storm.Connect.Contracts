﻿using System.ServiceModel;
using System.ServiceModel.Web;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [ServiceContract(Name = "OrderService", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public interface IOrderService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "CreateInvoice")]
        void CreateInvoice(Invoice request);

        [OperationContract]
        [WebInvoke(UriTemplate = "CreateDeliveryNote")]
        void CreateDeliveryNote(DeliveryNote deliveryNote);

        [OperationContract]
        [WebInvoke(UriTemplate = "CancelOrder")]
        void CancelOrder(CancelOrderRequest cancelOrderRequest);

        [OperationContract]
        [WebInvoke(UriTemplate = "SendOrderStatus")]
        void SendOrderStatus(SendOrderStatusRequest statusRequest);
    }
}
