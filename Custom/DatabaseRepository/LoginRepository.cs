using BHISApi.Custom.DatabaseHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BHISApi.Custom.DatabaseRepository
{
    public class LoginRepository
    {
        public async Task<DatabaseSingleResult<int>> CheckPersonalNumber(string PersonalNumber)
           => (await new Query().SelectSingle<int>("[GetIdByPersonalNumber] @PersonalNumber", new { PersonalNumber }));
    }
}
