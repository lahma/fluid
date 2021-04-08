using System;
using System.Reflection;
using Microsoft.Extensions.Internal;

namespace Fluid.Accessors
{
    public sealed class PropertyInfoAccessor : IMemberAccessor
    {
        private readonly PropertyInfo _propertyInfo;
        private Func<object, object> _getter;

        public PropertyInfoAccessor(PropertyInfo propertyInfo)
        {
            _propertyInfo = propertyInfo;
        }

        public object Get(object obj, string name, TemplateContext ctx)
        {
            _getter ??= PropertyHelper.MakeFastPropertyGetter(_propertyInfo);
            return _getter(obj);
        }
    }
}
