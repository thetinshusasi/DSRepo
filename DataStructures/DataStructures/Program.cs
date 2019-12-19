using DataStructures.DS.LinkedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumsNET;
using DataStructures.MIT;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option");
            PrintChoices();
            var value = (MenuChoice)Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                /// Data Structures
                case MenuChoice.SingleLinkedListPrint:
                    PrintCustomLinkedList();
                    break;

                /// MIT
                case MenuChoice.FindAPeakIn1DArray:
                    PrintFindAPeak();
                    break;

            }

            Console.ReadKey();

        }

        #region Common
        public static CustomLinkedList<int> CreateList()
        {
            var list = new CustomLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            return list;
        }



        #endregion Common

        #region Data Structures
        public static void PrintCustomLinkedList()
        {
            var list = CreateList();
            list.PrintLinkedList();
        }
        #endregion Data Structures


        #region MIT
        public static void PrintFindAPeak()
        {
            var peakFinder1DArrray = new PeakFinder1DArray();
            var arrs = new int[5] { 1,20,15,4,3};


            Console.WriteLine(peakFinder1DArrray.FindPeakIfItExist(arrs, 0, arrs.Length-1));

        }
        #endregion MIT

        public static void PrintChoices()
        {
            Console.WriteLine(Convert.ToInt32(MenuChoice.SingleLinkedListPrint) +
                " - " +
                MenuChoice.SingleLinkedListPrint.AsString(EnumFormat.Description));
            Console.WriteLine(Convert.ToInt32(MenuChoice.FindAPeakIn1DArray) +
                " - " +
                MenuChoice.FindAPeakIn1DArray.AsString(EnumFormat.Description));
        }
    }


    #region Enums
    public enum MenuChoice
    {
        [Description("Print Single linked list")]
        SingleLinkedListPrint = 1,

        [Description("Find A peak in 1D array")]
        FindAPeakIn1DArray = 100


    }
    #endregion Enums
}
