using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Lab4.Models
{
    public class Province
    { 
        [Key]
        public String ProvinceCode { get; set; }
        public String ProvinceName { get; set; }
        public List<City> Cities { get; set; }
    }
}