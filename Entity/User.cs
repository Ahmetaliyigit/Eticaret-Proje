﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string CountryId  { get; set; }
        public Country Country { get; set; }
        public string City  { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

    }
}
