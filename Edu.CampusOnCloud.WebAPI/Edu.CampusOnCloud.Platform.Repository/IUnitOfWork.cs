using System;
using System.Data.Entity;

namespace Edu.CampusOnCloud.Platform.Repository
{
    public interface IUnitOfWork
    {
        void Commit();
        DbContext Context { get; }
    }
}
