using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural
{
    /*
     * WeatherData is the concrete subject. It maintains a list of observers and notifies them of changes in weather data.
     * CurrentConditionsDisplay is a concrete observer that updates its display based on the data it receives from WeatherData.
     */

    // Observer interface
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }

    // Subject interface
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    // Concrete Subject
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }

    // Concrete Observers
    public class CurrentConditionsDisplay : IObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");
        }
    }
}
