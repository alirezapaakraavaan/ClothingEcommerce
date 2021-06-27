using System.Collections.Generic;
using System.Linq;
using _0_Framework.Application;
using _0_Framework.Infrastructure;
using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Domain.CommentAgg;

namespace CommentManagement.Infrastructure.EfCore.Repository
{
    public class CommentRepository : RepositoryBase<long, Comment>, ICommentRepository
    {
        private readonly CommentContext _context;

        public CommentRepository(CommentContext context) : base(context)
        {
            _context = context;
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            var query = _context.Comments.Select(x => new CommentViewModel
            {
                Id = x.Id,
                Email = x.Email,
                Website = x.Website,
                IsCanceled = x.IsCanceled,
                IsConfirmed = x.IsConfirmed,
                Message = x.Message,
                OwnerRecordId = x.OwnerRecordId,
                Type = x.Type,
                Name = x.Name,
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(x => x.Name.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.Email))
                query = query.Where(x => x.Name.Contains(searchModel.Email));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}