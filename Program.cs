using System;
using System.IO;
using Unosquare.RaspberryIO;

namespace TakePic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pi.Info);
            Console.WriteLine("Taking picture...");
            TestCaptureImage();
        }

        static void TestCaptureImage()
        {
            var pictureBytes = Pi.Camera.CaptureImageJpeg(640, 480);
            var targetPath = "/home/pi/picture.jpg";
            if (File.Exists(targetPath))
                File.Delete(targetPath);

            File.WriteAllBytes(targetPath, pictureBytes);
            Console.WriteLine($"Took picture -- Byte count: {pictureBytes.Length}");
        }
    }
}
