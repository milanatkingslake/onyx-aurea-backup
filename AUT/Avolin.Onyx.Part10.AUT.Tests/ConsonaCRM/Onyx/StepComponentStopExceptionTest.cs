using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.StepComponentStopException" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepComponentStopExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StepComponentStopException" />)
        /// </summary>
        public StepComponentStopExceptionTest() : base(typeof(StepComponentStopException))
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

        #region General Initializer : Class (StepComponentStopException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stepComponentStopExceptionInstanceType;
        private StepComponentStopException _stepComponentStopExceptionInstance;
        private StepComponentStopException _stepComponentStopExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StepComponentStopException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepComponentStopExceptionInstanceType = typeof(StepComponentStopException);
            _stepComponentStopExceptionInstanceFixture = this.Create<StepComponentStopException>(false);
            _stepComponentStopExceptionInstance = _stepComponentStopExceptionInstanceFixture ?? this.Create<StepComponentStopException>(true);
            CurrentInstance = _stepComponentStopExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepComponentStopException) Initializer

        #region Properties

        private const string PropertyreturnValue = "returnValue";

        #endregion

        #region Fields

        private const string Fieldm_returnValue = "m_returnValue";

        #endregion

        #endregion

        #region General Initializer : Class (StepComponentStopException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepComponentStopException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentStopException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentStopException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepComponentStopException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentStopException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentStopException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepComponentStopException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentStopException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StepComponentStopException)

        #region General Initializer : Class (StepComponentStopException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentStopException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyreturnValue)]
        [Category("AUT Property")]
        public void AUT_StepComponentStopException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepComponentStopException) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentStopException" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_returnValue)]
        [Category("AUT Fields")]
        public void AUT_StepComponentStopException_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (StepComponentStopException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StepComponentStopException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentStopException_Is_Instance_Present_Test()
        {
            // Assert
            _stepComponentStopExceptionInstanceType.ShouldNotBeNull();
            _stepComponentStopExceptionInstance.ShouldNotBeNull();
            _stepComponentStopExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StepComponentStopException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StepComponentStopException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentStopException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stepComponentStopExceptionInstance.ShouldBeAssignableTo<StepComponentStopException>();
            _stepComponentStopExceptionInstanceFixture.ShouldBeAssignableTo<StepComponentStopException>();
            CurrentInstance.ShouldBeAssignableTo<StepComponentStopException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StepComponentStopException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentStopException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var psReturnValue = this.CreateType<string>();
            StepComponentStopException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepComponentStopException(psReturnValue);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepComponentStopExceptionInstance.ShouldNotBeNull();
            _stepComponentStopExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<StepComponentStopException>();
        }

        #endregion

        #region General Constructor : Class (StepComponentStopException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentStopException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var psReturnValue = this.CreateType<string>();
            StepComponentStopException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepComponentStopException(psReturnValue);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepComponentStopExceptionInstance.ShouldNotBeNull();
            _stepComponentStopExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepComponentStopException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyreturnValue)]
        public void AUT_StepComponentStopException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (StepComponentStopException) => Property (returnValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentStopException_Public_Class_returnValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyreturnValue);
            var propertyInfo = this.GetPropertyInfo(PropertyreturnValue);

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