﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace NexuscsChallenge.mvc.AutoMapper
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper { get; private set; }
        public static void RegisterMappings()
        {


            var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<DomainToViewModelMappingProfile>();
                    cfg.AddProfile<ViewModelToDomainMappingtoProfile>();
                });
          
            Mapper = config.CreateMapper();
        }
    }
}