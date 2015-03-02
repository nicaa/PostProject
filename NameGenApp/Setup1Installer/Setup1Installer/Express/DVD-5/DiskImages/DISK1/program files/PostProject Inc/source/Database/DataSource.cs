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
        private readonly String PASSWORD = "password=123";

        private readonly String packageId = "packageId";
        private readonly String packageSender = "sender";
        

        // Tables
        private readonly String TABLE_PACKAGES = "packages";

        // Package table columns
        private readonly String PACKAGE_ID = "packageId";
        private readonly String RECIPIENT_FIRST_NAME = "recipientFirstName";
        private readonly String RECIPIENT_LAST_NAME = "recipientLastName";
        private readonly String RECIPIENT_STREET = "recipientStreet";
        private readonly String RECIPIENT_CITY = "recipientCity";
        private readonly String RECIPIENT_POSTAL_CODE = "recipientPostalCode";

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

        public string TablePackages
        {
            get { return TABLE_PACKAGES; }
        }

        public string PackageId
        {
            get { return PACKAGE_ID; }
        }

        public string RecipientFirstName
        {
            get { return RECIPIENT_FIRST_NAME; }
        }

        public string RecipientLastName
        {
            get { return RECIPIENT_LAST_NAME; }
        }

        public string RecipientStreet
        {
            get { return RECIPIENT_STREET; }
        }

        public string RecipientCity
        {
            get { return RECIPIENT_CITY; }
        }

        public string RecipientPostalCode
        {
            get { return RECIPIENT_POSTAL_CODE; }
        }
    }
}
