using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GetAsessmentAnswers.Models;

namespace GetAsessmentAnswers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssessmentAnswersController : ControllerBase
    {
        private readonly AssessmentsContext _context;

        public AssessmentAnswersController(AssessmentsContext context)
        {
            _context = context;
        }

        // GET: api/AssessmentAnswers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssessmentAnswer>>> GetAssessmentAnswers()
        {
          if (_context.AssessmentAnswers == null)
          {
              return NotFound();
          }
            return await _context.AssessmentAnswers.ToListAsync();
        }

        // GET: api/AssessmentAnswers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AssessmentAnswer>> GetAssessmentAnswer(int id)
        {
          if (_context.AssessmentAnswers == null)
          {
              return NotFound();
          }
            var assessmentAnswer = await _context.AssessmentAnswers.FindAsync(id);

            if (assessmentAnswer == null)
            {
                return NotFound();
            }

            return assessmentAnswer;
        }

        // POST: api/AssessmentAnswers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AssessmentAnswer>> PostAssessmentAnswer(AssessmentAnswer assessmentAnswer)
        {
          if (_context.AssessmentAnswers == null)
          {
              return Problem("Entity set 'AssessmentsContext.AssessmentAnswers'  is null.");
          }
            _context.AssessmentAnswers.Add(assessmentAnswer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssessmentAnswer", new { id = assessmentAnswer.answer_id }, assessmentAnswer);
        }



        private bool AssessmentAnswerExists(int id)
        {
            return (_context.AssessmentAnswers?.Any(e => e.answer_id == id)).GetValueOrDefault();
        }
    }
}
