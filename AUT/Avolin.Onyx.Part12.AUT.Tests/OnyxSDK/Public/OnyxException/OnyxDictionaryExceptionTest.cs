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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxDictionaryException" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxDictionaryExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxDictionaryException" />)
        /// </summary>
        public OnyxDictionaryExceptionTest() : base(typeof(OnyxDictionaryException))
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

        #region General Initializer : Class (OnyxDictionaryException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxDictionaryExceptionInstanceType;
        private OnyxDictionaryException _onyxDictionaryExceptionInstance;
        private OnyxDictionaryException _onyxDictionaryExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxDictionaryException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxDictionaryExceptionInstanceType = typeof(OnyxDictionaryException);
            _onyxDictionaryExceptionInstanceFixture = this.Create<OnyxDictionaryException>(false);
            _onyxDictionaryExceptionInstance = _onyxDictionaryExceptionInstanceFixture ?? this.Create<OnyxDictionaryException>(true);
            CurrentInstance = _onyxDictionaryExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxDictionaryException) Initializer

        #region Properties

        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertyObjectName = "ObjectName";
        private const string PropertyPropertyName = "PropertyName";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxDictionaryException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxDictionaryException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxDictionaryException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxDictionaryException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxDictionaryException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxDictionaryException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxDictionaryException)

        #region General Initializer : Class (OnyxDictionaryException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyObjectName)]
        [TestCase(PropertyPropertyName)]
        [Category("AUT Property")]
        public void AUT_OnyxDictionaryException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxDictionaryException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxDictionaryException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxDictionaryExceptionInstanceType.ShouldNotBeNull();
            _onyxDictionaryExceptionInstance.ShouldNotBeNull();
            _onyxDictionaryExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxDictionaryException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxDictionaryException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxDictionaryExceptionInstance.ShouldBeAssignableTo<OnyxDictionaryException>();
            _onyxDictionaryExceptionInstanceFixture.ShouldBeAssignableTo<OnyxDictionaryException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxDictionaryException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxDictionaryException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxDictionaryException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var applicationName = this.CreateType<string>();
            var objectName = this.CreateType<string>();
            var propertyName = this.CreateType<string>();
            OnyxDictionaryException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxDictionaryException(applicationName, objectName, propertyName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxDictionaryExceptionInstance.ShouldNotBeNull();
            _onyxDictionaryExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxDictionaryException>();
        }

        #endregion

        #region General Constructor : Class (OnyxDictionaryException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxDictionaryException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var applicationName = this.CreateType<string>();
            var objectName = this.CreateType<string>();
            var propertyName = this.CreateType<string>();
            OnyxDictionaryException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxDictionaryException(applicationName, objectName, propertyName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxDictionaryExceptionInstance.ShouldNotBeNull();
            _onyxDictionaryExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxDictionaryException) instance created

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxDictionaryException_Is_Created_Test()
        {
            // Assert
            _onyxDictionaryExceptionInstance.ShouldNotBeNull();
            _onyxDictionaryExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxDictionaryException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxDictionaryException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxDictionaryException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxDictionaryException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxDictionaryException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxDictionaryException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxDictionaryException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxDictionaryException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxDictionaryException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxDictionaryExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxDictionaryExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxDictionaryException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxDictionaryException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxDictionaryException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxDictionaryExceptionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxDictionaryExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxDictionaryException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyObjectName)]
        [TestCase(PropertyPropertyName)]
        public void AUT_OnyxDictionaryException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxDictionaryException) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxDictionaryException_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxDictionaryException) => Property (ObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxDictionaryException_Public_Class_ObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxDictionaryException) => Property (PropertyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxDictionaryException_Public_Class_PropertyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyPropertyName);

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