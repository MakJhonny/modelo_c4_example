namespace BackEndAlbergue.Services
{
    public class FlightService : IFlightService
    {
        private IRefuge _refugeRepository;
        private IMapper _mapper;

        public FlightService(IRefuge refugeRepository, IMapper _mapper)
        {
            this._refugeRepository = refugeRepository;
            this._mapper = _mapper;
        }
    }
}