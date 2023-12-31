﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GetAsessmentAnswers.Models;
using System.Net;

namespace GetAsessmentAnswers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class assessment_answerController : ControllerBase
    {
        private readonly AssessmentsContext _context;

        public assessment_answerController(AssessmentsContext context)
        {
            _context = context;
        }

        [HttpGet("{type}")]
        public IActionResult Getassessment(string type)
        {
            if (_context.assessment_questions == null)
            {
                return NotFound();
            }
          

            var assessment_answer = (from aa in _context.assessment_questions
                                     join bb in _context.assessment_answers on aa.id equals bb.question_id
                                     join cc in _context.assessments on bb.assessment_id equals cc.id
                                     where aa.type == type
                                     select new { AssessmentID = cc.id, cc.title, cc.short_description, aa.question, aa.type, bb.answer }
                 ).ToList();


            if (assessment_answer == null)
            {
                return NotFound();
            }

            return Ok(assessment_answer);

        }
        //// GET: api/assessment_answer
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<assessment_answer>>> Getassessment_answers()
        //{
        //  if (_context.assessment_answers == null)
        //  {
        //      return NotFound();
        //  }
        //    return await _context.assessment_answers.ToListAsync();
        //}

        //// GET: api/assessment_answer/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<assessment_answer>> Getassessment_answer(long id)
        //{
        //  if (_context.assessment_answers == null)
        //  {
        //      return NotFound();
        //  }
        //    var assessment_answer = await _context.assessment_answers.FindAsync(id);

        //    if (assessment_answer == null)
        //    {
        //        return NotFound();
        //    }

        //    return assessment_answer;
        //}





        // POST: api/assessment_answer
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<assessment_answer>> Postassessment_answer(assessment_answer assessment_answer)
        {
          if (_context.assessment_answers == null)
          {
              return Problem("Entity set 'AssessmentsContext.assessment_answers'  is null.");
          }
            _context.assessment_answers.Add(assessment_answer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getassessment_answer", new { id = assessment_answer.id }, assessment_answer);
        }

        private bool assessment_answerExists(long id)
        {
            return (_context.assessment_answers?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
