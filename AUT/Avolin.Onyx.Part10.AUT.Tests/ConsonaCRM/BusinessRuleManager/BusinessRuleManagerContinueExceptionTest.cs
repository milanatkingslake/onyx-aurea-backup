using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.BusinessRuleManagerContinueException" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class BusinessRuleManagerContinueExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="BusinessRuleManagerContinueException" />)
        /// </summary>
        public BusinessRuleManagerContinueExceptionTest() : base(typeof(BusinessRuleManagerContinueException))
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

        #region General Initializer : Class (BusinessRuleManagerContinueException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _businessRuleManagerContinueExceptionInstanceType;
        private BusinessRuleManagerContinueException _businessRuleManagerContinueExceptionInstance;
        private BusinessRuleManagerContinueException _businessRuleManagerContinueExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="BusinessRuleManagerContinueException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _businessRuleManagerContinueExceptionInstanceType = typeof(BusinessRuleManagerContinueException);
            _businessRuleManagerContinueExceptionInstanceFixture = this.Create<BusinessRuleManagerContinueException>(false);
            _businessRuleManagerContinueExceptionInstance = _businessRuleManagerContinueExceptionInstanceFixture ?? this.Create<BusinessRuleManagerContinueException>(true);
            CurrentInstance = _businessRuleManagerContinueExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (BusinessRuleManagerContinueException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerContinueException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRuleManagerContinueException_Is_Instance_Present_Test()
        {
            // Assert
            _businessRuleManagerContinueExceptionInstanceType.ShouldNotBeNull();
            _businessRuleManagerContinueExceptionInstance.ShouldNotBeNull();
            _businessRuleManagerContinueExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (BusinessRuleManagerContinueException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerContinueException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRuleManagerContinueException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _businessRuleManagerContinueExceptionInstance.ShouldBeAssignableTo<BusinessRuleManagerContinueException>();
            _businessRuleManagerContinueExceptionInstanceFixture.ShouldBeAssignableTo<BusinessRuleManagerContinueException>();
            CurrentInstance.ShouldBeAssignableTo<BusinessRuleManagerContinueException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (BusinessRuleManagerContinueException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRuleManagerContinueException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            BusinessRuleManagerContinueException instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}