using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Silent_Hill_Result_Hack.Offsets;

// TODO: Will make more object oriented friendly.

namespace Silent_Hill_Result_Hack.MemoryHackyThings
{
    public static class BusinessThing
    {
        public static Dictionary<int,string>  d_actionLevel = new Dictionary<int, string>() { { 0, "Beginner" }, { 1, "Easy" }, { 2, "Normal" }, { 3, "Hard" } };
        public static Dictionary<int, string> d_riddleLevel = new Dictionary<int, string>() { { 0, "Easy" }, { 1, "Normal" }, { 2, "Hard" }, { 3, "Extra" } };
        public static Dictionary<int, string> d_endingType  = new Dictionary<int, string>() { { 0, "Leave" }, { 1, "In Water" }, { 2, "Maria" }, { 3, "Rebirth" },{ 4,"Dog" },{5,"UFO" } };
        public static Dictionary<int, string> d_endingClear = new Dictionary<int, string>() { { 0, "0/4" },      { 1, "1/4" },      { 3, "2/4" }, { 7, "3/4" },  { 15, "4/4" }, 
                                                                                              { 16, "0/4(+1)" }, { 17, "1/4(+1)" }, { 19, "2/4(+1)" }, { 23, "3/4(+1)" }, { 31, "4/4(+1)" },
                                                                                              { 48, "0/4(+2)" }, { 49, "1/4(+2)" }, { 51, "2/4(+2)" }, { 55, "3/4(+2)" }, { 63, "4/4(+2)" },
                                                                                              { 240, "0/4(+3)" },{241, "1/4(+3)" }, { 243, "2/4(+3)" }, { 247, "3/4(+3)" }, {255, "4/4(+3)" }  
                                                                                            };
        public static Dictionary<int, string> d_ItemPlus = new Dictionary<int, string>() { { 0, "0" }, { 1, "+1" }, { 2, "+2" }, { 3, "+3" }, { 4, "+4" }, { 5, "+5" }, {6, "+6" }, {7, "+7" }, {8, "+8" } };
        public static bool cheatActive()
        { 
            
            return Memory.MemoryHacker.Init();
        }
        
        public static int ReadMenuSwitch
        {
            get
            {
                return Memory.MemoryHacker.Read<int>(Memory.MemoryHacker.clientBase + signatures.menuSwitch);
            }
            set
            {
                Memory.MemoryHacker.Write<int>(Memory.MemoryHacker.clientBase + signatures.menuSwitch, value);
            }
        }
        public static int SaveChanges
        {
            set
            {
                Memory.MemoryHacker.Write<int>(Memory.MemoryHacker.clientBase + signatures.saveIGuess, value);
            }
        }

        public static int ActionLevel
        {
            get
            {
                return Memory.MemoryHacker.Read<Byte>(Memory.MemoryHacker.clientBase + signatures.actionLevel);
            }
            set
            {
                Memory.MemoryHacker.Write<Byte>(Memory.MemoryHacker.clientBase + signatures.actionLevel, value);
            }
        }

        public static int RiddleLevel
        {
            get
            {
                return Memory.MemoryHacker.Read<Byte>(Memory.MemoryHacker.clientBase + signatures.riddleLevel);
            }
            set
            {
                Memory.MemoryHacker.Write<Byte>(Memory.MemoryHacker.clientBase + signatures.riddleLevel, value);
            }
        }

        public static int EndingType
        {
            get
            {
                return Memory.MemoryHacker.Read<int>(Memory.MemoryHacker.clientBase + signatures.endingType);
            }
            set
            {
                Memory.MemoryHacker.Write<int>(Memory.MemoryHacker.clientBase + signatures.endingType, value);
            }
        }
        
        public static int UFOEnding
        {
            get
            {
                return Memory.MemoryHacker.Read<int>(Memory.MemoryHacker.clientBase + signatures.ufo_ending);
            }
            set
            {
                Memory.MemoryHacker.Write<int>(Memory.MemoryHacker.clientBase + signatures.ufo_ending, value);
            }
        }

        public static int EndingClear
        {
            get
            {
                return Memory.MemoryHacker.Read<Byte>(Memory.MemoryHacker.clientBase + signatures.endingClear);
            }
            set
            {
                Memory.MemoryHacker.Write<Byte>(Memory.MemoryHacker.clientBase + signatures.endingClear,value);
            }
        }

        public static int Saves
        {
            get
            {
                return Memory.MemoryHacker.Read<Int32>(Memory.MemoryHacker.clientBase + signatures.Saves);
            }
            set
            {
                Memory.MemoryHacker.Write<Int32>(Memory.MemoryHacker.clientBase + signatures.Saves, value);
            }
        }

        public static float TotalTime
        {
            get
            {
                return Memory.MemoryHacker.Read<float>(Memory.MemoryHacker.clientBase + signatures.totalTime);
            }
            set
            {
                Memory.MemoryHacker.Write<float>(Memory.MemoryHacker.clientBase + signatures.totalTime, value);
            }
        }
        
        public static float WalkingDistance
        {
            get
            {
                return Memory.MemoryHacker.Read<float>(Memory.MemoryHacker.clientBase + signatures.walkingDistance);
            }
            set
            {
                Memory.MemoryHacker.Write<float>(Memory.MemoryHacker.clientBase + signatures.walkingDistance, value);
            }
        }

        public static float RunningDistance
        {
            get
            {
                return Memory.MemoryHacker.Read<float>(Memory.MemoryHacker.clientBase + signatures.runningDistance);
            }
            set
            {
                Memory.MemoryHacker.Write<float>(Memory.MemoryHacker.clientBase + signatures.runningDistance, value);
            }
        }

        public static short EndOfResultItems
        {
            get
            {
                return Memory.MemoryHacker.Read<short>(Memory.MemoryHacker.clientBase + signatures.items);
            }
            set
            {
                Memory.MemoryHacker.Write<short>(Memory.MemoryHacker.clientBase + signatures.items, value);
            }
        }
        public static byte EndOfResultItemsPlus
        {
            get
            {
                return Memory.MemoryHacker.Read<byte>(Memory.MemoryHacker.clientBase + signatures.itemsPlus);
            }
            set
            {
                Memory.MemoryHacker.Write<byte>(Memory.MemoryHacker.clientBase + signatures.itemsPlus, value);
            }
        }
        public static short DefeatedEnemyByShooting
        {
            get
            {
                return Memory.MemoryHacker.Read<short>(Memory.MemoryHacker.clientBase + signatures.defeatedEnemyByShooting);
            }
            set
            {
                Memory.MemoryHacker.Write<short>(Memory.MemoryHacker.clientBase + signatures.defeatedEnemyByShooting, value);
            }
        }
        public static short DefeatedEnemyByFighting
        {
            get
            {
                return Memory.MemoryHacker.Read<short>(Memory.MemoryHacker.clientBase + signatures.defeatedEnemyByFighting);
            }
            set
            {
                Memory.MemoryHacker.Write<short>(Memory.MemoryHacker.clientBase + signatures.defeatedEnemyByFighting, value);
            }
        }
        public static float BoatStageTime
        {
            get
            {
                return Memory.MemoryHacker.Read<float>(Memory.MemoryHacker.clientBase + signatures.boatStageTime);
            }
            set
            {
                Memory.MemoryHacker.Write<float>(Memory.MemoryHacker.clientBase + signatures.boatStageTime, value);
            }
        }

        public static float BoatMaxSpeed
        {
            get
            {
                return Memory.MemoryHacker.Read<float>(Memory.MemoryHacker.clientBase + signatures.boatMaxSpeed);
            }
            set
            {
                Memory.MemoryHacker.Write<float>(Memory.MemoryHacker.clientBase + signatures.boatMaxSpeed, value);
            }
        }

        public static float TotalDamage
        {
            get
            {
                return Memory.MemoryHacker.Read<float>(Memory.MemoryHacker.clientBase + signatures.totalDamage);
            }
            set
            {
                Memory.MemoryHacker.Write<float>(Memory.MemoryHacker.clientBase + signatures.totalDamage, value);
            }
        }
    }
}
