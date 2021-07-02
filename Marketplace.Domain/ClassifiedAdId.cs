using System;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class ClassifiedAdId : Value<ClassifiedAdId>
    {
        private readonly Guid Value;

        public ClassifiedAdId(Guid value)
        {
            if (value == default) throw new ArgumentNullException(nameof(value), "Classified Ad id cannot be empty");
            Value = value;
        }

        public static implicit operator Guid(ClassifiedAdId self) => self.Value;
    }
}
