using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            //int
            IEnumerable<IEnumerable<int>> resultInt = GetPermutations(Enumerable.Range(1, 3), 3);
            ListPermutation(resultInt);

            //string
            var string1 = "a,b,c";
            var string2 = "b,c,a";
            var string3 = "c,d,a";

            Console.WriteLine($"Is string {{{string1}}} permutation of {{{string2}}} ?");
            var check1 = IsPermuted(GetPermutations(string2.Split(',').AsEnumerable(), 3), string1.Split(',').AsEnumerable());
            Console.WriteLine(check1);

            Console.WriteLine($"Is string {{{string1}}} permutation of {{{string3}}} ?");
            var check2 = IsPermuted(GetPermutations(string3.Split(',').AsEnumerable(), 3), string1.Split(',').AsEnumerable());
            Console.WriteLine(check2);

            Console.ReadKey();
        }

        static IEnumerable<IEnumerable<T>>  GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        static void ListPermutation<T>(IEnumerable<IEnumerable<T>> input)
        {
            foreach (var elem in input)
            {
                Console.Write("{");
                foreach (var item in elem)
                {
                    Console.Write(item);
                }
                Console.Write("}");
            }
            Console.WriteLine();
        }

        static bool IsPermuted<T>(IEnumerable<IEnumerable<T>> input, IEnumerable<T> search)
        {
            foreach (var elem in input)
            {
                return (elem.Count() == search.Count() && (!elem.Except(search).Any() || !search.Except(elem).Any()));
            }
            return false;
        }
    }
}
