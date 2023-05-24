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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxSessionException" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSessionExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxSessionException" />)
        /// </summary>
        public OnyxSessionExceptionTest() : base(typeof(OnyxSessionException))
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

        #region General Initializer : Class (OnyxSessionException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxSessionExceptionInstanceType;
        private OnyxSessionException _onyxSessionExceptionInstance;
        private OnyxSessionException _onyxSessionExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxSessionException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxSessionExceptionInstanceType = typeof(OnyxSessionException);
            _onyxSessionExceptionInstanceFixture = this.Create<OnyxSessionException>(false);
            _onyxSessionExceptionInstance = _onyxSessionExceptionInstanceFixture ?? this.Create<OnyxSessionException>(true);
            CurrentInstance = _onyxSessionExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OnyxSessionException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxSessionException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSessionException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxSessionExceptionInstanceType.ShouldNotBeNull();
            _onyxSessionExceptionInstance.ShouldNotBeNull();
            _onyxSessionExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxSessionException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxSessionException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxSessionException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxSessionExceptionInstance.ShouldBeAssignableTo<OnyxSessionException>();
            _onyxSessionExceptionInstanceFixture.ShouldBeAssignableTo<OnyxSessionException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxSessionException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxSessionException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSessionException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            OnyxSessionException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxSessionException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxSessionExceptionInstance.ShouldNotBeNull();
            _onyxSessionExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxSessionException>();
        }

        #endregion

        #region General Constructor : Class (OnyxSessionException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSessionException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            OnyxSessionException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxSessionException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxSessionExceptionInstance.ShouldNotBeNull();
            _onyxSessionExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxSessionException) instance created

        /// <summary>
        ///     Class (<see cref="OnyxSessionException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSessionException_Is_Created_Test()
        {
            // Assert
            _onyxSessionExceptionInstance.ShouldNotBeNull();
            _onyxSessionExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxSessionException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxSessionException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_OnyxSessionException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxSessionException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxSessionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSessionException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxSessionException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxSessionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSessionException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxSessionExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxSessionExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxSessionException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxSessionException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxSessionException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxSessionExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxSessionExceptionParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}