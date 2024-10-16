using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA1_WebFrameWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CA1_WebFrameWorks.EnduranceRacing;

namespace CA1_WebFrameWorks.Tests
{
    [TestClass()]
    public class EventScheduleTests
    {
        
        // get HorseList for Endurance Racing 
        [TestMethod()]
        public void testGetHorseListFromEduranceRacing()
        {
            List<Horse> startingData = new List<Horse>();
            startingData.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            startingData.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            startingData.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));

            List<Horse> expectedData = new List<Horse>();
            expectedData.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            expectedData.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            expectedData.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));



            EventSchedule comp = new EventSchedule();
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", DateTime.Now, expectedData, "Dubai World Cup", "Dubai", 7, 8, DateTime.Now, 100));

            // execute the method to get the horseList in Endurance Racing

            List<Horse> horseList = comp.getHorseFromEventNameInEnduranceRacing("Dubai World Cup");

            /// test size

            Assert.AreEqual(startingData.Count, horseList.Count);


            // test if values in horseList are the same 

            for(int i = 0; i < horseList.Count; i++)
            {
                Assert.AreEqual(horseList[i].Name, startingData[i].Name);
                Assert.AreEqual(horseList[i].DateOfBirth, startingData[i].DateOfBirth);
            }

        }



        // get horse list for Jump Racing 
        [TestMethod()]
        public void testGetHorseListFromJumpRacing()
        {
            List<Horse> startingData = new List<Horse>();
            startingData.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            startingData.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            startingData.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));

            List<Horse> expectedData = new List<Horse>();
            expectedData.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            expectedData.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            expectedData.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));



            EventSchedule comp = new EventSchedule();
            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, expectedData, "Dubai World Cup", "Dubai", 15, 2.5, DateTime.Now, 40));
            // execute the method to get the horseList in Endurance Racing

            List<Horse> horseList = comp.getHorseFromEventNameInJumpRacing("Dubai World Cup");

            /// test size

            Assert.AreEqual(startingData.Count, horseList.Count);


            // test if values in horseList are the same 

            for (int i = 0; i < horseList.Count; i++)
            {
                Assert.AreEqual(horseList[i].Name, startingData[i].Name);
                Assert.AreEqual(horseList[i].DateOfBirth, startingData[i].DateOfBirth);
            }

        }

        // get horselist for Harness Racing 
        [TestMethod()]
        public void testGetHorseListFromHarnessRacing()
        {
            List<Horse> startingData = new List<Horse>();
            startingData.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            startingData.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            startingData.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));

            List<Horse> expectedData = new List<Horse>();
            expectedData.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            expectedData.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            expectedData.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));



            EventSchedule comp = new EventSchedule();
            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", expectedData, "Dubai World Cup", "Dubai", 5, 1.5, DateTime.Now, 70));

            // execute the method to get the horseList in Endurance Racing

            List<Horse> horseList = comp.getHorseFromEventNameInHarnessRacing("Dubai World Cup");

            /// test size

            Assert.AreEqual(startingData.Count, horseList.Count);


            // test if values in horseList are the same 

            for (int i = 0; i < horseList.Count; i++)
            {
                Assert.AreEqual(horseList[i].Name, startingData[i].Name);
                Assert.AreEqual(horseList[i].DateOfBirth, startingData[i].DateOfBirth);
            }

        }


        [TestMethod]
        public void getRacesFromEventName()
        {
            List<Horse> horseList1 = new List<Horse>();
            horseList1.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            horseList1.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            horseList1.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));

            List<Horse> horseList2 = new List<Horse>();
            horseList2.Add(new Horse("Sandy", new DateTime(16 / 10 / 2024)));
            horseList2.Add(new Horse("Allen", new DateTime(10 / 12 / 2024)));
            horseList2.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));

            List<Horse> horseList3 = new List<Horse>();
            horseList3.Add(new Horse("Mandy", new DateTime(16 / 10 / 2024)));
            horseList3.Add(new Horse("Andrew", new DateTime(10 / 12 / 2024)));
            horseList3.Add(new Horse("Glow", new DateTime(08 / 09 / 2022)));


           

            List<Event> startingData = new List<Event>();


            startingData.Add(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), horseList1, "Royal Ascot", "Ireland", 5, 25, new DateTime(16 / 10 / 2024), 50));
            startingData.Add(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), horseList1, "Dubai World Cup", "Dubai", 7, 8, new DateTime(16 / 10 / 2024), 100));
            startingData.Add(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), horseList1, "Grand National", "England", 3, 40, new DateTime(16 / 10 / 2024), 300));


            startingData.Add(new HarnessRacing("Race Bikes", "Trot", horseList2, "Dubai World Cup", "Dubai", 5, 1.5, new DateTime(16 / 10 / 2024), 70));
            startingData.Add(new HarnessRacing("Jog Carts", "Walk", horseList2, "Royal Ascot", "Ireland", 10, 1.5, new DateTime(16 / 10 / 2024), 30));
            startingData.Add(new HarnessRacing("Speed Carts", "Gallop", horseList2, "Grand National", "England", 4, 1, new DateTime(16 / 10 / 2024), 50));

            startingData.Add(new JumpRacing("High Hurdle", "Hurdle", 0.5, horseList3, "Dubai World Cup", "Dubai", 15, 2.5, new DateTime(16 / 10 / 2024), 40));
            startingData.Add(new JumpRacing("Drop Fence", "Fence", 3, horseList3, "Royal Ascot", "Ireland", 3, 4, new DateTime(16 / 10 / 2024), 55));
            startingData.Add(new JumpRacing("Standard Water Jump", "Water", 1, horseList3, "Grand National", "England", 6, 3.5, new DateTime(16 / 10 / 2024), 120));



            EventSchedule comp = new EventSchedule();

           // comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), horseList1, "Royal Ascot", "Ireland", 5, 25, new DateTime(16 / 10 / 2024), 50));
           /// comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), horseList1, "Dubai World Cup", "Dubai", 7, 8, new DateTime(16 / 10 / 2024), 100));
           // comp.addEvent(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), horseList1, "Grand National", "England", 3, 40, new DateTime(16 / 10 / 2024), 300));

            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", horseList2, "Dubai World Cup", "Dubai", 5, 1.5, new DateTime(16 / 10 / 2024), 70));
            comp.addEvent(new HarnessRacing("Jog Carts", "Walk", horseList2, "Royal Ascot", "Ireland", 10, 1.5, new DateTime(16 / 10 / 2024), 30));
            comp.addEvent(new HarnessRacing("Speed Carts", "Gallop", horseList2, "Grand National", "England", 4, 1, new DateTime(16 / 10 / 2024), 50));

            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, horseList3, "Dubai World Cup", "Dubai", 15, 2.5, new DateTime(16 / 10 / 2024), 40));
            comp.addEvent(new JumpRacing("Drop Fence", "Fence", 3, horseList3, "Royal Ascot", "Ireland", 3, 4, new DateTime(16 / 10 / 2024), 55));
            comp.addEvent(new JumpRacing("Standard Water Jump", "Water", 1, horseList3, "Grand National", "England", 6, 3.5, new DateTime(16 / 10 / 2024), 120));

                
            List<Event> events = comp.getAllEvents();

            for(int i = 0;i < events.Count; i++)
            {
                
                Assert.AreEqual(events[i], startingData[i]);
               
            }


        }


    }
}