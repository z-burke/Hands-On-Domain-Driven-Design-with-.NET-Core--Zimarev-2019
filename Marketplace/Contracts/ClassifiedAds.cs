using System;

namespace Marketplace.Contracts
{
    public static class ClassifiedAds
    {
        public static class V1
        {
            public class Create
            {
                public Guid ID { get; set; }
                public Guid OwnerId { get; set; }
            }
        }
    }
}
