using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 가장큰수
    {
        public 가장큰수()
        {
            solution(new int[] { 10, 15, 62, 6, 67,22,2 });
        }
        public string solution(int[] numbers)
        {
            Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
            //앞자리만 잘라서 가장 큰 수를 찾는다.

            //가져온 가장 큰수중에 제일 작은수(단위가 작은것)부터 문자열로 붙인다.

            //그다음 큰수를 가져온다. 

            //작은단위부터 붙인다 계속 반복

            foreach(int number in numbers)
            {
                int key = int.Parse(number.ToString().Substring(0, 1));
                if (dic.Keys.Contains(key) == false)
                    dic.Add(key, new List<int>());
                dic[key].Add(number);
            }
            var items = from pair in dic
                        orderby pair.Key descending
                        select pair;

            foreach (KeyValuePair<int, List< int>> item in items)
            {
                Dictionary<int, int> lengthDic = new Dictionary<int, int>();
                foreach(int num in item.Value)
                {
                    lengthDic.Add(num.ToString().Length, num);
                }
                item.Value.Sort();

            }

            string answer = "";
            return answer;
        }
    }
}
