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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxNatLangException" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxNatLangExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxNatLangException" />)
        /// </summary>
        public OnyxNatLangExceptionTest() : base(typeof(OnyxNatLangException))
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

        #region General Initializer : Class (OnyxNatLangException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxNatLangExceptionInstanceType;
        private OnyxNatLangException _onyxNatLangExceptionInstance;
        private OnyxNatLangException _onyxNatLangExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxNatLangException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxNatLangExceptionInstanceType = typeof(OnyxNatLangException);
            _onyxNatLangExceptionInstanceFixture = this.Create<OnyxNatLangException>(false);
            _onyxNatLangExceptionInstance = _onyxNatLangExceptionInstanceFixture ?? this.Create<OnyxNatLangException>(true);
            CurrentInstance = _onyxNatLangExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxNatLangException) Initializer

        #region Properties

        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertyNatLangId = "NatLangId";
        private const string PropertyNatLangParam = "NatLangParam";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxNatLangException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxNatLangException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxNatLangException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxNatLangException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxNatLangException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxNatLangException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxNatLangException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxNatLangException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxNatLangException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxNatLangException)

        #region General Initializer : Class (OnyxNatLangException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxNatLangException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyNatLangId)]
        [TestCase(PropertyNatLangParam)]
        [Category("AUT Property")]
        public void AUT_OnyxNatLangException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxNatLangException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxNatLangException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxNatLangException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxNatLangExceptionInstanceType.ShouldNotBeNull();
            _onyxNatLangExceptionInstance.ShouldNotBeNull();
            _onyxNatLangExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxNatLangException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxNatLangException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxNatLangException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxNatLangExceptionInstance.ShouldBeAssignableTo<OnyxNatLangException>();
            _onyxNatLangExceptionInstanceFixture.ShouldBeAssignableTo<OnyxNatLangException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxNatLangException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxNatLangException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxNatLangException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var applicationName = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var natLangId = this.CreateType<string>();
            var natLangParam = this.CreateType<string>();
            OnyxNatLangException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxNatLangException(applicationName, languageCode, natLangId, natLangParam);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxNatLangExceptionInstance.ShouldNotBeNull();
            _onyxNatLangExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxNatLangException>();
        }

        #endregion

        #region General Constructor : Class (OnyxNatLangException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxNatLangException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var applicationName = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var natLangId = this.CreateType<string>();
            var natLangParam = this.CreateType<string>();
            OnyxNatLangException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxNatLangException(applicationName, languageCode, natLangId, natLangParam);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxNatLangExceptionInstance.ShouldNotBeNull();
            _onyxNatLangExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxNatLangException) instance created

        /// <summary>
        ///     Class (<see cref="OnyxNatLangException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxNatLangException_Is_Created_Test()
        {
            // Assert
            _onyxNatLangExceptionInstance.ShouldNotBeNull();
            _onyxNatLangExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxNatLangException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxNatLangException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxNatLangException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxNatLangException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxNatLangException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxNatLangException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxNatLangException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxNatLangException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxNatLangException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxNatLangExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxNatLangExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxNatLangException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxNatLangException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxNatLangException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxNatLangExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxNatLangExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxNatLangException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyNatLangId)]
        [TestCase(PropertyNatLangParam)]
        public void AUT_OnyxNatLangException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxNatLangException) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxNatLangException_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxNatLangException) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxNatLangException_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguageCode);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguageCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxNatLangException) => Property (NatLangId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxNatLangException_Public_Class_NatLangId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxNatLangException) => Property (NatLangParam) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxNatLangException_Public_Class_NatLangParam_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNatLangParam);
            var propertyInfo = this.GetPropertyInfo(PropertyNatLangParam);

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