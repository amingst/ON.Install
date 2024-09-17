// <copyright file="V1TransactionsAchRefundPrevTrxnRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace FortisAPI.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using FortisAPI.Standard;
    using FortisAPI.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// V1TransactionsAchRefundPrevTrxnRequest.
    /// </summary>
    public class V1TransactionsAchRefundPrevTrxnRequest : BaseModel
    {
        private string checkinDate;
        private string checkoutDate;
        private string clerkNumber;
        private string contactApiId;
        private string contactId;
        private string customerId;
        private string description;
        private Models.IiasIndEnum? iiasInd;
        private string imageFront;
        private string imageBack;
        private int? installmentNumber;
        private int? installmentCount;
        private string locationApiId;
        private string locationId;
        private string productTransactionId;
        private string notificationEmailAddress;
        private string orderNumber;
        private string poNumber;
        private string quickInvoiceId;
        private int? recurringNumber;
        private string roomNum;
        private int? roomRate;
        private string saveAccountTitle;
        private int? subtotalAmount;
        private int? surchargeAmount;
        private List<string> tags;
        private int? tax;
        private int? tipAmount;
        private int? secondaryAmount;
        private string transactionApiId;
        private string transactionC1;
        private string transactionC2;
        private string transactionC3;
        private string achIdentifier;
        private Models.AchSecCode1Enum? achSecCode;
        private string effectiveDate;
        private string previousTransactionApiId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "checkin_date", false },
            { "checkout_date", false },
            { "clerk_number", false },
            { "contact_api_id", false },
            { "contact_id", false },
            { "customer_id", false },
            { "description", false },
            { "iias_ind", false },
            { "image_front", false },
            { "image_back", false },
            { "installment_number", false },
            { "installment_count", false },
            { "location_api_id", false },
            { "location_id", false },
            { "product_transaction_id", false },
            { "notification_email_address", false },
            { "order_number", false },
            { "po_number", false },
            { "quick_invoice_id", false },
            { "recurring_number", false },
            { "room_num", false },
            { "room_rate", false },
            { "save_account_title", false },
            { "subtotal_amount", false },
            { "surcharge_amount", false },
            { "tags", false },
            { "tax", false },
            { "tip_amount", false },
            { "secondary_amount", false },
            { "transaction_api_id", false },
            { "transaction_c1", false },
            { "transaction_c2", false },
            { "transaction_c3", false },
            { "ach_identifier", false },
            { "ach_sec_code", false },
            { "effective_date", false },
            { "previous_transaction_api_id", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1TransactionsAchRefundPrevTrxnRequest"/> class.
        /// </summary>
        public V1TransactionsAchRefundPrevTrxnRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1TransactionsAchRefundPrevTrxnRequest"/> class.
        /// </summary>
        /// <param name="transactionAmount">transaction_amount.</param>
        /// <param name="previousTransactionId">previous_transaction_id.</param>
        /// <param name="additionalAmounts">additional_amounts.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="checkinDate">checkin_date.</param>
        /// <param name="checkoutDate">checkout_date.</param>
        /// <param name="clerkNumber">clerk_number.</param>
        /// <param name="contactApiId">contact_api_id.</param>
        /// <param name="contactId">contact_id.</param>
        /// <param name="customData">custom_data.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="description">description.</param>
        /// <param name="identityVerification">identity_verification.</param>
        /// <param name="iiasInd">iias_ind.</param>
        /// <param name="imageFront">image_front.</param>
        /// <param name="imageBack">image_back.</param>
        /// <param name="installment">installment.</param>
        /// <param name="installmentNumber">installment_number.</param>
        /// <param name="installmentCount">installment_count.</param>
        /// <param name="locationApiId">location_api_id.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="productTransactionId">product_transaction_id.</param>
        /// <param name="advanceDeposit">advance_deposit.</param>
        /// <param name="noShow">no_show.</param>
        /// <param name="notificationEmailAddress">notification_email_address.</param>
        /// <param name="orderNumber">order_number.</param>
        /// <param name="poNumber">po_number.</param>
        /// <param name="quickInvoiceId">quick_invoice_id.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="recurringNumber">recurring_number.</param>
        /// <param name="roomNum">room_num.</param>
        /// <param name="roomRate">room_rate.</param>
        /// <param name="saveAccount">save_account.</param>
        /// <param name="saveAccountTitle">save_account_title.</param>
        /// <param name="subtotalAmount">subtotal_amount.</param>
        /// <param name="surchargeAmount">surcharge_amount.</param>
        /// <param name="tags">tags.</param>
        /// <param name="tax">tax.</param>
        /// <param name="tipAmount">tip_amount.</param>
        /// <param name="secondaryAmount">secondary_amount.</param>
        /// <param name="transactionApiId">transaction_api_id.</param>
        /// <param name="transactionC1">transaction_c1.</param>
        /// <param name="transactionC2">transaction_c2.</param>
        /// <param name="transactionC3">transaction_c3.</param>
        /// <param name="bankFundedOnlyOverride">bank_funded_only_override.</param>
        /// <param name="allowPartialAuthorizationOverride">allow_partial_authorization_override.</param>
        /// <param name="autoDeclineCvvOverride">auto_decline_cvv_override.</param>
        /// <param name="autoDeclineStreetOverride">auto_decline_street_override.</param>
        /// <param name="autoDeclineZipOverride">auto_decline_zip_override.</param>
        /// <param name="achIdentifier">ach_identifier.</param>
        /// <param name="achSecCode">ach_sec_code.</param>
        /// <param name="effectiveDate">effective_date.</param>
        /// <param name="previousTransactionApiId">previous_transaction_api_id.</param>
        public V1TransactionsAchRefundPrevTrxnRequest(
            int transactionAmount,
            string previousTransactionId,
            List<Models.AdditionalAmount> additionalAmounts = null,
            Models.BillingAddress billingAddress = null,
            string checkinDate = null,
            string checkoutDate = null,
            string clerkNumber = null,
            string contactApiId = null,
            string contactId = null,
            object customData = null,
            string customerId = null,
            string description = null,
            Models.IdentityVerification18 identityVerification = null,
            Models.IiasIndEnum? iiasInd = null,
            string imageFront = null,
            string imageBack = null,
            bool? installment = null,
            int? installmentNumber = null,
            int? installmentCount = null,
            string locationApiId = null,
            string locationId = null,
            string productTransactionId = null,
            bool? advanceDeposit = null,
            bool? noShow = null,
            string notificationEmailAddress = null,
            string orderNumber = null,
            string poNumber = null,
            string quickInvoiceId = null,
            bool? recurring = null,
            int? recurringNumber = null,
            string roomNum = null,
            int? roomRate = null,
            bool? saveAccount = null,
            string saveAccountTitle = null,
            int? subtotalAmount = null,
            int? surchargeAmount = null,
            List<string> tags = null,
            int? tax = null,
            int? tipAmount = null,
            int? secondaryAmount = null,
            string transactionApiId = null,
            string transactionC1 = null,
            string transactionC2 = null,
            string transactionC3 = null,
            bool? bankFundedOnlyOverride = null,
            bool? allowPartialAuthorizationOverride = null,
            bool? autoDeclineCvvOverride = null,
            bool? autoDeclineStreetOverride = null,
            bool? autoDeclineZipOverride = null,
            string achIdentifier = null,
            Models.AchSecCode1Enum? achSecCode = null,
            string effectiveDate = null,
            string previousTransactionApiId = null)
        {
            this.AdditionalAmounts = additionalAmounts;
            this.BillingAddress = billingAddress;
            if (checkinDate != null)
            {
                this.CheckinDate = checkinDate;
            }

            if (checkoutDate != null)
            {
                this.CheckoutDate = checkoutDate;
            }

            if (clerkNumber != null)
            {
                this.ClerkNumber = clerkNumber;
            }

            if (contactApiId != null)
            {
                this.ContactApiId = contactApiId;
            }

            if (contactId != null)
            {
                this.ContactId = contactId;
            }

            this.CustomData = customData;
            if (customerId != null)
            {
                this.CustomerId = customerId;
            }

            if (description != null)
            {
                this.Description = description;
            }

            this.IdentityVerification = identityVerification;
            if (iiasInd != null)
            {
                this.IiasInd = iiasInd;
            }

            if (imageFront != null)
            {
                this.ImageFront = imageFront;
            }

            if (imageBack != null)
            {
                this.ImageBack = imageBack;
            }

            this.Installment = installment;
            if (installmentNumber != null)
            {
                this.InstallmentNumber = installmentNumber;
            }

            if (installmentCount != null)
            {
                this.InstallmentCount = installmentCount;
            }

            if (locationApiId != null)
            {
                this.LocationApiId = locationApiId;
            }

            if (locationId != null)
            {
                this.LocationId = locationId;
            }

            if (productTransactionId != null)
            {
                this.ProductTransactionId = productTransactionId;
            }

            this.AdvanceDeposit = advanceDeposit;
            this.NoShow = noShow;
            if (notificationEmailAddress != null)
            {
                this.NotificationEmailAddress = notificationEmailAddress;
            }

            if (orderNumber != null)
            {
                this.OrderNumber = orderNumber;
            }

            if (poNumber != null)
            {
                this.PoNumber = poNumber;
            }

            if (quickInvoiceId != null)
            {
                this.QuickInvoiceId = quickInvoiceId;
            }

            this.Recurring = recurring;
            if (recurringNumber != null)
            {
                this.RecurringNumber = recurringNumber;
            }

            if (roomNum != null)
            {
                this.RoomNum = roomNum;
            }

            if (roomRate != null)
            {
                this.RoomRate = roomRate;
            }

            this.SaveAccount = saveAccount;
            if (saveAccountTitle != null)
            {
                this.SaveAccountTitle = saveAccountTitle;
            }

            if (subtotalAmount != null)
            {
                this.SubtotalAmount = subtotalAmount;
            }

            if (surchargeAmount != null)
            {
                this.SurchargeAmount = surchargeAmount;
            }

            if (tags != null)
            {
                this.Tags = tags;
            }

            if (tax != null)
            {
                this.Tax = tax;
            }

            if (tipAmount != null)
            {
                this.TipAmount = tipAmount;
            }

            this.TransactionAmount = transactionAmount;
            if (secondaryAmount != null)
            {
                this.SecondaryAmount = secondaryAmount;
            }

            if (transactionApiId != null)
            {
                this.TransactionApiId = transactionApiId;
            }

            if (transactionC1 != null)
            {
                this.TransactionC1 = transactionC1;
            }

            if (transactionC2 != null)
            {
                this.TransactionC2 = transactionC2;
            }

            if (transactionC3 != null)
            {
                this.TransactionC3 = transactionC3;
            }

            this.BankFundedOnlyOverride = bankFundedOnlyOverride;
            this.AllowPartialAuthorizationOverride = allowPartialAuthorizationOverride;
            this.AutoDeclineCvvOverride = autoDeclineCvvOverride;
            this.AutoDeclineStreetOverride = autoDeclineStreetOverride;
            this.AutoDeclineZipOverride = autoDeclineZipOverride;
            if (achIdentifier != null)
            {
                this.AchIdentifier = achIdentifier;
            }

            if (achSecCode != null)
            {
                this.AchSecCode = achSecCode;
            }

            if (effectiveDate != null)
            {
                this.EffectiveDate = effectiveDate;
            }

            this.PreviousTransactionId = previousTransactionId;
            if (previousTransactionApiId != null)
            {
                this.PreviousTransactionApiId = previousTransactionApiId;
            }

        }

        /// <summary>
        /// Additional amounts
        /// </summary>
        [JsonProperty("additional_amounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AdditionalAmount> AdditionalAmounts { get; set; }

        /// <summary>
        /// Billing Address Object
        /// </summary>
        [JsonProperty("billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingAddress BillingAddress { get; set; }

        /// <summary>
        /// Checkin Date - The time difference between checkin_date and checkout_date must be less than or equal to 99 days.
        /// </summary>
        [JsonProperty("checkin_date")]
        public string CheckinDate
        {
            get
            {
                return this.checkinDate;
            }

            set
            {
                this.shouldSerialize["checkin_date"] = true;
                this.checkinDate = value;
            }
        }

        /// <summary>
        /// Checkout Date - The time difference between checkin_date and checkout_date must be less than or equal to 99 days.
        /// </summary>
        [JsonProperty("checkout_date")]
        public string CheckoutDate
        {
            get
            {
                return this.checkoutDate;
            }

            set
            {
                this.shouldSerialize["checkout_date"] = true;
                this.checkoutDate = value;
            }
        }

        /// <summary>
        /// Clerk or Employee Identifier
        /// </summary>
        [JsonProperty("clerk_number")]
        public string ClerkNumber
        {
            get
            {
                return this.clerkNumber;
            }

            set
            {
                this.shouldSerialize["clerk_number"] = true;
                this.clerkNumber = value;
            }
        }

        /// <summary>
        /// This can be supplied in place of contact_id if you would like to use a contact for the transaction and are using your own custom api_id's to track contacts in the system.
        /// </summary>
        [JsonProperty("contact_api_id")]
        public string ContactApiId
        {
            get
            {
                return this.contactApiId;
            }

            set
            {
                this.shouldSerialize["contact_api_id"] = true;
                this.contactApiId = value;
            }
        }

        /// <summary>
        /// If contact_id is provided, ensure it belongs to the same location as the transaction. You cannot move transaction across locations.
        /// </summary>
        [JsonProperty("contact_id")]
        public string ContactId
        {
            get
            {
                return this.contactId;
            }

            set
            {
                this.shouldSerialize["contact_id"] = true;
                this.contactId = value;
            }
        }

        /// <summary>
        /// A field that allows custom JSON to be entered to store extra data.
        /// </summary>
        [JsonProperty("custom_data", NullValueHandling = NullValueHandling.Ignore)]
        public object CustomData { get; set; }

        /// <summary>
        /// Can be used by Merchants to identify Contacts in our system by an ID from another system.
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId
        {
            get
            {
                return this.customerId;
            }

            set
            {
                this.shouldSerialize["customer_id"] = true;
                this.customerId = value;
            }
        }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Identity Verification
        /// </summary>
        [JsonProperty("identity_verification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IdentityVerification18 IdentityVerification { get; set; }

        /// <summary>
        /// Possible values are '0', '1','2'
        /// </summary>
        [JsonProperty("iias_ind")]
        public Models.IiasIndEnum? IiasInd
        {
            get
            {
                return this.iiasInd;
            }

            set
            {
                this.shouldSerialize["iias_ind"] = true;
                this.iiasInd = value;
            }
        }

        /// <summary>
        /// A base64 encoded string for the image.  Used with Check21 ACH transactions.
        /// </summary>
        [JsonProperty("image_front")]
        public string ImageFront
        {
            get
            {
                return this.imageFront;
            }

            set
            {
                this.shouldSerialize["image_front"] = true;
                this.imageFront = value;
            }
        }

        /// <summary>
        /// A base64 encoded string for the image.  Used with Check21 ACH transactions.
        /// </summary>
        [JsonProperty("image_back")]
        public string ImageBack
        {
            get
            {
                return this.imageBack;
            }

            set
            {
                this.shouldSerialize["image_back"] = true;
                this.imageBack = value;
            }
        }

        /// <summary>
        /// Flag that is allowed to be passed on card not present industries to signify the transaction is a fixed installment plan transaction.
        /// </summary>
        [JsonProperty("installment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Installment { get; set; }

        /// <summary>
        /// If this is a fixed installment plan and installment field is being passed as 1, then this field must have a vlue of 1-999 specifying the current installment number that is running.
        /// </summary>
        [JsonProperty("installment_number")]
        public int? InstallmentNumber
        {
            get
            {
                return this.installmentNumber;
            }

            set
            {
                this.shouldSerialize["installment_number"] = true;
                this.installmentNumber = value;
            }
        }

        /// <summary>
        /// If this is a fixed installment plan and installment field is being passed as 1, then this field must have a vlue of 1-999 specifying the total number of installments on the plan. This number must be grater than or equal to installment_number.
        /// </summary>
        [JsonProperty("installment_count")]
        public int? InstallmentCount
        {
            get
            {
                return this.installmentCount;
            }

            set
            {
                this.shouldSerialize["installment_count"] = true;
                this.installmentCount = value;
            }
        }

        /// <summary>
        /// This can be supplied in place of location_id for the transaction if you are using your own custom api_id's for your locations.
        /// </summary>
        [JsonProperty("location_api_id")]
        public string LocationApiId
        {
            get
            {
                return this.locationApiId;
            }

            set
            {
                this.shouldSerialize["location_api_id"] = true;
                this.locationApiId = value;
            }
        }

        /// <summary>
        /// A valid Location Id to associate the transaction with.
        /// </summary>
        [JsonProperty("location_id")]
        public string LocationId
        {
            get
            {
                return this.locationId;
            }

            set
            {
                this.shouldSerialize["location_id"] = true;
                this.locationId = value;
            }
        }

        /// <summary>
        /// The Product's method (cc/ach) has to match the action. If not provided, the API will use the default configured for the Location.
        /// </summary>
        [JsonProperty("product_transaction_id")]
        public string ProductTransactionId
        {
            get
            {
                return this.productTransactionId;
            }

            set
            {
                this.shouldSerialize["product_transaction_id"] = true;
                this.productTransactionId = value;
            }
        }

        /// <summary>
        /// Advance Deposit
        /// </summary>
        [JsonProperty("advance_deposit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdvanceDeposit { get; set; }

        /// <summary>
        /// Used in Lodging
        /// </summary>
        [JsonProperty("no_show", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoShow { get; set; }

        /// <summary>
        /// If email is supplied then receipt will be emailed
        /// </summary>
        [JsonProperty("notification_email_address")]
        public string NotificationEmailAddress
        {
            get
            {
                return this.notificationEmailAddress;
            }

            set
            {
                this.shouldSerialize["notification_email_address"] = true;
                this.notificationEmailAddress = value;
            }
        }

        /// <summary>
        /// Required for CC transactions , if merchant's deposit account's duplicate check per batch has 'order_number' field
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber
        {
            get
            {
                return this.orderNumber;
            }

            set
            {
                this.shouldSerialize["order_number"] = true;
                this.orderNumber = value;
            }
        }

        /// <summary>
        /// Purchase Order number
        /// </summary>
        [JsonProperty("po_number")]
        public string PoNumber
        {
            get
            {
                return this.poNumber;
            }

            set
            {
                this.shouldSerialize["po_number"] = true;
                this.poNumber = value;
            }
        }

        /// <summary>
        /// Can be used to associate a transaction to a Quick Invoice.  Quick Invoice transactions will have a value for this field automatically.
        /// </summary>
        [JsonProperty("quick_invoice_id")]
        public string QuickInvoiceId
        {
            get
            {
                return this.quickInvoiceId;
            }

            set
            {
                this.shouldSerialize["quick_invoice_id"] = true;
                this.quickInvoiceId = value;
            }
        }

        /// <summary>
        /// Flag that is allowed to be passed on card not present industries to signify the transaction is an ongoing recurring transaction. Possible values to send are 0 or 1. This field must be 0 or not present if installment is sent as 1.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

        /// <summary>
        /// If this is an ongoing recurring and recurring field is being passed as 1, then this field must have a vlue of 1-999 specifying the current recurring number that is running.
        /// </summary>
        [JsonProperty("recurring_number")]
        public int? RecurringNumber
        {
            get
            {
                return this.recurringNumber;
            }

            set
            {
                this.shouldSerialize["recurring_number"] = true;
                this.recurringNumber = value;
            }
        }

        /// <summary>
        /// Used in Lodging
        /// </summary>
        [JsonProperty("room_num")]
        public string RoomNum
        {
            get
            {
                return this.roomNum;
            }

            set
            {
                this.shouldSerialize["room_num"] = true;
                this.roomNum = value;
            }
        }

        /// <summary>
        /// Required if merchant industry type is lodging.
        /// </summary>
        [JsonProperty("room_rate")]
        public int? RoomRate
        {
            get
            {
                return this.roomRate;
            }

            set
            {
                this.shouldSerialize["room_rate"] = true;
                this.roomRate = value;
            }
        }

        /// <summary>
        /// Specifies to save account to contacts profile if account_number/track_data is present with either contact_id or contact_api_id in params.
        /// </summary>
        [JsonProperty("save_account", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SaveAccount { get; set; }

        /// <summary>
        /// If saving token while running a transaction, this will be the title of the token.
        /// </summary>
        [JsonProperty("save_account_title")]
        public string SaveAccountTitle
        {
            get
            {
                return this.saveAccountTitle;
            }

            set
            {
                this.shouldSerialize["save_account_title"] = true;
                this.saveAccountTitle = value;
            }
        }

        /// <summary>
        /// This field is allowed and required for transactions that have a product where surcharge is configured. Use only integer numbers, so $10.99 will be 1099.
        /// </summary>
        [JsonProperty("subtotal_amount")]
        public int? SubtotalAmount
        {
            get
            {
                return this.subtotalAmount;
            }

            set
            {
                this.shouldSerialize["subtotal_amount"] = true;
                this.subtotalAmount = value;
            }
        }

        /// <summary>
        /// This field is allowed and required for transactions that have a product where surcharge is configured. Use only integer numbers, so $10.99 will be 1099.
        /// </summary>
        [JsonProperty("surcharge_amount")]
        public int? SurchargeAmount
        {
            get
            {
                return this.surchargeAmount;
            }

            set
            {
                this.shouldSerialize["surcharge_amount"] = true;
                this.surchargeAmount = value;
            }
        }

        /// <summary>
        /// Tags
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags
        {
            get
            {
                return this.tags;
            }

            set
            {
                this.shouldSerialize["tags"] = true;
                this.tags = value;
            }
        }

        /// <summary>
        /// Amount of Sales tax - If supplied, this amount should be included in the total transaction_amount field. Use only integer numbers, so $10.99 will be 1099.
        /// </summary>
        [JsonProperty("tax")]
        public int? Tax
        {
            get
            {
                return this.tax;
            }

            set
            {
                this.shouldSerialize["tax"] = true;
                this.tax = value;
            }
        }

        /// <summary>
        /// Optional tip amount. Tip is not supported for lodging and ecommerce merchants. Use only integer numbers, so $10.99 will be 1099.
        /// </summary>
        [JsonProperty("tip_amount")]
        public int? TipAmount
        {
            get
            {
                return this.tipAmount;
            }

            set
            {
                this.shouldSerialize["tip_amount"] = true;
                this.tipAmount = value;
            }
        }

        /// <summary>
        /// Amount of the transaction. This should always be the desired settle amount of the transaction. Use only integer numbers, so $10.99 will be 1099.
        /// </summary>
        [JsonProperty("transaction_amount")]
        public int TransactionAmount { get; set; }

        /// <summary>
        /// Retained Amount of the transaction. This should always be less than transaction amount. Use only integer numbers, so $10.99 will be 1099
        /// </summary>
        [JsonProperty("secondary_amount")]
        public int? SecondaryAmount
        {
            get
            {
                return this.secondaryAmount;
            }

            set
            {
                this.shouldSerialize["secondary_amount"] = true;
                this.secondaryAmount = value;
            }
        }

        /// <summary>
        /// See api_id page for more details
        /// </summary>
        [JsonProperty("transaction_api_id")]
        public string TransactionApiId
        {
            get
            {
                return this.transactionApiId;
            }

            set
            {
                this.shouldSerialize["transaction_api_id"] = true;
                this.transactionApiId = value;
            }
        }

        /// <summary>
        /// Custom field 1 for api users to store custom data
        /// </summary>
        [JsonProperty("transaction_c1")]
        public string TransactionC1
        {
            get
            {
                return this.transactionC1;
            }

            set
            {
                this.shouldSerialize["transaction_c1"] = true;
                this.transactionC1 = value;
            }
        }

        /// <summary>
        /// Custom field 2 for api users to store custom data
        /// </summary>
        [JsonProperty("transaction_c2")]
        public string TransactionC2
        {
            get
            {
                return this.transactionC2;
            }

            set
            {
                this.shouldSerialize["transaction_c2"] = true;
                this.transactionC2 = value;
            }
        }

        /// <summary>
        /// Custom field 3 for api users to store custom data
        /// </summary>
        [JsonProperty("transaction_c3")]
        public string TransactionC3
        {
            get
            {
                return this.transactionC3;
            }

            set
            {
                this.shouldSerialize["transaction_c3"] = true;
                this.transactionC3 = value;
            }
        }

        /// <summary>
        /// Bank Funded Only Override
        /// </summary>
        [JsonProperty("bank_funded_only_override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BankFundedOnlyOverride { get; set; }

        /// <summary>
        /// Allow Partial Authorization Override
        /// </summary>
        [JsonProperty("allow_partial_authorization_override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPartialAuthorizationOverride { get; set; }

        /// <summary>
        /// Auto Decline CVV Override
        /// </summary>
        [JsonProperty("auto_decline_cvv_override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoDeclineCvvOverride { get; set; }

        /// <summary>
        /// Auto Decline Street Override
        /// </summary>
        [JsonProperty("auto_decline_street_override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoDeclineStreetOverride { get; set; }

        /// <summary>
        /// Auto Decline Zip Override
        /// </summary>
        [JsonProperty("auto_decline_zip_override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoDeclineZipOverride { get; set; }

        /// <summary>
        /// Required for ACH transactions in certain scenarios.
        /// </summary>
        [JsonProperty("ach_identifier")]
        public string AchIdentifier
        {
            get
            {
                return this.achIdentifier;
            }

            set
            {
                this.shouldSerialize["ach_identifier"] = true;
                this.achIdentifier = value;
            }
        }

        /// <summary>
        /// Required for ACH transactions if account_vault_id is not provided.
        /// </summary>
        [JsonProperty("ach_sec_code")]
        public Models.AchSecCode1Enum? AchSecCode
        {
            get
            {
                return this.achSecCode;
            }

            set
            {
                this.shouldSerialize["ach_sec_code"] = true;
                this.achSecCode = value;
            }
        }

        /// <summary>
        /// For ACH only, this is optional and defaults to current day.
        /// </summary>
        [JsonProperty("effective_date")]
        public string EffectiveDate
        {
            get
            {
                return this.effectiveDate;
            }

            set
            {
                this.shouldSerialize["effective_date"] = true;
                this.effectiveDate = value;
            }
        }

        /// <summary>
        /// previous_transaction_id is used as token to run transaction. Account details OR previous_transaction_id should be passed to run transaction.
        /// </summary>
        [JsonProperty("previous_transaction_id")]
        public string PreviousTransactionId { get; set; }

        /// <summary>
        /// previous_transaction_api_id is used as token to run transaction. Account details OR previous_transaction_api_id should be passed to run transaction.
        /// </summary>
        [JsonProperty("previous_transaction_api_id")]
        public string PreviousTransactionApiId
        {
            get
            {
                return this.previousTransactionApiId;
            }

            set
            {
                this.shouldSerialize["previous_transaction_api_id"] = true;
                this.previousTransactionApiId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1TransactionsAchRefundPrevTrxnRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCheckinDate()
        {
            this.shouldSerialize["checkin_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCheckoutDate()
        {
            this.shouldSerialize["checkout_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClerkNumber()
        {
            this.shouldSerialize["clerk_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactApiId()
        {
            this.shouldSerialize["contact_api_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContactId()
        {
            this.shouldSerialize["contact_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerId()
        {
            this.shouldSerialize["customer_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIiasInd()
        {
            this.shouldSerialize["iias_ind"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetImageFront()
        {
            this.shouldSerialize["image_front"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetImageBack()
        {
            this.shouldSerialize["image_back"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInstallmentNumber()
        {
            this.shouldSerialize["installment_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInstallmentCount()
        {
            this.shouldSerialize["installment_count"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationApiId()
        {
            this.shouldSerialize["location_api_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocationId()
        {
            this.shouldSerialize["location_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductTransactionId()
        {
            this.shouldSerialize["product_transaction_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNotificationEmailAddress()
        {
            this.shouldSerialize["notification_email_address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOrderNumber()
        {
            this.shouldSerialize["order_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPoNumber()
        {
            this.shouldSerialize["po_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetQuickInvoiceId()
        {
            this.shouldSerialize["quick_invoice_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRecurringNumber()
        {
            this.shouldSerialize["recurring_number"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRoomNum()
        {
            this.shouldSerialize["room_num"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRoomRate()
        {
            this.shouldSerialize["room_rate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSaveAccountTitle()
        {
            this.shouldSerialize["save_account_title"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubtotalAmount()
        {
            this.shouldSerialize["subtotal_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSurchargeAmount()
        {
            this.shouldSerialize["surcharge_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTags()
        {
            this.shouldSerialize["tags"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTax()
        {
            this.shouldSerialize["tax"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTipAmount()
        {
            this.shouldSerialize["tip_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSecondaryAmount()
        {
            this.shouldSerialize["secondary_amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionApiId()
        {
            this.shouldSerialize["transaction_api_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionC1()
        {
            this.shouldSerialize["transaction_c1"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionC2()
        {
            this.shouldSerialize["transaction_c2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionC3()
        {
            this.shouldSerialize["transaction_c3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAchIdentifier()
        {
            this.shouldSerialize["ach_identifier"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAchSecCode()
        {
            this.shouldSerialize["ach_sec_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEffectiveDate()
        {
            this.shouldSerialize["effective_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPreviousTransactionApiId()
        {
            this.shouldSerialize["previous_transaction_api_id"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCheckinDate()
        {
            return this.shouldSerialize["checkin_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCheckoutDate()
        {
            return this.shouldSerialize["checkout_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClerkNumber()
        {
            return this.shouldSerialize["clerk_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactApiId()
        {
            return this.shouldSerialize["contact_api_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContactId()
        {
            return this.shouldSerialize["contact_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerId()
        {
            return this.shouldSerialize["customer_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIiasInd()
        {
            return this.shouldSerialize["iias_ind"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeImageFront()
        {
            return this.shouldSerialize["image_front"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeImageBack()
        {
            return this.shouldSerialize["image_back"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstallmentNumber()
        {
            return this.shouldSerialize["installment_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstallmentCount()
        {
            return this.shouldSerialize["installment_count"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationApiId()
        {
            return this.shouldSerialize["location_api_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocationId()
        {
            return this.shouldSerialize["location_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductTransactionId()
        {
            return this.shouldSerialize["product_transaction_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNotificationEmailAddress()
        {
            return this.shouldSerialize["notification_email_address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOrderNumber()
        {
            return this.shouldSerialize["order_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePoNumber()
        {
            return this.shouldSerialize["po_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeQuickInvoiceId()
        {
            return this.shouldSerialize["quick_invoice_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRecurringNumber()
        {
            return this.shouldSerialize["recurring_number"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRoomNum()
        {
            return this.shouldSerialize["room_num"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRoomRate()
        {
            return this.shouldSerialize["room_rate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSaveAccountTitle()
        {
            return this.shouldSerialize["save_account_title"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubtotalAmount()
        {
            return this.shouldSerialize["subtotal_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSurchargeAmount()
        {
            return this.shouldSerialize["surcharge_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTags()
        {
            return this.shouldSerialize["tags"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTax()
        {
            return this.shouldSerialize["tax"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTipAmount()
        {
            return this.shouldSerialize["tip_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSecondaryAmount()
        {
            return this.shouldSerialize["secondary_amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionApiId()
        {
            return this.shouldSerialize["transaction_api_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionC1()
        {
            return this.shouldSerialize["transaction_c1"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionC2()
        {
            return this.shouldSerialize["transaction_c2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionC3()
        {
            return this.shouldSerialize["transaction_c3"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAchIdentifier()
        {
            return this.shouldSerialize["ach_identifier"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAchSecCode()
        {
            return this.shouldSerialize["ach_sec_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEffectiveDate()
        {
            return this.shouldSerialize["effective_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePreviousTransactionApiId()
        {
            return this.shouldSerialize["previous_transaction_api_id"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is V1TransactionsAchRefundPrevTrxnRequest other &&                ((this.AdditionalAmounts == null && other.AdditionalAmounts == null) || (this.AdditionalAmounts?.Equals(other.AdditionalAmounts) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.CheckinDate == null && other.CheckinDate == null) || (this.CheckinDate?.Equals(other.CheckinDate) == true)) &&
                ((this.CheckoutDate == null && other.CheckoutDate == null) || (this.CheckoutDate?.Equals(other.CheckoutDate) == true)) &&
                ((this.ClerkNumber == null && other.ClerkNumber == null) || (this.ClerkNumber?.Equals(other.ClerkNumber) == true)) &&
                ((this.ContactApiId == null && other.ContactApiId == null) || (this.ContactApiId?.Equals(other.ContactApiId) == true)) &&
                ((this.ContactId == null && other.ContactId == null) || (this.ContactId?.Equals(other.ContactId) == true)) &&
                ((this.CustomData == null && other.CustomData == null) || (this.CustomData?.Equals(other.CustomData) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.IdentityVerification == null && other.IdentityVerification == null) || (this.IdentityVerification?.Equals(other.IdentityVerification) == true)) &&
                ((this.IiasInd == null && other.IiasInd == null) || (this.IiasInd?.Equals(other.IiasInd) == true)) &&
                ((this.ImageFront == null && other.ImageFront == null) || (this.ImageFront?.Equals(other.ImageFront) == true)) &&
                ((this.ImageBack == null && other.ImageBack == null) || (this.ImageBack?.Equals(other.ImageBack) == true)) &&
                ((this.Installment == null && other.Installment == null) || (this.Installment?.Equals(other.Installment) == true)) &&
                ((this.InstallmentNumber == null && other.InstallmentNumber == null) || (this.InstallmentNumber?.Equals(other.InstallmentNumber) == true)) &&
                ((this.InstallmentCount == null && other.InstallmentCount == null) || (this.InstallmentCount?.Equals(other.InstallmentCount) == true)) &&
                ((this.LocationApiId == null && other.LocationApiId == null) || (this.LocationApiId?.Equals(other.LocationApiId) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                ((this.ProductTransactionId == null && other.ProductTransactionId == null) || (this.ProductTransactionId?.Equals(other.ProductTransactionId) == true)) &&
                ((this.AdvanceDeposit == null && other.AdvanceDeposit == null) || (this.AdvanceDeposit?.Equals(other.AdvanceDeposit) == true)) &&
                ((this.NoShow == null && other.NoShow == null) || (this.NoShow?.Equals(other.NoShow) == true)) &&
                ((this.NotificationEmailAddress == null && other.NotificationEmailAddress == null) || (this.NotificationEmailAddress?.Equals(other.NotificationEmailAddress) == true)) &&
                ((this.OrderNumber == null && other.OrderNumber == null) || (this.OrderNumber?.Equals(other.OrderNumber) == true)) &&
                ((this.PoNumber == null && other.PoNumber == null) || (this.PoNumber?.Equals(other.PoNumber) == true)) &&
                ((this.QuickInvoiceId == null && other.QuickInvoiceId == null) || (this.QuickInvoiceId?.Equals(other.QuickInvoiceId) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true)) &&
                ((this.RecurringNumber == null && other.RecurringNumber == null) || (this.RecurringNumber?.Equals(other.RecurringNumber) == true)) &&
                ((this.RoomNum == null && other.RoomNum == null) || (this.RoomNum?.Equals(other.RoomNum) == true)) &&
                ((this.RoomRate == null && other.RoomRate == null) || (this.RoomRate?.Equals(other.RoomRate) == true)) &&
                ((this.SaveAccount == null && other.SaveAccount == null) || (this.SaveAccount?.Equals(other.SaveAccount) == true)) &&
                ((this.SaveAccountTitle == null && other.SaveAccountTitle == null) || (this.SaveAccountTitle?.Equals(other.SaveAccountTitle) == true)) &&
                ((this.SubtotalAmount == null && other.SubtotalAmount == null) || (this.SubtotalAmount?.Equals(other.SubtotalAmount) == true)) &&
                ((this.SurchargeAmount == null && other.SurchargeAmount == null) || (this.SurchargeAmount?.Equals(other.SurchargeAmount) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.Tax == null && other.Tax == null) || (this.Tax?.Equals(other.Tax) == true)) &&
                ((this.TipAmount == null && other.TipAmount == null) || (this.TipAmount?.Equals(other.TipAmount) == true)) &&
                this.TransactionAmount.Equals(other.TransactionAmount) &&
                ((this.SecondaryAmount == null && other.SecondaryAmount == null) || (this.SecondaryAmount?.Equals(other.SecondaryAmount) == true)) &&
                ((this.TransactionApiId == null && other.TransactionApiId == null) || (this.TransactionApiId?.Equals(other.TransactionApiId) == true)) &&
                ((this.TransactionC1 == null && other.TransactionC1 == null) || (this.TransactionC1?.Equals(other.TransactionC1) == true)) &&
                ((this.TransactionC2 == null && other.TransactionC2 == null) || (this.TransactionC2?.Equals(other.TransactionC2) == true)) &&
                ((this.TransactionC3 == null && other.TransactionC3 == null) || (this.TransactionC3?.Equals(other.TransactionC3) == true)) &&
                ((this.BankFundedOnlyOverride == null && other.BankFundedOnlyOverride == null) || (this.BankFundedOnlyOverride?.Equals(other.BankFundedOnlyOverride) == true)) &&
                ((this.AllowPartialAuthorizationOverride == null && other.AllowPartialAuthorizationOverride == null) || (this.AllowPartialAuthorizationOverride?.Equals(other.AllowPartialAuthorizationOverride) == true)) &&
                ((this.AutoDeclineCvvOverride == null && other.AutoDeclineCvvOverride == null) || (this.AutoDeclineCvvOverride?.Equals(other.AutoDeclineCvvOverride) == true)) &&
                ((this.AutoDeclineStreetOverride == null && other.AutoDeclineStreetOverride == null) || (this.AutoDeclineStreetOverride?.Equals(other.AutoDeclineStreetOverride) == true)) &&
                ((this.AutoDeclineZipOverride == null && other.AutoDeclineZipOverride == null) || (this.AutoDeclineZipOverride?.Equals(other.AutoDeclineZipOverride) == true)) &&
                ((this.AchIdentifier == null && other.AchIdentifier == null) || (this.AchIdentifier?.Equals(other.AchIdentifier) == true)) &&
                ((this.AchSecCode == null && other.AchSecCode == null) || (this.AchSecCode?.Equals(other.AchSecCode) == true)) &&
                ((this.EffectiveDate == null && other.EffectiveDate == null) || (this.EffectiveDate?.Equals(other.EffectiveDate) == true)) &&
                ((this.PreviousTransactionId == null && other.PreviousTransactionId == null) || (this.PreviousTransactionId?.Equals(other.PreviousTransactionId) == true)) &&
                ((this.PreviousTransactionApiId == null && other.PreviousTransactionApiId == null) || (this.PreviousTransactionApiId?.Equals(other.PreviousTransactionApiId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AdditionalAmounts = {(this.AdditionalAmounts == null ? "null" : $"[{string.Join(", ", this.AdditionalAmounts)} ]")}");
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.CheckinDate = {(this.CheckinDate == null ? "null" : this.CheckinDate)}");
            toStringOutput.Add($"this.CheckoutDate = {(this.CheckoutDate == null ? "null" : this.CheckoutDate)}");
            toStringOutput.Add($"this.ClerkNumber = {(this.ClerkNumber == null ? "null" : this.ClerkNumber)}");
            toStringOutput.Add($"this.ContactApiId = {(this.ContactApiId == null ? "null" : this.ContactApiId)}");
            toStringOutput.Add($"this.ContactId = {(this.ContactId == null ? "null" : this.ContactId)}");
            toStringOutput.Add($"CustomData = {(this.CustomData == null ? "null" : this.CustomData.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.IdentityVerification = {(this.IdentityVerification == null ? "null" : this.IdentityVerification.ToString())}");
            toStringOutput.Add($"this.IiasInd = {(this.IiasInd == null ? "null" : this.IiasInd.ToString())}");
            toStringOutput.Add($"this.ImageFront = {(this.ImageFront == null ? "null" : this.ImageFront)}");
            toStringOutput.Add($"this.ImageBack = {(this.ImageBack == null ? "null" : this.ImageBack)}");
            toStringOutput.Add($"this.Installment = {(this.Installment == null ? "null" : this.Installment.ToString())}");
            toStringOutput.Add($"this.InstallmentNumber = {(this.InstallmentNumber == null ? "null" : this.InstallmentNumber.ToString())}");
            toStringOutput.Add($"this.InstallmentCount = {(this.InstallmentCount == null ? "null" : this.InstallmentCount.ToString())}");
            toStringOutput.Add($"this.LocationApiId = {(this.LocationApiId == null ? "null" : this.LocationApiId)}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId)}");
            toStringOutput.Add($"this.ProductTransactionId = {(this.ProductTransactionId == null ? "null" : this.ProductTransactionId)}");
            toStringOutput.Add($"this.AdvanceDeposit = {(this.AdvanceDeposit == null ? "null" : this.AdvanceDeposit.ToString())}");
            toStringOutput.Add($"this.NoShow = {(this.NoShow == null ? "null" : this.NoShow.ToString())}");
            toStringOutput.Add($"this.NotificationEmailAddress = {(this.NotificationEmailAddress == null ? "null" : this.NotificationEmailAddress)}");
            toStringOutput.Add($"this.OrderNumber = {(this.OrderNumber == null ? "null" : this.OrderNumber)}");
            toStringOutput.Add($"this.PoNumber = {(this.PoNumber == null ? "null" : this.PoNumber)}");
            toStringOutput.Add($"this.QuickInvoiceId = {(this.QuickInvoiceId == null ? "null" : this.QuickInvoiceId)}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");
            toStringOutput.Add($"this.RecurringNumber = {(this.RecurringNumber == null ? "null" : this.RecurringNumber.ToString())}");
            toStringOutput.Add($"this.RoomNum = {(this.RoomNum == null ? "null" : this.RoomNum)}");
            toStringOutput.Add($"this.RoomRate = {(this.RoomRate == null ? "null" : this.RoomRate.ToString())}");
            toStringOutput.Add($"this.SaveAccount = {(this.SaveAccount == null ? "null" : this.SaveAccount.ToString())}");
            toStringOutput.Add($"this.SaveAccountTitle = {(this.SaveAccountTitle == null ? "null" : this.SaveAccountTitle)}");
            toStringOutput.Add($"this.SubtotalAmount = {(this.SubtotalAmount == null ? "null" : this.SubtotalAmount.ToString())}");
            toStringOutput.Add($"this.SurchargeAmount = {(this.SurchargeAmount == null ? "null" : this.SurchargeAmount.ToString())}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
            toStringOutput.Add($"this.Tax = {(this.Tax == null ? "null" : this.Tax.ToString())}");
            toStringOutput.Add($"this.TipAmount = {(this.TipAmount == null ? "null" : this.TipAmount.ToString())}");
            toStringOutput.Add($"this.TransactionAmount = {this.TransactionAmount}");
            toStringOutput.Add($"this.SecondaryAmount = {(this.SecondaryAmount == null ? "null" : this.SecondaryAmount.ToString())}");
            toStringOutput.Add($"this.TransactionApiId = {(this.TransactionApiId == null ? "null" : this.TransactionApiId)}");
            toStringOutput.Add($"this.TransactionC1 = {(this.TransactionC1 == null ? "null" : this.TransactionC1)}");
            toStringOutput.Add($"this.TransactionC2 = {(this.TransactionC2 == null ? "null" : this.TransactionC2)}");
            toStringOutput.Add($"this.TransactionC3 = {(this.TransactionC3 == null ? "null" : this.TransactionC3)}");
            toStringOutput.Add($"this.BankFundedOnlyOverride = {(this.BankFundedOnlyOverride == null ? "null" : this.BankFundedOnlyOverride.ToString())}");
            toStringOutput.Add($"this.AllowPartialAuthorizationOverride = {(this.AllowPartialAuthorizationOverride == null ? "null" : this.AllowPartialAuthorizationOverride.ToString())}");
            toStringOutput.Add($"this.AutoDeclineCvvOverride = {(this.AutoDeclineCvvOverride == null ? "null" : this.AutoDeclineCvvOverride.ToString())}");
            toStringOutput.Add($"this.AutoDeclineStreetOverride = {(this.AutoDeclineStreetOverride == null ? "null" : this.AutoDeclineStreetOverride.ToString())}");
            toStringOutput.Add($"this.AutoDeclineZipOverride = {(this.AutoDeclineZipOverride == null ? "null" : this.AutoDeclineZipOverride.ToString())}");
            toStringOutput.Add($"this.AchIdentifier = {(this.AchIdentifier == null ? "null" : this.AchIdentifier)}");
            toStringOutput.Add($"this.AchSecCode = {(this.AchSecCode == null ? "null" : this.AchSecCode.ToString())}");
            toStringOutput.Add($"this.EffectiveDate = {(this.EffectiveDate == null ? "null" : this.EffectiveDate)}");
            toStringOutput.Add($"this.PreviousTransactionId = {(this.PreviousTransactionId == null ? "null" : this.PreviousTransactionId)}");
            toStringOutput.Add($"this.PreviousTransactionApiId = {(this.PreviousTransactionApiId == null ? "null" : this.PreviousTransactionApiId)}");

            base.ToString(toStringOutput);
        }
    }
}