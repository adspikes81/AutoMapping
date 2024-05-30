using AutoMapping.Models;
using System;
using System.Threading.Tasks;

namespace Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class BookController //: ControllerBase
    {
        //private readonly IServiceName _serviceName;

        //public BookController(IServiceName serviceName) 
        //{
        //    _serviceName = serviceName;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Burdens>>> RetrieveAllBurdens()
        //{
        //    //// USING EF CORE   
        //    return await _context.Burdens.ToListAsync();

        //    //// USING A SERVICE LAYER 
        ////    return await _serviceName.GetAllBurdens();

        //    //// USING EF CORE W/ DTO CUSTOM MAPPER  
        ////    return await _context.Burdens.ToListAsync();

        //}

        //[HttpPost]
        //public async Task<GetBookDTO> Post([FromBody] CreatedBookDTO bookDTO)
        ////public async Task<Book> Post([FromBody] Book book)
        //{
        ////    return await _service.Create(book);
        //      return await _service.Create(bookDTO);
        ////        OR
        //// within the _services file, instead of mapping directly to your model use ur DTOs
        //    return await _service.Create(new Book()
        //    { AuthorId = bookDTO.AuthorId
        //    , etc
        //    , etc
        //    ,[this happens for each object within the entity]
        //    });
        //}

        //[HttpPut("{id}")]
        //public async Task<Book> Put(int Id, [FromBody] Book book)
        //{
        //    return await _service.Update(Id, book);
        //}

        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        //[HttpGet("GetBurdens/{id}")]
        //public async Task<ActionResult<Burdens>> GetOwnerAddressesMainDetails(int id)
        //{
        //    var burdens = await _context.Burdens.FindAsync(id);

        //    if (burdens == null)
        //    {
        //        return NotFound();
        //    }

        //    return burdens;
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        //[HttpGet("{SearchBurdens}")]
        //public async Task<IEnumerable<Burdens>> SearchBurdens(string name)
        //{
        //    try
        //    {
        //        var result = await SearchBurdens(name);

        //        if (result.Any())
        //        {
        //            return (IEnumerable<Burdens>)Ok(result);
        //        }

        //        return (IEnumerable<Burdens>)NotFound();
        //    }
        //    catch (Exception)
        //    {
        //        return (IEnumerable<Burdens>)StatusCode(StatusCodes.Status500InternalServerError,
        //            "Error retrieving data from database");

        //    }
        //}
    }
}
