﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTier.Entities.Abstract;
using DataTier.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly EFDbContext _context;
        public OrderController(EFDbContext context)
        {
            _context = context;
        }

      /*  [HttpGet]
        public IActionResult GetActiveOrders()
        {
            var orders = _context.Orders.Where(os => os.OrderStatus == OrderStatus.active)

                  .Select(or => new
                  {
                     orderId = or.Id,
                     dateTimeOrdered = or.DateTimeOrdered,
                     clientFirstName = or.ClientFirstName,
                     clientSecondName = or.ClientSecondName,
                     clientThirdName = or.ClientThirdName,
                     technicalAssistanceCardNumber = or.TechnicalAssistanceCardNumber,
                     location = or.Location,
                     pointOfDeparture = or.PointOfDeparture,
                     pointOfDestination = or.PointOfDestination,
                     services = or.Services,
                     servicesCostForClient = or.ServicesCostForClient,
                     sevicesCostForContractor = or.ServicesCostForContractor,
                     companyComission = or.CompanyComission,
                     contractorId = or.ContractorId,
                     contractorSerialNumber = or.ContractorSerialNumber,
                     contractorPhoneNumber = or.ContractorPhoneNumber,
                     serviceTime = or.ServiceTime,
                     orderStatus = or.OrderStatus,
                     paymentMethod = or.PaymentMethod,
                     serviceRating = or.ServiceRating,
                     operatorComment = or.OperatorComment,
                     clientRewiev = or.ClientReview
                  });
            return Ok(orders);

        }*/
    }
}