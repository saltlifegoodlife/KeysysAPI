using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using KeysysAPI.DTO;
using KeysysAPI.Entities;

namespace KeysysAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly KeysysDbContext DBContext;

        public InvoicesController(KeysysDbContext DBContext)
        {
            this.DBContext = DBContext;
        }

        [HttpGet("List")]
        public async Task<ActionResult<List<InvoiceOptionDTO>>> Get(string? invoiceTypeCode, string? categoryId)
        {
            var List = await DBContext.InvoiceOptions.Select(
                s => new InvoiceOptionDTO
                {
                    CategoryDescription = s.Ns3CategoryDescription,
                    CategoryId = s.Ns3CategoryId,
                    InvoiceTypeCode = s.Ns3InvoiceTypeCode,
                    InvoiceTypeDescription = s.Ns3InvoiceTypeDescription,
                    SubCategoryDescription = s.Ns3SubCategoryDescription,
                    SubCategoryId = s.Ns3SubCategoryId,


                }
            ).ToListAsync();

            if (String.IsNullOrEmpty(invoiceTypeCode) && String.IsNullOrEmpty(categoryId))
            {
                return List;
            }else if (!String.IsNullOrEmpty(invoiceTypeCode))
            {
                var result = List.Where(x => x.InvoiceTypeCode == Int32.Parse(invoiceTypeCode));
                return Ok(result);
            }
            else
            {
                var result = List.Where(x => x.CategoryId == Int32.Parse(categoryId));
                return Ok(result);
            }


        }



      




    }
}
