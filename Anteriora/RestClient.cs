using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Anteriora
{
    public class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    try
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            new Wiadomosc("Błąd: " + response.StatusCode.ToString()).Show();
                        }

                        using (Stream responseStream = response.GetResponseStream())
                        {
                            if (responseStream != null)
                            {
                                using (StreamReader reader = new StreamReader(responseStream))
                                {
                                    strResponseValue = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        new Wiadomosc(ex.Message).Show();
                    }

                }
            }
            catch(Exception ex)
            {
                new Wiadomosc("Błędny login lub hasło." + Environment.NewLine + Environment.NewLine + ex.Message).Show();
            }

            return strResponseValue;
        }
    }

    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
}
