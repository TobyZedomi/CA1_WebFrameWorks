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
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", DateTime.Now, "Dubai World Cup", "Dubai", 7, "8 miles", DateTime.Now, 100, expectedData));

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
            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", DateTime.Now, 40, expectedData));
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
            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", DateTime.Now, 70, expectedData));

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
        public void getAllEventRaces()
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


            startingData.Add(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), "Royal Ascot", "Ireland", 5, "25 miles", new DateTime(16 / 10 / 2024), 50, horseList1));
            startingData.Add(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), "Dubai World Cup", "Dubai", 7, "8 miles", new DateTime(16 / 10 / 2024), 100, horseList1));
            startingData.Add(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), "Grand National", "England", 3, "40 miles", new DateTime(16 / 10 / 2024), 300, horseList1));


            startingData.Add(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", new DateTime(16 / 10 / 2024), 70, horseList2));
            startingData.Add(new HarnessRacing("Jog Carts", "Walk", "Royal Ascot", "Ireland", 10, "1.5 miles", new DateTime(16 / 10 / 2024), 30, horseList2));
            startingData.Add(new HarnessRacing("Speed Carts", "Gallop", "Grand National", "England", 4, "1 mile", new DateTime(16 / 10 / 2024), 50, horseList2));

            startingData.Add(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", new DateTime(16 / 10 / 2024), 40, horseList3));
            startingData.Add(new JumpRacing("Drop Fence", "Fence", 3, "Royal Ascot", "Ireland", 3, "4 miles", new DateTime(16 / 10 / 2024), 55, horseList3));
            startingData.Add(new JumpRacing("Standard Water Jump", "Water", 1, "Grand National", "England", 6, "3.5 miles", new DateTime(16 / 10 / 2024), 120, horseList3));



            EventSchedule comp = new EventSchedule();

            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), "Royal Ascot", "Ireland", 5, "25 miles", new DateTime(16 / 10 / 2024), 50, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), "Dubai World Cup", "Dubai", 7, "8 miles", new DateTime(16 / 10 / 2024), 100, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), "Grand National", "England", 3, "40 miles", new DateTime(16 / 10 / 2024), 300, horseList1));

            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", new DateTime(16 / 10 / 2024), 70, horseList2));
            comp.addEvent(new HarnessRacing("Jog Carts", "Walk", "Royal Ascot", "Ireland", 10, "1.5 miles", new DateTime(16 / 10 / 2024), 30, horseList2));
            comp.addEvent(new HarnessRacing("Speed Carts", "Gallop", "Grand National", "England", 4, "1 mile", new DateTime(16 / 10 / 2024), 50, horseList2));

            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", new DateTime(16 / 10 / 2024), 40, horseList3));
            comp.addEvent(new JumpRacing("Drop Fence", "Fence", 3, "Royal Ascot", "Ireland", 3, "4 miles", new DateTime(16 / 10 / 2024), 55, horseList3));
            comp.addEvent(new JumpRacing("Standard Water Jump", "Water", 1, "Grand National", "England", 6, "3.5 miles", new DateTime(16 / 10 / 2024), 120, horseList3));

                
            List<Event> events = comp.getAllEvents();

            for (int i = 0; i < events.Count; i++)
            {
                Assert.AreEqual(events[i].Name, startingData[i].Name);
                Assert.AreEqual(events[i].Location, startingData[i].Location);
                Assert.AreEqual(events[i].NumberOfRaces, startingData[i].NumberOfRaces);
                Assert.AreEqual(events[i].Distance, startingData[i].Distance);
                Assert.AreEqual(events[i].StartDate, startingData[i].StartDate);
                Assert.AreEqual(events[i].WinningBetPrice, startingData[i].WinningBetPrice);
            }


        }

        [TestMethod]
        public void getRacesFromEventRaceTypeEnduranceRacing()
        {

            List<Horse> horseList1 = new List<Horse>();
            horseList1.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            horseList1.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            horseList1.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));


            List<Event> startingData = new List<Event>();


            startingData.Add(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), "Royal Ascot", "Ireland", 5, "25 miles", new DateTime(16 / 10 / 2024), 50, horseList1));
            startingData.Add(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), "Dubai World Cup", "Dubai", 7, "8 miles", new DateTime(16 / 10 / 2024), 100, horseList1));
            startingData.Add(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), "Grand National", "England", 3, "40 miles", new DateTime(16 / 10 / 2024), 300, horseList1));

            EventSchedule comp = new EventSchedule();


            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), "Royal Ascot", "Ireland", 5, "25 miles", new DateTime(16 / 10 / 2024), 50, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), "Dubai World Cup", "Dubai", 7, "8 miles", new DateTime(16 / 10 / 2024), 100, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), "Grand National", "England", 3, "40 miles", new DateTime(16 / 10 / 2024), 300, horseList1));

            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", new DateTime(16 / 10 / 2024), 70, horseList1));
            comp.addEvent(new HarnessRacing("Jog Carts", "Walk", "Royal Ascot", "Ireland", 10, "1.5 miles", new DateTime(16 / 10 / 2024), 30, horseList1));
            comp.addEvent(new HarnessRacing("Speed Carts", "Gallop", "Grand National", "England", 4, "1 mile", new DateTime(16 / 10 / 2024), 50, horseList1));

            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", new DateTime(16 / 10 / 2024), 40, horseList1));
            comp.addEvent(new JumpRacing("Drop Fence", "Fence", 3, "Royal Ascot", "Ireland", 3, "4 miles", new DateTime(16 / 10 / 2024), 55, horseList1));
            comp.addEvent(new JumpRacing("Standard Water Jump", "Water", 1, "Grand National", "England", 6, "3.5 miles", new DateTime(16 / 10 / 2024), 120, horseList1));


            List<Event> events = comp.getRacesFromEvent(typeof(EnduranceRacing));

            /// test size

            Assert.AreEqual(events.Count, startingData.Count);

            // test if values are the same

            for (int i = 0; i < events.Count;i++)
                {
                List<Horse> horseList = (events[i] as EnduranceRacing).HorseList;
                List<Horse> horseList2 = (startingData[i] as EnduranceRacing).HorseList;

                for (int j = 0; i < startingData.Count;i++)
                    {
                    Assert.AreEqual(horseList[i].Name, horseList2[i].Name);
                    Assert.AreEqual(horseList[i].DateOfBirth, horseList2[i].DateOfBirth);
                }
                }


                for (int i = 0;i < events.Count;i++)
                {
                 Assert.AreEqual(events[i].Name, startingData[i].Name);
                Assert.AreEqual(events[i].Location, startingData[i].Location);
                Assert.AreEqual(events[i].NumberOfRaces, startingData[i].NumberOfRaces);
                Assert.AreEqual(events[i].Distance, startingData[i].Distance);
                Assert.AreEqual(events[i].StartDate, startingData[i].StartDate);
                Assert.AreEqual(events[i].WinningBetPrice, startingData[i].WinningBetPrice);
            }

      

        }

        [TestMethod]
        public void getRacesFromEventRaceTypeHarnessRacing()
        {

            List<Horse> horseList1 = new List<Horse>();
            horseList1.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            horseList1.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            horseList1.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));


            List<Event> startingData = new List<Event>();


            startingData.Add(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", new DateTime(16 / 10 / 2024), 70, horseList1));
            startingData.Add(new HarnessRacing("Jog Carts", "Walk", "Royal Ascot", "Ireland", 10, "1.5 miles", new DateTime(16 / 10 / 2024), 30, horseList1));
            startingData.Add(new HarnessRacing("Speed Carts", "Gallop", "Grand National", "England", 4, "1 mile", new DateTime(16 / 10 / 2024), 50, horseList1));

            EventSchedule comp = new EventSchedule();

            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), "Royal Ascot", "Ireland", 5, "25 miles", new DateTime(16 / 10 / 2024), 50, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), "Dubai World Cup", "Dubai", 7, "8 miles", new DateTime(16 / 10 / 2024), 100, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), "Grand National", "England", 3, "40 miles", new DateTime(16 / 10 / 2024), 300, horseList1));

            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", new DateTime(16 / 10 / 2024), 70, horseList1));
            comp.addEvent(new HarnessRacing("Jog Carts", "Walk", "Royal Ascot", "Ireland", 10, "1.5 miles", new DateTime(16 / 10 / 2024), 30, horseList1));
            comp.addEvent(new HarnessRacing("Speed Carts", "Gallop", "Grand National", "England", 4, "1 mile", new DateTime(16 / 10 / 2024), 50, horseList1));

            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", new DateTime(16 / 10 / 2024), 40, horseList1));
            comp.addEvent(new JumpRacing("Drop Fence", "Fence", 3, "Royal Ascot", "Ireland", 3, "4 miles", new DateTime(16 / 10 / 2024), 55, horseList1));
            comp.addEvent(new JumpRacing("Standard Water Jump", "Water", 1, "Grand National", "England", 6, "3.5 miles", new DateTime(16 / 10 / 2024), 120, horseList1));


            List<Event> events = comp.getRacesFromEvent(typeof(HarnessRacing));

            /// test size

            Assert.AreEqual(events.Count, startingData.Count);

            // test if values are the same

            for (int i = 0; i < events.Count; i++)
            {
                List<Horse> horseList = (events[i] as HarnessRacing).HorseList;
                List<Horse> horseList2 = (startingData[i] as HarnessRacing).HorseList;

                for (int j = 0; i < events.Count; i++)
                {
                    Assert.AreEqual(horseList[i].Name, horseList2[i].Name);
                    Assert.AreEqual(horseList[i].DateOfBirth, horseList2[i].DateOfBirth);
                }
            }


            for (int i = 0; i < events.Count; i++)
            {
                Assert.AreEqual(events[i].Name, startingData[i].Name);
                Assert.AreEqual(events[i].Location, startingData[i].Location);
                Assert.AreEqual(events[i].NumberOfRaces, startingData[i].NumberOfRaces);
                Assert.AreEqual(events[i].Distance, startingData[i].Distance);
                Assert.AreEqual(events[i].StartDate, startingData[i].StartDate);
                Assert.AreEqual(events[i].WinningBetPrice, startingData[i].WinningBetPrice);
            }



        }


        [TestMethod]
        public void getRacesFromEventRaceTypeJumpRacing()
        {

            List<Horse> horseList1 = new List<Horse>();
            horseList1.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            horseList1.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            horseList1.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));


            List<Event> startingData = new List<Event>();


            startingData.Add(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", new DateTime(16 / 10 / 2024), 40, horseList1));
            startingData.Add(new JumpRacing("Drop Fence", "Fence", 3, "Royal Ascot", "Ireland", 3, "4 miles", new DateTime(16 / 10 / 2024), 55, horseList1));
            startingData.Add(new JumpRacing("Standard Water Jump", "Water", 1, "Grand National", "England", 6, "3.5 miles", new DateTime(16 / 10 / 2024), 120, horseList1));

            EventSchedule comp = new EventSchedule();

            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), "Royal Ascot", "Ireland", 5, "25 miles", new DateTime(16 / 10 / 2024), 50, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), "Dubai World Cup", "Dubai", 7, "8 miles", new DateTime(16 / 10 / 2024), 100, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), "Grand National", "England", 3, "40 miles", new DateTime(16 / 10 / 2024), 300, horseList1));

            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", new DateTime(16 / 10 / 2024), 70, horseList1));
            comp.addEvent(new HarnessRacing("Jog Carts", "Walk", "Royal Ascot", "Ireland", 10, "1.5 miles", new DateTime(16 / 10 / 2024), 30, horseList1));
            comp.addEvent(new HarnessRacing("Speed Carts", "Gallop", "Grand National", "England", 4, "1 mile", new DateTime(16 / 10 / 2024), 50, horseList1));

            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", new DateTime(16 / 10 / 2024), 40, horseList1));
            comp.addEvent(new JumpRacing("Drop Fence", "Fence", 3, "Royal Ascot", "Ireland", 3, "4 miles", new DateTime(16 / 10 / 2024), 55, horseList1));
            comp.addEvent(new JumpRacing("Standard Water Jump", "Water", 1, "Grand National", "England", 6, "3.5 miles", new DateTime(16 / 10 / 2024), 120, horseList1));



            List<Event> events = comp.getRacesFromEvent(typeof(JumpRacing));

            /// test size

            Assert.AreEqual(events.Count, startingData.Count);

            // test if values are the same 

            for (int i = 0; i < events.Count; i++)
            {
                List<Horse> horseList = (events[i] as JumpRacing).HorseList;
                List<Horse> horseList2 = (startingData[i] as JumpRacing).HorseList;

                for (int j = 0; i < events.Count; i++)
                {
                    Assert.AreEqual(horseList[i].Name, horseList2[i].Name);
                    Assert.AreEqual(horseList[i].DateOfBirth, horseList2[i].DateOfBirth);
                }
            }


            for (int i = 0; i < events.Count; i++)
            {
                Assert.AreEqual(events[i].Name, startingData[i].Name);
                Assert.AreEqual(events[i].Location, startingData[i].Location);
                Assert.AreEqual(events[i].NumberOfRaces, startingData[i].NumberOfRaces);
                Assert.AreEqual(events[i].Distance, startingData[i].Distance);
                Assert.AreEqual(events[i].StartDate, startingData[i].StartDate);
                Assert.AreEqual(events[i].WinningBetPrice, startingData[i].WinningBetPrice);
            }



        }


        [TestMethod]
        public void getRaceFromEventName()
        {

            List<Horse> horseList1 = new List<Horse>();
            horseList1.Add(new Horse("Toby", new DateTime(16 / 10 / 2024)));
            horseList1.Add(new Horse("John", new DateTime(10 / 12 / 2024)));
            horseList1.Add(new Horse("Rob", new DateTime(08 / 09 / 2022)));

           
            List<Event> startingData = new List<Event>();


            startingData.Add(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), "Dubai World Cup", "Dubai", 7, "8 miles", new DateTime(16 / 10 / 2024), 100, horseList1));
            startingData.Add(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", new DateTime(16 / 10 / 2024), 70, horseList1));
            startingData.Add(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", new DateTime(16 / 10 / 2024), 40, horseList1));
   



            EventSchedule comp = new EventSchedule();

            comp.addEvent(new EnduranceRacing(raceGroup.ProgressiveTrailRides, true, "fence", new DateTime(16 / 10 / 2024), "Royal Ascot", "Ireland", 5, "25 miles", new DateTime(16 / 10 / 2024), 50, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.PleasureRides, true, "Hurdles", new DateTime(16 / 10 / 2024), "Dubai World Cup", "Dubai", 7, "8 miles", new DateTime(16 / 10 / 2024), 100, horseList1));
            comp.addEvent(new EnduranceRacing(raceGroup.CompetetiveTrailRides, true, "Water Jump", new DateTime(16 / 10 / 2024), "Grand National", "England", 3, "40 miles", new DateTime(16 / 10 / 2024), 300, horseList1));

            comp.addEvent(new HarnessRacing("Race Bikes", "Trot", "Dubai World Cup", "Dubai", 5, "1.5 miles", new DateTime(16 / 10 / 2024), 70, horseList1));
            comp.addEvent(new HarnessRacing("Jog Carts", "Walk", "Royal Ascot", "Ireland", 10, "1.5 miles", new DateTime(16 / 10 / 2024), 30, horseList1));
            comp.addEvent(new HarnessRacing("Speed Carts", "Gallop", "Grand National", "England", 4, "1 mile", new DateTime(16 / 10 / 2024), 50, horseList1));

            comp.addEvent(new JumpRacing("High Hurdle", "Hurdle", 0.5, "Dubai World Cup", "Dubai", 15, "2.5 miles", new DateTime(16 / 10 / 2024), 40, horseList1));
            comp.addEvent(new JumpRacing("Drop Fence", "Fence", 3, "Royal Ascot", "Ireland", 3, "4 miles", new DateTime(16 / 10 / 2024), 55, horseList1));
            comp.addEvent(new JumpRacing("Standard Water Jump", "Water", 1, "Grand National", "England", 6, "3.5 miles", new DateTime(16 / 10 / 2024), 120, horseList1));

            List<Event> events = comp.getRacesFromEventName("Dubai World Cup");


            /// test size

            Assert.AreEqual(events.Count, startingData.Count);



            for (int i = 0; i < events.Count; i++)
            {
                Assert.AreEqual(events[i].Name, startingData[i].Name);
            
            }
        }

    }
}