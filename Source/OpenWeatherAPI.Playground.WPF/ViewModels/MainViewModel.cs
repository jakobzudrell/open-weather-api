using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using OpenWeatherAPI;

namespace SimpleWeather
{
    /// <summary>
    /// The MainViewModel for this application
    /// </summary>
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Public Events

        /// <summary>
        /// The event that is fired when a property has changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        #endregion

        #region Public Properties

        /// <summary>
        /// Indicates whether non retard or retard units should be used
        /// </summary>
        public bool UseNonRetardUnits { get; set; } = true;


        /// <summary>
        /// The id of the city to retreive data from
        /// </summary>
        public string CityID { get; set; }

        public CurrentWeatherModel CurrentWeather { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// Command to get the data
        /// </summary>
        public ICommand GetDataCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainViewModel()
        {
            GetDataCommand = new RelayCommand(async () => await GetDataAsync());
        }

        #endregion

        #region Public Methods

        public async Task GetDataAsync()
        {

        }

        #endregion
    }
}
