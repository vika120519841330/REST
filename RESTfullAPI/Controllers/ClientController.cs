using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTfullAPI.Models;

namespace RESTfullAPI.Controllers
{
    public class ClientController : ApiController
    {
        IClientBase cl = ClientBase.GetStaticClient();
        
        [HttpGet]
        public IEnumerable<Client> ShowAllClients()
        {
            return cl.ShowAllClients();
        }

        [HttpGet]
        public Client GetClient(int id)
        {
            return cl.GetClient(id);
        }

        [HttpPost]
        public Client AddClient(Client inst)
        {
            return cl.AddClient(inst);
        }
        [HttpPut]
        public bool UpdateClient(Client inst)
        {
            return cl.UpdateClient(inst);
        }

        [HttpDelete]
        public void DeleteCient(int id)
        {
            cl.DeleteCient(id);
        }
    }
}
