using BlazorServerApp_RelationalCRUD_DataFirst.Models;
using BlazorServerApp_RelationalCRUD_DataFirst.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp_RelationalCRUD_DataFirst.Pages.Courses
{
    public partial class Edit
    {
        [Inject]
        protected ICourseService CourseService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public int Id { get; set; }
        public Course Course { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Course = await CourseService.GetCourseById(Id);
        }
        private async void SubmitCourse()
        {
            await CourseService.UpdateCourse(Course);
            NavigationManager.NavigateTo("/courses");
        }
    }
}
