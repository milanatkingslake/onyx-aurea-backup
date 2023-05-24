using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Notification.ViewModel;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Notification.ViewModel
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.ViewModel.ResponseViewModel" />)
    ///     and namespace <see cref="Onyx.UI.Notification.ViewModel"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResponseViewModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResponseViewModel" />)
        /// </summary>
        public ResponseViewModelTest() : base(typeof(ResponseViewModel))
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

        #region General Initializer : Class (ResponseViewModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _responseViewModelInstanceType;
        private ResponseViewModel _responseViewModelInstance;
        private ResponseViewModel _responseViewModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResponseViewModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _responseViewModelInstanceType = typeof(ResponseViewModel);
            _responseViewModelInstanceFixture = this.Create<ResponseViewModel>(false);
            _responseViewModelInstance = _responseViewModelInstanceFixture ?? this.Create<ResponseViewModel>(true);
            CurrentInstance = _responseViewModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ResponseViewModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResponseViewModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResponseViewModel_Is_Instance_Present_Test()
        {
            // Assert
            _responseViewModelInstanceType.ShouldNotBeNull();
            _responseViewModelInstance.ShouldNotBeNull();
            _responseViewModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResponseViewModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResponseViewModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResponseViewModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _responseViewModelInstance.ShouldBeAssignableTo<ResponseViewModel>();
            _responseViewModelInstanceFixture.ShouldBeAssignableTo<ResponseViewModel>();
            CurrentInstance.ShouldBeAssignableTo<ResponseViewModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResponseViewModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseViewModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ResponseViewModel instance = null;

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