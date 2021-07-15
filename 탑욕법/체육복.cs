using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 체육복
    {
        public 체육복()
        {
            //solution(5)
        }

        public int solution(int n, int[] lost, int[] reserve)
        {

            List<int> lLost = lost.ToList();
            Dictionary<int, int> dReserve = new Dictionary<int, int>();
            foreach (int r in reserve)
                dReserve.Add(r, 0);

            int 체육복못입는사람 = 0;

            //여별을 가져온사람중 옷잃어버린 사람먼저 제거해주자.
            for (int i = 0; i < lLost.Count; i++)
            {
                int lostIndex = lLost[i];
                if (dReserve.ContainsKey(lostIndex))
                {
                    dReserve.Remove(lostIndex);
                    lLost.Remove(lostIndex);
                    i--;
                }
            }


            for (int i = 0; i < lLost.Count; i++)
            {
                int lostIndex = lLost[i];

                if (dReserve.ContainsKey(lostIndex - 1))
                {
                    dReserve.Remove(lostIndex - 1);
                    continue;
                }

                if (dReserve.ContainsKey(lostIndex + 1))
                {
                    dReserve.Remove(lostIndex + 1);
                    continue;
                }

                체육복못입는사람++;
            }
            return n - 체육복못입는사람;
        }
    }
}
