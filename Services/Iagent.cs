using apidb2.Models;
using Microsoft.AspNetCore.Mvc;

namespace apidb2.Services;
public interface Iagent
 {

    List<Agent> GetAll() ;
    void  Create(Agent agent) ;
    Task<ActionResult > Delete(int id) ;
     void Update(int id , Agent newagent) ;

    
 }