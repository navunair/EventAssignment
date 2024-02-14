using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using static Program;

namespace Delegates
{
    public class CustomSort
    {
        public delegate int ComparisonDelegate<T>(T x, T y);
        public static void SortStudent<T>(List<T> array, ComparisonDelegate<T> comparison)
        {
            
            int n = array.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparison(array[j], array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

    }
    
}
