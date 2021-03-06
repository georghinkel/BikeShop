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
    /// The default implementation of the Configuration class
    /// </summary>
    [XmlNamespaceAttribute("http://www.fzi.de/MULTI/2017/bicycleChallenge")]
    [XmlNamespacePrefixAttribute("bikes")]
    [ModelRepresentationClassAttribute("http://www.fzi.de/MULTI/2017/bicycleChallenge#//Configuration")]
    public abstract partial class Configuration : ModelElement, IConfiguration, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Name property
        /// </summary>
        private string _name;
        
        private static Lazy<ITypedElement> _nameAttribute = new Lazy<ITypedElement>(RetrieveNameAttribute);
        
        private static Lazy<ITypedElement> _componentsReference = new Lazy<ITypedElement>(RetrieveComponentsReference);
        
        /// <summary>
        /// The backing field for the Components property
        /// </summary>
        private ObservableCompositionList<BikeShop.BicycleChallenge.IComponent> _components;
        
        private static IClass _classInstance;
        
        public Configuration()
        {
            this._components = new ObservableCompositionList<BikeShop.BicycleChallenge.IComponent>(this);
            this._components.CollectionChanging += this.ComponentsCollectionChanging;
            this._components.CollectionChanged += this.ComponentsCollectionChanged;
        }
        
        /// <summary>
        /// The Name property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if ((this._name != value))
                {
                    string old = this._name;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNameChanging(e);
                    this.OnPropertyChanging("Name", e, _nameAttribute);
                    this._name = value;
                    this.OnNameChanged(e);
                    this.OnPropertyChanged("Name", e, _nameAttribute);
                }
            }
        }
        
        /// <summary>
        /// The Components property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public ICollectionExpression<BikeShop.BicycleChallenge.IComponent> Components
        {
            get
            {
                return this._components;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ConfigurationChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ConfigurationReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.fzi.de/MULTI/2017/bicycleChallenge#//Configuration")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Name property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanging;
        
        /// <summary>
        /// Gets fired when the Name property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> NameChanged;
        
        private static ITypedElement RetrieveNameAttribute()
        {
            return ((ITypedElement)(((ModelElement)(BikeShop.BicycleChallenge.Configuration.ClassInstance)).Resolve("Name")));
        }
        
        /// <summary>
        /// Raises the NameChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NameChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnNameChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.NameChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveComponentsReference()
        {
            return ((ITypedElement)(((ModelElement)(BikeShop.BicycleChallenge.Configuration.ClassInstance)).Resolve("Components")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Components property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ComponentsCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Components", e, _componentsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Components property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ComponentsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Components", e, _componentsReference);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "NAME"))
            {
                return this.Name;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "COMPONENTS"))
            {
                return this._components;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "NAME"))
            {
                this.Name = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._components))
            {
                return "Components";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://www.fzi.de/MULTI/2017/bicycleChallenge#//Configuration")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Configuration class
        /// </summary>
        public class ConfigurationChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Configuration _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ConfigurationChildrenCollection(Configuration parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Components.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Components.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Components.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                BikeShop.BicycleChallenge.IComponent componentsCasted = item.As<BikeShop.BicycleChallenge.IComponent>();
                if ((componentsCasted != null))
                {
                    this._parent.Components.Add(componentsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Components.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Components.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> componentsEnumerator = this._parent.Components.GetEnumerator();
                try
                {
                    for (
                    ; componentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = componentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    componentsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                BikeShop.BicycleChallenge.IComponent componentItem = item.As<BikeShop.BicycleChallenge.IComponent>();
                if (((componentItem != null) 
                            && this._parent.Components.Remove(componentItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Components).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Configuration class
        /// </summary>
        public class ConfigurationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Configuration _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ConfigurationReferencedElementsCollection(Configuration parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    count = (count + this._parent.Components.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Components.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Components.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                BikeShop.BicycleChallenge.IComponent componentsCasted = item.As<BikeShop.BicycleChallenge.IComponent>();
                if ((componentsCasted != null))
                {
                    this._parent.Components.Add(componentsCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Components.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Components.Contains(item))
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
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                IEnumerator<IModelElement> componentsEnumerator = this._parent.Components.GetEnumerator();
                try
                {
                    for (
                    ; componentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = componentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    componentsEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                BikeShop.BicycleChallenge.IComponent componentItem = item.As<BikeShop.BicycleChallenge.IComponent>();
                if (((componentItem != null) 
                            && this._parent.Components.Remove(componentItem)))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Components).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Name property
        /// </summary>
        private sealed class NameProxy : ModelPropertyChange<IConfiguration, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public NameProxy(IConfiguration modelElement) : 
                    base(modelElement, "Name")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Name;
                }
                set
                {
                    this.ModelElement.Name = value;
                }
            }
        }
    }
}

