using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 위장
    {
        //입출력 예시
        //clothes                                                                   	return
        //[["yellowhat", "headgear"], ["bluesunglasses", "eyewear"], ["green_turban", "headgear"]]	5
        //[["crowmask", "face"], ["bluesunglasses", "face"], ["smoky_makeup", "face"]]	3
        public int solution(string[,] clothes)
        {

            Dictionary<string, List<string>> 타입별옷 = new Dictionary<string, List<string>>();

            List<string> 옷이름 = new List<string>();
            List<string> 타입 = new List<string>();

            for (int i = 0; i < clothes.GetLength(0); i++)
            {
                if (타입.Contains(clothes[i, 1]) == false)
                {
                    타입.Add(clothes[i, 1]);
                }

                if (옷이름.Contains(clothes[i, 0]) == false)
                {
                    옷이름.Add(clothes[i, 0]);
                }

                if (타입별옷.ContainsKey(clothes[i, 1]) == false)
                {
                    타입별옷.Add(clothes[i, 1], new List<string>());
                }

                타입별옷[clothes[i, 1]].Add(clothes[i, 0]);
            }

            
            int 조합가능갯수 = 1;
            
            foreach (KeyValuePair<string, List<string>> key in 타입별옷)
            {
                //각 타입별 안입는것도 포함해서 계산해야 하기 때문에
                조합가능갯수 *= (key.Value.Count + 1);
            }
           
            return 조합가능갯수 - 1; //전부 안입을 경우를 제거
        }
    }
}
