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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxChangePasswordException" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxChangePasswordExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxChangePasswordException" />)
        /// </summary>
        public OnyxChangePasswordExceptionTest() : base(typeof(OnyxChangePasswordException))
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

        #region General Initializer : Class (OnyxChangePasswordException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxChangePasswordExceptionInstanceType;
        private OnyxChangePasswordException _onyxChangePasswordExceptionInstance;
        private OnyxChangePasswordException _onyxChangePasswordExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxChangePasswordException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxChangePasswordExceptionInstanceType = typeof(OnyxChangePasswordException);
            _onyxChangePasswordExceptionInstanceFixture = this.Create<OnyxChangePasswordException>(false);
            _onyxChangePasswordExceptionInstance = _onyxChangePasswordExceptionInstanceFixture ?? this.Create<OnyxChangePasswordException>(true);
            CurrentInstance = _onyxChangePasswordExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxChangePasswordException) Initializer

        #region Properties

        private const string PropertyUserId = "UserId";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxChangePasswordException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxChangePasswordException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxChangePasswordException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxChangePasswordException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxChangePasswordException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxChangePasswordException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxChangePasswordException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxChangePasswordException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxChangePasswordException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxChangePasswordException)

        #region General Initializer : Class (OnyxChangePasswordException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxChangePasswordException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserId)]
        [Category("AUT Property")]
        public void AUT_OnyxChangePasswordException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxChangePasswordException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxChangePasswordException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxChangePasswordException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxChangePasswordExceptionInstanceType.ShouldNotBeNull();
            _onyxChangePasswordExceptionInstance.ShouldNotBeNull();
            _onyxChangePasswordExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxChangePasswordException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxChangePasswordException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxChangePasswordException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxChangePasswordExceptionInstance.ShouldBeAssignableTo<OnyxChangePasswordException>();
            _onyxChangePasswordExceptionInstanceFixture.ShouldBeAssignableTo<OnyxChangePasswordException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxChangePasswordException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxChangePasswordException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxChangePasswordException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var userId = this.CreateType<string>();
            OnyxChangePasswordException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxChangePasswordException(userId);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxChangePasswordExceptionInstance.ShouldNotBeNull();
            _onyxChangePasswordExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxChangePasswordException>();
        }

        #endregion

        #region General Constructor : Class (OnyxChangePasswordException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxChangePasswordException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var userId = this.CreateType<string>();
            OnyxChangePasswordException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxChangePasswordException(userId);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxChangePasswordExceptionInstance.ShouldNotBeNull();
            _onyxChangePasswordExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxChangePasswordException) instance created

        /// <summary>
        ///     Class (<see cref="OnyxChangePasswordException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxChangePasswordException_Is_Created_Test()
        {
            // Assert
            _onyxChangePasswordExceptionInstance.ShouldNotBeNull();
            _onyxChangePasswordExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxChangePasswordException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxChangePasswordException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxChangePasswordException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxChangePasswordException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxChangePasswordException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxChangePasswordException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxChangePasswordException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxChangePasswordException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxChangePasswordException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxChangePasswordExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxChangePasswordExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxChangePasswordException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxChangePasswordException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxChangePasswordException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxChangePasswordExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxChangePasswordExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxChangePasswordException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserId)]
        public void AUT_OnyxChangePasswordException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxChangePasswordException) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxChangePasswordException_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserId);
            var propertyInfo = this.GetPropertyInfo(PropertyUserId);

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