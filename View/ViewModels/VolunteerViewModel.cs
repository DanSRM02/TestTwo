using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.Models;
using FluentValidation;
using Logic.Services.Interfaces;
using System.Collections.ObjectModel;



namespace View.ViewModels
{

    public partial class VolunteerViewModel : ObservableObject
    {
        private readonly IVolunteerService _volunteerService;
        private readonly IValidator<VolunteerViewModel> _validator;

        [ObservableProperty]
        private string _fullName;
        [ObservableProperty]
        private string _email;
        [ObservableProperty]
        private string _phoneNumber;
        [ObservableProperty]
        private DateTime _birthDate = DateTime.Now;
        [ObservableProperty]
        private string _skillsAndExperience;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(BirthDate))]
        private string _calculatedAge;

        public ObservableCollection<string> GeneralErrors { get; } = new ObservableCollection<string>();

        public AsyncRelayCommand SaveVolunteerCommand { get; }

        public VolunteerViewModel(IVolunteerService volunteerService, IValidator<VolunteerViewModel> validator)
        {
            _volunteerService = volunteerService;
            _validator = validator;
            SaveVolunteerCommand = new AsyncRelayCommand(ExecuteSaveVolunteerCommand);
        }

        private async Task ExecuteSaveVolunteerCommand()
        {
            GeneralErrors.Clear();

            if (ValidateViewModel())
            {
                try
                {
                    Volunteer volunteer = new Volunteer
                    {
                        FullName = FullName,
                        Email = Email,
                        Phone = PhoneNumber,
                        BirthDate = BirthDate,
                        SkillsAndExperience = SkillsAndExperience,
                        Availabilities = new List<VolunteerAvailability>()
                    };

                    volunteer.Availabilities.Add(new VolunteerAvailability
                    {
                        StartTime = DateTime.Now.AddHours(2).TimeOfDay,
                        EndTime = DateTime.Now.AddHours(3).TimeOfDay,
                        DayOfWeek = DayOfWeek.Sunday,
                    });

                    await _volunteerService.Add(volunteer);
                    ClearForm();
                    MessageBox.Show("Voluntario guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    GeneralErrors.Add($"Error al guardar el voluntario: {ex.Message}");
                    MessageBox.Show($"Error al guardar el voluntario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        public bool ValidateViewModel()
        {
            var validationResult = _validator.Validate(this);
            if (!validationResult.IsValid)
            {
                GeneralErrors.Clear();
                foreach (var error in validationResult.Errors)
                {
                    GeneralErrors.Add(error.ErrorMessage);
                    MessageBox.Show(error.ErrorMessage, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
        }


        partial void OnBirthDateChanged(DateTime value)
        {
            UpdateCalculatedAge(value);
        }

        private void UpdateCalculatedAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            CalculatedAge = age.ToString();
        }

        private void ClearForm() {
            FullName = string.Empty;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            BirthDate = DateTime.Now;
            SkillsAndExperience = string.Empty;
            CalculatedAge = string.Empty;
            GeneralErrors.Clear();
        }


        //private string _availability; 
        //private TimeOnly _startHour;
        //private TimeOnly _endHour;

    }

}