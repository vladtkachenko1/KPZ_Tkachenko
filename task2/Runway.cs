using System;

namespace task2
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        private Aircraft? _aircraft;
        private IAirTrafficMediator? _mediator;

        public void SetMediator(IAirTrafficMediator mediator)
        {
            _mediator = mediator;
        }

        public bool CheckIsActive()
        {
            return _aircraft?.IsTakingOff ?? false;
        }

        public void AssignAircraft(Aircraft aircraft)
        {
            _aircraft = aircraft;
            HighLightRed();
        }

        public void ClearRunway()
        {
            _aircraft = null;
            HighLightGreen();
        }

        private void HighLightRed()
        {
            Console.WriteLine($"Runway {Id} is now busy!");
        }

        private void HighLightGreen()
        {
            Console.WriteLine($"Runway {Id} is now free!");
        }
    }
}
