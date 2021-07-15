using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest._업체
{
    class 하이브
    {
        //다음은 구현하실 기능의 명세서 입니다.
        //명세서에 기재된 대로 기능을 완성해주세요.
        //GetMaxAlphaNumeric 메서드(C#)

        //string 안에 포함된 개수가 가장 많은 알파벳 혹은 숫자를 골라냅니다.
        
        //구문
        //public static char GetMaxAlphaNumeric(string content)

        //매개 변수
        //content
        //Type: System.String
        //검사 할 문자열입니다.

        //반환 값
        //Type: System.Char
        //인자로 넘겨받은 content 문자열 중 가장 많이 들어있는 알파벳 혹은 숫자를 리턴 합니다.

        //문자의 수가 동일하다면 ASCII 코드 상으로 더 높은 값을 가진 문자를 리턴 합니다.

        //반환 할 문자가 없을 경우 ASCII NUL 문자를 리턴 합니다.

        //예외
        //ArgumentNullException
        //content 가 null 일 경우 발생되어야 하는 예외입니다.

        //기대 결과
        //GetMaxAlphaNumeric(“foo”) == ‘o’
        //GetMaxAlphaNumeric(“bbccaa”) == ‘c’
        //GetMaxAlphaNumeric(“ab2c2d”) == ‘2’
        //GetMaxAlphaNumeric(“abCD”) == ‘b’
        //GetMaxAlphaNumeric(“#a## # #”) == ‘a’ 
        //GetMaxAlphaNumeric(“@#*@@#*”) == ‘\0’
        //GetMaxAlphaNumeric(“”) == ‘\0’
        //GetMaxAlphaNumeric(null) == ArgumentNullException

        //제한 사항
        //C# 언어의 로직을 어떻게 작성 하는지,
        //제어문(조건문, 반복문, 기타 등등)을 어떻게 다루는지,
        //코딩 스타일 등등을 확인하기 위한 테스트 입니다.

        //따라서 기본 제공되는 System.Char.IsLetterOrDigit 등의 유틸리티 함수를 사용하지 않고 직접 비교 연산을 사용해주세요.

        public 하이브()
        {
            Console.WriteLine(GetMaxAlpahNumberic("foo"));
            Console.WriteLine(GetMaxAlpahNumberic("bbccaa"));
            Console.WriteLine(GetMaxAlpahNumberic("ab2c2d"));
            Console.WriteLine(GetMaxAlpahNumberic("abCD"));
            Console.WriteLine(GetMaxAlpahNumberic("#a## # #"));
            Console.WriteLine(GetMaxAlpahNumberic("@#*@@#*"));
            Console.WriteLine(GetMaxAlpahNumberic(""));
            Console.WriteLine(GetMaxAlpahNumberic("12851fff"));
            Console.WriteLine(GetMaxAlpahNumberic(null));
        }

        public static char GetMaxAlpahNumberic(string content)
        {
            //예외처리
            if (content == null)
                throw new ArgumentNullException();

            //문자분리
            char[] characters = content.ToCharArray();

            //문자별 갯수 Dictionary 추가
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in characters)
            {
                //숫자                     // 대문자              //소문자
                if ((c >= 48 && c <= 57) || (c >= 65 && c <= 90) || (c >= 97 && c <= 122))
                {
                    if (dic.ContainsKey(c) == false)
                    {
                        dic.Add(c, 0);
                    }
                    dic[c]++;
                }
            }

            //정렬
            var items = from pair in dic
                        orderby pair.Value descending
                        select pair;

            //제일 많이 들어간 문자들만 검색
            int maxCount = 0;
            List<char> maxChars = new List<char>();
            foreach (KeyValuePair<char, int> item in items)
            {
                if (item.Value >= maxCount)
                {
                    maxCount = item.Value;
                    maxChars.Add(item.Key);
                }
                else
                    break;
            }


            if (maxChars.Count == 1)
                return maxChars[0];
            else if (maxChars.Count > 1)
            {
                //아스키 최대값 구하기.
                int maxAscii = 0;
                foreach (char c in maxChars)
                {
                    if (maxAscii < c)
                    {
                        maxAscii = c;
                    }
                }
                return (char)maxAscii;
            }
            else
                return (char)0;

        }
    }
}
