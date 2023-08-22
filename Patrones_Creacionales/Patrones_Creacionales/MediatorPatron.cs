using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    public interface IAirplaneMediator
    {
        void Notify(object sender, string eventDescription);
    }

    class AirplaneMediator : IAirplaneMediator
    {
        private Pilot _pilot1;
        private Pilot _pilot2;

        public AirplaneMediator(Pilot pilot1, Pilot pilot2)
        {
            this._pilot1 = pilot1;
            this._pilot1.SetMediator(this);
            this._pilot2 = pilot2;
            this._pilot2.SetMediator(this);
        }

        public void Notify(object sender, string eventDescription)
        {
            if (eventDescription == "Emergency")
            {
                Console.WriteLine("Mediator detects emergency and takes necessary actions:");
                this._pilot1.InitiateEmergencyProtocol();
                this._pilot2.InitiateEmergencyProtocol();
            }
            else if (eventDescription == "ChangeCourse")
            {
                Console.WriteLine("Mediator reacts to course change request:");
                this._pilot1.AdjustCourse();
                this._pilot2.AdjustCourse();
            }
        }
    }

    class Airplane
    {
        protected IAirplaneMediator _mediator;

        public Airplane(IAirplaneMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IAirplaneMediator mediator)
        {
            this._mediator = mediator;
        }
    }

    class Pilot : Airplane
    {
        public void InitiateEmergencyProtocol()
        {
            Console.WriteLine("Pilot initiates emergency protocol.");
            this._mediator.Notify(this, "Emergency");
        }

        public void AdjustCourse()
        {
            Console.WriteLine("Pilot adjusts course based on new information.");
            this._mediator.Notify(this, "ChangeCourse");
        }
    }
}
