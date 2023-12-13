// See https://aka.ms/new-console-template for more information
using OpenCvSharp;

Console.WriteLine("Hello, World!");

string imagePath = @"C:\Users\ben96\source\repos\DotNet-OpenCV-Video-Test\lena.jpg";
Mat src = new Mat(imagePath, ImreadModes.Grayscale);

Mat dst = new Mat();

Cv2.Canny(src, dst, 50, 200);
using (new OpenCvSharp.Window("src image", src))
using (new OpenCvSharp.Window("dst image", dst))
{
    Cv2.WaitKey();
}
