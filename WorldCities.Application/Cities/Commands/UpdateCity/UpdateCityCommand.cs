﻿using MediatR;


namespace WorldCities.Application.Cities.Commands.UpdateCity
{
    public class UpdateCityCommand : IRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Name_ASCII { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public int CountryId { get; set; }
    }
}
