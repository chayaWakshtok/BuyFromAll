using Entities.DataManagers;
using Entities.Retail;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.DataManagers.IDataManager;

namespace DAL.MySqlManagers
{
    public class MySqlPaymentManager : IPaymentManager
    {
        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public PaymentEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<PaymentEntity>> GetAllEntityAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<PaymentEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(PaymentEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(PaymentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
