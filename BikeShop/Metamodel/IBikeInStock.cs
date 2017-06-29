//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace BikeShop.BicycleChallenge
{
    
    
    /// <summary>
    /// The public interface for BikeInStock
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BikeInStock))]
    [XmlDefaultImplementationTypeAttribute(typeof(BikeInStock))]
    public interface IBikeInStock : IModelElement
    {
        
        /// <summary>
        /// The DiscountedPrice property
        /// </summary>
        Nullable<double> DiscountedPrice
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Model property
        /// </summary>
        IBicycle Model
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the DiscountedPrice property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DiscountedPriceChanging;
        
        /// <summary>
        /// Gets fired when the DiscountedPrice property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> DiscountedPriceChanged;
        
        /// <summary>
        /// Gets fired before the Model property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ModelChanging;
        
        /// <summary>
        /// Gets fired when the Model property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ModelChanged;
    }
}

