using HRMS.DataAccess.Repositories;
using HRMS.Entities.Models;
using NTierArchitecture.Business.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Business.Services
{
    public class LeaveRequestService(LeaveRequestRepository lRepo) : IManager<LeaveRequest>
    {
        private readonly LeaveRequestRepository _repository = lRepo;

        public void Create(LeaveRequest entity) => _repository.Create(entity);

        public void Delete(Guid id)
        {
            var leaveRequestToDelete = _repository.GetById(id);
            if (leaveRequestToDelete != null)
            {
                _repository.DeleteById(id);
            }
            else
            {
                throw new Exception("İzin talebi bulunamadı.");
            }
        }

        public IEnumerable<LeaveRequest>? GetAll()
        {
            return _repository.GetAll() ?? throw new Exception("İzin talebi bulunamadı");
        }

        public LeaveRequest? GetById(Guid id)
        {
            return _repository.GetById(id) ?? throw new Exception("İzin talebi bulunamadı");
        }

        public bool IfEntityExists(Expression<Func<LeaveRequest, bool>> filter)
        {
            return _repository.IfEntityExists(filter);
        }

        public void Update(LeaveRequest entity)
        {
            var existingLeaveRequest = _repository.GetById(entity.ID);
            if (existingLeaveRequest != null)
            {
                // Güncellenmesi gereken izin talebi var
                existingLeaveRequest.StartDate = entity.StartDate;
                existingLeaveRequest.EndDate = entity.EndDate;
                existingLeaveRequest.LeaveType = entity.LeaveType;
                existingLeaveRequest.LeaveStatus = entity.LeaveStatus;
                _repository.Update(existingLeaveRequest); // Repository'nin update metoduyla güncelle
            }
            else
            {
                throw new Exception("İzin talebi bulunamadı.");
            }
        }

    }
}
