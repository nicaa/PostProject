using System;

namespace PostProjectWebServices.Database
{
    public class DataSource
    {
        // Database
        private readonly String SERVER = "server=localhost;";
        private readonly String DATABASE = "database=test;";
        private readonly String USER = "user=root;";
        private readonly String PASSWORD = "password=1234";

        // Tables
        private readonly String TABLE_PERSONS = "person";
        private readonly String TABLE_PACKAGES = "packages";
        private readonly String TABLE_STATISTICS = "statistics";

        // Package table columns
        private readonly String PACKAGE_ID = "packageId";
        private readonly String RECIPIENT_FIRST_NAME = "recipientFirstName";
        private readonly String RECIPIENT_LAST_NAME = "recipientLastName";
        private readonly String RECIPIENT_STREET = "recipientStreet";
        private readonly String RECIPIENT_CITY = "recipientCity";
        private readonly String RECIPIENT_POSTAL_CODE = "recipientPostalCode";

        //Statistics table columns
        private readonly String STATISTIC_ID = "statisticId";
        private readonly String STATISTIC_CITY = "city";
        private readonly String STATISTIC_COUNT = "count";
        private readonly String STATISTIC_DATE = "date";

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

        public string TableStatistics
        {
            get { return TABLE_STATISTICS; }
        }

        public string StatisticId
        {
            get { return STATISTIC_ID; }
        }

        public string StatisticCity
        {
            get { return STATISTIC_CITY; }
        }

        public string StatisticCount
        {
            get { return STATISTIC_COUNT; }
        }

        public string StatisticDate
        {
            get { return STATISTIC_DATE; }
        }
    }
}
