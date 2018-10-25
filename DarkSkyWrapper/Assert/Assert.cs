using System;
using System.Collections.Generic;
using System.Text;

namespace DarkSkyWrapper.Assert
{
    public class Assert
    {
        public static void NotNull(object ObjectName, string Message)
        {
            if (ObjectName == null)
            {
                throw new ArgumentException(Message);
            }
        }
        public static void NotNullOrEmpty(string ObjectName, string MessageForEmpty, string MessageForNull)
        {
            if (ObjectName == string.Empty)
            {
                throw new ArgumentException(MessageForEmpty);
            }
            if (ObjectName == null)
            {
                throw new ArgumentException(MessageForNull);
            }

        }
        public static void LongitudeCheck(float Longitude, string ErrorMessage)
        {
            if (Longitude < -180 || Longitude > 180)
            {
                throw new ArgumentException(ErrorMessage);
            }
        }

        public static void LatitudeCheck(double Latitude, string ErrorMessage)
        {
            if (Latitude < -90 || Latitude > 90)
            {
                throw new ArgumentException(ErrorMessage);
            }
        }
    }
}
