using FluentValidation;
using Logic.Services.Interfaces;
using View.ViewModels;

namespace View
{
    public partial class Volunteers : Form
    {
        private VolunteerViewModel _viewModel;
        public Volunteers(VolunteerViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            volunteerViewModelBindingSource.DataSource = _viewModel;

            boxFullName.DataBindings.Add("Text", volunteerViewModelBindingSource, nameof(VolunteerViewModel.FullName), true, DataSourceUpdateMode.OnPropertyChanged);
            boxEmail.DataBindings.Add("Text", volunteerViewModelBindingSource, nameof(VolunteerViewModel.Email), true, DataSourceUpdateMode.OnPropertyChanged);
            boxPhone.DataBindings.Add("Text", volunteerViewModelBindingSource, nameof(VolunteerViewModel.PhoneNumber), true, DataSourceUpdateMode.OnPropertyChanged);
            boxBirth.DataBindings.Add("Value", volunteerViewModelBindingSource, nameof(VolunteerViewModel.BirthDate), true, DataSourceUpdateMode.OnPropertyChanged);
            boxSkills.DataBindings.Add("Text", volunteerViewModelBindingSource, nameof(VolunteerViewModel.SkillsAndExperience), true, DataSourceUpdateMode.OnPropertyChanged);
            boxYearsOld.DataBindings.Add("Text", volunteerViewModelBindingSource, nameof(VolunteerViewModel.CalculatedAge), true, DataSourceUpdateMode.OnPropertyChanged);            
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            await _viewModel.SaveVolunteerCommand.ExecuteAsync(null);
            volunteerViewModelBindingSource.ResetBindings(false);            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var vo
            volunteersAssigment.Show();
            this.Hide();

        }
    }
}
