using apidb2.Models;
using apidb2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class AgentService :Iagent{

   private readonly ApplicationDbContext _context ;


    //database will be injected here
    public AgentService(ApplicationDbContext context)
    
    {
        _context = context ;

    }

    public async void  Create(Agent agent )
    {
        //  _context.Add(agent);
         Console.Write("created") ;
         await _context.AddAsync<Agent>(agent) ;
         _context.SaveChanges() ;
        
    }

    public async Task<ActionResult> Delete(int id)
    {
        var agent  =  _context.Agents.FirstOrDefault( x => x.Id == id.ToString()) ;

        if(agent ==null){

            return null;
        }

        _context.Remove(agent);
        await _context.SaveChangesAsync() ;

        return null ;
    }


    public  List<Agent> GetAll(){


        return  _context.Agents.ToList();
    }

    public void Update(int id , Agent newagent)
    {
        newagent.Id = id.ToString() ;
        _context.Entry(newagent).State = EntityState.Modified ;
        _context.SaveChangesAsync();


        
    }
}