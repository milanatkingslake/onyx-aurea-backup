using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.StepComponentException" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepComponentExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StepComponentException" />)
        /// </summary>
        public StepComponentExceptionTest() : base(typeof(StepComponentException))
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

        #region General Initializer : Class (StepComponentException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stepComponentExceptionInstanceType;
        private StepComponentException _stepComponentExceptionInstance;
        private StepComponentException _stepComponentExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StepComponentException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepComponentExceptionInstanceType = typeof(StepComponentException);
            _stepComponentExceptionInstanceFixture = this.Create<StepComponentException>(false);
            _stepComponentExceptionInstance = _stepComponentExceptionInstanceFixture ?? this.Create<StepComponentException>(true);
            CurrentInstance = _stepComponentExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepComponentException) Initializer

        #region Properties

        private const string PropertymessageId = "messageId";
        private const string PropertymessageArguments = "messageArguments";
        private const string PropertyadditionalInfo = "additionalInfo";
        private const string PropertyerrorType = "errorType";
        private const string PropertysourceType = "sourceType";
        private const string PropertysourceName = "sourceName";

        #endregion

        #region Fields

        private const string Fieldm_messageId = "m_messageId";
        private const string Fieldm_messageArguments = "m_messageArguments";
        private const string Fieldm_additionalInfo = "m_additionalInfo";
        private const string Fieldm_errorType = "m_errorType";
        private const string Fieldm_sourceType = "m_sourceType";
        private const string Fieldm_sourceName = "m_sourceName";

        #endregion

        #endregion

        #region General Initializer : Class (StepComponentException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StepComponentException)

        #region General Initializer : Class (StepComponentException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertymessageId)]
        [TestCase(PropertymessageArguments)]
        [TestCase(PropertyadditionalInfo)]
        [TestCase(PropertyerrorType)]
        [TestCase(PropertysourceType)]
        [TestCase(PropertysourceName)]
        [Category("AUT Property")]
        public void AUT_StepComponentException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepComponentException) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldm_messageId)]
        [TestCase(Fieldm_messageArguments)]
        [TestCase(Fieldm_additionalInfo)]
        [TestCase(Fieldm_errorType)]
        [TestCase(Fieldm_sourceType)]
        [TestCase(Fieldm_sourceName)]
        [Category("AUT Fields")]
        public void AUT_StepComponentException_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (StepComponentException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentException_Is_Instance_Present_Test()
        {
            // Assert
            _stepComponentExceptionInstanceType.ShouldNotBeNull();
            _stepComponentExceptionInstance.ShouldNotBeNull();
            _stepComponentExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StepComponentException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stepComponentExceptionInstance.ShouldBeAssignableTo<StepComponentException>();
            _stepComponentExceptionInstanceFixture.ShouldBeAssignableTo<StepComponentException>();
            CurrentInstance.ShouldBeAssignableTo<StepComponentException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StepComponentException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            StepComponentException instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (StepComponentException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var psSource = this.CreateType<string>();
            var plMessageId = this.CreateType<long>();
            var psMessageArguments = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var psErrorType = this.CreateType<string>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();
            StepComponentException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepComponentException(psSource, plMessageId, psMessageArguments, psAdditionalInfo, psErrorType, psSourceType, psSourceName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepComponentExceptionInstance.ShouldNotBeNull();
            _stepComponentExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<StepComponentException>();
        }

        #endregion

        #region General Constructor : Class (StepComponentException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var psSource = this.CreateType<string>();
            var plMessageId = this.CreateType<long>();
            var psMessageArguments = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var psErrorType = this.CreateType<string>();
            var psSourceType = this.CreateType<string>();
            var psSourceName = this.CreateType<string>();
            StepComponentException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepComponentException(psSource, plMessageId, psMessageArguments, psAdditionalInfo, psErrorType, psSourceType, psSourceName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepComponentExceptionInstance.ShouldNotBeNull();
            _stepComponentExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (StepComponentException) instance created

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Is_Created_Test()
        {
            // Assert
            _stepComponentExceptionInstance.ShouldNotBeNull();
            _stepComponentExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (StepComponentException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="StepComponentException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void AUT_StepComponentException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (StepComponentException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="StepComponentException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (StepComponentException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepComponentException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodStepComponentExceptionParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepComponentExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (StepComponentException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepComponentException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodStepComponentExceptionParametersTypes = new Type[] { typeof(string), typeof(long), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepComponentExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (StepComponentException) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepComponentException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodStepComponentExceptionParametersTypes = new Type[] { typeof(string), typeof(long), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepComponentExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (StepComponentException) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepComponentException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodStepComponentExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepComponentExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (StepComponentException) constructors with dynamic parameters (Overloading_Of_4_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="StepComponentException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentException_Constructors_Overloading_Of_4_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodStepComponentExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodStepComponentExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepComponentException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertymessageId)]
        [TestCase(PropertymessageArguments)]
        [TestCase(PropertyadditionalInfo)]
        [TestCase(PropertyerrorType)]
        [TestCase(PropertysourceType)]
        [TestCase(PropertysourceName)]
        public void AUT_StepComponentException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (StepComponentException) => Property (additionalInfo) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentException_Public_Class_additionalInfo_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyadditionalInfo);
            var propertyInfo = this.GetPropertyInfo(PropertyadditionalInfo);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentException) => Property (errorType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentException_Public_Class_errorType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyerrorType);
            var propertyInfo = this.GetPropertyInfo(PropertyerrorType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentException) => Property (messageArguments) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentException_Public_Class_messageArguments_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymessageArguments);
            var propertyInfo = this.GetPropertyInfo(PropertymessageArguments);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentException) => Property (messageId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentException_Public_Class_messageId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertymessageId);
            var propertyInfo = this.GetPropertyInfo(PropertymessageId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentException) => Property (sourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentException_Public_Class_sourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysourceName);
            var propertyInfo = this.GetPropertyInfo(PropertysourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentException) => Property (sourceType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentException_Public_Class_sourceType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertysourceType);
            var propertyInfo = this.GetPropertyInfo(PropertysourceType);

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