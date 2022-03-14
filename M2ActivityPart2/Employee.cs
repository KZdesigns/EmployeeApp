using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2ActivityPart2
{
    class Employee
    {

        // Fields
        private String _name;
        private int _idNumber;
        private String _department;
        private String _position;

        // Constructors
        public Employee(String name, int idNumber, String department, String position)
        {
            _name = name;
            _idNumber = idNumber;
            _department = department;
            _position = position;
        }

        public Employee(String name, int idNumber)
        {
            _name = name;
            _idNumber = idNumber;
            _department = "";
            _position = "";
        }

        public Employee()
        {
            _name = "";
            _idNumber = 0;
            _department = "";
            _position = "";
        }

        // Properties
        public String Name {
            get { return _name; }
        }
        public int IdNumber {
            get { return _idNumber; }
        }
        public String Department
        {
            get { return _department; }
        }
        public String Position {
            get { return _position; }
        }

    }
}
