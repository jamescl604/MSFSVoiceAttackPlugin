//=================================================================================================================
// PROJECT: MSFS Agent
// PURPOSE: Contains misc. helper functions
// AUTHOR: James Clark
// Licensed under the MS-PL license. See LICENSE.md file in the project root for full license information.
//================================================================================================================= 
using System;

namespace MSFS
{
    // Credit for these functions come from the internet and various forums.
    public class Utils
    {
        public static double Deg2Rad(double deg)
        {
            return deg * Math.PI / 180;
        }

        public static double Rad2Deg(double rad)
        {
            return rad * 180 / Math.PI;
        }

        public static uint Bcd2Dec(uint num) 
        { 
            return HornerScheme(num, 0x10, 10); 
        } 
        
        public static uint Dec2Bcd(uint num) { 
            return HornerScheme(num, 10, 0x10); 
        } 
        
        static private uint HornerScheme(uint Num, uint Divider, uint Factor) 
        { 
            uint Remainder = 0, Quotient = 0, Result = 0; 
            Remainder = Num % Divider; 
            Quotient = Num / Divider; 
            
            if (!(Quotient == 0 && Remainder == 0)) 
                Result += HornerScheme(Quotient, Divider, Factor) * Factor + Remainder; 
            
            return Result; 
        }

        static private string BCD16ToFrequency(int bcd)
        {
            byte[] bytes = BitConverter.GetBytes(bcd);
            int high, low;
            int mhz, khz;

            // byte 1
            high = bytes[1] >> 4;
            low = bytes[1] & 0xF;
            mhz = (10 * high) + low;

            // byte 0
            high = bytes[0] >> 4;
            low = bytes[0] & 0xF;
            khz = (100 * high) + (low * 10);

            // calculate .25 spacing
            khz += (khz % 50 == 0 ? 0 : 5);

            return string.Format("1{0}.{1}", mhz, khz);
        }

        static private string BCO16ToFrequency(int bco)
        {
            byte[] bytes = BitConverter.GetBytes(bco);
            int high, low;
            string code;

            // byte 0
            high = bytes[1] >> 4;
            low = bytes[1] & 0xF;

            code = Convert.ToString(high, 8);
            code += Convert.ToString(low, 8);

            // byte 1
            high = bytes[0] >> 4;
            low = bytes[0] & 0xF;

            code += Convert.ToString(high, 8);
            code += Convert.ToString(low, 8);

            return code;
        }


    }
}
