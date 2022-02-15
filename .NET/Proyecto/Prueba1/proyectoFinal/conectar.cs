using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace proyectoFinal
{
    internal class conectar
    {
        private String url;
        private HttpWebRequest request;

        public conectar(String url, String tipo)
        {
            this.url = url;
            this.request = (HttpWebRequest)WebRequest.Create(this.url);
            this.request.Method = "GET";

            switch (tipo)
            {
                case "GET":
                    this.request.Method = "GET";
                    break;

                case "POST":
                    this.request.Method = "POST";
                    break;

                case "PUT":
                    this.request.Method = "PUT";
                    break;

                case "DELETE":
                    this.request.Method = "DELETE";
                    break;
            }

            this.request.ContentType = "application/json";
            request.Accept = "application/json";

        }

        class habitaciones
        {
            public long idRoom {get; set;}
            public String Tipo { get; set; }
            public String Caracteristicas { get; set; }
            public float ImporteNoche { get; set; }

        }

        public String getItem()
        {
            try
            {
                WebResponse response = request.GetResponse();
                Stream strReader = response.GetResponseStream();

                if (strReader != null)
                {
                    StreamReader sr = new StreamReader(strReader);
                    string str = sr.ReadToEnd();
                    
                    Console.WriteLine(str);
                    return str;
                }
                else return null;

            }catch(WebException e)
            {
                Console.WriteLine(e);
                return null;
            }catch(JsonSerializationException e)
            {
                return null;
            }
        }

        public String postItem(String data)
        {
            try
            {
                Stream strWriter = request.GetRequestStream();
                if (strWriter != null)
                {
                    StreamWriter sw = new StreamWriter(strWriter);

                    sw.Write(data);
                    sw.Flush();
                    sw.Close();

                    WebResponse response = request.GetResponse();
                    Stream strReader = response.GetResponseStream();

                    if (strReader != null)
                    {
                        StreamReader sr = new StreamReader(strReader);
                        String respuesta = sr.ReadToEnd();
                        return respuesta;
                    }
                }
                else return null;

            }catch(WebException e)
            {
                return null;
            }

            return null;
        }


    }
}
