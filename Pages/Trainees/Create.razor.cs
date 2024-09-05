using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using BlazorServerApp_RelationalCRUD_DataFirst.Models;
using BlazorServerApp_RelationalCRUD_DataFirst.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp_RelationalCRUD_DataFirst.Pages.Trainees
{
    public partial class Create
    {
        [Inject]
        protected ITraineeService TraineeService { get; set; }
        [Inject]
        protected ICourseService CourseService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public Trainee Trainee { get; set; }
        private List<Course> Courses { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Trainee = new Trainee();
            Courses = await CourseService.GetCourseList();
        }
        private async void SubmitTrainee()
        {
            await TraineeService.CreateTrainee(Trainee);
            NavigationManager.NavigateTo("/trainees");
        }
    }
}
