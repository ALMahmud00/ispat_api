using ispat.DTO.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ispat.IRepository
{
    public interface IAuthentication
    {
        public Task<LogInInformationDTO> LogIn(LogInDTO obj);
    }
}
