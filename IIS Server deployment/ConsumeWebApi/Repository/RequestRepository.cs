using System.Net.Http;
using System.Collections.Generic;
using System;
using System.Linq;
using ConsumeWebApi.Models;

namespace ConsumeWebApi.Models
{

    public class RequestRepository : IRequest
    {
        private readonly ConsumeApiDbContext context;
        public RequestRepository(ConsumeApiDbContext context)
        {
            this.context = context;
        }
        public List<Request> AllRequests()
        {
            return context.Requests.AsEnumerable().ToList();
        }
       
    
        public Request Add(Request request)
        {
            context.Requests.Add(request);
            context.SaveChanges();
            return request;
        }
        public bool Update(int id,Request requestChanges)
        {
            if(id==requestChanges.requestId)
            {
            context.Requests.Update(requestChanges);
            context.SaveChanges();
            return true;
            }
            return false;

        }
    }
}

