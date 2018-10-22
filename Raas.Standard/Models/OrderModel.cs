/*
 * Raas.Standard
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TangoCard.Raas;
using TangoCard.Raas.Utilities;


namespace TangoCard.Raas.Models
{
    public class OrderModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string referenceOrderID;
        private string customerIdentifier;
        private string accountIdentifier;
        private string accountNumber;
        private Models.CurrencyBreakdownModel amountCharged;
        private Models.CurrencyBreakdownModel denomination;
        private string utid;
        private string rewardName;
        private Models.NameEmailModel sender;
        private Models.NameEmailModel recipient;
        private bool sendEmail;
        private string etid;
        private string status;
        private DateTime createdAt;
        private Models.RewardModel reward;
        private string campaign;
        private string emailSubject;
        private string externalRefID;
        private string message;
        private string notes;
        private Models.CurrencyBreakdownModel marginShare;

        /// <summary>
        /// The reference order id
        /// </summary>
        [JsonProperty("referenceOrderID")]
        public string ReferenceOrderID 
        { 
            get 
            {
                return this.referenceOrderID; 
            } 
            set 
            {
                this.referenceOrderID = value;
                onPropertyChanged("ReferenceOrderID");
            }
        }

        /// <summary>
        /// The customer identifier
        /// </summary>
        [JsonProperty("customerIdentifier")]
        public string CustomerIdentifier 
        { 
            get 
            {
                return this.customerIdentifier; 
            } 
            set 
            {
                this.customerIdentifier = value;
                onPropertyChanged("CustomerIdentifier");
            }
        }

        /// <summary>
        /// The account identifier
        /// </summary>
        [JsonProperty("accountIdentifier")]
        public string AccountIdentifier 
        { 
            get 
            {
                return this.accountIdentifier; 
            } 
            set 
            {
                this.accountIdentifier = value;
                onPropertyChanged("AccountIdentifier");
            }
        }

        /// <summary>
        /// The account number
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber 
        { 
            get 
            {
                return this.accountNumber; 
            } 
            set 
            {
                this.accountNumber = value;
                onPropertyChanged("AccountNumber");
            }
        }

        /// <summary>
        /// The order's amount information
        /// </summary>
        [JsonProperty("amountCharged")]
        public Models.CurrencyBreakdownModel AmountCharged 
        { 
            get 
            {
                return this.amountCharged; 
            } 
            set 
            {
                this.amountCharged = value;
                onPropertyChanged("AmountCharged");
            }
        }

        /// <summary>
        /// Information about the gift card amount
        /// </summary>
        [JsonProperty("denomination")]
        public Models.CurrencyBreakdownModel Denomination 
        { 
            get 
            {
                return this.denomination; 
            } 
            set 
            {
                this.denomination = value;
                onPropertyChanged("Denomination");
            }
        }

        /// <summary>
        /// The UTID
        /// </summary>
        [JsonProperty("utid")]
        public string Utid 
        { 
            get 
            {
                return this.utid; 
            } 
            set 
            {
                this.utid = value;
                onPropertyChanged("Utid");
            }
        }

        /// <summary>
        /// The reward name
        /// </summary>
        [JsonProperty("rewardName")]
        public string RewardName 
        { 
            get 
            {
                return this.rewardName; 
            } 
            set 
            {
                this.rewardName = value;
                onPropertyChanged("RewardName");
            }
        }

        /// <summary>
        /// The sender data
        /// </summary>
        [JsonProperty("sender")]
        public Models.NameEmailModel Sender 
        { 
            get 
            {
                return this.sender; 
            } 
            set 
            {
                this.sender = value;
                onPropertyChanged("Sender");
            }
        }

        /// <summary>
        /// The recipient data
        /// </summary>
        [JsonProperty("recipient")]
        public Models.NameEmailModel Recipient 
        { 
            get 
            {
                return this.recipient; 
            } 
            set 
            {
                this.recipient = value;
                onPropertyChanged("Recipient");
            }
        }

        /// <summary>
        /// Indicates if an email was sent to the recipient
        /// </summary>
        [JsonProperty("sendEmail")]
        public bool SendEmail 
        { 
            get 
            {
                return this.sendEmail; 
            } 
            set 
            {
                this.sendEmail = value;
                onPropertyChanged("SendEmail");
            }
        }

        /// <summary>
        /// The email template id
        /// </summary>
        [JsonProperty("etid")]
        public string Etid 
        { 
            get 
            {
                return this.etid; 
            } 
            set 
            {
                this.etid = value;
                onPropertyChanged("Etid");
            }
        }

        /// <summary>
        /// The order's status
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// When the order was placed
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// Contains the reward credentials
        /// </summary>
        [JsonProperty("reward")]
        public Models.RewardModel Reward 
        { 
            get 
            {
                return this.reward; 
            } 
            set 
            {
                this.reward = value;
                onPropertyChanged("Reward");
            }
        }

        /// <summary>
        /// An optional campaign identifier
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaign 
        { 
            get 
            {
                return this.campaign; 
            } 
            set 
            {
                this.campaign = value;
                onPropertyChanged("Campaign");
            }
        }

        /// <summary>
        /// The subject of the email
        /// </summary>
        [JsonProperty("emailSubject")]
        public string EmailSubject 
        { 
            get 
            {
                return this.emailSubject; 
            } 
            set 
            {
                this.emailSubject = value;
                onPropertyChanged("EmailSubject");
            }
        }

        /// <summary>
        /// An external reference id
        /// </summary>
        [JsonProperty("externalRefID")]
        public string ExternalRefID 
        { 
            get 
            {
                return this.externalRefID; 
            } 
            set 
            {
                this.externalRefID = value;
                onPropertyChanged("ExternalRefID");
            }
        }

        /// <summary>
        /// A message included with the email
        /// </summary>
        [JsonProperty("message")]
        public string Message 
        { 
            get 
            {
                return this.message; 
            } 
            set 
            {
                this.message = value;
                onPropertyChanged("Message");
            }
        }

        /// <summary>
        /// Optional customer notes
        /// </summary>
        [JsonProperty("notes")]
        public string Notes 
        { 
            get 
            {
                return this.notes; 
            } 
            set 
            {
                this.notes = value;
                onPropertyChanged("Notes");
            }
        }

        /// <summary>
        /// Margin share information
        /// </summary>
        [JsonProperty("marginShare")]
        public Models.CurrencyBreakdownModel MarginShare 
        { 
            get 
            {
                return this.marginShare; 
            } 
            set 
            {
                this.marginShare = value;
                onPropertyChanged("MarginShare");
            }
        }
    }
} 