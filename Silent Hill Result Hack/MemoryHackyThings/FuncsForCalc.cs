using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silent_Hill_Result_Hack.MemoryHackyThings
{
    public static class FuncsForCalc
    {
        public static int EndingCalculation(int Ending, int UFOEnding)
        {
            if ((Ending & 0x4000) == 0)
            {
                if ((Ending & 0x2000) != 0)
                    return 3;
                if ((Ending & 0x1000) != 0)
                    return 1;
                if ((Ending & 0x800) != 0)
                    return 2;
                if ((Ending & 0x400) != 0)
                    return 0;
                if ((UFOEnding & 0x800000) != 0)
                    return 5;
            }
            return 4;
        }

        public static void SetEndingByIndex(int Index)
        {
            switch (Index)
            {
                case 0:
                    BusinessThing.EndingType = 0x400;
                    break;
                case 1:
                    BusinessThing.EndingType = 0x1000;
                    break;
                case 2:
                    BusinessThing.EndingType = 0x800;
                    break;
                case 3:
                    BusinessThing.EndingType = 0x2000;
                    break;
                case 4:
                    BusinessThing.EndingType = 0x4000;
                    break;
                case 5:
                    BusinessThing.EndingType = 0;
                    BusinessThing.UFOEnding = 0x800000;
                    break;
            }
        }
        public static byte GetEndingClear(int endingClear)
        {
            Byte endingClearPoint = 0;
            
            if((endingClear & 1) != 0)
            {
                endingClearPoint++;
            }
            if ((endingClear & 2) != 0)
            {
                endingClearPoint++;
            }
            if ((endingClear & 4) != 0)
            {
                endingClearPoint++;
            }
            if ((endingClear & 8) != 0)
            {
                endingClearPoint++;
            }
            return endingClearPoint;
        }
        public static Byte GetEndingClearPlus(int endingPlus)
        {
            Byte Plus = 0;
            if((endingPlus & 0x10) != 0)
            {
                Plus++;
            }
            if ((endingPlus & 0x20) != 0)
            {
                Plus++;
            }
            if ((endingPlus & 0x40) != 0)
            {
                Plus++;
            }
            return Plus;
        }

        public static void SetEndingClearPlus(byte number)
        {
            switch (number)
            {
                case 0:
                    BusinessThing.EndingClear = 10;
                    break;
                case 1:
                    BusinessThing.EndingClear = 1;
                    break;
                case 2:
                    BusinessThing.EndingClear = 2;
                    break;
                case 3:
                    BusinessThing.EndingClear = 4;
                    break;
                case 4:
                    BusinessThing.EndingClear = 8;
                    break;
            }
        }

        public static Byte GetItemsPlus(byte itemsPlus)
        {
            Byte plus = 0;
            if((itemsPlus & 1) != 0)
            {
                plus++;
            }
            if ((itemsPlus & 2) != 0)
            {
                plus++;
            }
            if ((itemsPlus & 4) != 0)
            {
                plus++;
            }
            if ((itemsPlus & 8) != 0)
            {
                plus++;
            }
            if ((itemsPlus & 0x10) != 0)
            {
                plus++;
            }
            if ((itemsPlus & 0x20) != 0)
            {
                plus++;
            }
            if ((itemsPlus & 0x40) != 0)
            {
                plus++;
            }
            if (itemsPlus < 0)
            {
                plus++;
            }
            return plus;
        }

        public static void setItemPlus(byte numOfItemPlus)
        {
            switch(numOfItemPlus)
            {
                case 0:
                    BusinessThing.EndOfResultItemsPlus = 0;
                    break;
                case 1:
                    BusinessThing.EndOfResultItemsPlus = 1;
                    break;
                case 2:
                    BusinessThing.EndOfResultItemsPlus = 3;
                    break;
                case 3:
                    BusinessThing.EndOfResultItemsPlus = 7;
                    break;
                case 4:
                    BusinessThing.EndOfResultItemsPlus = 15;
                    break;
                case 5:
                    BusinessThing.EndOfResultItemsPlus = 47;
                    break;
                case 6:
                    BusinessThing.EndOfResultItemsPlus = 123;
                    break;
                case 7:
                    BusinessThing.EndOfResultItemsPlus = 127;
                    break;
                case 8:
                    BusinessThing.EndOfResultItemsPlus = 255;
                    break;
            }
        }

        public static string[] TimeCalc(float time)
        {
            string[] returnTime = new string[3];

            returnTime[2] = Convert.ToInt32(time % 60).ToString("00");
            returnTime[1] = (Math.Floor(time / 60) % 60).ToString("00");
            returnTime[0] = Math.Floor(time / 60 / 60).ToString("00");
            return returnTime;
        }

        public static float CalcDistance(float distance)
        {
            return (distance * 0.002f * 0.001f);
        }
        public static float ReverseCalcDistance(float distance)
        {
            return (distance / 0.002f / 0.001f);
        }
    }
}
