using System.ComponentModel;

namespace OpenWeatherAPI.Playground.WPF
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

        public bool UseNonRetardUnits { get; set; } = true;

        #endregion
    }
}
