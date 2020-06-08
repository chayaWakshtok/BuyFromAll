﻿using Entities.DataManagers;
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
    public class MySqlItemManager : IItemManager
    {
        public Task<int> AddRelationAsync(ItemEntity parentEntity, IItemChildManager listedEntity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteEntityAsync(int key)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteRelationAsync(int parentEntityKey, int listedEntityKey)
        {
            throw new NotImplementedException();
        }

        public ItemEntity FillEntity(DataRow row, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemEntity>> GetEntitiesAsync(Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<ItemEntity> GetEntityAsync(int key, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<IList<IItemChildManager>> GetRelatedEntitiesAsync(int parentEntityKey, int start = 0, int count = 100, Includes includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveEntityAsync(ItemEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEntityAsync(ItemEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}