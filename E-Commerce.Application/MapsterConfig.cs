using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application
{
    public  class MapsterConfig
    {
        public static void RegisterMapsterconfiguration ()
        {
            //TypeAdapterConfig<category, CategoryDTO>.NewConfig()
            // .Map(des => des.CatId, src => src.id)
            // .Map(des => des.CatName, src => src.name)
        }

    }
}
