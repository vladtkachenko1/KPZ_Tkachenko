using System;
using System.Collections.Generic;

namespace task2
{
    class CommandCentre : IAirTrafficMediator
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private CommandCentre? _mediator;

        public void SetMediator(CommandCentre mediator)
        {
            _mediator = mediator;
        }

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {

            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);

            foreach (var aircraft in _aircrafts)
            {
                aircraft.SetMediator(this);
            }

            foreach (var runway in _runways)
            {
                runway.SetMediator(this);
            }
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsFree())
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {runway.Id}.");
                    runway.AssignAircraft(aircraft);
                    aircraft.SetRunway(runway);
                    return;
                }
            }

            Console.WriteLine($"No available runway for aircraft {aircraft.Name} to land.");
        }


        public void RequestTakeOff(Aircraft aircraft)
        {
            if (aircraft.CurrentRunway != null)
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {aircraft.CurrentRunway.Id}.");
                aircraft.CurrentRunway.ClearRunway();
                aircraft.SetRunway(null);
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not assigned to any runway.");
            }
        }
    }
}
