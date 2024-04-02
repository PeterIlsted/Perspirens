using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        private string _name;
        private DateTime _birthDate;
        private double _height;
        private bool _isMarried;
        private int _noOfChildren;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }

        }

        public bool IsMarried
        {
            get { return _isMarried; }
            set { _isMarried = value; }
        }

        public int NoOfChildren
        {
            get { return _noOfChildren; }
            set { _noOfChildren = value; }
        }
        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            _name = name;
            _birthDate = birthDate;
            _height = height;
            _isMarried = isMarried;
            _noOfChildren = noOfChildren;
        }
        public string MakeTitle()
        {
            string title;
            return title = ($"{_name};{_birthDate};{_height};{_isMarried};{_noOfChildren}");
        }
    }

}
