using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxDictionaryDAC;
using Shouldly;

namespace Avolin.Onyx.Part05.AUT.Tests.OnyxDictionaryDAC
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxDictionaryDAC.PerfMeter" />)
    ///     and namespace <see cref="OnyxDictionaryDAC"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PerfMeterTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="PerfMeterNonPublicTypeName" />) using
        ///     Using a public type <see cref="Dictionary" /> to
        ///     create a non-public type.
        /// </summary>
        public PerfMeterTest() : base(publicType: typeof(Dictionary), classNameWithNamespace: PerfMeterNonPublicTypeName)
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        private Type _perfMeterInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string PerfMeterNonPublicTypeName = "OnyxDictionaryDAC.PerfMeter";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _perfMeterInstance;
        private object _perfMeterInstanceFixture;

        #region General Initializer : Class (PerfMeter) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="PerfMeter" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _perfMeterInstanceFixture = this.CreateNonPublicType(PerfMeterNonPublicTypeName);
            _perfMeterInstance = _perfMeterInstanceFixture;
            CurrentInstance = _perfMeterInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PerfMeter) Initializer

        #region Methods

        private const string MethodStartTimer = "StartTimer";
        private const string MethodTimerMilliseconds = "TimerMilliseconds";

        #endregion

        #region Fields

        private const string FieldMAX_TIMER = "MAX_TIMER";
        private const string FieldmaStartMarks = "maStartMarks";
        private const string FieldmaCounter = "maCounter";
        private const string FieldmcOverhead = "mcOverhead";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (PerfMeter)

        #region General Initializer : Class (PerfMeter) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PerfMeter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodStartTimer, 0)]
        [TestCase(MethodTimerMilliseconds, 0)]
        [Category("AUT Explore")]
        public void AUT_PerfMeter_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (PerfMeter) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PerfMeter" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PerfMeter_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (PerfMeter) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PerfMeter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldMAX_TIMER)]
        [TestCase(FieldmaStartMarks)]
        [TestCase(FieldmaCounter)]
        [TestCase(FieldmcOverhead)]
        [Category("AUT Fields")]
        public void AUT_PerfMeter_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (PerfMeter) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PerfMeter" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PerfMeter_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}