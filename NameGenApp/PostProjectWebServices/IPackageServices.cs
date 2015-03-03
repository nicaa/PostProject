using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PostProjectWebServices.Models;

namespace PostProjectWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPackageServices" in both code and config file together.
    [ServiceContract]
    public interface IPackageServices
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        Package GetPackage(int packageId);

        [OperationContract]
        void CreatePackage(String firstName, String lastName, String street, String city, String postalCode);

        [OperationContract]
        void GatherCityStatistics();
    }
}
