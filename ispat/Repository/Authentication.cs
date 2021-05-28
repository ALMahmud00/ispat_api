using ispat.DbContexts;
using ispat.DTO.Authentication;
using ispat.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ispat.Repository
{
    public class Authentication : IAuthentication
    {
        private readonly ReadWriteContext _context;
        public Authentication(ReadWriteContext Context)
        {
            _context = Context;
        }
        public async Task<LogInInformationDTO> LogIn(LogInDTO obj)
        {
            var data = await Task.FromResult(_context.Credential.FirstOrDefault(x=>x.MobileNumber == obj.MobileNumber && x.Password == obj.Password && x.IsBlock == false));

            if (data == null)
            {
                throw new Exception("Username or password is not valid!");
            }

            var result = new LogInInformationDTO();

            result.UserName = data.UserName;
            result.Token = "token to be generate";

            return result;             
        }
    }
}
