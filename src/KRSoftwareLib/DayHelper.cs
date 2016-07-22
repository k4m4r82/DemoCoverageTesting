using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KRSoftwareLib
{
    public class DayHelper
    {        
        public string GetIndonesianDay(DateTime date)
        {
            var indonesianDay = string.Empty;

            switch (Weekday(date))   
            {
                case 1:
                    indonesianDay = "Senin";
                    break;
                case 2:
                    indonesianDay = "Selasa";
                    break;
                case 3:
                    indonesianDay = "Rabu";
                    break;
                case 4:
                    indonesianDay = "Kamis";
                    break;
                case 5:
                    indonesianDay = "Jum'at";
                    break;
                case 6:
                    indonesianDay = "Sabtu";
                    break;
                default:
                    indonesianDay = "Minggu";
                    break;
            }

            return indonesianDay;
        }

        private int Weekday(DateTime date)
        {
            var startOfWeek = DayOfWeek.Sunday;
            return (date.DayOfWeek - startOfWeek + 7) % 7;
        }
    }
}
