using System.Collections.Generic;


namespace ConsumeWebApi.Models{
    public interface IRequest
    {

        List<Request> AllRequests();
        // Request GetRequest(int Id);
    
        Request Add(Request request);
        bool Update(int id,Request requestChanges);

    
    }
}
