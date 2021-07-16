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
            //solution(new int[] { 10, 15, 62, 6, 67,22,2,695,673,69 });

            //solution(new int[] { 10, 0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //solution(new int[] { 200,20,2 });
            solution(new int[] { 0,0,0,0 });
            //987654321101000
        }



        public string solution(int[] numbers)
        {
            List<NumberClass> list = new List<NumberClass>();
          
            foreach (int number in numbers)
            {
                //정렬을 하기 위하여 같은 문자를 더해서 6자리 일치 시켜준다. 
                string modiStr = number.ToString();
                while(modiStr.Length < 6)
                {
                    modiStr += number;
                }
                modiStr = modiStr.Substring(0, 6);
                NumberClass num = new NumberClass();
                num.key = int.Parse(modiStr);
                num.original = number;
                list.Add(num);
            }

            //6자리로 만든 수로 정렬을 한다. 
            var items = list.OrderByDescending(dict => dict.key);
            string answer = "";
            
            list = items.ToList();
            //6자리로 만든 숫자중에 중복되는 값이 있는경우 원본 값으로 정렬을 해서 더한다.
            for (int i = 0; i < list.Count; i++)
            {
                answer += 중복키계산(ref i, list);
               // answer += list[i].original;
            }

            //0체크
            List<char> checkList = new List<char>();
            checkList.Add('1');
            checkList.Add('2');
            checkList.Add('3');
            checkList.Add('4');
            checkList.Add('5');
            checkList.Add('6');
            checkList.Add('7');
            checkList.Add('8');
            checkList.Add('9');

            bool onlyZero = true;
            foreach(char c in checkList)
            {
                if (answer.Contains(c))
                {
                    onlyZero = false;
                    break;
                }
            }

            if (onlyZero)
                return "0";
            return answer;
        }

        private string 중복키계산(ref int index , List<NumberClass> list)
        {
            List<int> dlist = new List<int>();
            int plusCount = 0;
            for (int i = index; i < list.Count; i++)
            {
                int currentKey = list[i].key;
                dlist.Add(list[i].original);
                if (list.Count <= i + 1)
                    break;

                int nextKey = list[i + 1].key;

                if (currentKey == nextKey)
                {
                    plusCount++;
                }
                else
                {
                    break;
                }
            }
            index += plusCount;
            if (dlist.Count > 1)
            {
                dlist.Sort();
            }
                        
            string returnString = string.Join("", dlist);
            return returnString;
        }
        public class NumberClass
        {
            public int key { get; set; }
            public int original { get; set; }
        }


        //속도는 5배정도 느린대신 메모리 30%정도 적게 사용.
        private string BestSolution(int[] number)
        {
            Array.Sort(number, (x, y) =>
            {
                string xy = x.ToString() + y.ToString();
                string yx = y.ToString() + x.ToString();
                return yx.CompareTo(xy);
            });

            if (number.Where(_ => _ == 0).Count() == number.Length)
                return "0";
            else
                return string.Join("", number);
        }
    }
}
