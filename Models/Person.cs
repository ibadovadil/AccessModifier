using System.Xml.Linq;

namespace Acces.Models
{
    internal class Person
    {
        private string _name;
        private string _surname;
        private byte _age;
        private DateTime _birthday;



        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >=16)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Minumum age 16!");
                }
            }
        }
        public byte GetAge() => _age;


        public string Surname
        {
            get
            {
                
                return _surname;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length >= 2)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("not possible!");
                }
            }
    }
            public string GetSurname() => _surname;

        public string Name
        {

            get
            {
                
                return _name;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length >= 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("not possible!");
                }
            }
        }
        public string GetName() => _name;
        

        public string GetFullInfo()
        {
            return GetName() + " " + GetSurname() + " " + GetAge();
        }

    public void SetName( string name)
        {

            if (!String.IsNullOrWhiteSpace(name) && name.Length >= 2)
            {
                _name = name;
            }
            else
            {
                Console.WriteLine("not possible!");
            }
        }

        public void SetSurName(string surname)
        {

            if (!String.IsNullOrWhiteSpace(surname) && surname.Length >= 2)
            {
                _surname = surname;
            }
            else
            {
                Console.WriteLine("not possible!");
            }
        }

        public void SetAge(byte age)
        {

           
                if (age >= 16)
                {
                    _age = age;
                }
                else
                {
                    Console.WriteLine("Minumum age 16!");
                }
            }
        }
    }
   













//public string GetName() => _name;

//public void SetName(string name)
//{
//    if (!String.IsNullOrWhiteSpace(name) && name.Length >= 2)
//    {
//        _name = name;
//    }
//    else
//    {
//        Console.WriteLine("This name too short");
//    }
//}
