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
    public class FoodItemsByRestaurantResponse : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private string itemName;
        private int calories;
        private double servingQty;
        private string servingUnit;
        private string foodItemId;
        private string foodBrandId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName 
        { 
            get 
            {
                return this.itemName; 
            } 
            set 
            {
                this.itemName = value;
                onPropertyChanged("ItemName");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("calories")]
        public int Calories 
        { 
            get 
            {
                return this.calories; 
            } 
            set 
            {
                this.calories = value;
                onPropertyChanged("Calories");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("serving_qty")]
        public double ServingQty 
        { 
            get 
            {
                return this.servingQty; 
            } 
            set 
            {
                this.servingQty = value;
                onPropertyChanged("ServingQty");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("serving_unit")]
        public string ServingUnit 
        { 
            get 
            {
                return this.servingUnit; 
            } 
            set 
            {
                this.servingUnit = value;
                onPropertyChanged("ServingUnit");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("food_item_id")]
        public string FoodItemId 
        { 
            get 
            {
                return this.foodItemId; 
            } 
            set 
            {
                this.foodItemId = value;
                onPropertyChanged("FoodItemId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("food_brand_id")]
        public string FoodBrandId 
        { 
            get 
            {
                return this.foodBrandId; 
            } 
            set 
            {
                this.foodBrandId = value;
                onPropertyChanged("FoodBrandId");
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