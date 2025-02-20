﻿using UniversityPortal.Repository;

namespace UniversityPortal.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        Task<int> Save();
        public IUniversityRepository UniversityRepository { get; }
        public IUniversityStaffRepository UniversityStaffRepository { get; }
        public IStudentRepository StudentRepository { get; }
        public IPaperRepository PaperRepository { get; }
        public IStudentExamRepository StudentExamRepository { get; }
        public ISemesterExamRepository SemesterExamRepository { get; }
        public IPaymentRepository PaymentRepository { get; }
    }
}
