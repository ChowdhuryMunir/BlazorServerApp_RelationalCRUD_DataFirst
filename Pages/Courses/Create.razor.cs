using BlazorServerApp_RelationalCRUD_DataFirst.Models;
using BlazorServerApp_RelationalCRUD_DataFirst.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp_RelationalCRUD_DataFirst.Pages.Courses
{
    public partial class Create
    {
        [Inject]
        protected ICourseService CourseService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public Course Course { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Course = new Course();
        }
        private async void SubmitCourse()
        {
            await CourseService.CreateCourse(Course);
            NavigationManager.NavigateTo("/courses");
        }
    }
}