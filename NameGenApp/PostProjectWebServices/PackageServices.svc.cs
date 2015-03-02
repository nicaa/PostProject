using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PostProjectWebServices.Models;
using PostProjectWebServices.Models.Repositories;

namespace PostProjectWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PackageServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PackageServices.svc or PackageServices.svc.cs at the Solution Explorer and start debugging.
    public class PackageServices : IPackageServices
    {
        private IPackageRepository _packageRepository = new PackageRepository();
        public void DoWork()
        {
            System.Diagnostics.Debug.WriteLine("Hello din service consumer!");
        }

        public Package GetPackage(int packageId)
        {
            Package package = _packageRepository.GetPackage(packageId);
            return package;
        }

        public void CreatePackage(string firstName, string lastName, string street, string city, string postalCode)
        {
            Package package = new Package();
            package.recipientFirstName = firstName;
            package.recipientLastName = lastName;
            package.recipientStreet = street;
            package.recipientCity = city;
            package.recipientPostalCode = postalCode;

            _packageRepository.CreatePackage(package);
        }

    }
}
