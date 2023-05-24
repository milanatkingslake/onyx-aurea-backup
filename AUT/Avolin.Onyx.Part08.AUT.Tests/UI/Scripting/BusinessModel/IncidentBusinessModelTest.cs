using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.BusinessModel;
using OnyxSDK.Public.Interface;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.BusinessModel
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessModel.IncidentBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessModel"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IncidentBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IncidentBusinessModel" />)
        /// </summary>
        public IncidentBusinessModelTest() : base(typeof(IncidentBusinessModel))
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

        #region General Initializer : Class (IncidentBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _incidentBusinessModelInstanceType;
        private IncidentBusinessModel _incidentBusinessModelInstance;
        private IncidentBusinessModel _incidentBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IncidentBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentBusinessModelInstanceType = typeof(IncidentBusinessModel);
            _incidentBusinessModelInstanceFixture = this.Create<IncidentBusinessModel>(false);
            _incidentBusinessModelInstance = _incidentBusinessModelInstanceFixture ?? this.Create<IncidentBusinessModel>(true);
            CurrentInstance = _incidentBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (IncidentBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IncidentBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _incidentBusinessModelInstanceType.ShouldNotBeNull();
            _incidentBusinessModelInstance.ShouldNotBeNull();
            _incidentBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IncidentBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IncidentBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _incidentBusinessModelInstance.ShouldBeAssignableTo<IncidentBusinessModel>();
            _incidentBusinessModelInstanceFixture.ShouldBeAssignableTo<IncidentBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<IncidentBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (IncidentBusinessModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentBusinessModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            IncidentBusinessModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (IncidentBusinessModel) instance created

        /// <summary>
        ///     Class (<see cref="IncidentBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentBusinessModel_Is_Created_Test()
        {
            // Assert
            _incidentBusinessModelInstance.ShouldNotBeNull();
            _incidentBusinessModelInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (IncidentBusinessModel) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="IncidentBusinessModel" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        public void AUT_IncidentBusinessModel_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (IncidentBusinessModel) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="IncidentBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentBusinessModel_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (IncidentBusinessModel) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="IncidentBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentBusinessModel_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodIncidentBusinessModelParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodIncidentBusinessModelParametersTypes);
        }

        #endregion

        #region General Constructor : Class (IncidentBusinessModel) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="IncidentBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentBusinessModel_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodIncidentBusinessModelParametersTypes = new Type[] { typeof(string), typeof(IOnyxUserContext), typeof(List<MessageModel>) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodIncidentBusinessModelParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}