using Gas_Station.EF.Repos;
using Gas_Station.Shared;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Gas_Station.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> item)
        {
            _itemRepo = item;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get()
        {
            var item = await _itemRepo.GetAllAsync();
            return item.Select(x=> new ItemListViewModel
            {
                Id=x.ID,
                Code=x.Code,
                Description=x.Description,
                Cost=x.Cost,
                Price=x.Price,
                Type=x.Type,
            });
        }

        [HttpGet("{id}")]
        public async Task<ItemListViewModel> Get(Guid id)
        {
            var getItem = new ItemListViewModel();
            if(id != Guid.Empty)
            {
                var existing = await _itemRepo.GetByIdAsync(id);
                if(existing ==null ) throw new ArgumentException($"Given id '{id}' was not found in database");

                getItem.Id = existing.ID;
                getItem.Code = existing.Code;
                getItem.Description = existing.Description;
                getItem.Cost = existing.Cost;
                getItem.Price = existing.Price;
                getItem.Type = existing.Type;

            }
            return getItem;
        }

        [HttpPost]
        public async Task Post(ItemEditViewModel model)
        {
            var getItem = new Item()
            {
                Description = model.Description,
                Price = model.Price,
                Type = model.Type,
                Cost = model.Cost
            };

            await _itemRepo.AddAsync(getItem);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemEditViewModel model)
        {
            var itemUpadate=await _itemRepo.GetByIdAsync(model.Id);
            if (itemUpadate == null) return NotFound();
            itemUpadate.Price = model.Price;
            itemUpadate.Cost = model.Cost;
            itemUpadate.Description = model.Description;
            if (itemUpadate.Type != model.Type) 
            { 
                itemUpadate.Code = Guid.NewGuid().ToString("N").Substring(0, 7);
                itemUpadate.Type = model.Type;
                
            }

            await _itemRepo.UpdateAsync(itemUpadate.ID, itemUpadate);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _itemRepo.DeleteAsync(id);
        }
    }
}
