using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper
{
    public class MathHelper
    {
        #region Map Range Method
        /// <summary>
        /// Method for converting a value between ranges
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <param name="inputMin">The minimum value of the input range</param>
        /// <param name="inputMax">The maximum value of the input range</param>
        /// <param name="outputMin">The minimum value of the output range</param>
        /// <param name="outputMax">The maximum value of the output range</param>
        /// <returns>The value in the output range</returns>
        public static int Map(int value, int inputMin, int inputMax, int outputMin, int outputMax)
        {
            return (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin) + outputMin;
        }

        /// <summary>
        /// Method for converting a value between ranges
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <param name="inputMin">The minimum value of the input range</param>
        /// <param name="inputMax">The maximum value of the input range</param>
        /// <param name="outputMin">The minimum value of the output range</param>
        /// <param name="outputMax">The maximum value of the output range</param>
        /// <returns>The value in the output range</returns>
        public static double Map(double value, double inputMin, double inputMax, double outputMin, double outputMax)
        {
            return (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin) + outputMin;
        }

        /// <summary>
        /// Method for converting a value between ranges
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <param name="inputMin">The minimum value of the input range</param>
        /// <param name="inputMax">The maximum value of the input range</param>
        /// <param name="outputMin">The minimum value of the output range</param>
        /// <param name="outputMax">The maximum value of the output range</param>
        /// <returns>The value in the output range</returns>
        public static long Map(long value, long inputMin, long inputMax, long outputMin, long outputMax)
        {
            return (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin) + outputMin;
        }

        /// <summary>
        /// Method for converting a value between ranges
        /// </summary>
        /// <param name="value">The value to convert</param>
        /// <param name="inputMin">The minimum value of the input range</param>
        /// <param name="inputMax">The maximum value of the input range</param>
        /// <param name="outputMin">The minimum value of the output range</param>
        /// <param name="outputMax">The maximum value of the output range</param>
        /// <returns>The value in the output range</returns>
        public static float Map(float value, float inputMin, float inputMax, float outputMin, float outputMax)
        {
            return (value - inputMin) * (outputMax - outputMin) / (inputMax - inputMin) + outputMin;
        }
        #endregion

        #region Linear Interpolation Method

        /// <summary>
        /// Method for calculating linear interpolation as an int
        /// </summary>
        /// <param name="min">The minimum range</param>
        /// <param name="max">The maximum range</param>
        /// <param name="value">The value to calculate</param>
        /// <returns></returns>
        public static int Lerp(int min, int max, int value)
        {
            return min + (max - min) * value;
        }

        /// <summary>
        /// Method for calculating linear interpolation as an double
        /// </summary>
        /// <param name="min">The minimum range</param>
        /// <param name="max">The maximum range</param>
        /// <param name="value">The value to calculate</param>
        /// <returns></returns>
        public static double Lerp(double min, double max, double value)
        {
            return min + (max - min) * value;
        }

        /// <summary>
        /// Method for calculating linear interpolation as an long
        /// </summary>
        /// <param name="min">The minimum range</param>
        /// <param name="max">The maximum range</param>
        /// <param name="value">The value to calculate</param>
        /// <returns></returns>
        public static long Lerp(long min, long max, long value)
        {
            return min + (max - min) * value;
        }

        /// <summary>
        /// Method for calculating linear interpolation as an float
        /// </summary>
        /// <param name="min">The minimum range</param>
        /// <param name="max">The maximum range</param>
        /// <param name="value">The value to calculate</param>
        /// <returns></returns>
        public static float Lerp(float min, float max, float value)
        {
            return min + (max - min) * value;
        }
        #endregion
    }
}
