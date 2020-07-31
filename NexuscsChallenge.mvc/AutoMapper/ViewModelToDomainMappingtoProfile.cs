using AutoMapper;
using NexuscsChallenge.domain.Entities;
using NexuscsChallenge.mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NexuscsChallenge.mvc.AutoMapper
{
    public class ViewModelToDomainMappingtoProfile : Profile
    {
        public ViewModelToDomainMappingtoProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
       

    }
}