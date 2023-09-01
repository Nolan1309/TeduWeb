using System;
using System.Collections.Generic;
using System.Text;

namespace TeduWeb.Infrastructure.SharedKernel
{
    public abstract class DomainEntity<T>
    {
        public T Id { get; set; }

        //True if domain entity has an identity
        //Mặc định True , nếu có ID đúng thì false
        public bool IsTranient() 
        {
            return Id.Equals(default(T));
        }
    }
}
