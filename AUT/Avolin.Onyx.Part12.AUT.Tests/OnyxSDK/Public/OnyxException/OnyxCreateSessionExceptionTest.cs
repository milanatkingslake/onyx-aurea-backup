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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxCreateSessionException" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxCreateSessionExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxCreateSessionException" />)
        /// </summary>
        public OnyxCreateSessionExceptionTest() : base(typeof(OnyxCreateSessionException))
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

        #region General Initializer : Class (OnyxCreateSessionException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxCreateSessionExceptionInstanceType;
        private OnyxCreateSessionException _onyxCreateSessionExceptionInstance;
        private OnyxCreateSessionException _onyxCreateSessionExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxCreateSessionException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxCreateSessionExceptionInstanceType = typeof(OnyxCreateSessionException);
            _onyxCreateSessionExceptionInstanceFixture = this.Create<OnyxCreateSessionException>(false);
            _onyxCreateSessionExceptionInstance = _onyxCreateSessionExceptionInstanceFixture ?? this.Create<OnyxCreateSessionException>(true);
            CurrentInstance = _onyxCreateSessionExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxCreateSessionException) Initializer

        #region Properties

        private const string PropertyUserId = "UserId";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxCreateSessionException) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxCreateSessionException" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxCreateSessionException_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxCreateSessionException) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxCreateSessionException" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxCreateSessionException_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxCreateSessionException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxCreateSessionException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxCreateSessionException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxCreateSessionException)

        #region General Initializer : Class (OnyxCreateSessionException) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxCreateSessionException" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserId)]
        [Category("AUT Property")]
        public void AUT_OnyxCreateSessionException_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxCreateSessionException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxCreateSessionException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxCreateSessionException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxCreateSessionExceptionInstanceType.ShouldNotBeNull();
            _onyxCreateSessionExceptionInstance.ShouldNotBeNull();
            _onyxCreateSessionExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxCreateSessionException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxCreateSessionException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxCreateSessionException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxCreateSessionExceptionInstance.ShouldBeAssignableTo<OnyxCreateSessionException>();
            _onyxCreateSessionExceptionInstanceFixture.ShouldBeAssignableTo<OnyxCreateSessionException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxCreateSessionException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxCreateSessionException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCreateSessionException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var userId = this.CreateType<string>();
            OnyxCreateSessionException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxCreateSessionException(userId);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxCreateSessionExceptionInstance.ShouldNotBeNull();
            _onyxCreateSessionExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxCreateSessionException>();
        }

        #endregion

        #region General Constructor : Class (OnyxCreateSessionException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCreateSessionException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var userId = this.CreateType<string>();
            OnyxCreateSessionException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxCreateSessionException(userId);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxCreateSessionExceptionInstance.ShouldNotBeNull();
            _onyxCreateSessionExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxCreateSessionException) instance created

        /// <summary>
        ///     Class (<see cref="OnyxCreateSessionException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCreateSessionException_Is_Created_Test()
        {
            // Assert
            _onyxCreateSessionExceptionInstance.ShouldNotBeNull();
            _onyxCreateSessionExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxCreateSessionException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxCreateSessionException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxCreateSessionException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxCreateSessionException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxCreateSessionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCreateSessionException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxCreateSessionException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxCreateSessionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCreateSessionException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxCreateSessionExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxCreateSessionExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxCreateSessionException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxCreateSessionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxCreateSessionException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxCreateSessionExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxCreateSessionExceptionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxCreateSessionException) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserId)]
        public void AUT_OnyxCreateSessionException_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxCreateSessionException) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxCreateSessionException_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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