using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxMessageSubsystem;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxMessageSubsystem
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxMessageSubsystem.OnyxException" />)
    ///     and namespace <see cref="OnyxMessageSubsystem"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxException" />)
        /// </summary>
        public OnyxExceptionTest() : base(typeof(OnyxException))
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

        #region General Initializer : Class (OnyxException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxExceptionInstanceType;
        private OnyxException _onyxExceptionInstance;
        private OnyxException _onyxExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxExceptionInstanceType = typeof(OnyxException);
            _onyxExceptionInstanceFixture = this.Create<OnyxException>(false);
            _onyxExceptionInstance = _onyxExceptionInstanceFixture ?? this.Create<OnyxException>(true);
            CurrentInstance = _onyxExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxException) Initializer

        #region Fields

        private const string FieldParameter = "Parameter";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxException) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxException" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxException_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxException)

        #region General Initializer : Class (OnyxException) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxException" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldParameter)]
        [Category("AUT Fields")]
        public void AUT_OnyxException_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxException_Is_Instance_Present_Test()
        {
            // Assert
            _onyxExceptionInstanceType.ShouldNotBeNull();
            _onyxExceptionInstance.ShouldNotBeNull();
            _onyxExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxExceptionInstance.ShouldBeAssignableTo<OnyxException>();
            _onyxExceptionInstanceFixture.ShouldBeAssignableTo<OnyxException>();
            CurrentInstance.ShouldBeAssignableTo<OnyxException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxException_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            var e = this.CreateType<Exception>();
            var parameter = this.CreateType<Hashtable>();
            OnyxException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxException(message, e, parameter);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxExceptionInstance.ShouldNotBeNull();
            _onyxExceptionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxException>();
        }

        #endregion

        #region General Constructor : Class (OnyxException) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxException_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var message = this.CreateType<string>();
            var e = this.CreateType<Exception>();
            var parameter = this.CreateType<Hashtable>();
            OnyxException instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxException(message, e, parameter);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxExceptionInstance.ShouldNotBeNull();
            _onyxExceptionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #endregion
    }
}