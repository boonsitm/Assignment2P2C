﻿using System;
using System.Globalization;

namespace Assignment2C2P.Utils.DateTimeUtils
{
    public static class DateTimeUtils
    {
        private const string DATETIME_FORMAT = "dd/MM/yyyy";
        private const string DATETIME_CSV_FORMAT = "dd/MM/yyyy hh:mm:ss";
        private const string DATETIME_XML_FORMAT = "yyyy-MM-ddTHH:mm:ss";

        public static DateTime ParseDate(string dateString)
        {
            return DateTime.ParseExact(dateString, DATETIME_FORMAT, CultureInfo.InvariantCulture);
        }
        public static DateTime ParseDate(string dateString, string fileExtension)
        {
            return fileExtension.Equals("csv", StringComparison.InvariantCulture) ? ParseCsvDate(dateString) : ParseXmlDate(dateString);
        }
        public static DateTime ParseCsvDate(string dateString)
        {
            return DateTime.ParseExact(dateString, DATETIME_CSV_FORMAT, CultureInfo.InvariantCulture);
        }

        public static DateTime ParseXmlDate(string dateString)
        {
            return DateTime.ParseExact(dateString, DATETIME_XML_FORMAT, CultureInfo.InvariantCulture);
        }
    }
}
