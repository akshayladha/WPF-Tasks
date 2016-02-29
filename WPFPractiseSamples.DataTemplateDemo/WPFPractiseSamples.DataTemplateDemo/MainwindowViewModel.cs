using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPractiseSamples.DataTemplateDemo
{
    public class MainwindowViewModel : INotifyPropertyChanged
    {

        private List<Vehicle> _vehicleList;
        public List<Vehicle> VehicleList
        {
            get { return _vehicleList; }
            set { _vehicleList = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(VehicleList))); }
        }

        private List<Person> _personList;
        public List<Person> PersonList
        {
            get { return _personList; }
            set
            {
                _personList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PersonList)));
            }
        }

        private string _passwordText;
        public string PasswordText
        {
            get { return _passwordText; }
            set { _passwordText = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PasswordText))); }
        }

        private Vehicle _selectedVehicle;
        public Vehicle SelectedVehicle
        {
            get { return _selectedVehicle; }
            set
            {
                _selectedVehicle = value;
                OnPropertyChanged(nameof(SelectedVehicle));
            }
        }

        private Person _selectedPerson;

        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { _selectedPerson = value; OnPropertyChanged(nameof(SelectedPerson));}
        }


        private int _selectionId;

        public int SelectionId
        {
            get { return _selectionId; }
            set
            {
                _selectionId = value;
                OnPropertyChanged(nameof(SelectionId));
            }
        }


        private RelayCommand _changeSelectionCommand;

        public RelayCommand ChangeSelectionCommand
        {
            get { return _changeSelectionCommand; }
            set { _changeSelectionCommand = value; }
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainwindowViewModel()
        {
            CreateData();
            ChangeSelectionCommand = new RelayCommand(OnSelectionChanged);
        }

        private void OnSelectionChanged(object obj)
        {
            SelectedVehicle = VehicleList.FirstOrDefault(v => v.Id == SelectionId);
            SelectedPerson = PersonList.FirstOrDefault(p => p.Id == SelectionId);
        }

        private void CreateData()
        {
            PersonList = new List<Person>
            {
                new Person {Id = 1, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 2, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 3, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 4, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 5, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 6, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 7, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 8, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 9, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 10, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 11, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 12, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 13, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 14, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 15, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 16, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 17, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 18, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 19, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 20, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 21, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 22, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 23, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 24, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 25, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 26, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 27, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 28, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 29, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 30, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 31, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 32, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 33, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 34, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 35, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 36, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 37, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 38, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 39, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 40, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 41, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 42, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 43, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 44, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 45, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 46, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 47, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 48, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 49, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 50, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 51, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 52, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" },
                new Person {Id = 53, FirstName = "Mike", LastName ="Birt", Age=35, EmailId="mike.birt@capita.co.uk",MobileNumber="" },
                new Person {Id = 54, FirstName = "Akshay", LastName ="Ladha", Age=28, EmailId="akshay.ladha@capita.co.uk",MobileNumber="" }
            };

            #region Vehicle data creation
            VehicleList = new List<Vehicle>
            {
                new Vehicle() {Id = 1,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 2,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 3,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 4,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 5,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 6,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 7,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 8,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 9,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 10,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 11,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 12,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 13,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 14,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 15,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 16,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 17,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 18,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 19,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 20,  Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 21,  Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 22, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 23, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 24, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 25, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 26, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 27, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 28, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 29, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 30, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 31, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 32, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 33, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 34, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 35, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 36, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 37, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 38, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 39, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 40, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 41, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 42, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 43, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 44, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 45, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 46, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 47, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 48, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 49, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 50, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 51, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 52, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2},
                new Vehicle() {Id = 53, Name = "Nissan 370Z", NumberOfDoors = 2, NumberOfWheels = 4},
                new Vehicle() {Id = 54, Name = "Suzuki Hayabusa", NumberOfDoors = 0, NumberOfWheels = 2}
            };

            #endregion

            //SelectedVehicle = VehicleList.FirstOrDefault(v => v.Id == 54);
        }
    }

    public class Person
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }

    }

    public class Vehicle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
    }
}
