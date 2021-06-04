using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3_C
{
    class ClassB : ClassA, IClassC
    {

        public void SortList(List<String> list, String order)
        {
            if (order.Equals("asc"))
            {
                list.Sort();
                list.ForEach(x => Console.WriteLine(x));
            }else if (order.Equals("desc"))
            {
                list.Sort();
                list.Reverse();
                list.ForEach(x => Console.WriteLine(x));
            }
        }

        public void FilterList(List<String> filteredList)
        {
            String remove;
            Console.WriteLine("Filtered List: ");
            for (int i = 0; i < filteredList.Count; i++)
            {
                remove = String.Concat(filteredList[i].Where(c => !Char.IsWhiteSpace(c)));
                Console.WriteLine(remove);
            }
        }

        public void RemoveDuplicates(List<int> list)
        {
            List<int> secondList = new List<int>();
            secondList.AddRange(list);
            int aux = list[0];
            for(int i = 1; i < list.Count; i++)
            {
                if(aux == list[i])
                {
                    list.Remove(i);
                }
                aux = list[i];
            }
            CompareListSize(list, secondList); //Inherited Method from Class A
            Console.WriteLine("-----------------");
            Console.WriteLine("List after remove duplicates elements: ");
            list.ForEach(x => Console.WriteLine(x));
        }
        
        public void Hello()
        {
            Console.WriteLine("Hello Interface");
        }
    }
}
