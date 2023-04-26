using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repository;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRespository<T> _respository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork,IGenericRespository<T> respository)
        {
            _unitOfWork = unitOfWork;
            _respository = respository; 
        }

        public async Task<T> AddAsync(T entity)
        {
            await _respository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _respository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _respository.AnyAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
           return await _respository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
           return await _respository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
           _respository.Remove(entity);
            await _unitOfWork.CommitAsync();    
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _respository.RemoveRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
           _respository.Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _respository.Where(expression);
        }
    }

}
