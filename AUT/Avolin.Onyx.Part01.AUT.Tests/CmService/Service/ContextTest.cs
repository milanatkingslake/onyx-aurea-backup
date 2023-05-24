using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Context" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ModelClasses.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ContextTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Context" />)
        /// </summary>
        public ContextTest() : base(typeof(Context))
        { }

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

        #region General Initializer : Class (Context) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _contextInstanceType;
        private Context _contextInstance;
        private Context _contextInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Context" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _contextInstanceType = typeof(Context);
            _contextInstanceFixture = this.Create<Context>(false);
            _contextInstance = _contextInstanceFixture ?? this.Create<Context>(true);
            CurrentInstance = _contextInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Context) Initializer

        #region Properties

        private const string PropertySessionSecondsRemaining = "SessionSecondsRemaining";

        #endregion

        #endregion

        #region General Initializer : Class (Context) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Context" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Context_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Context) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Context" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Context_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Context) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Context" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Context_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Context)

        #region General Initializer : Class (Context) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Context" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySessionSecondsRemaining)]
        [Category("AUT Property")]
        public void AUT_Context_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #region General Instance : Class (Context) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Context" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Context_Is_Instance_Present_Test()
        {
            // Assert
            _contextInstanceType.ShouldNotBeNull();
            _contextInstance.ShouldNotBeNull();
            _contextInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Context) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Context" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Context_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _contextInstance.ShouldBeAssignableTo<Context>();
            _contextInstanceFixture.ShouldBeAssignableTo<Context>();
            CurrentInstance.ShouldBeAssignableTo<Context>();
        }

        #endregion

        #region General Constructor : Class (Context) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Context_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Context instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (Context) => All Properties and Fields Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Context_Class_All_Properties_Getter_Settter_Test()
        {
            // Arrange
            var sessionSecondsRemaining = this.CreateType<string>();

            // Act
            _contextInstanceFixture.SessionSecondsRemaining = sessionSecondsRemaining;

            // Assert
            _contextInstanceFixture.SessionSecondsRemaining.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (Context) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySessionSecondsRemaining)]
        public void AUT_Context_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Context) => Property (SessionSecondsRemaining) (Type : string) Property Type test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Context_SessionSecondsRemaining_Property_String_Type_Verify_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionSecondsRemaining);
            _contextInstanceFixture.SessionSecondsRemaining = this.CreateType<string>();
            var stringType = _contextInstanceFixture.SessionSecondsRemaining.GetType();

            // Act
            var isTypeString = typeof(string) == (stringType);

            // Assert
            isTypeString.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Context) => Property (SessionSecondsRemaining) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Context_Public_Class_SessionSecondsRemaining_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionSecondsRemaining);
            var propertyInfo = this.GetPropertyInfo(PropertySessionSecondsRemaining);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion
    }
}