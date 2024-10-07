﻿
namespace carvedrock.bl.refactoring.OrganizingData.ReplaceFields
{
    public struct Location
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string? CityName { get; set; }
        public string? StateName { get; set; }
        public string? CountryName { get; set; }
    }
}
