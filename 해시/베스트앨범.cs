using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 베스트앨범
    {
        public 베스트앨범()
        {
            string[] a = new string[] { "classic", "pop", "classic", "classic", "pop" };
            int[] b = new int[] { 500, 600, 150, 800, 2500 };
            solution(a, b);
        }

        public static int[] solution(string[] genres, int[] plays)
        {
            Dictionary<string, Dictionary<int, int>> dic = new Dictionary<string, Dictionary<int, int>>();
            Dictionary<string, int> dictotCount = new Dictionary<string, int>();
            for (int i = 0; i < genres.Length; i++)
            {

                if (dic.ContainsKey(genres[i]) == false)
                {
                    Dictionary<int, int> inta = new Dictionary<int, int>();
                    inta.Add(i, plays[i]);

                    dic.Add(genres[i], inta);
                    dictotCount.Add(genres[i], plays[i]);
                }
                else
                {

                    dic[genres[i]].Add(i, plays[i]);
                    dictotCount[genres[i]] += plays[i];
                }
            }

            var items = from pair in dictotCount
                        orderby pair.Value descending
                        select pair;

            //int[] answer = new int[] { };

            List<int> answer = new List<int>();
            foreach (KeyValuePair<string, int> pair in items)
            {
                var subItems = from subpair in dic[pair.Key]
                               orderby subpair.Value descending
                               select subpair;

                int nCount = 0;
                foreach (KeyValuePair<int, int> childpair in subItems)
                {
                    if (nCount == 2)
                        break;
                    answer.Add(childpair.Key);
                    nCount++;
                }
            }




            return answer.ToArray();
        }
    }
}
