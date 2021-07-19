using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CodingTest
{
    class 퍼즐망고 : Form
    {
        public 퍼즐망고()
        {
            //보드삭제(new string[] { "ABBBBC", "AABAAC", "BCDDAC", "DCCDDE", "DCCEDE", "DDEEEB" })
            //보드삭제(new string[] { "DDCCC", "DBBBC", "DBABC", "DBBBC", "DDCCC"});

            파일배치(2, 5, new int[] { 5, 4, 3, 2, 1 });
            파일배치(1, 5, new int[] { 1, 4, 5 });
            파일배치(2, 3, new int[] { 2, 2, 2, 2, 2 });
        }

        public int 보드삭제(string[] board)
        {
            List<int> 검사결과 = new List<int>();
            //삭제가 되는걸 찾아볼까
            for (int w = 0; w < board[0].Length; w++)
            {
                int matchCount = 0;
                List<List<char>> deleteBoard = 보드초기화(board);

                for (int h = 0; h < board.Length; h++)
                {
                    char s = deleteBoard[h][w];
                    if (s == '0')
                        continue;

                    deleteBoard[h][w] = '0';
                    matchCount++;
                    matchCount += Find(s, w, h, deleteBoard);
                }

                검사결과.Add(matchCount);
            }

            for (int h = 0; h < board.Length; h++)
            {
                int matchCount = 0;
                List<List<char>> deleteBoard = 보드초기화(board);
                for (int w = 0; w < board[0].Length; w++)
                {
                    char s = deleteBoard[h][w];
                    if (s == '0')
                        continue;

                    deleteBoard[h][w] = '0';
                    matchCount++;
                    matchCount += Find(s, w, h, deleteBoard);
                }

                검사결과.Add(matchCount);
            }

            검사결과 = 검사결과.OrderByDescending(c => c).ToList();
            return 검사결과[0];

        }

        private List<List<char>> 보드초기화(string[] board)
        {
            List<List<char>> defaultBoard = new List<List<char>>();
            for (int w = 0; w < board[0].Length; w++)
            {
                List<char> hRange = new List<char>();
                for (int h = 0; h < board.Length; h++)
                {
                    hRange.Add(board[w][h]);
                }
                defaultBoard.Add(hRange);
            }

            return defaultBoard;
        }

        private int Find(char c, int w, int h, List<List<char>> board)
        {
            int matchCount = 0;
            //오른쪽 찾기
            int findW = w + 1;
            int findH = h;
            if (findW < board[0].Count && board[findH][findW] == c)
            {
                board[findH][findW] = '0';
                matchCount++;
                matchCount += Find(c, findW, findH, board);
            }

            findW = w - 1;
            findH = h;
            //왼쪽 찾기
            if (findW > -1 && board[findH][findW] == c)
            {
                board[findH][findW] = '0';
                matchCount++;
                matchCount += Find(c, findW, findH, board);
            }
            findW = w;
            findH = h + 1;
            //세로 아래로 찾기
            if (findH < board.Count && board[findH][findW] == c)
            {
                board[findH][findW] = '0';
                matchCount++;
                matchCount += Find(c, findW, findH, board);
            }
            findW = w;
            findH = h - 1;
            //위로 찾기
            if (findH > -1 && board[findH][findW] == c)
            {
                board[findH][findW] = '0';
                matchCount++;
                matchCount += Find(c, findW, findH, board);
            }

            return matchCount;
        }



        public int 파일배치(int n, int capacity, int[] files)
        {
            List<int> 파일 = files.OrderBy(x => x).ToList();


            int 결과 = 0;
            for (int i = 0; i < n; i++)
            {
                int fileFileSize = 파일[i];
                파일[i] = 0;
                List<int> 삭제할목록 = 찾기(fileFileSize, capacity, i, 파일);

                foreach (int 삭제할파일 in 삭제할목록)
                {
                    파일.Remove(삭제할파일);
                    결과++;
                }
            }


            return 0;
        }

        public List<int> 찾기(int 기준용량, int capacity, int startIndex, List<int> 파일목록)
        {
            //선택한 파일로 조합가능한 수를 찾는다.
            List<List<int>> 조합가능 = new List<List<int>>();


            for (int i = startIndex; i < 파일목록.Count; i++)
            {

                List<int> 조합될목록 = 조합하기(i, 파일목록, 기준용량, capacity);
                조합될목록.Add(기준용량);
                조합가능.Add(조합될목록);
            }

            //당연히 첫번째가 제일 많은 조합
            int n = 조합가능[0].Count;

            int 최대조합가능수 = 0;

            List<int> 삭제할숫자들 = new List<int>();
            foreach (List<int> 조합 in 조합가능)
            {
                if (조합.Count == n)
                {
                    if (최대조합가능수 < 조합.Max())
                    {
                        최대조합가능수 = 조합.Max();
                        삭제할숫자들 = 조합;
                    }
                }
            }

            return 삭제할숫자들;
        }

        List<int> 조합하기(int startIndex, List<int> 파일목록, int 기준용량, int capacity)
        {
            List<int> 조합될목록 = new List<int>();

            for (int i = startIndex; i < 파일목록.Count; i++)
            {
                int target파일용량 = 파일목록[i];
                if (target파일용량 == 0)
                {
                    //이미조합된거
                    continue;
                }
                int 용량 = 기준용량 + target파일용량;

                if (용량 > capacity)
                    break;

                조합될목록.Add(target파일용량);
                기준용량 = 용량;
            }

            return 조합될목록;
        }

    }
}
