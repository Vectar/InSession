using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSession
{
    public class School
    {

        //Setup One form variables.

        public string password { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string ImageFile { get; set; }

        //Setup Two form variables.
        public School()
        {

        }

        public School(string password, string email, string name, string address, string city, string state, string zip, string latitude, string longitude, string ImageFile)
        {
            this.password = password;
            this.email = email;
            this.name = name;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.latitude = latitude;
            this.longitude = longitude;
            this.ImageFile = ImageFile;
        }

        public string GetGeoCodeAddress()
        {
            string sReturn = "";
            sReturn = String.Format("{0}, {1}, {2}, {3}", address.Replace(' ', '+'), city.Replace(' ', '+'), state.Replace(' ', '+'), zip.Replace(' ', '+'));
            return sReturn;
        }

    }
}
