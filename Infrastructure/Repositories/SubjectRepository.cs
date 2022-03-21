using Microsoft.EntityFrameworkCore;
using PreviaturasFing.Domain.Interfaces;
using PreviaturasFing.Domain.Models;
using PreviaturasFing.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PreviaturasFing.Infrastructure.Repositories
{
    public class SubjectRepository : IRepository<Subject>
    {
        private readonly SubjectDbContext _dbContext;
        protected readonly DbSet<Subject> ModelDbSets;

        public SubjectRepository(SubjectDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException();
            ModelDbSets = _dbContext.Set<Subject>();
        }


        public void Dispose()
        {
            _dbContext?.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Subject> GetAsync(Expression<Func<Subject, bool>> predicate)
        {
            return await ModelDbSets.AsNoTracking().Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Subject>> GetListAsync(Expression<Func<Subject, bool>> predicate)
        {
            return await ModelDbSets.AsNoTracking().Where(predicate).ToListAsync();
        }

        public IQueryable<Subject> Queryable(Expression<Func<Subject, bool>> predicate)
        {
            return ModelDbSets.Where(predicate);
        }

        public void Add(Subject entity)
        {
            ModelDbSets.Add(entity);
        }

        public void AddRange(IEnumerable<Subject> entities)
        {
            ModelDbSets.AddRange(entities);
        }

        public void Remove(Subject entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached) ModelDbSets.Attach(entity);

            ModelDbSets.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Subject> entities)
        {
            foreach (var entity in entities)
            {
                if (_dbContext.Entry(entity).State == EntityState.Detached) ModelDbSets.Attach(entity);

                ModelDbSets.Remove(entity);
            }
        }

        public void Update(Subject entity)
        {
            ModelDbSets.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
