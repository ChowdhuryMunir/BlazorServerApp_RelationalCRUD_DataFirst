using BlazorServerApp_RelationalCRUD_DataFirst.Models;
using BlazorServerApp_RelationalCRUD_DataFirst.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp_RelationalCRUD_DataFirst.Pages.Courses
{
    public partial class Detail
    {
        [Inject]
        protected ICourseService CourseService { get; set; }
        public Course Course { get; set; }
        [Parameter]
        public int Id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Course = await CourseService.GetCourseById(Id);
        }
    }
}
