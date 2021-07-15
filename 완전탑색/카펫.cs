using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 카펫
    {
        public 카펫()
        {
            solution(10, 2);
        }
        public static int[] solution(int brown, int yellow)
        {
            int 가로세로합계 = brown / 2 + 2;

            int xy = 가로세로합계 / 2;

            int result = 0;
            for (int i = xy; i < 가로세로합계; i++)
            {
                int x = i - 2;
                int y = (가로세로합계 - i - 2);
                if (x >= y && x * y == yellow)
                {
                    result = i;
                    break;
                }
            }


            int[] answer = new int[] { result, 가로세로합계 - result };
            return answer;
        }

    }
}
