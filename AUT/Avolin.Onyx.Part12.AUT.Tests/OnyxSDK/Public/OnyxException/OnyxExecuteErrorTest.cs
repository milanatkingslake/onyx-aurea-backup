using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OnyxSDK.Public.OnyxException;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OnyxException
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxExecuteError" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxExecuteErrorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxExecuteError" />)
        /// </summary>
        public OnyxExecuteErrorTest() : base(typeof(OnyxExecuteError))
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

        #region General Initializer : Class (OnyxExecuteError) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxExecuteErrorInstanceType;
        private OnyxExecuteError _onyxExecuteErrorInstance;
        private OnyxExecuteError _onyxExecuteErrorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxExecuteError" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxExecuteErrorInstanceType = typeof(OnyxExecuteError);
            _onyxExecuteErrorInstanceFixture = this.Create<OnyxExecuteError>(false);
            _onyxExecuteErrorInstance = _onyxExecuteErrorInstanceFixture ?? this.Create<OnyxExecuteError>(true);
            CurrentInstance = _onyxExecuteErrorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxExecuteError) Initializer

        #region Properties

        private const string PropertySeverity = "Severity";
        private const string PropertyErrorNumber = "ErrorNumber";
        private const string PropertyErrorDescription = "ErrorDescription";
        private const string PropertyErrorType = "ErrorType";
        private const string PropertyNatLangId = "NatLangId";
        private const string PropertySourceType = "SourceType";
        private const string PropertySourceName = "SourceName";
        private const string PropertyTimestamp = "Timestamp";
        private const string PropertyAssociationId = "AssociationId";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxExecuteError) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxExecuteError" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxExecuteError_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxExecuteError) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxExecuteError" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxExecuteError_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxExecuteError) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxExecuteError" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxExecuteError_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxExecuteError)

        #region General Initializer : Class (OnyxExecuteError) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxExecuteError" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySeverity)]
        [TestCase(PropertyErrorNumber)]
        [TestCase(PropertyErrorDescription)]
        [TestCase(PropertyErrorType)]
        [TestCase(PropertyNatLangId)]
        [TestCase(PropertySourceType)]
        [TestCase(PropertySourceName)]
        [TestCase(PropertyTimestamp)]
        [TestCase(PropertyAssociationId)]
        [Category("AUT Property")]
        public void AUT_OnyxExecuteError_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxExecuteError) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxExecuteError" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxExecuteError_Is_Instance_Present_Test()
        {
            // Assert
            _onyxExecuteErrorInstanceType.ShouldNotBeNull();
            _onyxExecuteErrorInstance.ShouldNotBeNull();
            _onyxExecuteErrorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxExecuteError) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxExecuteError" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxExecuteError_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxExecuteErrorInstance.ShouldBeAssignableTo<OnyxExecuteError>();
            _onyxExecuteErrorInstanceFixture.ShouldBeAssignableTo<OnyxExecuteError>();
            CurrentInstance.ShouldBeAssignableTo<OnyxExecuteError>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxExecuteError) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxExecuteError_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxExecuteError instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxExecuteError) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxExecuteError_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var data = this.CreateType<JToken>();
            OnyxExecuteError instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxExecuteError(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxExecuteErrorInstance.ShouldNotBeNull();
            _onyxExecuteErrorInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxExecuteError>();
        }

        #endregion

        #region General Constructor : Class (OnyxExecuteError) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxExecuteError_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var data = this.CreateType<JToken>();
            OnyxExecuteError instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxExecuteError(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxExecuteErrorInstance.ShouldNotBeNull();
            _onyxExecuteErrorInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxExecuteError) instance created

        /// <summary>
        ///     Class (<see cref="OnyxExecuteError" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxExecuteError_Is_Created_Test()
        {
            // Assert
            _onyxExecuteErrorInstance.ShouldNotBeNull();
            _onyxExecuteErrorInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxExecuteError) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxExecuteError" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxExecuteError_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxExecuteError) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxExecuteError" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxExecuteError_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxExecuteError) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxExecuteError" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxExecuteError_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodOnyxExecuteErrorParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxExecuteErrorParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxExecuteError) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxExecuteError" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxExecuteError_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxExecuteErrorParametersTypes = new Type[] { typeof(JToken) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxExecuteErrorParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxExecuteError) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySeverity)]
        [TestCase(PropertyErrorNumber)]
        [TestCase(PropertyErrorDescription)]
        [TestCase(PropertyErrorType)]
        [TestCase(PropertyNatLangId)]
        [TestCase(PropertySourceType)]
        [TestCase(PropertySourceName)]
        [TestCase(PropertyTimestamp)]
        [TestCase(PropertyAssociationId)]
        public void AUT_OnyxExecuteError_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (AssociationId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_AssociationId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAssociationId);
            var propertyInfo = this.GetPropertyInfo(PropertyAssociationId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (ErrorDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_ErrorDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (ErrorNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_ErrorNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorNumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (ErrorType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_ErrorType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorType);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (NatLangId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_NatLangId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNatLangId);
            var propertyInfo = this.GetPropertyInfo(PropertyNatLangId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (Severity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_Severity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySeverity);
            var propertyInfo = this.GetPropertyInfo(PropertySeverity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (SourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_SourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySourceName);
            var propertyInfo = this.GetPropertyInfo(PropertySourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (SourceType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_SourceType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySourceType);
            var propertyInfo = this.GetPropertyInfo(PropertySourceType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxExecuteError) => Property (Timestamp) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxExecuteError_Public_Class_Timestamp_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTimestamp);
            var propertyInfo = this.GetPropertyInfo(PropertyTimestamp);

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