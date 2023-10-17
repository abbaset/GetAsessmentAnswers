using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GetAsessmentAnswers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Assessments : ControllerBase
    {
        public readonly IConfiguration configuration;
        public Assessments(IConfiguration configuration)
        {

        }
    }
}
