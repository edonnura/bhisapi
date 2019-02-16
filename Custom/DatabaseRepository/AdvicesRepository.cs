using BHISApi.Custom.DatabaseHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BHISApi.Custom.DatabaseRepository
{
    public class AdvicesRepository
    {
        public async Task<DatabaseResult<dynamic>> GetAdvices()
          => (await new Query().Select<dynamic>("GetAdvices"));
    }
}
