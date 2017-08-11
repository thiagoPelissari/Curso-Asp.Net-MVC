using AutoMapper;
using MaromFit.Dtos;
using MaromFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MaromFit.Controllers.Api
{
    public class ClientsController : ApiController
    {
        private ApplicationDbContext _context;

        public ClientsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/clients
        public IHttpActionResult GetClient()
        {
            return Ok(_context.Client.ToList().Select(Mapper.Map<Client, ClientDto>));
        }


        //GET /api/clients/1
        public IHttpActionResult GetClient(int id)
        {
            var client = _context.Client.SingleOrDefault(c => c.Id == id);

            if (client == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();
            }
            else
            {
                return Ok(Mapper.Map<Client, ClientDto>(client));
            }
        }

        //POST /api/clients
        [HttpPost]
        public IHttpActionResult CreateClient(ClientDto clientDto)
        {
            if (!ModelState.IsValid)
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();

            var client = Mapper.Map<ClientDto, Client>(clientDto);

            _context.Client.Add(client);
            _context.SaveChanges();

            clientDto.Id = client.Id;

            return Created(new Uri(Request.RequestUri + "/" + client.Id),clientDto);
        }


        //PUT /api/clients/1
        [HttpPut]
        public IHttpActionResult UpdateClient(int id, Client clientDto)
        {
            if (!ModelState.IsValid)
                //throw new HttpResponseException(HttpStatusCode.BadRequest);
                return BadRequest();

            var clientIndIb = _context.Client.SingleOrDefault(c => c.Id == id);

            if (clientIndIb == null)
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();

            Mapper.Map(clientDto, clientIndIb);

            _context.SaveChanges();

            return Ok();
        }

        //DELETE /api/clients/1
        [HttpDelete]
        public IHttpActionResult DeleteClient(int id)
        {
            var clientIndIb = _context.Client.SingleOrDefault(c => c.Id == id);

            if (clientIndIb == null)
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();

            _context.Client.Remove(clientIndIb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
