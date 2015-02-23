using System;
using System.Collections;
using System.IO;

namespace POSTWebService.Models
{
    class InitRandomPersons
    {
        String line;
        int count = 0;
        ArrayList list = new ArrayList();
        Random ran = new Random();
        
        public InitRandomPersons(){
            initPersons();
        }

        StreamReader reader = new StreamReader("...\\...\\TextFile\\Navne- 5163.txt");

 
        
       
        public void initPersons()
        {
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
                count++;
                Console.WriteLine(count);
            }
            Console.WriteLine(list.Count);
        }

        public void addRandomToDb()
        {
            for (int i = 1; i <= 1; i++)
            {
                Person person = new Person();
                int r = ran.Next(0, list.Count);
                person.FirstName = (String)list[r];
                r = ran.Next(0, list.Count);
                person.LastName = (String)list[r];

                Console.WriteLine(person.FirstName + " " + person.LastName);
            }
        }

    }
}
