using System;

namespace task2
{
    class Aircraft
    {
        public string Name;
        public bool IsTakingOff { get; set; }
        public Runway? CurrentRunway { get; private set; }
        private IAirTrafficMediator? _mediator;

        public Aircraft(string name)
        {
            Name = name;
        }

        public void SetMediator(IAirTrafficMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetRunway(Runway? runway)
        {
            CurrentRunway = runway;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {Name} requesting to land...");
            _mediator?.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {Name} requesting to take off...");
            IsTakingOff = true;
            _mediator?.RequestTakeOff(this);
            IsTakingOff = false;
        }
    }
}
