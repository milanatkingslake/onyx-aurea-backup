using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.BusinessRuleManagerStopException" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class BusinessRuleManagerStopExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="BusinessRuleManagerStopException" />)
        /// </summary>
        public BusinessRuleManagerStopExceptionTest() : base(typeof(BusinessRuleManagerStopException))
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

        #region General Initializer : Class (BusinessRuleManagerStopException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _businessRuleManagerStopExceptionInstanceType;
        private BusinessRuleManagerStopException _businessRuleManagerStopExceptionInstance;
        private BusinessRuleManagerStopException _businessRuleManagerStopExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="BusinessRuleManagerStopException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _businessRuleManagerStopExceptionInstanceType = typeof(BusinessRuleManagerStopException);
            _businessRuleManagerStopExceptionInstanceFixture = this.Create<BusinessRuleManagerStopException>(false);
            _businessRuleManagerStopExceptionInstance = _businessRuleManagerStopExceptionInstanceFixture ?? this.Create<BusinessRuleManagerStopException>(true);
            CurrentInstance = _businessRuleManagerStopExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (BusinessRuleManagerStopException) Initializer

        #region Properties

        private const string PropertyreturnValue = "returnValue";

        #endregion

        #region Fields

        private const string Fieldm_returnValue = "m_returnValue";

        #endregion

        #endregion

        #region General Initializer : Class (BusinessRuleManagerStopException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerStopException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_BusinessRuleManagerStopException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (BusinessRuleManagerStopException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerStopException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_BusinessRuleManagerStopException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (BusinessRuleManagerStopException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerStopException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_BusinessRuleManagerStopException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (BusinessRuleManagerStopException)

        #region General Initializer : Class (BusinessRuleManagerStopException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerStopException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyreturnValue)]
        [Category("AUT Property")]
        public void AUT_BusinessRuleManagerStopException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (BusinessRuleManagerStopException) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerStopException" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_returnValue)]
        [Category("AUT Fields")]
        public void AUT_BusinessRuleManagerStopException_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (BusinessRuleManagerStopException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerStopException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRuleManagerStopException_Is_Instance_Present_Test()
        {
            // Assert
            _businessRuleManagerStopExceptionInstanceType.ShouldNotBeNull();
            _businessRuleManagerStopExceptionInstance.ShouldNotBeNull();
            _businessRuleManagerStopExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (BusinessRuleManagerStopException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerStopException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRuleManagerStopException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _businessRuleManagerStopExceptionInstance.ShouldBeAssignableTo<BusinessRuleManagerStopException>();
            _businessRuleManagerStopExceptionInstanceFixture.ShouldBeAssignableTo<BusinessRuleManagerStopException>();
            CurrentInstance.ShouldBeAssignableTo<BusinessRuleManagerStopException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (BusinessRuleManagerStopException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRuleManagerStopException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var psReturnValue = this.CreateType<string>();
            BusinessRuleManagerStopException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new BusinessRuleManagerStopException(psReturnValue);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _businessRuleManagerStopExceptionInstance.ShouldNotBeNull();
            _businessRuleManagerStopExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<BusinessRuleManagerStopException>();
        }

        #endregion

        #region General Constructor : Class (BusinessRuleManagerStopException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRuleManagerStopException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var psReturnValue = this.CreateType<string>();
            BusinessRuleManagerStopException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new BusinessRuleManagerStopException(psReturnValue);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _businessRuleManagerStopExceptionInstance.ShouldNotBeNull();
            _businessRuleManagerStopExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (BusinessRuleManagerStopException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyreturnValue)]
        public void AUT_BusinessRuleManagerStopException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (BusinessRuleManagerStopException) => Property (returnValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_BusinessRuleManagerStopException_Public_Class_returnValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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