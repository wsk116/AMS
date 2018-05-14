﻿using System.Collections.Generic;
using AMS.Model.dto;
using AMS.Model.Repositories.Implements;
using AMS.Model.Repositories.Interfaces;
using AMS.Service.Services.Interfaces;

namespace AMS.Service.Services.Implements
{
    public class PartsService : IPartsService
    {
        private readonly IPartsRepository _partsRepository;

        public PartsService()
        {
            _partsRepository = new PartsRepository();
        }

        public List<PartsDto> GetAllParts()
        {
            return _partsRepository.GetAllParts();
        }
    }
}
