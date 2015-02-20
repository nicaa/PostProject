using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenApp.Database
{
    public class DataSource
    {
<<<<<<< HEAD
        public readonly String SERVER = "server=localhost;";
        public readonly String DATABASE = "database=test;";
        public readonly String USER = "user=root;";
        public readonly String PASSWORD = "password=1234";

        public readonly String packageId = "packageId";
        public readonly String packageSender = "sender";
        
=======
        // Database 
        private readonly String SERVER = "server=localhost;";
        private readonly String DATABASE = "database=test;";
        private readonly String USER = "user=root;";
        private readonly String PASSWORD = "password=1234;";

        // Tables
        private readonly String TABLE_PERSONS = "person";
        private readonly String TABLE_PACKAGES = "packages";

        // Package table columns
        private readonly String PACKAGE_ID = "packageId";
        private readonly String SENDER_ID = "senderId";
        private readonly String RECIPIENT_ID = "recipientId";
        private readonly String DESTINATION_STREET = "destinationStreet";
        private readonly String DESTINATION_CITY = "destinationCity";
        private readonly String DESTINATION_POSTAL_CODE = "destinationPostalCode";

        // Person table columns
        private readonly String PERSON_ID = "personId";
        private readonly String FIRST_NAME = "fName";
        private readonly String LAST_NAME = "lName";


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

        public string SenderId
        {
            get { return SENDER_ID; }
        }

        public string RecipientId
        {
            get { return RECIPIENT_ID; }
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

        public string PersonId
        {
            get { return PERSON_ID; }
        }

        public string FirstName
        {
            get { return FIRST_NAME; }
        }

        public string LastName
        {
            get { return LAST_NAME; }
        }
>>>>>>> origin/master
    }
}
