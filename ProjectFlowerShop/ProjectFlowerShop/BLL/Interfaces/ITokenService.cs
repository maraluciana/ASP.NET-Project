using ProjectFlowerShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectFlowerShop.BLL.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(User user);

    }
}
