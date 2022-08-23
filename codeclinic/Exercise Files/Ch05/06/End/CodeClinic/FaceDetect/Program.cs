using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace FaceDetect
{
    class Program
    {
        private static string msg = "Please provide the API Key as the first command-line parameter, followed by the filename of the image to be submitted for processing.";

        static void Main(string[] args)
        {
            // Command Line Arguments

            var apiKey = !string.IsNullOrWhiteSpace(args[0]) ? args[0] : throw new ArgumentException(msg, args[0]);
            var filename = File.Exists(args[1]) ? args[1] : throw new FileNotFoundException(msg, args[1]);

            // HTTP Request

            var region = "westcentralus";
            var target = new Uri($"https://{region}.api.cognitive.microsoft.com/face/v1.0/detect/?subscription-key={apiKey}");
            var httpPost = CreateHttpRequest(target, "POST", "application/octet-stream");

            // Load Image

            using (var fs = File.OpenRead(filename))
            {
                fs.CopyTo(httpPost.GetRequestStream());
            }

            // Submit the Image to HTTP endpoint

            string data = GetResponse(httpPost);

            // Inspect JSON

            var rectangles = GetRectangles(data);

            // Draw rectangles on the image (copy)
        }

        private static void GetRectangles(string data)
        {
            var faces = JArray.Parse(data);
            foreach (var face in faces)
            {
                var id = (string)face["faceId"];

                var top = (int)face["faceRectangle"]["top"];
                var left = (int)face["faceRectangle"]["left"];
                var width = (int)face["faceRectangle"]["width"];
                var height = (int)face["faceRectangle"]["height"];
            }
        }

        private static string GetResponse(HttpWebRequest httpPost)
        {
            using (var response = httpPost.GetResponse())
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                return sr.ReadToEnd();
            }
        }

        private static HttpWebRequest CreateHttpRequest(Uri target, string method, string contentType)
        {
            var request = WebRequest.CreateHttp(target);
            request.Method = method;
            request.ContentType = contentType;
            return request;
        }
    }
}
