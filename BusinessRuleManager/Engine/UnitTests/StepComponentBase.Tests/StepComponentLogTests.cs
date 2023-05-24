using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.QualityTools.Testing.Fakes;
using NUnit.Framework;
using ConsonaCRM.Onyx;

namespace StepComponentBase.Tests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class StepComponentLogTester : StepComponentLog
    {
        private static int totalEntryCount = 0;
        private const string Name = "Application";

        public StepComponentLogTester(string psEventLogSource) : base(psEventLogSource)
        {
        }

        public StepComponentLogTester() : this(Name)
        {
        }

        [Test]
        public void WriteEventLogEntry_ValidScenario_TotalEntryCountIsCorrect()
        {
            using (ShimsContext.Create())
            {
                // Arrange
                System.Diagnostics.Fakes.ShimEventLog.AllInstances.WriteEventEventInstanceObjectArray = (a, b, c) =>
                {
                    totalEntryCount++;
                };

                var stepComponentLogTester = new StepComponentLogTester(Name);
                stepComponentLogTester.eventLog = new EventLog();
                stepComponentLogTester.eventLog.Source = Name;
                stepComponentLogTester.eventLog.Log = Name;
                const int additionalInfoLength = 40000; // This should generate 3 log entries since entry limit is 16000
                var psAdditionalInfo = new string('0', additionalInfoLength);

                // Act
                stepComponentLogTester.WriteEventLogEntry(EventLogEntryType.Information,
                                                                  Name,
                                                                  "psMessage",
                                                                  psAdditionalInfo);

                // Assert
                NUnit.Framework.Assert.AreEqual(3, totalEntryCount);
            }
        }
    }
}