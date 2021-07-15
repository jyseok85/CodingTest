using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 모의고사
    {
        public 모의고사()
        {
            solution(new[] { 1, 2, 3, 4, 5 });
        }

        public static int[] solution(int[] answers)
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            int[] b = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] c = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            Dictionary<int, int> temp = new Dictionary<int, int>();
            temp.Add(1, 0);
            temp.Add(2, 0);
            temp.Add(3, 0);

            for (int i = 0; i < answers.Length; i++)
            {
                int arrayIndex = i % 10;

                if (answers[i] == a[arrayIndex])
                    temp[1]++;
                int barrayIndex = i % 8;

                if (answers[i] == b[barrayIndex])
                    temp[2]++;
                if (answers[i] == c[arrayIndex])
                    temp[3]++;
            }

            var items = from pair in temp
                        orderby pair.Value descending
                        select pair;

            int maxVlaue = 0;

            List<int> asnwerList = new List<int>();
            foreach (KeyValuePair<int, int> item in items)
            {
                if (item.Value >= maxVlaue)
                {
                    asnwerList.Add(item.Key);
                    maxVlaue = item.Value;
                }
                else
                    break;
            }

            return asnwerList.ToArray();
        }
    }
}
