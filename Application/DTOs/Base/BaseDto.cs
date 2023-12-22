using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Base
{
    public class UserDTO
    {
        public Task IsValid()
        {
            return Task.CompletedTask;
        }
    }
}
