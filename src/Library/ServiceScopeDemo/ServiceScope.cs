using System;

namespace ServiceScopeDemo
{
    public sealed class ServiceScope : IServiceScope
    {
        private Guid Number { get; set; }
        public ServiceScope()
        {
            Number = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return Number;
        }
    }
}