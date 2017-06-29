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
    /// The collection class to implement the refined Purpose attribute for the ProRaceBike class
    /// </summary>
    public class ProRaceBikePurposeCollection : ICollectionExpression<Purpose>, IListExpression<Purpose>
    {
        
        private IProRaceBike _parent;
        
        private static Purpose[] _standardValues = new Purpose[] {
                Purpose.City,
                Purpose.Race,
                Purpose.Race};
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        public ProRaceBikePurposeCollection(IProRaceBike parent)
        {
            this._parent = parent;
        }
        
        /// <summary>
        /// Gets the amount of elements contained in this collection
        /// </summary>
        public virtual int Count
        {
            get
            {
                int count = 3;
                return count;
            }
        }
        
        /// <summary>
        /// Gets a value indicating that the collection is not read-only
        /// </summary>
        public virtual bool IsReadOnly
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets or sets the item at the given position
        /// </summary>
        public virtual Purpose this[int index]
        {
            get
            {
                if ((index < 3))
                {
                    return ProRaceBikePurposeCollection._standardValues[index];
                }
                int runningIndex = 3;
                throw new System.IndexOutOfRangeException();
            }
            set
            {
                int runningIndex = 3;
                throw new System.IndexOutOfRangeException();
            }
        }
        
        /// <summary>
        /// Returns that this composed collection is always attached.
        /// </summary>
        public bool IsAttached
        {
            get
            {
                return true;
            }
        }
        
        /// <summary>
        /// Gets fired when the contents of this collection changes
        /// </summary>
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        
        /// <summary>
        /// Fires the CollectionChanged event
        /// </summary>
        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
        {
            System.Collections.Specialized.NotifyCollectionChangedEventHandler handler = this.CollectionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Adds the given element to the collection
        /// </summary>
        /// <param name="item">The item to add</param>
        public virtual void Add(Purpose item)
        {
        }
        
        /// <summary>
        /// Clears the collection and resets all attributes that implement it.
        /// </summary>
        public virtual void Clear()
        {
        }
        
        /// <summary>
        /// Gets a value indicating whether the given element is contained in the collection
        /// </summary>
        /// <returns>True, if it is contained, otherwise False</returns>
        /// <param name="item">The item that should be looked out for</param>
        public virtual bool Contains(Purpose item)
        {
            if (ProRaceBikePurposeCollection._standardValues.Contains(item))
            {
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// Copies the contents of the collection to the given array starting from the given array index
        /// </summary>
        /// <param name="array">The array in which the elements should be copied</param>
        /// <param name="arrayIndex">The starting index</param>
        public virtual void CopyTo(Purpose[] array, int arrayIndex)
        {
            ProRaceBikePurposeCollection._standardValues.CopyTo(array, arrayIndex);
            arrayIndex = (arrayIndex + 3);
        }
        
        /// <summary>
        /// Removes the given item from the collection
        /// </summary>
        /// <returns>True, if the item was removed, otherwise False</returns>
        /// <param name="item">The item that should be removed</param>
        public virtual bool Remove(Purpose item)
        {
            return false;
        }
        
        /// <summary>
        /// Gets an enumerator that enumerates the collection
        /// </summary>
        /// <returns>A generic enumerator</returns>
        public virtual IEnumerator<Purpose> GetEnumerator()
        {
            return ProRaceBikePurposeCollection._standardValues.Cast<Purpose>().GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the index of the given element
        /// </summary>
        /// <returns>The index of the given element or -1 if it was not found</returns>
        /// <param name="item">The item that should be looked for</param>
        public virtual int IndexOf(Purpose item)
        {
            for (int i = 0; (i < 3); i = (i + 1))
            {
                if ((ProRaceBikePurposeCollection._standardValues[i] == item))
                {
                    return i;
                }
            }
            int runningIndex = 3;
            int index;
            return -1;
        }
        
        /// <summary>
        /// Inserts the given item at the given index of the collection
        /// </summary>
        /// <param name="index">The index where to add the item</param>
        /// <param name="item">The item that should be added</param>
        public virtual void Insert(int index, Purpose item)
        {
            int runningIndex = 3;
            throw new ArgumentOutOfRangeException("index");
        }
        
        /// <summary>
        /// Removes the item at the given position
        /// </summary>
        /// <param name="index">The index where to remove the item</param>
        public virtual void RemoveAt(int index)
        {
            int runningIndex = 3;
            throw new ArgumentOutOfRangeException("index");
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        public virtual INotifyCollection<Purpose> AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable<Purpose> IEnumerableExpression<Purpose>.AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Gets an observable version of this collection
        /// </summary>
        INotifyEnumerable IEnumerableExpression.AsNotifiable()
        {
            return this.WithUpdates();
        }
        
        /// <summary>
        /// Attaches this collection class
        /// </summary>
        public void Attach()
        {
        }
        
        /// <summary>
        /// Detaches this collection class
        /// </summary>
        public void Detach()
        {
        }
    }
}

