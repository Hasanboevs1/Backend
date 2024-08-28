
using API.DTOs.SubjectDTOs;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;
[Route("api/subjects")]
[ApiController]
public class SubjectsController : ControllerBase
{
    private readonly ISubjectService _subjectService;

    public SubjectsController(ISubjectService subjectService)
    {
        _subjectService = subjectService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllSubjects()
    {
        var subjects = await _subjectService.GetAllSubjectsAsync();
        return Ok(subjects);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetSubjectById(int id)
    {
        var subject = await _subjectService.GetSubjectByIdAsync(id);
        if (subject == null) return NotFound();
        return Ok(subject);
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubject(SubjectCreateDTO subjectCreateDTO)
    {
        var subject = await _subjectService.CreateSubjectAsync(subjectCreateDTO);
        return CreatedAtAction(nameof(GetSubjectById), new { id = subject.Id }, subject);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateSubject(int id, SubjectUpdateDTO subjectUpdateDTO)
    {
        await _subjectService.UpdateSubjectAsync(id, subjectUpdateDTO);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSubject(int id)
    {
        await _subjectService.DeleteSubjectAsync(id);
        return NoContent();
    }
}