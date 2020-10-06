using System;
using System.Collections.Generic;

namespace Lab4.Models
{
    public class City
    {
        public int CityId { get; set; }
        public String CityName { get; set; }
        public int Population { get; set; }
        
        public String ProvinceCode { get; set; }
        
        public Province Province { get; set; }
    }
}