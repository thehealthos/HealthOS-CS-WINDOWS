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
    public class SideEffect : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string term;
        private int count;
        private double percent;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("term")]
        public string Term 
        { 
            get 
            {
                return this.term; 
            } 
            set 
            {
                this.term = value;
                onPropertyChanged("Term");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("count")]
        public int Count 
        { 
            get 
            {
                return this.count; 
            } 
            set 
            {
                this.count = value;
                onPropertyChanged("Count");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("percent")]
        public double Percent 
        { 
            get 
            {
                return this.percent; 
            } 
            set 
            {
                this.percent = value;
                onPropertyChanged("Percent");
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