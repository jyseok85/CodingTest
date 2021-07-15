using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 가장먼노드
    {
        public 가장먼노드()
        {
            int[,] ab = new int[,] { { 3, 6 }, { 4, 3 }, { 3, 2 }, { 1, 3 }, { 1, 2 }, { 2, 4 }, { 5, 2 } };

            solutions(6, ab);
        }
        public int solutions (int n, int[,] edge)
        {
            List<int> 다음검색할숫자 = new List<int>();
            //1과연결된 로드를 구한다.
            List<Dictionary<string, int>> edges = new List<Dictionary<string, int>>();
            for (int i = 0; i < edge.GetLength(0); i++)
            {
                int n1 = edge[i, 0];
                int n2 = edge[i, 1];

                if (n1 == 1)
                    다음검색할숫자.Add(n2);
                else if (n2 == 1)
                    다음검색할숫자.Add(n1);
                else
                {
                    Dictionary<string, int> temp = new Dictionary<string, int>();
                    temp.Add("n1", n1);
                    temp.Add("n2", n2);
                    edges.Add(temp);
                }
            }

            int answer = 반복계산(edges, 다음검색할숫자);

            return answer;
        }

        public int 반복계산(List<Dictionary<string, int>> edges, List<int> 다음검색할숫자)
        {
            List<Dictionary<string, int>> myedges = new List<Dictionary<string, int>>();
            List<int> my다음검색할숫자 = new List<int>();

            for (int i = 0; i < edges.Count; i++)
            {
                int n1 = edges[i]["n1"];
                int n2 = edges[i]["n2"];

                if (다음검색할숫자.Contains(n1))
                {
                    if (다음검색할숫자.Contains(n2) == false && my다음검색할숫자.Contains(n2) == false)
                        my다음검색할숫자.Add(n2);
                }
                else if (다음검색할숫자.Contains(n2))
                {
                    if (다음검색할숫자.Contains(n1) == false && my다음검색할숫자.Contains(n1) == false)
                        my다음검색할숫자.Add(n1);
                }
                else
                {
                    Dictionary<string, int> temp = new Dictionary<string, int>();
                    temp.Add("n1", n1);
                    temp.Add("n2", n2);
                    myedges.Add(temp);
                }
            }

            if (my다음검색할숫자.Count == 0)
                return 다음검색할숫자.Count;
            else
                return 반복계산(myedges, my다음검색할숫자);
        }

    }


}
