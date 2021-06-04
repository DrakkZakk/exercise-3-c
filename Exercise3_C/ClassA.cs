using System;
using System.Collections.Generic;

namespace Exercise3_C
{
    class ClassA
    {

        public void CompareStringLength(String text1, String text2)
        {
            int length1 = text1.Length;
            int length2 = text2.Length;
            if(length1 == length2)
            {
                Console.WriteLine("Length of String 1 and String 2 are the same.");
            }
            else
            {
                Console.WriteLine("Length of String 1 and String 2 are not the same.");
            }
        }

        public void CompareListSize(List<int> list, List<int> list2)
        {
            int size1 = list.Count;
            int size2 = list2.Count;
            if(size1 == size2)
            {
                Console.WriteLine("Size of List 1 and List 2 are the same.");
            }
            else
            {
                Console.WriteLine("Size of List 1 and List 2 are not the same.");
            }
        }

    }
}
