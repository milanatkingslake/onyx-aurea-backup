using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.OnyxException;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OnyxException
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxTransactionException" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxTransactionExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxTransactionException" />)
        /// </summary>
        public OnyxTransactionExceptionTest() : base(typeof(OnyxTransactionException))
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

        #region General Initializer : Class (OnyxTransactionException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxTransactionExceptionInstanceType;
        private OnyxTransactionException _onyxTransactionExceptionInstance;
        private OnyxTransactionException _onyxTransactionExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxTransactionException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxTransactionExceptionInstanceType = typeof(OnyxTransactionException);
            _onyxTransactionExceptionInstanceFixture = this.Create<OnyxTransactionException>(false);
            _onyxTransactionExceptionInstance = _onyxTransactionExceptionInstanceFixture ?? this.Create<OnyxTransactionException>(true);
            CurrentInstance = _onyxTransactionExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxTransactionException) Initializer

        #region Properties

        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertyObjectName = "ObjectName";
        private const string PropertyMethodName = "MethodName";
        private const string PropertyStepPackage = "StepPackage";
        private const string PropertyParamXml = "ParamXml";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxTransactionException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxTransactionException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxTransactionException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxTransactionException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxTransactionException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxTransactionException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxTransactionException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxTransactionException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxTransactionException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxTransactionException)

        #region General Initializer : Class (OnyxTransactionException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxTransactionException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyObjectName)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyStepPackage)]
        [TestCase(PropertyParamXml)]
        [Category("AUT Property")]
        public void AUT_OnyxTransactionException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #region Category : Instance

        #region General Instance : Class (OnyxTransactionException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxTransactionException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxTransactionException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxTransactionExceptionInstanceType.ShouldNotBeNull();
            _onyxTransactionExceptionInstance.ShouldNotBeNull();
            _onyxTransactionExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxTransactionException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxTransactionException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxTransactionException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxTransactionExceptionInstance.ShouldBeAssignableTo<OnyxTransactionException>();
            _onyxTransactionExceptionInstanceFixture.ShouldBeAssignableTo<OnyxTransactionException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxTransactionException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxTransactionException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxTransactionException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var applicationName = this.CreateType<string>();
            var objectName = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var stepPackage = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            OnyxTransactionException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxTransactionException(applicationName, objectName, methodName, stepPackage, paramXml);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxTransactionExceptionInstance.ShouldNotBeNull();
            _onyxTransactionExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxTransactionException>();
        }

        #endregion

        #region General Constructor : Class (OnyxTransactionException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxTransactionException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var applicationName = this.CreateType<string>();
            var objectName = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var stepPackage = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            OnyxTransactionException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxTransactionException(applicationName, objectName, methodName, stepPackage, paramXml);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxTransactionExceptionInstance.ShouldNotBeNull();
            _onyxTransactionExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxTransactionException) instance created

        /// <summary>
        ///     Class (<see cref="OnyxTransactionException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxTransactionException_Is_Created_Test()
        {
            // Assert
            _onyxTransactionExceptionInstance.ShouldNotBeNull();
            _onyxTransactionExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxTransactionException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxTransactionException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxTransactionException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxTransactionException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxTransactionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxTransactionException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxTransactionException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxTransactionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxTransactionException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxTransactionExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxTransactionExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxTransactionException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxTransactionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxTransactionException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxTransactionExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxTransactionExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxTransactionException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyObjectName)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyStepPackage)]
        [TestCase(PropertyParamXml)]
        public void AUT_OnyxTransactionException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxTransactionException) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxTransactionException_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyApplicationName);
            var propertyInfo = this.GetPropertyInfo(PropertyApplicationName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxTransactionException) => Property (MethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxTransactionException_Public_Class_MethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethodName);
            var propertyInfo = this.GetPropertyInfo(PropertyMethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxTransactionException) => Property (ObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxTransactionException_Public_Class_ObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectName);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxTransactionException) => Property (ParamXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxTransactionException_Public_Class_ParamXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParamXml);
            var propertyInfo = this.GetPropertyInfo(PropertyParamXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxTransactionException) => Property (StepPackage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxTransactionException_Public_Class_StepPackage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStepPackage);
            var propertyInfo = this.GetPropertyInfo(PropertyStepPackage);

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