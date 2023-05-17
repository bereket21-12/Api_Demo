using apidb2.Models;
using apidb2.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/Agent")]
public class AgentController:ControllerBase{


        private readonly Iagent _agent;

    public AgentController(Iagent agent )
    {
        this._agent = agent ;
        
    }

    [HttpGet]
    public Task<ActionResult <List<Agent>>> get(){

        return Task.FromResult<ActionResult<List<Agent>>>(_agent.GetAll());
        
    }

    [HttpPut("{id:int}")]
    public Task<ActionResult> update(int id , [FromBody] Agent newagent){

         _agent.Update(id,newagent);

        return Task.FromResult<ActionResult>(NoContent());
    }

       [HttpDelete("{id:int}")]
    public void Delete(int id){

         _agent.Delete(id);
    }

       [HttpPost]
    public void Create([FromBody]Agent agent){

         _agent.Create(agent);

    }


}