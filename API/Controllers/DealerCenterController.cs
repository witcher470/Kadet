using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTier.Entities.Abstract;
using DataTier.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealerCenterController : ControllerBase
    {
        private readonly EFDbContext _context;
        public DealerCenterController(EFDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetActiveDealerCenters()
        {
            var dealerCenters = _context.DealerCenters.Where(dcs => dcs.DealerCenterStatus == DealerCenterStatus.active)

                  .Select(dc => new
                  {
                      dealerCenterId = dc.Id,
                      name=dc.Name,
                      hasFillial = dc.HasFillial,
                      fillials = dc.Fillials,
                      location = dc.Location,
                      carBrands = dc.CarBrands,
                      dealerCenterStatus = dc.DealerCenterStatus,
                      website = dc.Website,
                      receptionPhoneNumber = dc.ReceptionPhoneNumber,
                      workingHours = dc.WorkingHours,
                      billingInformation = dc.BillingInformation,
                      legalPesonName = dc.LegalPesonName,
                      legalPesonBillingInformation = dc.LegalPesonBillingInformation,
                      legalPesonDirectorOrSignatory = dc.LegalPesonDirectorOrSignatory,
                      dateTimeOfContract = dc.DateTimeOfContract,
                      settlementPeriod = dc.SettlementPeriod,
                      settlementType = dc.SettlementType,
                      commercialResponsiblePersonsName = dc.CommercialResponsiblePersonsName,
                      commercialResponsiblePersonsPhoneNumber = dc.CommercialResponsiblePersonsPhoneNumber,
                      commercialResponsiblePersonsEmail = dc.CommercialResponsiblePersonsEmail,
                      accountingResponsiblePersonsName =dc.AccountingResponsiblePersonsName,
                      accountingResponsiblePersonsPhoneNumber = dc.AccountingResponsiblePersonsPhoneNumber,
                      accountingResponsiblePersonsEmail = dc.AccountingResponsiblePersonsEmail,
                      technicalAssistanceCardSeries = dc.TechnicalAssistanceCardSeries,
                      typesAndFillingOfServicePackages = dc.TypesAndFillingOfServicePackages,
                      materialsLink = dc.MaterialsLink,
                      anotherProducts = dc.AnotherProducts,
                      login = dc.Login,
                      password = dc.Password,
                      cooperatorName = dc.CooperatorName,
                      cooperatorPhoneNumber = dc.CooperatorPhoneNumber,
                      serviceStations = dc.ServiceStations
                  });
            return Ok(dealerCenters);

        }
    }
}