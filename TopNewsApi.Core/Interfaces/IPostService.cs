using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopNewsApi.Core.DTOs.Category;
using TopNewsApi.Core.DTOs.Post;

namespace TopNewsApi.Core.Interfaces
{
    public interface IPostService
    {
        Task<List<PostDto>> GetAll();
        Task<PostDto?> Get(int id);
        Task<List<PostDto>> GetByCategory(int id);
        Task Create(PostDto model);
        Task Update(PostDto model);
        Task Delete(int id);
        Task<PostDto?> GetById(int id);
        Task<List<PostDto>> Search(string searchString);
    }
}
