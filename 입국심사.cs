using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 입국심사
    {
        public 입국심사()
        {
            solution(6, new int[] { 7, 10 });
        }
        public long solution(int n, int[] times)
        {
            //time 정렬 시간순으로

            int 토탈시간 = 0;

            int 최소시간 = 0;
            for (int i = 0; i < n;)
            {
                foreach (int 심사시간 in times)
                {
                    if (최소시간 == 0)
                    {
                        최소시간 = 심사시간;
                        i++;
                    }
                    else if (최소시간 > 심사시간 + 심사시간)
                        break;
                    else
                    {
                        최소시간 = 심사시간;
                        i++;
                    }
                                    }
                토탈시간 += 최소시간;
            }

            long answer = 토탈시간;
            return answer;
        }
    }
}
