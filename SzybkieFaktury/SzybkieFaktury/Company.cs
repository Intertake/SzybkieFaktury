﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzybkieFaktury
{
    public class Company
    {
        public long NIP { get; set; }
        public string NameCompany { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string Postcode { get; set; }
     
        public static string AddCompany(string nip, string name_company, string city, string street, string building, string postcode)
        {

            Company comp1 = new Company
            {
                NIP = Convert.ToInt64(nip),
                NameCompany = name_company,
                City = city,
                Street = street,
                Building = building,
                Postcode = postcode
            };
            return "Insert into Company(nip, name_company, city, street, building_nr, postcode)Values('" + comp1.NIP+ "','" +comp1.NameCompany+ "','" +comp1.City+ "','" +comp1.Street+ "','" +comp1.Building+ "','" +comp1.Postcode+ "')";
            
        }

        public static string DelCompany(string nip)
        {
            return "DELETE FROM Company WHERE nip="+nip+";";
        }
    }
}