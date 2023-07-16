using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using RealHomeProject.Business.Abstract;
using RealHomeProject.DataAccess.Concrete;
using RealHomeProject.Dto.Dtos.BlogDTOs;
using RealHomeProject.Entities.Concrete;

namespace RealHomeProject.WebUI.Controllers
{
    [AllowAnonymous]

    public class BlogController : Controller
	{
		private readonly IBlogPostService _blogPostService;
		public BlogController(IBlogPostService blogPostService)
		{
			_blogPostService = blogPostService;
		}

		public async Task<IActionResult> Index()
		{
			var result = _blogPostService.TGetAll();
			return View(result);
		}
		
		public IActionResult BlogDetails(int id)
		{
			var result = _blogPostService.TGetByFilter(x=> x.ID == id);
			return View(result);
		}

	}
}
