using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COCOMO_Backup
{
    class CostDrivers
    {
        public static float[] reliability = { 0.75f, 0.88f, 1.00f, 1.15f, 1.40f };
        public static float[] databaseSize = { 0.94f, 1.00f, 1.08f, 1.16f };
        public static float[] productComplexity = { 0.70f, 0.85f, 1.00f, 1.15f, 1.30f, 1.65f };

        public static float[] performance = { 1.00f, 1.11f, 1.30f, 1.66f };
        public static float[] memory = { 1.00f, 1.06f, 1.21f, 1.56f };
        public static float[] volatility = { 0.87f, 1.00f, 1.15f, 1.30f };
        public static float[] turnaboutTime = { 0.87f, 1.00f, 1.07f, 1.15f };

        public static float[] analystCapability = { 1.46f, 1.19f, 1.00f, 0.86f, 0.71f };
        public static float[] appExperience = { 1.29f, 1.13f, 1.00f, 0.91f, 0.82f };
        public static float[] engCapability = { 1.42f, 1.17f, 1.00f, 0.86f, 0.70f };
        public static float[] vmExpericence = { 1.21f, 1.10f, 1.00f, 0.90f };
        public static float[] progammingLangExp = { 1.14f, 1.07f, 1.00f, 0.95f };

        public static float[] SWEmethods = { 1.24f, 1.10f, 1.00f, 0.91f, 0.82f };
        public static float[] softwareTools = { 1.24f, 1.10f, 1.00f, 0.91f, 0.83f };
        public static float[] devSchedule = { 1.23f, 1.08f, 1.00f, 1.04f, 1.10f };


    }
}
