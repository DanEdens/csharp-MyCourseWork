using System;
using System.IO;

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

            // Inspect JSON

            // Draw rectangles on the image (copy)
        }
    }
}
