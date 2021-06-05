using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindergartenJoy.Klase
{
    public class ValidacijaRegistracija
    {

        public static string ValidacijaRegistracije(string korIme, string lozinka, string ime, string prezime, string email, string telefon)
        {
            string poruka = "";

            if(ime.Length < 2)
            {
                poruka = "Ime pogrešno uneseno (treba sadržavati barem 2 znaka!) ";
            }

            foreach (var item in ime)
            {
                if (!Char.IsLetter(item))
                {
                    poruka = "Ime se može sastojati samo od slova!";
                }
            }

            if (prezime.Length < 2)
            {
                poruka = "Prezime pogrešno uneseno (treba sadržavati barem 2 znaka!) ";
            }

            foreach (var item in prezime)
            {
                if (!Char.IsLetter(item))
                {
                    poruka = "Prezime se može sastojati samo od slova!";
                }
            }

            if(!new EmailAddressAttribute().IsValid(email))
            {
                poruka = "Email je neispravno unesen!";
            }

            if(lozinka.Length < 6 || lozinka.Contains(" ") || !lozinka.Any(char.IsUpper) || !lozinka.Any(char.IsLower))
            {
                poruka = "Lozinka mora imati 6 ili više znakova. Bez razmaka i jedno\rveliko i malo slovo.";
            }

            return poruka;
        }
    }
}
