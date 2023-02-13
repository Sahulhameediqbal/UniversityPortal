﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UniversityPortal.Common;
using UniversityPortal.Models;

namespace UniversityPortal.Interfaces.Services
{
    public interface IStudentService
    {
        Task<StudentViewModel> Get(Guid id);
        Task<IEnumerable<StudentViewModel>> GetAll();
        Task<AppResponse> Save(StudentViewModel model);
        Task<Guid> GetUniversityId();
        Task<Guid> GetStudentId();
        Task<string> GetStudentName();
        Task<string> GetStudentName(Guid id);
        Task<List<SelectListItem>> GetAllGender();
        Task<StudentViewModel> GetStudentProfile();
        Task UpdatePaidTutionFee();
        Task<IActionResult> DegreeCertificateExportToPDF();
    }
}
