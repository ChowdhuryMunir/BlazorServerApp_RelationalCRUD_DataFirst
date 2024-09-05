using BlazorServerApp_RelationalCRUD_DataFirst.Models;
using BlazorServerApp_RelationalCRUD_DataFirst.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp_RelationalCRUD_DataFirst.Pages.Courses
{
    public partial class List
    {
        [Inject]
        protected ICourseService CourseService { get; set; }
        private List<Course> Courses { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Courses = await CourseService.GetCourseList();
        }
        public async Task DeleteCourse(int courseId)
        {
            var course = await CourseService.GetCourseById(courseId);
            if (course != null)
            {
                await CourseService.DeleteCourse(course);
                Courses.RemoveAll(c => c.Id == courseId);
            }
        }
    }
}
