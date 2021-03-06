using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Square;
using Square.Utilities;

namespace Square.Models
{
    public class OrderReturn 
    {
        public OrderReturn(string uid = null,
            string sourceOrderId = null,
            IList<Models.OrderReturnLineItem> returnLineItems = null,
            IList<Models.OrderReturnServiceCharge> returnServiceCharges = null,
            IList<Models.OrderReturnTax> returnTaxes = null,
            IList<Models.OrderReturnDiscount> returnDiscounts = null,
            Models.OrderRoundingAdjustment roundingAdjustment = null,
            Models.OrderMoneyAmounts returnAmounts = null)
        {
            Uid = uid;
            SourceOrderId = sourceOrderId;
            ReturnLineItems = returnLineItems;
            ReturnServiceCharges = returnServiceCharges;
            ReturnTaxes = returnTaxes;
            ReturnDiscounts = returnDiscounts;
            RoundingAdjustment = roundingAdjustment;
            ReturnAmounts = returnAmounts;
        }

        /// <summary>
        /// Unique ID that identifies the return only within this order.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; }

        /// <summary>
        /// Order which contains the original sale of these returned line items. This will be unset
        /// for unlinked returns.
        /// </summary>
        [JsonProperty("source_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceOrderId { get; }

        /// <summary>
        /// Collection of line items which are being returned.
        /// </summary>
        [JsonProperty("return_line_items", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.OrderReturnLineItem> ReturnLineItems { get; }

        /// <summary>
        /// Collection of service charges which are being returned.
        /// </summary>
        [JsonProperty("return_service_charges", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.OrderReturnServiceCharge> ReturnServiceCharges { get; }

        /// <summary>
        /// Collection of references to taxes being returned for an order, including the total
        /// applied tax amount to be returned. The taxes must reference a top-level tax ID from the source
        /// order.
        /// </summary>
        [JsonProperty("return_taxes", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.OrderReturnTax> ReturnTaxes { get; }

        /// <summary>
        /// Collection of references to discounts being returned for an order, including the total
        /// applied discount amount to be returned. The discounts must reference a top-level discount ID
        /// from the source order.
        /// </summary>
        [JsonProperty("return_discounts", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Models.OrderReturnDiscount> ReturnDiscounts { get; }

        /// <summary>
        /// A rounding adjustment of the money being returned. Commonly used to apply Cash Rounding
        /// when the minimum unit of account is smaller than the lowest physical denomination of currency.
        /// </summary>
        [JsonProperty("rounding_adjustment", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderRoundingAdjustment RoundingAdjustment { get; }

        /// <summary>
        /// A collection of various money amounts.
        /// </summary>
        [JsonProperty("return_amounts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OrderMoneyAmounts ReturnAmounts { get; }

        public Builder ToBuilder()
        {
            var builder = new Builder()
                .Uid(Uid)
                .SourceOrderId(SourceOrderId)
                .ReturnLineItems(ReturnLineItems)
                .ReturnServiceCharges(ReturnServiceCharges)
                .ReturnTaxes(ReturnTaxes)
                .ReturnDiscounts(ReturnDiscounts)
                .RoundingAdjustment(RoundingAdjustment)
                .ReturnAmounts(ReturnAmounts);
            return builder;
        }

        public class Builder
        {
            private string uid;
            private string sourceOrderId;
            private IList<Models.OrderReturnLineItem> returnLineItems;
            private IList<Models.OrderReturnServiceCharge> returnServiceCharges;
            private IList<Models.OrderReturnTax> returnTaxes;
            private IList<Models.OrderReturnDiscount> returnDiscounts;
            private Models.OrderRoundingAdjustment roundingAdjustment;
            private Models.OrderMoneyAmounts returnAmounts;



            public Builder Uid(string uid)
            {
                this.uid = uid;
                return this;
            }

            public Builder SourceOrderId(string sourceOrderId)
            {
                this.sourceOrderId = sourceOrderId;
                return this;
            }

            public Builder ReturnLineItems(IList<Models.OrderReturnLineItem> returnLineItems)
            {
                this.returnLineItems = returnLineItems;
                return this;
            }

            public Builder ReturnServiceCharges(IList<Models.OrderReturnServiceCharge> returnServiceCharges)
            {
                this.returnServiceCharges = returnServiceCharges;
                return this;
            }

            public Builder ReturnTaxes(IList<Models.OrderReturnTax> returnTaxes)
            {
                this.returnTaxes = returnTaxes;
                return this;
            }

            public Builder ReturnDiscounts(IList<Models.OrderReturnDiscount> returnDiscounts)
            {
                this.returnDiscounts = returnDiscounts;
                return this;
            }

            public Builder RoundingAdjustment(Models.OrderRoundingAdjustment roundingAdjustment)
            {
                this.roundingAdjustment = roundingAdjustment;
                return this;
            }

            public Builder ReturnAmounts(Models.OrderMoneyAmounts returnAmounts)
            {
                this.returnAmounts = returnAmounts;
                return this;
            }

            public OrderReturn Build()
            {
                return new OrderReturn(uid,
                    sourceOrderId,
                    returnLineItems,
                    returnServiceCharges,
                    returnTaxes,
                    returnDiscounts,
                    roundingAdjustment,
                    returnAmounts);
            }
        }
    }
}