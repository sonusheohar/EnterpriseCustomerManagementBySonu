using AutoMapper;
using CRM.Application.Features.Customers.DTOs;
using CRM.Domain.Entities;


namespace CRM.Application.Common.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>();

            CreateMap<CustomerDto, Customer>();
        }
    }
}
