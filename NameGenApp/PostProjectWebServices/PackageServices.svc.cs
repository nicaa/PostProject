using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PostProjectWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PackageServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PackageServices.svc or PackageServices.svc.cs at the Solution Explorer and start debugging.
    public class PackageServices : IPackageServices
    {
        public void DoWork()
        {
            System.Diagnostics.Debug.WriteLine("Hello din service consumer!");
        }
    }
}
