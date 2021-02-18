using Context;
using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Generic;
using Repositories.Interfaces;

namespace Repositories
{
    public class AssetRepository : DbRepository<Asset>, IAssetRepository
    {
        public AssetRepository(AppDbContext context) : base(context)
        {

        }
    }
}
