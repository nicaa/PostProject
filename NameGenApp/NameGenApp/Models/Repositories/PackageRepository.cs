using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NameGenApp.Models.Repositories
{
    class PackageRepository : IPackageRepository
    {
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public Package FindPackage(int packageId)
        {
            throw new NotImplementedException();
        }

        public Package SendPackage(int packageId)
        {
            throw new NotImplementedException();
        }

        public void CreatePackage()
        {
            throw new NotImplementedException();
        }
    }

    interface IPackageRepository
    {
        void GetAll();
        Package FindPackage(int packageId);
        Package SendPackage(int packageId);
        void CreatePackage();

    }
}
