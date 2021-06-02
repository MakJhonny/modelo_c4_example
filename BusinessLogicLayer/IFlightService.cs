using System;
namespace BackEndAlbergue.Services
{
    public interface IFlightService
    {
        public IEnumerable<FlightModel> GetFlights();
        public FlightModel GetFlight(int FlightId);
        public FlightModel CreateFlight(FlightModel FlightModel);
        public bool DeleteFlight(int FlightId);
        public FlightModel UpdateFlight(int FlightId, FlightModel FlightModel);
    }
}