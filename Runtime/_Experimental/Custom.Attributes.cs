#region Header
// **    Copyright (C) 2023 Nicolas Reinhard, @LTMX. All rights reserved.
// **    Github Profile: https://github.com/LTMX
// **    Repository : https://github.com/LTMX/Unity.Mathematics-Extensions
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using AOT;
using Unity.Burst;

namespace Unity.Mathematics
{
    public interface IMetadataAttribute
    {
        Attribute[] Process();
    }

    // public class MySampleMetadataAttribute : Attribute, IMetadataAttribute
    // {
    //     public Attribute[] Process() {
    //         var attributes = new Attribute[]
    //         {
    //             new BrowsableAttribute(false),
    //             new EditorBrowsableAttribute(EditorBrowsableState.Never),
    //             new BindableAttribute(false),
    //             new DesignerSerializationVisibilityAttribute(
    //                 DesignerSerializationVisibility.Hidden),
    //             new ObsoleteAttribute("", true)
    //         };
    //         return attributes;
    //     }
    // }
    
    public class InlineAttribute : Attribute
    {
        public Attribute Process() => new MethodImplAttribute(MethodImplOptions.AggressiveInlining);
    }
    
    public class ILAttribute : Attribute
    {
        public Attribute Process() => new MethodImplAttribute(MethodImplOptions.AggressiveInlining);
    }

    public class IL2CPPBurstCompiledAttribute : Attribute, IMetadataAttribute
    {
        public Attribute[] Process() => new Attribute[]{ new BurstCompileAttribute(), new MonoPInvokeCallbackAttribute(typeof(Operations.p2f1)) };
    }
    
    public class MathxAttribute : Attribute
    {
        public Attribute Process() => new BurstCompileAttribute(FloatPrecision.Low, FloatMode.Fast);
    }
    
    public class BurstPerforbanceAttribute : Attribute
    {
        public Attribute Process() => new BurstCompileAttribute { OptimizeFor = OptimizeFor.Performance };
    }

    public class MyPropertyDescriptor : PropertyDescriptor
    {
        private readonly PropertyDescriptor original;
        public MyPropertyDescriptor(PropertyDescriptor originalProperty)
            : base(originalProperty) {
            original = originalProperty;
        }
    
        public override AttributeCollection Attributes
        {
            get {
                var attributes = base.Attributes.Cast<Attribute>();
                var result = new List<Attribute>();
                foreach (var item in attributes)
                    if (item is IMetadataAttribute attribute) {
                        var attrs = attribute.Process();
                        if (attrs != null) result.AddRange(attrs);
                    }
                    else result.Add(item);
    
                return new AttributeCollection(result.ToArray());
            }
        }
    
        // Implement other properties and methods simply using return original
        // The implementation is trivial like this one:
        public override Type ComponentType => original.ComponentType;
        public override bool CanResetValue(object component) => throw new NotImplementedException();
        public override object GetValue(object component) => throw new NotImplementedException();
        public override void ResetValue(object component) => throw new NotImplementedException();
        public override void SetValue(object component, object value) => throw new NotImplementedException();
        public override bool ShouldSerializeValue(object component) => throw new NotImplementedException();
    
        // public override Type ComponentType { get; }
        public override bool IsReadOnly { get; }
        public override Type PropertyType { get; }
    }

    public class MyTypeDescriptor : CustomTypeDescriptor
    {
        private ICustomTypeDescriptor original;
        public MyTypeDescriptor(ICustomTypeDescriptor originalDescriptor) : base(originalDescriptor) => original = originalDescriptor;
        public override PropertyDescriptorCollection GetProperties() => GetProperties(new Attribute[] { });
        public override PropertyDescriptorCollection GetProperties(Attribute[] attributes) {
            var properties = base.GetProperties(attributes).Cast<PropertyDescriptor>()
                .Select(p => new MyPropertyDescriptor(p))
                .ToArray();
            return new PropertyDescriptorCollection(properties);
        }
    }
    
    public class MyTypeDescriptionProvider : TypeDescriptionProvider
    {
        public MyTypeDescriptionProvider() : base(TypeDescriptor.GetProvider(typeof(object))) { }
        public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) => new MyTypeDescriptor(base.GetTypeDescriptor(objectType, instance));
    }

    [TypeDescriptionProvider(typeof(MyTypeDescriptionProvider))]
    public class MySampleClass
    {
        public int Id { get; set; }
    
        // [MySampleMetadata] 
        [DisplayName("My Name")]
        public string Name { get; set; }
    }
}