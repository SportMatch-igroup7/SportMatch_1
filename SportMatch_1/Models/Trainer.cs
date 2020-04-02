using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportMatch_1.Models
{
    public class Trainer
    {
        int trainerCode;
        string firstName;
        string lastName;
        DateTime dateOfBirth;
        string email;
        string phone1; 
        string phone2;
        string gender;
        string password;
        string aboutMe;
        int pricePerHour;
        //image


        public Trainer()
        {

        }

        public int TrainerCode { get => trainerCode; set => trainerCode = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public string Phone1 { get => phone1; set => phone1 = value; }
        public string Phone2 { get => phone2; set => phone2 = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Password { get => password; set => password = value; }
        public string AboutMe { get => aboutMe; set => aboutMe = value; }
        public int PricePerHour { get => pricePerHour; set => pricePerHour = value; }

        public Trainer(string fn, string ln, string em, string ph1, string ph2, string gen, string pas, string abm, int pr)
        {
            FirstName = fn;
            LastName = ln;
            Email = em;
            Phone1 = ph1;
            Phone2 = ph2;
            Gender = gen;
            Password = pas;
            AboutMe = abm;
            PricePerHour = pr;
        }
        public int insert()
        {
            DBservices dbs = new DBservices();
            int numAffected = dbs.insertTrainer(this);
            return numAffected;
        }
    }
}