/*
 * HealthOS.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 02/18/2017
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
using HealthOS.PCL;
using HealthOS.PCL.Utilities;

namespace HealthOS.PCL.Models
{
    public class LabTestData34 : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string orderingInformation;
        private string laboratory;
        private string testCode;
        private string specimenTypes;
        private string containerTypes;
        private string collectionInstructions;
        private string frequency;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Ordering information")]
        public string OrderingInformation 
        { 
            get 
            {
                return this.orderingInformation; 
            } 
            set 
            {
                this.orderingInformation = value;
                onPropertyChanged("OrderingInformation");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Laboratory")]
        public string Laboratory 
        { 
            get 
            {
                return this.laboratory; 
            } 
            set 
            {
                this.laboratory = value;
                onPropertyChanged("Laboratory");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Test Code")]
        public string TestCode 
        { 
            get 
            {
                return this.testCode; 
            } 
            set 
            {
                this.testCode = value;
                onPropertyChanged("TestCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Specimen types")]
        public string SpecimenTypes 
        { 
            get 
            {
                return this.specimenTypes; 
            } 
            set 
            {
                this.specimenTypes = value;
                onPropertyChanged("SpecimenTypes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Container types")]
        public string ContainerTypes 
        { 
            get 
            {
                return this.containerTypes; 
            } 
            set 
            {
                this.containerTypes = value;
                onPropertyChanged("ContainerTypes");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Collection Instructions")]
        public string CollectionInstructions 
        { 
            get 
            {
                return this.collectionInstructions; 
            } 
            set 
            {
                this.collectionInstructions = value;
                onPropertyChanged("CollectionInstructions");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency 
        { 
            get 
            {
                return this.frequency; 
            } 
            set 
            {
                this.frequency = value;
                onPropertyChanged("Frequency");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 