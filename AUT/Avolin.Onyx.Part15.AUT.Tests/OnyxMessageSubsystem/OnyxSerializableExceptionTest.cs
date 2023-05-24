using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxMessageSubsystem;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxMessageSubsystem
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxMessageSubsystem.OnyxSerializableException" />)
    ///     and namespace <see cref="OnyxMessageSubsystem"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSerializableExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxSerializableException" />)
        /// </summary>
        public OnyxSerializableExceptionTest() : base(typeof(OnyxSerializableException))
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

        #region General Initializer : Class (OnyxSerializableException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxSerializableExceptionInstanceType;
        private OnyxSerializableException _onyxSerializableExceptionInstance;
        private OnyxSerializableException _onyxSerializableExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxSerializableException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxSerializableExceptionInstanceType = typeof(OnyxSerializableException);
            _onyxSerializableExceptionInstanceFixture = this.Create<OnyxSerializableException>(false);
            _onyxSerializableExceptionInstance = _onyxSerializableExceptionInstanceFixture ?? this.Create<OnyxSerializableException>(true);
            CurrentInstance = _onyxSerializableExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxSerializableException) Initializer

        #region Properties

        private const string PropertyMessage = "Message";
        private const string PropertySource = "Source";
        private const string PropertyStackTrace = "StackTrace";
        private const string PropertyInnerException = "InnerException";

        #endregion

        #region Fields

        private const string FieldParameters = "Parameters";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxSerializableException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSerializableException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSerializableException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSerializableException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxSerializableException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSerializableException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxSerializableException)

        #region General Initializer : Class (OnyxSerializableException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyMessage)]
        [TestCase(PropertySource)]
        [TestCase(PropertyStackTrace)]
        [TestCase(PropertyInnerException)]
        [Category("AUT Property")]
        public void AUT_OnyxSerializableException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxSerializableException) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldParameters)]
        [Category("AUT Fields")]
        public void AUT_OnyxSerializableException_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxSerializableException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSerializableException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxSerializableExceptionInstanceType.ShouldNotBeNull();
            _onyxSerializableExceptionInstance.ShouldNotBeNull();
            _onyxSerializableExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxSerializableException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSerializableException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxSerializableExceptionInstance.ShouldBeAssignableTo<OnyxSerializableException>();
            _onyxSerializableExceptionInstanceFixture.ShouldBeAssignableTo<OnyxSerializableException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxSerializableException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxSerializableException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSerializableException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxSerializableException instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxSerializableException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSerializableException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var e = this.CreateType<Exception>();
            OnyxSerializableException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxSerializableException(e);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxSerializableExceptionInstance.ShouldNotBeNull();
            _onyxSerializableExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxSerializableException>();
        }

        #endregion

        #region General Constructor : Class (OnyxSerializableException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSerializableException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var e = this.CreateType<Exception>();
            OnyxSerializableException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxSerializableException(e);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxSerializableExceptionInstance.ShouldNotBeNull();
            _onyxSerializableExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxSerializableException) instance created

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSerializableException_Is_Created_Test()
        {
            // Assert
            _onyxSerializableExceptionInstance.ShouldNotBeNull();
            _onyxSerializableExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxSerializableException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxSerializableException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxSerializableException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxSerializableException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxSerializableException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSerializableException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxSerializableException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxSerializableException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSerializableException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodOnyxSerializableExceptionParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxSerializableExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxSerializableException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxSerializableException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSerializableException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxSerializableExceptionParametersTypes = new Type[] { typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxSerializableExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxSerializableException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyMessage)]
        [TestCase(PropertySource)]
        [TestCase(PropertyStackTrace)]
        [TestCase(PropertyInnerException)]
        public void AUT_OnyxSerializableException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxSerializableException) => Property (InnerException) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSerializableException_InnerException_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInnerException);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInnerException);
            Action currentAction = () => propertyInfo.SetValue(_onyxSerializableExceptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSerializableException) => Property (InnerException) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSerializableException_Public_Class_InnerException_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInnerException);
            var propertyInfo = this.GetPropertyInfo(PropertyInnerException);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSerializableException) => Property (Message) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSerializableException_Public_Class_Message_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSerializableException) => Property (Source) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSerializableException_Public_Class_Source_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySource);
            var propertyInfo = this.GetPropertyInfo(PropertySource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxSerializableException) => Property (StackTrace) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxSerializableException_Public_Class_StackTrace_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStackTrace);
            var propertyInfo = this.GetPropertyInfo(PropertyStackTrace);

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