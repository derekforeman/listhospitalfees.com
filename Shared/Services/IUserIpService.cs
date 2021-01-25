using System;
using System.Threading.Tasks;
using ListHospitalFees.Shared.Model;

namespace ListHospitalFees.Shared.Services
{
    public interface IUserIpService
    {
        Task<IPAddress> GetUserIPAsync();
    }
}
