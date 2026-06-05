using AutoMapper;
using CRM.Application.Common.Interfaces;
using CRM.Application.Features.Customers.DTOs;
using CRM.Domain.Common;
using CRM.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerHandler
    : IRequestHandler<CreateCustomerCommand,
        Result<CustomerDto>>
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public CreateCustomerHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<CustomerDto>> Handle(
            CreateCustomerCommand request,
            CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };

            await _unitOfWork.Customers.AddAsync(customer);

            await _unitOfWork.SaveChangesAsync();

            var dto = _mapper.Map<CustomerDto>(customer);

            return Result<CustomerDto>.Succeed(
                dto,
                "Customer created successfully");
        }
    }
}