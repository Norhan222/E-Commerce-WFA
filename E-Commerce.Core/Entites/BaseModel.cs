using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entites
{
    public abstract class BaseModel<TId> 
    {
        public TId Id { get; set; }
    }
}
