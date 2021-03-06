﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAppFinal.Model
{
    class Restaurant
    {
        private string _name;
        private string _address;
        private string _web;
        private string _email;
        private string _phone;
        private string _cityArea;
        private string _conferenceFacilities;
        private string _generalFacilities;
        private string _description;
        private string _image;
        private string _image1;
        private string _image2;
        private string _image3;
        private string _image4;
        private string _openingHours;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Web
        {
            get { return _web; }
            set { _web = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string CityArea
        {
            get { return _cityArea; }
            set { _cityArea = value; }
        }

        public string ConferenceFacilities
        {
            get { return _conferenceFacilities; }
            set { _conferenceFacilities = value; }
        }

        public string GeneralFacilities
        {
            get { return _generalFacilities; }
            set { _generalFacilities = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Image
        {
            get { return _image; }
            set { _image = value;  }
        }
        public string Image1
        {
            get { return _image1; }
            set { _image1 = value; }
        }

        public string Image2
        {
            get { return _image2; }
            set { _image2 = value; }
        }

        public string Image3
        {
            get { return _image3; }
            set { _image3 = value; }
        }

        public string Image4
        {
            get { return _image4; }
            set { _image4 = value; }
        }

        public string OpeningHours
        {
            get { return _openingHours; }
            set { _openingHours = value; }
        }

        public Restaurant(string Name, string Address, string Web, string Email, string Phone, string CityArea,string ConferenceFacilities,
            string GeneralFacilities, string OpeningHours, string Description, string Image, string Image1, string Image2, string Image3, string Image4)
        {
            _name = Name;
            _address = Address;
            _web = Web;
            _email = Email;
            _phone = Phone;
            _cityArea = CityArea;
            _conferenceFacilities = ConferenceFacilities;
            _generalFacilities = GeneralFacilities;
            _description = Description;
            _openingHours = OpeningHours;
            _image = Image;
            _image1 = Image1;
            _image2 = Image2;
            _image3 = Image3;
            _image4 = Image4;

        }
    }

}
