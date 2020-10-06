using System.Collections.Generic;
using Lab4.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab4.Data
{
    public static class SeedData
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>
            {
                new Province() {
                    ProvinceCode="BC",
                    ProvinceName="British Columbia"
                },
                new Province() {
                    ProvinceCode="ON",
                    ProvinceName="Ontario"
                },
                new Province() {
                    ProvinceCode="MB",
                    ProvinceName="Manitoba"
                },
                new Province() {
                    ProvinceCode="AB",
                    ProvinceName="Alberta"
                },
            };

            return provinces;
        }
        
        public static List<City> GetCities()
        {
            List<City> cities = new List<City>
            {
                
                new City() {
                    
                    CityId= 1,
                    CityName= "Vancouver",
                    Population = 675218,
                    ProvinceCode = "BC"
                },
                new City() {
                    
                    CityId= 2,
                    CityName= "Hope",
                    Population = 6181,
                    ProvinceCode = "BC"
                },
                new City() {
                    
                    CityId= 3,
                    CityName= "Kelowna",
                    Population = 132084,
                    ProvinceCode = "BC"
                },
                new City() {
                    
                    CityId= 4,
                    CityName= "Toronto",
                    Population = 2731571,
                    ProvinceCode = "ON"
                },
                new City() {
                    
                    CityId= 5,
                    CityName= "Mississauga",
                    Population = 721599,
                    ProvinceCode = "ON"
                },
                new City() {
                    
                    CityId= 6,
                    CityName= "Brampton",
                    Population = 593638,
                    ProvinceCode = "ON"
                },
                new City() {
                    
                    CityId= 7,
                    CityName= "Winnipeg",
                    Population = 711925,
                    ProvinceCode = "MB"
                },
                new City() {
                    
                    CityId= 8,
                    CityName= "Brandon",
                    Population = 48324,
                    ProvinceCode = "MB"
                },
                new City() {
                    
                    CityId= 9,
                    CityName= "Steinbach",
                    Population = 14753,
                    ProvinceCode = "MB"
                },
                new City() {
                    
                    CityId= 10,
                    CityName= "Calgary",
                    Population = 1237656,
                    ProvinceCode = "AB"
                },
                new City() {
                    
                    CityId= 11,
                    CityName= "Edmonton",
                    Population = 1062643,
                    ProvinceCode = "AB"
                },
                new City() {
                    
                    CityId= 12,
                    CityName= "Red Deer",
                    Population = 99718,
                    ProvinceCode = "AB"
                },
            };

            return cities;
        }
        
    }
}