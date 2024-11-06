using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_challenge.Services
{
    public class AuthService
    {
            public async Task<bool> IsAuthetnticatedAsync()
            {
                await Task.Delay(2000);
                return false;
            }
    }
}
