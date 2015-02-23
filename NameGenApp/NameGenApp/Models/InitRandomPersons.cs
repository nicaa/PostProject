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
        ArrayList list = new ArrayList();
        Random ran = new Random();
        StreamReader reader = new StreamReader("...\\...\\TextFile\\Navne- 5163.txt");
        
        public InitRandomPersons(){
            initPersons();
        }

        

 
        
       
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
                person.fName = (String)list[r];
                r = ran.Next(0, list.Count);
                person.lName = (String)list[r];

                Console.WriteLine(person.fName + " " + person.lName);
            }
        }

    }
}
