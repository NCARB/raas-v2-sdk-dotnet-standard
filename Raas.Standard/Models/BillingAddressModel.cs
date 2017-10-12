/*
 * Raas.Standard
 *
 * This file was automatically generated for Tango Card, Inc. by APIMATIC v2.0 ( https://apimatic.io )
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
    public class BillingAddressModel : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string firstName;
        private string lastName;
        private string addressLine1;
        private string city;
        private string state;
        private string postalCode;
        private string country;
        private string emailAddress;
        private string addressLine2;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName 
        { 
            get 
            {
                return this.firstName; 
            } 
            set 
            {
                this.firstName = value;
                onPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName 
        { 
            get 
            {
                return this.lastName; 
            } 
            set 
            {
                this.lastName = value;
                onPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("addressLine1")]
        public string AddressLine1 
        { 
            get 
            {
                return this.addressLine1; 
            } 
            set 
            {
                this.addressLine1 = value;
                onPropertyChanged("AddressLine1");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("city")]
        public string City 
        { 
            get 
            {
                return this.city; 
            } 
            set 
            {
                this.city = value;
                onPropertyChanged("City");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("state")]
        public string State 
        { 
            get 
            {
                return this.state; 
            } 
            set 
            {
                this.state = value;
                onPropertyChanged("State");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode 
        { 
            get 
            {
                return this.postalCode; 
            } 
            set 
            {
                this.postalCode = value;
                onPropertyChanged("PostalCode");
            }
        }

        /// <summary>
        /// 2-letter country code
        /// </summary>
        [JsonProperty("country")]
        public string Country 
        { 
            get 
            {
                return this.country; 
            } 
            set 
            {
                this.country = value;
                onPropertyChanged("Country");
            }
        }

        /// <summary>
        /// billing email address
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress 
        { 
            get 
            {
                return this.emailAddress; 
            } 
            set 
            {
                this.emailAddress = value;
                onPropertyChanged("EmailAddress");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("addressLine2")]
        public string AddressLine2 
        { 
            get 
            {
                return this.addressLine2; 
            } 
            set 
            {
                this.addressLine2 = value;
                onPropertyChanged("AddressLine2");
            }
        }
    }
} 