using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    //이분탐색
    class 입국심사
    {
        public 입국심사()
        {
            solution(6, new int[] { 7, 10 });
        }
        public long solution(int n, int[] times)
        {
            long fastest_person = 1000000000;

            for (int i = 0; i < times.Length; i++)
            {
                if (times[i] < fastest_person)
                {
                    fastest_person = times[i];
                }
            }

            // Binary search
            long start = fastest_person;
            long end = n * fastest_person;
            long min_time = n * fastest_person;
            long checked_person = 0;

            while (start <= end)
            {
                long mid = (start + end) / 2;
                checked_person = 0;

                for (int i = 0; i < times.Length; i++)
                {
                    checked_person += mid / times[i];

                    // long long인 애들 계속 더하다보면, long long 범위도 초과할 수 있다!
                    // 따라서 checked_person > n인 경우는 이 for문 안에서 체크해야한다!
                    // (checked_person == n인 경우까지 포함하는 이유는, 여기서 min_time 값을 바꾸기 때문)
                    if (checked_person >= n)
                    {
                        // 일단 이 경우도 min_time이 될 수 있으므로, 저장!
                        // end를 하나 줄여가면서 더 짧게 걸리는 시간이 있는지 체크한다.
                        min_time = mid;
                        end = mid - 1;
                        break;
                    }
                }

                if (checked_person < n) start = mid + 1;
            }


            return (long)min_time;
        }
    }
}
