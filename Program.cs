using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        //Ikkita metod yozing.
        //Birinchi metod nomi: SortListAsc.
        //Ikkinchi metod nomi: SortListDesc.
        //Ikkala metod List<int> numbers argumentiga ega bo'ladi. Ya'ni, int turidagi elementlardan tashkil topgan ro'yxat.
        //Birinchi metodning bajaradigan ishi, numbers ro'yxatidagi elementlarni o'sish tartibida, ya'ni, kichikidan kattasiga
        //qarab "sort" qilish,tartiblash va natijani konsolga vergul bilan ajratib chiqarish.
        //Ikkinchi metodning bajaradigan ishi, numbers ro'yxatidagi elementlarni kamayish tartibidi, ya'ni,
        //kattasidan kichigiga qarab "sort" qilish, tartiblash va natijani konsolga vergul bilan ajratib chiqarish.
        //Masalan, agar ro'yxatda 3, 12, 1, 4, 8 elementlar bo'lsa, birinchi metodning ishlashi natijasida konsolga 1, 3, 4,
        //8, 12 chiqishi kerak.
        //Ikkinchi metodning ishlashi natijasida esa konsolga 12, 8, 4, 3, 1 chiqariladi.


        static void Main(string[] args)
        {
            List<int> num= new List<int> { 3, 12, 1, 4, 8 };
            List<int> sortedNum = SortListAsc(new List<int>(num)); // 'num' ni nusxa qilib jo‘natish
            int c = sortedNum.Count;

            for (int i = 0; i < c; i++)
            {
                Console.Write(sortedNum[i] + ",");
            }
            Console.WriteLine("\n");
            List<int> sortedNumDesc = SortListDesc(new List<int>(num)); // 'num' ni nusxa qilib jo‘natish
            for (int i = 0; i < c; i++)
            {
                Console.Write(sortedNumDesc[i] + ",");
            }

        }
        static List<int> SortListAsc(List<int> list)
        {
            List<int> listAsc = new List<int>();
            int a = list.Count;
            for (int i = 0; i <a; i++)
            {
                listAsc.Add(list.Min());
                list.Remove(list.Min());
            }


            return listAsc;
        }
        static List<int> SortListDesc(List<int> list)
        {
            List<int> listDesc = new List<int>();
            int a = list.Count - 1;
            for (int i = 0; i <= a; i++)
            {
                listDesc.Add(list.Max());
                list.Remove(list.Max());
            }


            return listDesc;
        }

    }
}
