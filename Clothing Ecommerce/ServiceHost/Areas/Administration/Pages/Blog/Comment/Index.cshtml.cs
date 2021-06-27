using System.Collections.Generic;
using CommentManagement.Application.Contracts.Comment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages.Blog.Comment
{
    public class IndexModel : PageModel
    {
        [TempData] public string Message { get; set; }
        public List<CommentViewModel> Comments;
        public CommentSearchModel SearchModel;
        private readonly ICommentApplication _commentApplication;

        public IndexModel(ICommentApplication commentApplication)
        {
            _commentApplication = commentApplication;
        }


        public void OnGet(CommentSearchModel searchModel)
        {
            Comments = _commentApplication.Search(searchModel);
        }

        public IActionResult OnGetCancel(long id)
        {
            var product = _commentApplication.Cancel(id);
            if (product.IsSucceeded)
                return RedirectToPage("./Index");

            Message = product.Message;
            return RedirectToPage("./Index");
        }

        public IActionResult OnGetConfirm(long id)
        {
            var product = _commentApplication.Confirm(id);
            if (product.IsSucceeded)
                return RedirectToPage("./Index");

            Message = product.Message;
            return RedirectToPage("./Index");
        }
    }
}