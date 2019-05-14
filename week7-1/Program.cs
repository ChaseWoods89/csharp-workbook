using System;

namespace week7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("867 1st St.", "Apt. 20", "Austin", "TX", 78738);
            Address a2 = new Address("13300 Cowdray Park", "Unit B", "Austin", "Texas", 78729);
            DriversLicense d1 = new DriversLicense("Bob", "Bobbertson", a1, "Male");
            DriversLicense d2 = new DriversLicense("Chase", "Woods", a2, "Male");
               
        }
    }

    class Address 
    {
        string street1;
        string street2;
        string city;
        string state;
        int zipCode;

        public Address(string initialStreet1, string initialStreet2, string initialCity,
        string initialState, int initialZipCode){
            this.street1 = initialStreet1;
            this.street2 = initialStreet2;
            this.city = initialCity;
            this.state = initialState;
            this.zipCode = initialZipCode;
        }   
    }

    class DriversLicense
    {
        string firstName;
        string lastName;
        Address address;
        string gender;
        string licenseType;

        public DriversLicense(string initialFirstName, string initialLastName, 
        Address initialAddress, string intialGender){
            this.firstName = initialFirstName;
            this.lastName = initialLastName;
            this.address = initialAddress;
            this.gender = intialGender;

        }

    }
}
