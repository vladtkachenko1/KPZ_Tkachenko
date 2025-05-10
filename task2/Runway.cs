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

        public bool IsFree()
        {
            return _aircraft == null;
        }

        public void AssignAircraft(Aircraft aircraft)
        {
            if (_aircraft == null)
            {
                _aircraft = aircraft;
                HighlightRed();
            }
            else
            {
                Console.WriteLine($"Error: Runway {Id} is already occupied by aircraft {_aircraft.Name}!");
            }
        }

        public void ClearRunway()
        {
            _aircraft = null;
            HighlightGreen();
        }

        public void HighlightRed()
        {
            Console.WriteLine($"Runway {Id} is now busy!");
        }

        public void HighlightGreen()
        {
            Console.WriteLine($"Runway {Id} is now free!");
        }
    }
}
