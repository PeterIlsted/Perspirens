using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace Persistens
{
    public class DataHandler
    {
        Person[] person = new Person[500];
        string DocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private string _dataFileName;
        public string DataFileName
        {
            get { return _dataFileName; }
        }
        public DataHandler(string dataFileName)
        {
            _dataFileName = dataFileName;
        }
        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(Path.Combine(DocPath, DataFileName));
            string title = person.MakeTitle();
            sw.Write(title);
            sw.Close();
        }

        public Person LoadPerson()
        {
            StreamReader reader = new StreamReader(Path.Combine(DocPath, "Data.txt"));
            string line = reader.ReadLine();
            reader.Close();
            string[] Line = line.Split(";");
            return new Person(Line[0], DateTime.Parse(Line[1]), Convert.ToDouble(Line[2]), Convert.ToBoolean(Line[3]), int.Parse(Line[4]));
        }
        public void SavePersons(Person[] person)
        {
            StreamWriter sw = new StreamWriter(Path.Combine(DocPath, DataFileName));
            for(int i = 0; i < person.Length; i++)
            {
                string title = person[i].MakeTitle();
                sw.Write(title);
            }
            sw.Close();
        }
        public Person[] LoadPersons()
        {
            int i = 0;
            StreamReader reader = new StreamReader(Path.Combine(DocPath, "Data.txt"));
            
            while (reader.ReadLine() != null)
            {
                string line = reader.ReadLine();
                string[] Line = line.Split(";");
                this.person[i] = new Person(Line[0], DateTime.Parse(Line[1]), Convert.ToDouble(Line[2]), Convert.ToBoolean(Line[3]), int.Parse(Line[4]));
                i++;
            }
            reader.Close();
            return this.person;
        }    
    }
}



