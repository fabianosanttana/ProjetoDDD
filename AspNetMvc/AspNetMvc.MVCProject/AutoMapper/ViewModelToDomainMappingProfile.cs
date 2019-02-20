using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AspNetMvc.MVC.ViewModels;
using AspNetMvc.Domain.Entities;

namespace AspNetMvc.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }


        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<ProductViewModel, Product>();
        }

    }
}