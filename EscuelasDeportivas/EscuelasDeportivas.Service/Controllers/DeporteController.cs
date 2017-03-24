using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using EscuelasDeportivas.Service.DataObjects;
using EscuelasDeportivas.Service.Models;

namespace EscuelasDeportivas.Service.Controllers
{
    public class DeporteController : TableController<Deporte>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            EscuelasDeportivasContext context = new EscuelasDeportivasContext();
            DomainManager = new EntityDomainManager<Deporte>(context, Request);
        }

        // GET tables/Deporte
        public IQueryable<Deporte> GetAllDeportes()
        {
            return Query();
        }

        // GET tables/Deporte/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Deporte> GetDeporte(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Deporte/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Deporte> PatchDeporte(string id, Delta<Deporte> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/Deporte
        public async Task<IHttpActionResult> PostDeporte(Deporte item)
        {
            Deporte current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Deporte/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteDeporte(string id)
        {
            return DeleteAsync(id);
        }
    }
}