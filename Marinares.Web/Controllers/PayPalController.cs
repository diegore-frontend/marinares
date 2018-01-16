
using System.Configuration;
using System.Web.Mvc;
using PayPal.Api;
using PayPal.Util;
using System.Collections.Generic;
using PayPal.PayPalAPIInterfaceService.Model;
using System;
using PayPal.PayPalAPIInterfaceService;
using System.Linq;

namespace Marinares.Web.Controllers
{
    public class PayPalController : Controller
    {
        // GET: PayPal
        public ActionResult Index()
        {
            return View();
        }

 ///*       public string GenerarOrden(List<ItemPayPal> lstItemPaypal)
 //       {
 //           try
 //           {


 //               // Create request object
 //               SetExpressCheckoutRequestType request = new SetExpressCheckoutRequestType();

 //               SetExpressCheckoutRequestDetailsType ecDetails = new SetExpressCheckoutRequestDetailsType();



 //               /* Populate payment requestDetails. 
 //                * SetExpressCheckout allows parallel payments of upto 10 payments. 
 //                * This samples shows just one payment.
 //                */
 //               PaymentDetailsType paymentDetails = new PaymentDetailsType();
 //               ecDetails.PaymentDetails.Add(paymentDetails);
 //               // (Required) Total cost of the transaction to the buyer. If shipping cost and tax charges are known, include them in this value. If not, this value should be the current sub-total of the order. If the transaction includes one or more one-time purchases, this field must be equal to the sum of the purchases. Set this field to 0 if the transaction does not include a one-time purchase such as when you set up a billing agreement for a recurring payment that is not immediately charged. When the field is set to 0, purchase-specific fields are ignored.
 //               double orderTotal = 0.0;
 //               // Sum of cost of all items in this order. For digital goods, this field is required.
 //               double itemTotal = 0.0;
 //               CurrencyCodeType currency = CurrencyCodeType.MXN;


 //               //(Optional) Description of items the buyer is purchasing.
 //               // Note:
 //               // The value you specify is available only if the transaction includes a purchase.
 //               // This field is ignored if you set up a billing agreement for a recurring payment 
 //               // that is not immediately charged.
 //               // Character length and limitations: 127 single-byte alphanumeric characters

 //               paymentDetails.OrderDescription = "";

 //               // How you want to obtain payment. When implementing parallel payments, 
 //               // this field is required and must be set to Order.
 //               // When implementing digital goods, this field is required and must be set to Sale.
 //               // If the transaction does not include a one-time purchase, this field is ignored. 
 //               // It is one of the following values:
 //               //   Sale – This is a final sale for which you are requesting payment (default).
 //               //   Authorization – This payment is a basic authorization subject to settlement with PayPal Authorization and Capture.
 //               //   Order – This payment is an order authorization subject to settlement with PayPal Authorization and Capture.
 //               paymentDetails.PaymentAction = PaymentActionCodeType.SALE;

 //               paymentDetails.ButtonSource = "marinares";

 //               foreach (ItemPayPal item in lstItemPaypal)
 //               {
 //                   PaymentDetailsItemType itemDetails = new PaymentDetailsItemType();
 //                   itemDetails.Name = item.Nombre;
 //                   itemDetails.Amount = new BasicAmountType(currency, ((decimal)item.Precio).ToString());
 //                   itemDetails.Quantity = item.Cantidad;

 //                   // Indicates whether an item is digital or physical. For digital goods, this field is required and must be set to Digital. It is one of the following values:
 //                   //   1.Digital
 //                   //   2.Physical
 //                   //  This field is available since version 65.1. 
 //                   //itemDetails.ItemCategory = ItemCategoryType.DIGITAL;

 //                   itemTotal += Convert.ToDouble(itemDetails.Amount.value) * itemDetails.Quantity.Value;

 //                   //(Optional) Item description.
 //                   // Character length and limitations: 127 single-byte characters
 //                   // This field is introduced in version 53.0. 

 //                   itemDetails.Description = item.Descripcion;

 //                   paymentDetails.PaymentDetailsItem.Add(itemDetails);
 //               }

 //               orderTotal += itemTotal;
 //               paymentDetails.ItemTotal = new BasicAmountType(currency, itemTotal.ToString());
 //               paymentDetails.OrderTotal = new BasicAmountType(currency, orderTotal.ToString());
 //               paymentDetails.Custom = "9998";
 //               paymentDetails.InvoiceID = null;

 //               ecDetails.ReturnURL = "";
 //               ecDetails.CancelURL = "";
 //               ecDetails.NoShipping = "1";
 //               ecDetails.AllowNote = "0";
 //               ecDetails.cppCartBorderColor = "0b5ba1";

 //               // (Optional) URL for the image you want to appear at the top left of the payment page. The image has a maximum size of 750 pixels wide by 90 pixels high. PayPal recommends that you provide an image that is stored on a secure (https) server. If you do not specify an image, the business name displays.
 //               ecDetails.cppHeaderImage = "";

 //               request.SetExpressCheckoutRequestDetails = ecDetails;

 //               ///////////////////////////////////////////////////////////////////////////////////////////////////////////////


 //               // Invoke the API
 //               SetExpressCheckoutReq wrapper = new SetExpressCheckoutReq();
 //               wrapper.SetExpressCheckoutRequest = request;

 //               System.Net.ServicePointManager.Expect100Continue = false;

 //               // Configuration map containing signature credentials and other required configuration.
 //               // For a full list of configuration parameters refer in wiki page 
 //               // [https://github.com/paypal/sdk-core-dotnet/wiki/SDK-Configuration-Parameters]

 //               // Create the PayPalAPIInterfaceServiceService service object to make the API call
 //               PayPalAPIInterfaceServiceService service = new PayPalAPIInterfaceServiceService(configuracion);

 //               //wrapper.SetExpressCheckoutRequest.Version = "84.0";
 //               // # API call 
 //               // Invoke the SetExpressCheckout method in service wrapper object  
 //               SetExpressCheckoutResponseType setECResponse = service.SetExpressCheckout(wrapper);

 //               // Check for API return status

 //               if (setECResponse.Ack.Equals(AckCodeType.FAILURE) ||
 //                  (setECResponse.Errors != null && setECResponse.Errors.Count > 0))
 //               {

 //                   throw new Exception(setECResponse.Errors != null && setECResponse.Errors.Count > 0
 //                       ? setECResponse.Errors.FirstOrDefault().LongMessage
 //                       : "Error inesperado");
 //               }
 //               else
 //               {
 //                   return setECResponse.Token;
 //               }

 //           }

 //           catch (Exception ex) { throw; }


 //       }
    }
}

public class ItemPayPal
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public int Cantidad { get; set; }
    public float Precio { get; set; }
}