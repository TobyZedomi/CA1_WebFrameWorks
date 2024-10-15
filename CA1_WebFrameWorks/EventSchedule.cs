using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CA1_WebFrameWorks
{
    public class EventSchedule
    {
        private List<Event> events;


        /// constructor
        /// 

        public EventSchedule(List<Event> events)
        {
            this.events = events;
        }

        public EventSchedule()
        {
            events = new List<Event>();

        }

        // Add event

        public void addEvent(Event e)
        {
          events.Add(e);
        }

        /*
        // addEevnt

        public void add(string fileName) 
        {
            StreamReader output = new StreamReader("invalidEvent");


            using(StreamReader input = new StreamReader(fileName))
            {

        string name, location;
        double numberOfRaces, distance;
        DateTime startTime;
        double winningPrice;


                string line = "";
                string[] tokens = new string[0];

            }

        }
        */

        public List<Event> getAllEvents()
        {

            List<Event> result = new List<Event>();
            for (int i = 0; i < events.Count; i++)
            {
                result.Add(events[i]);
            }
            return result;
        }

        // get Races from eveent type
        public List<Event> getRacesFromEvent(Type wType)
        {

            List<Event> result = new List<Event>();

            for (int i = 0; i < events.Count; i++)
            {

                if (events[i].GetType() == wType)
                {
                    result.Add(events[i]);
                }

            }

            return result;
        }

        // get races from event name

        public List<Event> getRacesFromEventName(String name)
        {

            List<Event> result = new List<Event>();

            for (int i = 0; i < events.Count; i++)
            {

                if (events[i].Name.Equals(name))
                {
                    result.Add(events[i]);
                }

            }

            return result;
        }

        // get Horse from event name in EnduranceRacing
        
        public List<Horse> getHorseFromEventNameInEnduranceRacing(String name)
        {

            List<Horse> result = new List<Horse>();

            foreach (Event e in events)
            {
                if (e is EnduranceRacing && e.Name.Equals(name))
                {
                    List<Horse> horseList = (e as EnduranceRacing).HorseList;
                    result.Add((Horse)horseList[0]);
                }

            }

            return result;
        }


        /// get Horse from event name in JumpRacing

        public List<Horse> getHorseFromEventNameInJumpRacing(String name)
        {

            List<Horse> result = new List<Horse>();

            foreach (Event e in events)
            {
                if (e is JumpRacing && e.Name.Equals(name))
                {
                    List<Horse> horseList = (e as JumpRacing).HorseList;
                    result.Add((Horse)horseList[0]);
                }

            }

            return result;
        }

        /// get Horse from event name in HarnessRacing

        public List<Horse> getHorseFromEventNameInHarnessRacing(String name)
        {

            List<Horse> result = new List<Horse>();

            foreach (Event e in events)
            {
                if (e is HarnessRacing && e.Name.Equals(name))
                {
                    List<Horse> horseList = (e as HarnessRacing).HorseList;
                    result.Add((Horse)horseList[0]);
                }

            }

            return result;
        }
    }
}
