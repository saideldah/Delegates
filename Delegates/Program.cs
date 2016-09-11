using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Photo myPhoto = new Photo();
            PhotoProcessor.ApplyFilter(myPhoto, Blur);

            Action<Photo> filterDelegate = RedEyeRemoval;
            filterDelegate += BlackAndWhit;
            PhotoProcessor.ApplyFilter(myPhoto, filterDelegate);

            PhotoProcessor.ApplyFilter2(myPhoto, Blur);

        }
        static void RedEyeRemoval(Photo photo)
        {
            Console.WriteLine("Red Eye Removal Filter");
        }

        static void Blur(Photo photo)
        {
            Console.WriteLine("Blur Filter");
        }
        static void BlackAndWhit(Photo photo)
        {
            Console.WriteLine("Black And Whit Filter");
        }
    }
}
