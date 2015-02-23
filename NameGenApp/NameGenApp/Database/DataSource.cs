using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenApp.Database
{
    public class DataSource
    {
        // Database
        private readonly String SERVER = "server=localhost;";
        private readonly String DATABASE = "database=test;";
        private readonly String USER = "user=root;";
        private readonly String PASSWORD = "password=1234";

        private readonly String packageId = "packageId";
        private readonly String packageSender = "sender";
        

        // Tables
        private readonly String TABLE_PERSONS = "person";
        private readonly String TABLE_PACKAGES = "packages";

        // Package table columns
        private readonly String PACKAGE_ID = "packageId";
        private readonly String RECIPIENT_FIRST_NAME = "recipientFirstName";
        private readonly String RECIPIENT_LAST_NAME = "recipientLastName";
        private readonly String DESTINATION_STREET = "destinationStreet";
        private readonly String DESTINATION_CITY = "destinationCity";
        private readonly String DESTINATION_POSTAL_CODE = "destinationPostalCode";

        public string Server
        {
            get { return SERVER; }
        }

        public string Database
        {
            get { return DATABASE; }
        }

        public string User
        {
            get { return USER; }
        }

        public string Password
        {
            get { return PASSWORD; }
        }

        public string TablePersons
        {
            get { return TABLE_PERSONS; }
        }

        public string TablePackages
        {
            get { return TABLE_PACKAGES; }
        }

        public string PackageId
        {
            get { return PACKAGE_ID; }
        }

        public string DestinationStreet
        {
            get { return DESTINATION_STREET; }
        }

        public string DestinationCity
        {
            get { return DESTINATION_CITY; }
        }

        public string DestinationPostalCode
        {
            get { return DESTINATION_POSTAL_CODE; }
        }

        public string RecipientFirstName
        {
            get { return RECIPIENT_FIRST_NAME; }
        }

        public string RecipientLastName
        {
            get { return RECIPIENT_LAST_NAME; }
        }
    }
}
