using MauiAppNetworkTest.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppNetworkTest
{
    public interface IApiService
    {
        [Get("/projects")]
        Task<List<Project>> GetProjectsAsync();

        [Get("/projects/{id}")]
        Task<Project> GetProjectByIdAsync(int id);

        [Post("/projects")]
        Task<Project> CreateProjectAsync([Body] Project project);

        [Put("/projects/{id}")]
        Task<Project> UpdateProjectAsync(int id, [Body] Project project);

        [Delete("/projects/{id}")]
        Task DeleteProjectAsync(int id);
    }
}
