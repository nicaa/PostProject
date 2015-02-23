using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenApp.Models
{
    class InitRandomPersons
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
        
        public InitRandomPersons(){
           // initPersons();

            // generate lists for packages
            genList(fNameReader, fNameList);
            genList(fLameReader, lNameList);
            genList(cityReader, cityList);
            genList(streetReader, streetList);
            genList(postalReader, postalList);

            // generate packages
            genRandomPackage();
            printPackages();
        }

        public void printPackages()
        {
            foreach (Package package in packageList)
            {                
                package.PrintPackage();
            }
        }

        //  generation of different lists.
        public void genList (StreamReader reader, ArrayList list)
        {
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
                count++;
                Console.WriteLine(count);
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
                package.destinationStreet = (String)streetList[r];

                r = ran.Next(0, cityList.Count);
                package.destinationCity = (String)cityList[r];

                r = ran.Next(0, postalList.Count);
                package.destinationPostalCode = (String)postalList[r];

                packageList.Add(package);
            }
            Console.WriteLine("Package Count = " + packageList.Count);
        }

        //Return package from list!
        public Package getRandomPackage()
        {

            return null;
        }
       
        public void initPersons()
        {
            /*
            while ((line = reader.ReadLine()) != null)
            {
                packageList.Add(line);
                count++;
                Console.WriteLine(count);
            }
            Console.WriteLine(list.Count);
             * */
        }
        /*
        public void addRandomToDb()
        {
            for (int i = 1; i <= 1; i++)
            {
                Person person = new Person();
                int r = ran.Next(0, list.Count);
                person.fName = (String)list[r];
                r = ran.Next(0, list.Count);
                person.lName = (String)list[r];

                Console.WriteLine(person.fName + " " + person.lName);
            }
        }*/

    }
}
