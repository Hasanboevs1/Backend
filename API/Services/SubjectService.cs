using API.DTOs.SubjectDTOs;
using API.Entities;
using API.Interfaces;
using API.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Services;

public class SubjectService : ISubjectService
    {
        private readonly IGenericRepository<Subject> _subjectRepository;
        private readonly IMapper _mapper;

        public SubjectService(IGenericRepository<Subject> subjectRepository, IMapper mapper)
        {
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SubjectDTO>> GetAllSubjectsAsync()
        {
            var subjects = await _subjectRepository.SelectAllAsync().ToListAsync();
            return _mapper.Map<IEnumerable<SubjectDTO>>(subjects);
        }

        public async Task<SubjectDTO> GetSubjectByIdAsync(int id)
        {
            var subject = await _subjectRepository.SelectByIdAsync(id);
            return _mapper.Map<SubjectDTO>(subject);
        }

        public async Task<SubjectDTO> CreateSubjectAsync(SubjectCreateDTO subjectCreateDTO)
        {
            var subject = _mapper.Map<Subject>(subjectCreateDTO);
            await _subjectRepository.InsertAsync(subject);
            return _mapper.Map<SubjectDTO>(subject);
        }

        public async Task<string> UpdateSubjectAsync(int id, SubjectUpdateDTO subjectUpdateDTO)
        {
            var subject = await _subjectRepository.SelectByIdAsync(id);
            if (subject == null) return "Not Found";

            _mapper.Map(subjectUpdateDTO, subject);
            await _subjectRepository.UpdateAsync(id, subject);

            return "Updated";
        }

        public async Task<string> DeleteSubjectAsync(int id)
        {
            var subject = await _subjectRepository.SelectByIdAsync(id);
            if (subject != null)
            {
                await _subjectRepository.DeleteAsync(id);
                return "Deleted";
            }
            return "Not Found";
        }
    }