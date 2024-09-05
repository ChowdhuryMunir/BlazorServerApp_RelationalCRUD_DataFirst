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
    public partial class Detail
    {
        [Inject]
        protected ITraineeService TraineeService { get; set; }
        [Parameter]
        public int Id { get; set; }
        public Trainee Trainee { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Trainee = await TraineeService.GetTraineeById(Id);
        }
    }
}
