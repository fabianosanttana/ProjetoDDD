using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AspNetMvc.Domain.Entities;
using AspNetMvc.MVC.ViewModels;

namespace AspNetMvc.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}