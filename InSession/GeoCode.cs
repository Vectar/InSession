using System;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO;


namespace InSession
{
    public class GeoCode
    {
        public GeoCode()
        {

        }
        public StreamReader GetGeoCode(string address)
        {
            string GoogleKey = "AIzaSyD771xcgU8reLmzVSBvLTDGkG-HMRIDug4";
            string sRequest = String.Format("https://maps.googleapis.com/maps/api/geocode/json?address={0}&key={1}", address, GoogleKey);
            //string sRequest = "https://maps.googleapis.com/maps/api/geocode/json?address=5111+S+99th_St,+Omaha.+NE, +68127&key=AIzaSyD771xcgU8reLmzVSBvLTDGkG-HMRIDug4";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sRequest);
            request.Method = "POST";
            request.ContentType = "application/json; charset=utf-8";
            request.ContentLength = 0;
            //DataContractJsonSerializer ser = new DataContractJsonSerializer(data.GetType());
            //MemoryStream ms = new MemoryStream();
            //ser.WriteObject(ms, data);
            //String json = Encoding.UTF8.GetString(ms.ToArray());
            //StreamWriter writer = new StreamWriter(request.GetRequestStream());
            //writer.Write(json);
            //writer.Close();
            Stream objStream;
            objStream = request.GetResponse().GetResponseStream();
            //JsonArray 
            StreamReader objReader = new StreamReader(objStream);
            return objReader;
        }
    }
}
