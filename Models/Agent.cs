using System.ComponentModel.DataAnnotations;

namespace apidb2.Models ;

public class Agent {
    
    //  [Required(ErrorMessage =" id field is required ")]
    public string? Id { get; set; }

    //  [Required(ErrorMessage =" Operationid field is required ")]
    public string? OperationId { get; set; }

    //  [Required(ErrorMessage =" id field is required ")]
    public string? Name { get; set; }
    public string? Amount { get; set; }
    public string? Currency { get; set; }
    public DateTime Date { get; set; }
    public  string? Agents { get; set; }
    public  string? Method { get; set; }



  // Id: string,
  // Name:String,
  // Method : String,
  // Currency : string,
  // Amount : String,
  // Description :string,
  // Agent :String,
  // Date : Date



//       OperationId: string,
//   Name:String,
//   Method : String,
//   Currency : string,
//   Amount : String,
//   Description :string,
//   Agent :String,
//   Date : Date

}