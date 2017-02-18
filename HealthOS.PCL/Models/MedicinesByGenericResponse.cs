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
    public class MedicinesByGenericResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string name;
        private string form;
        private int standardUnits;
        private string packageForm;
        private double price;
        private string size;
        private string manufacturer;
        private List<Constituent> constituents;
        private Schedule schedule;
        private string medicineId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("form")]
        public string Form 
        { 
            get 
            {
                return this.form; 
            } 
            set 
            {
                this.form = value;
                onPropertyChanged("Form");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("standardUnits")]
        public int StandardUnits 
        { 
            get 
            {
                return this.standardUnits; 
            } 
            set 
            {
                this.standardUnits = value;
                onPropertyChanged("StandardUnits");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("packageForm")]
        public string PackageForm 
        { 
            get 
            {
                return this.packageForm; 
            } 
            set 
            {
                this.packageForm = value;
                onPropertyChanged("PackageForm");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("price")]
        public double Price 
        { 
            get 
            {
                return this.price; 
            } 
            set 
            {
                this.price = value;
                onPropertyChanged("Price");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("size")]
        public string Size 
        { 
            get 
            {
                return this.size; 
            } 
            set 
            {
                this.size = value;
                onPropertyChanged("Size");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("manufacturer")]
        public string Manufacturer 
        { 
            get 
            {
                return this.manufacturer; 
            } 
            set 
            {
                this.manufacturer = value;
                onPropertyChanged("Manufacturer");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("constituents")]
        public List<Constituent> Constituents 
        { 
            get 
            {
                return this.constituents; 
            } 
            set 
            {
                this.constituents = value;
                onPropertyChanged("Constituents");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("schedule")]
        public Schedule Schedule 
        { 
            get 
            {
                return this.schedule; 
            } 
            set 
            {
                this.schedule = value;
                onPropertyChanged("Schedule");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("medicine_id")]
        public string MedicineId 
        { 
            get 
            {
                return this.medicineId; 
            } 
            set 
            {
                this.medicineId = value;
                onPropertyChanged("MedicineId");
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