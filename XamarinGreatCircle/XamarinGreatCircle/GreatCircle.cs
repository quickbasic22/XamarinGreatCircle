using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinGreatCircle
{
    public class GreatCircle
    { 
        public double DMS_Degrees(double deg, double min, double sec)
        {
            double Min = min / 60;
            double Sec = sec / 3600;
            double Deg = deg * Math.Sign(deg);
            double Degrees = Deg + Min + Sec;
            double Negation = Math.Sin(Deg);
            return (Degrees * Negation);
        }
        public double Deg_Radians(double deg)
        {
            double Deg = deg * Math.Sign(deg);
            double answer = (Math.PI / 180) * Deg;
            double Negation = Math.Sign(deg);
            return (answer * Negation);
        }
        public double Radians_Deg(double rad)
        {
            double Rad = rad * Math.Sign(rad);
            double answer = (180 / Math.PI) * Rad;
            double Negation = Math.Sign(rad);
            return (answer * Negation);
        }
        public string  Deg_DMS(double deg)
        {
            double Negation = Math.Sign(deg);
            double Deg = deg * Negation;
            double DecimalPart = (Deg - Math.Truncate(Deg));
            double IntegerPart = Math.Truncate(Deg);
            double Min = DecimalPart * 60;
            double MinDecimalPart = Min - Math.Truncate(Min);
            double MinIntegerPart = Math.Truncate(Min);
            double Sec = Math.Round(MinDecimalPart * 60, 0);
            double IntegerWithSign = Math.Sign(Deg) * IntegerPart;
            string result = $"{IntegerWithSign} {MinIntegerPart} {Sec}";
            return result;
        }
        public double GreatCircle_Calculation(double LatDeg1, double LongDeg1, double LatDeg2, double LongDeg2)
        {
            double lat1 = Deg_Radians(LatDeg1);
            double long1 = Deg_Radians(LongDeg1);
            double lat2 = Deg_Radians(LatDeg2);
            double long2 = Deg_Radians(LongDeg2);

            double result = Math.Acos(Math.Sin(lat1) * Math.Sin(lat2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(long1 - long2)) * 3959;
            result = Math.Round(result, 1);
            return result;
        }
        public void ViewableMileage_AtHeight()
        {
            Console.WriteLine("Height above earth in feet");

            double height = double.Parse(Console.ReadLine());
            height = (height / 5280) + 3959;
            double angle = (Math.Asin((3959 / height)) * (180 * Math.PI));
            angle = Math.Round(angle * 2, 1);
            double answer = Math.Round(180 - angle, 1);
            double visible = Math.PI * 2 * answer;
            Console.WriteLine($"Viewing {answer} degrees of 360 in two directions");
            double EarthCircumference = Math.PI * 3959 * 2;
            double arch = answer / 360;
            answer = arch * EarthCircumference;
            answer = Math.Round(answer / 2, 0);
            Console.WriteLine($"visible part {answer} miles in one direction.");
            Console.ReadKey();


        }
        public double[] Get_AntiPodal(double latdeg, double latmin, double latsec, double longdeg, double longmin, double longsec)
        {
            double Lat = DMS_Degrees(latdeg, latmin, latsec);
            double Long = DMS_Degrees(longdeg, longmin, longsec);
            Lat = -Lat;
            Long = Long + 180;
            return new double[] { Lat, Long };
        }
    }
}
