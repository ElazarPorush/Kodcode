using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employs
{
    public class Employ
    {
        private int _code;
        public int Code {get {return _code;}set {_code = value;} }
        private int _id;
        public int Id { get { return _id;} set { _id = value; } }
        private string _firstName;
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        private string _lastName;
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        private string _fullName;
        public string FullName { get { return FirstName + " " + LastName; } }
        public DateTime BirthDay { get; set; }
        public int Age { get { return DateTime.Now.Year - BirthDay.Year; } }
        public string IsMale { get; set; }
        public string Status { get; set; }
        public int CelPhone { get; set; }
        public int Phone {  get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string HomeAdress { get { return City + " " + Street + " " + Number; } }
        
        
        public Employ() {}
        public Employ(int code, int id, string firstname, string lastname, DateTime birthday, string ismale, string status, int celphone, int phone, string street, int number, string city) {
            Code = code;
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            BirthDay = birthday;
            IsMale = ismale;
            Status = status;
            CelPhone = celphone;
            Phone = phone;
            Street = street;
            Number = number;
            City = city;
        }
    }
}
