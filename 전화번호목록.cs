using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    class 전화번호목록
    {
        public 전화번호목록()
        {
            List<string> phonebook = new List<string>();
            phonebook.Add("119");
            phonebook.Add("97674223");
            phonebook.Add("1195524421");

            Debug.WriteLine(Solution(phonebook));

            phonebook.Clear();
            phonebook.Add("123");
            phonebook.Add("456");
            phonebook.Add("789");
            Debug.WriteLine(Solution(phonebook));

            phonebook.Clear();
            phonebook.Add("12");
            phonebook.Add("123");
            phonebook.Add("1235");
            phonebook.Add("567");
            phonebook.Add("88");
            Debug.WriteLine(Solution(phonebook));

        }
        bool Solution(List<string> phone_book)
        {
            bool answer = true;
            phone_book = phone_book.OrderBy(x => x.Length).ToList();

            for(int i = 0; i < phone_book.Count ; i++)
            {
                string keyNumber = phone_book[i];
                for(int subi = i + 1; subi < phone_book.Count ; subi++)
                {
                    int value = phone_book[subi].IndexOf(keyNumber);
                    if (value >= 0)
                        return false;
                }
            }
            return answer;
        }
    }
}
