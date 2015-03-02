using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostProjectClient.PackageWebService;

namespace PostProjectClient.Models
{
    class PackageGenerator
    {
        String line;
        int count = 0;

        public List<Package> packageList = new List<Package>();

        ArrayList fNameList = new ArrayList();
        ArrayList lNameList = new ArrayList();
        ArrayList cityList = new ArrayList();
        ArrayList streetList = new ArrayList();
        ArrayList postalList = new ArrayList();


        Random ran = new Random();
        StreamReader reader = new StreamReader("...\\...\\TextFile\\Navne- 5163.txt");

        StreamReader fNameReader = new StreamReader("...\\...\\TextFile\\fName.txt");
        StreamReader fLameReader = new StreamReader("...\\...\\TextFile\\lName.txt");
        StreamReader cityReader = new StreamReader("...\\...\\TextFile\\City.txt");
        StreamReader streetReader = new StreamReader("...\\...\\TextFile\\Street.txt");
        StreamReader postalReader = new StreamReader("...\\...\\TextFile\\Postal.txt");
        
        public PackageGenerator(){
            genList(fNameReader, fNameList);
            genList(fLameReader, lNameList);
            genList(cityReader, cityList);
            genList(streetReader, streetList);
            genList(postalReader, postalList);

            genRandomPackage();
        }

        //  generation of different lists.
        public void genList (StreamReader reader, ArrayList list)
        {
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
                count++;
                //Console.WriteLine(count);
            }
        }
        
        // inits packages with abtributes from the lists 
        public void genRandomPackage()
        {
            for (int i = 0; i <= 100; i++)
            {
                int r = ran.Next(0, fNameList.Count);
                Package package = new Package();
                package.recipientFirstName = (String)fNameList[r];

                r = ran.Next(0, lNameList.Count);
                package.recipientLastName = (String)lNameList[r];

                r = ran.Next(0, streetList.Count);
                package.recipientStreet = (String)streetList[r];

                r = ran.Next(0, cityList.Count);
                package.recipientCity = (String)cityList[r];

                r = ran.Next(0, postalList.Count);
                package.recipientPostalCode = (String)postalList[r];

                packageList.Add(package);
            }
        }

        //Return package from list!
        public Package getRandomPackage()
        {
            Package package = new Package();
            int r = ran.Next(0, packageList.Count);
            package = packageList[r];
            return package;
        }
    }
}
