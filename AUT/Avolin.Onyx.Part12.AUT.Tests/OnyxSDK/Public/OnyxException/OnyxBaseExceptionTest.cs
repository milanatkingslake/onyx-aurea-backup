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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxBaseException" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxBaseExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxBaseException" />)
        /// </summary>
        public OnyxBaseExceptionTest() : base(typeof(OnyxBaseException))
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

        #region General Initializer : Class (OnyxBaseException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxBaseExceptionInstanceType;
        private OnyxBaseException _onyxBaseExceptionInstance;
        private OnyxBaseException _onyxBaseExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxBaseException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxBaseExceptionInstanceType = typeof(OnyxBaseException);
            _onyxBaseExceptionInstanceFixture = this.Create<OnyxBaseException>(false);
            _onyxBaseExceptionInstance = _onyxBaseExceptionInstanceFixture ?? this.Create<OnyxBaseException>(true);
            CurrentInstance = _onyxBaseExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OnyxBaseException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxBaseException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxBaseException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxBaseExceptionInstanceType.ShouldNotBeNull();
            _onyxBaseExceptionInstance.ShouldNotBeNull();
            _onyxBaseExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxBaseException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxBaseException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxBaseException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxBaseExceptionInstance.ShouldBeAssignableTo<OnyxBaseException>();
            _onyxBaseExceptionInstanceFixture.ShouldBeAssignableTo<OnyxBaseException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxBaseException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxBaseException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBaseException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxBaseException instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxBaseException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBaseException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            OnyxBaseException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxBaseException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxBaseExceptionInstance.ShouldNotBeNull();
            _onyxBaseExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxBaseException>();
        }

        #endregion

        #region General Constructor : Class (OnyxBaseException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBaseException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            OnyxBaseException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxBaseException(message);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxBaseExceptionInstance.ShouldNotBeNull();
            _onyxBaseExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (OnyxBaseException) instance created

        /// <summary>
        ///     Class (<see cref="OnyxBaseException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBaseException_Is_Created_Test()
        {
            // Assert
            _onyxBaseExceptionInstance.ShouldNotBeNull();
            _onyxBaseExceptionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (OnyxBaseException) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="OnyxBaseException" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void AUT_OnyxBaseException_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (OnyxBaseException) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="OnyxBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBaseException_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (OnyxBaseException) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBaseException_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodOnyxBaseExceptionParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxBaseExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxBaseException) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBaseException_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxBaseExceptionParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxBaseExceptionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (OnyxBaseException) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="OnyxBaseException" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxBaseException_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodOnyxBaseExceptionParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodOnyxBaseExceptionParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}