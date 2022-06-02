using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2WebAPI.Core.Shared
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; protected set; }
    }
}
