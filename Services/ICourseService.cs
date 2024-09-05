using BlazorServerApp_RelationalCRUD_DataFirst.Models;

namespace BlazorServerApp_RelationalCRUD_DataFirst.Services
{
    public interface ICourseService
    {
        Task<List<Course>> GetCourseList();
        Task<Course> GetCourseById(int id);
        Task<Course> CreateCourse(Course course);
        Task UpdateCourse(Course course);
        Task DeleteCourse(Course course);
    }
}