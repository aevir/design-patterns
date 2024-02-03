namespace DesignPatterns.Behavioural
{
    // State interface
    public interface ITrafficLightState
    {
        void Change(TrafficLight trafficLight);
        void ReportState();
    }

    // Concrete States
    public class GreenLightState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.SetState(new YellowLightState());
        }

        public void ReportState()
        {
            Console.WriteLine("Traffic light is green.");
        }
    }

    public class YellowLightState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.SetState(new RedLightState());
        }

        public void ReportState()
        {
            Console.WriteLine("Traffic light is yellow.");
        }
    }

    public class RedLightState : ITrafficLightState
    {
        public void Change(TrafficLight trafficLight)
        {
            trafficLight.SetState(new GreenLightState());
        }

        public void ReportState()
        {
            Console.WriteLine("Traffic light is red.");
        }
    }

    // Context Class
    public class TrafficLight
    {
        private ITrafficLightState state;

        public TrafficLight(ITrafficLightState initialState)
        {
            state = initialState;
        }

        public void SetState(ITrafficLightState state)
        {
            this.state = state;
        }

        public void ChangeState()
        {
            state.Change(this);
        }

        public void ReportState()
        {
            state.ReportState();
        }
    }
}
