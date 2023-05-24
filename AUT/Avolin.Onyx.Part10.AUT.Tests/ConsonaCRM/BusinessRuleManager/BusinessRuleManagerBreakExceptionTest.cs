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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.BusinessRuleManagerBreakException" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class BusinessRuleManagerBreakExceptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="BusinessRuleManagerBreakException" />)
        /// </summary>
        public BusinessRuleManagerBreakExceptionTest() : base(typeof(BusinessRuleManagerBreakException))
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

        #region General Initializer : Class (BusinessRuleManagerBreakException) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _businessRuleManagerBreakExceptionInstanceType;
        private BusinessRuleManagerBreakException _businessRuleManagerBreakExceptionInstance;
        private BusinessRuleManagerBreakException _businessRuleManagerBreakExceptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="BusinessRuleManagerBreakException" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _businessRuleManagerBreakExceptionInstanceType = typeof(BusinessRuleManagerBreakException);
            _businessRuleManagerBreakExceptionInstanceFixture = this.Create<BusinessRuleManagerBreakException>(false);
            _businessRuleManagerBreakExceptionInstance = _businessRuleManagerBreakExceptionInstanceFixture ?? this.Create<BusinessRuleManagerBreakException>(true);
            CurrentInstance = _businessRuleManagerBreakExceptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (BusinessRuleManagerBreakException) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerBreakException" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRuleManagerBreakException_Is_Instance_Present_Test()
        {
            // Assert
            _businessRuleManagerBreakExceptionInstanceType.ShouldNotBeNull();
            _businessRuleManagerBreakExceptionInstance.ShouldNotBeNull();
            _businessRuleManagerBreakExceptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (BusinessRuleManagerBreakException) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="BusinessRuleManagerBreakException" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRuleManagerBreakException_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _businessRuleManagerBreakExceptionInstance.ShouldBeAssignableTo<BusinessRuleManagerBreakException>();
            _businessRuleManagerBreakExceptionInstanceFixture.ShouldBeAssignableTo<BusinessRuleManagerBreakException>();
            CurrentInstance.ShouldBeAssignableTo<BusinessRuleManagerBreakException>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (BusinessRuleManagerBreakException) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRuleManagerBreakException_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            BusinessRuleManagerBreakException instance = null;

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