using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.TimeExpiration" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class TimeExpirationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TimeExpiration" />)
        /// </summary>
        public TimeExpirationTest() : base(typeof(TimeExpiration))
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

        #region General Initializer : Class (TimeExpiration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _timeExpirationInstanceType;
        private TimeExpiration _timeExpirationInstance;
        private TimeExpiration _timeExpirationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TimeExpiration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _timeExpirationInstanceType = typeof(TimeExpiration);
            _timeExpirationInstanceFixture = this.Create<TimeExpiration>(false);
            _timeExpirationInstance = _timeExpirationInstanceFixture ?? this.Create<TimeExpiration>(true);
            CurrentInstance = _timeExpirationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TimeExpiration) Initializer

        #region Properties

        private const string PropertyMinutes = "Minutes";

        #endregion

        #region Fields

        private const string FieldminutesField = "minutesField";

        #endregion

        #endregion

        #region General Initializer : Class (TimeExpiration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TimeExpiration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_TimeExpiration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TimeExpiration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TimeExpiration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_TimeExpiration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TimeExpiration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TimeExpiration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_TimeExpiration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TimeExpiration)

        #region General Initializer : Class (TimeExpiration) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TimeExpiration" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyMinutes)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_TimeExpiration_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (TimeExpiration) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TimeExpiration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldminutesField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_TimeExpiration_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (TimeExpiration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TimeExpiration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_TimeExpiration_Is_Instance_Present_Test()
        {
            // Assert
            _timeExpirationInstanceType.ShouldNotBeNull();
            _timeExpirationInstance.ShouldNotBeNull();
            _timeExpirationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TimeExpiration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TimeExpiration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_TimeExpiration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _timeExpirationInstance.ShouldBeAssignableTo<TimeExpiration>();
            _timeExpirationInstanceFixture.ShouldBeAssignableTo<TimeExpiration>();
            CurrentInstance.ShouldBeAssignableTo<TimeExpiration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TimeExpiration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_TimeExpiration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TimeExpiration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TimeExpiration) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyMinutes)]
        public void AUT_TimeExpiration_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (TimeExpiration) => Property (Minutes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_TimeExpiration_Public_Class_Minutes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMinutes);
            var propertyInfo = this.GetPropertyInfo(PropertyMinutes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}