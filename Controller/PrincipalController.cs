using Microsoft.AspNetCore.Mvc;

namespace Protafolio1.Controllers;

public class PrincipalController : Controller{
    [HttpGet]
    [Route("")]
    public string Index(){
        return "This is my index!";

    }

    [HttpGet]
    [Route("projects/")]
    public string Projects() {
        return "These are my projects";

    }

    [HttpGet]
    [Route("contact/")]
    public string Conctact() {
        return "This is my contact";

    }


}