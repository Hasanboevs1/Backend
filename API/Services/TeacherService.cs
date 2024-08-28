using API.DTOs.TeacherDTOs;
using API.Entities;
using API.Interfaces;
using API.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class TeacherService : ITeacherService
{
    private readonly IGenericRepository<Teacher> _teacherRepository;
    private readonly IMapper _mapper;

    public TeacherService(IGenericRepository<Teacher> teacherRepository, IMapper mapper)
    {
        _teacherRepository = teacherRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TeacherDTO>> GetAllTeachersAsync()
    {
        var teachers = await _teacherRepository.SelectAllAsync().Include(x => x.Subjects).ThenInclude(x => x.Subject)
        .ToListAsync();
        return _mapper.Map<IEnumerable<TeacherDTO>>(teachers);
    }

    public async Task<TeacherDTO> GetTeacherByIdAsync(int id)
    {
        var teacher = await _teacherRepository.SelectAllAsync().Include(x => x.Subjects).ThenInclude(x => x.Subject)
        .FirstOrDefaultAsync(x => x.Id == id);
        return _mapper.Map<TeacherDTO>(teacher);
    }

    public async Task<TeacherDTO> CreateTeacherAsync(TeacherCreateDTO teacherCreateDTO)
    {
        var teacher = _mapper.Map<Teacher>(teacherCreateDTO);
        await _teacherRepository.InsertAsync(teacher);
        return _mapper.Map<TeacherDTO>(teacher);
    }

    public async Task<string> UpdateTeacherAsync(int id, TeacherUpdateDTO teacherUpdateDTO)
    {
        var teacher = await _teacherRepository.SelectByIdAsync(id);
        if (teacher == null) return "Not Found";

        _mapper.Map(teacherUpdateDTO, teacher);
        await _teacherRepository.UpdateAsync(id, teacher);
        return "Updated";
    }

    public async Task<string> DeleteTeacherAsync(int id)
    {
        var teacher = await _teacherRepository.SelectByIdAsync(id);
        if (teacher != null)
        {
            await _teacherRepository.DeleteAsync(id);
            return "Deleted";
        }
        return "Not Found";
    }
}
