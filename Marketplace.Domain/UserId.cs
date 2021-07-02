using System;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class UserId : Value<UserId>
    {
        private readonly Guid Value;

        public UserId(Guid value) => Value = value;

        public static implicit operator Guid(UserId self) => self.Value;
    }
}
