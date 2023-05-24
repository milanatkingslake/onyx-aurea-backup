using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Operators" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ModelClasses.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OperatorsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Operators" />)
        /// </summary>
        public OperatorsTest() : base(typeof(Operators))
        { }

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

        #region General Initializer : Class (Operators) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _operatorsInstanceType;
        private Operators _operatorsInstance;
        private Operators _operatorsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Operators" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _operatorsInstanceType = typeof(Operators);
            _operatorsInstanceFixture = this.Create<Operators>(false);
            _operatorsInstance = _operatorsInstanceFixture ?? this.Create<Operators>(true);
            CurrentInstance = _operatorsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Operators) Initializer

        #region Fields

        private const string FieldOperator = "Operator";

        #endregion

        #endregion

        #region General Initializer : Class (Operators) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Operators" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Operators_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Operators)

        #region General Initializer : Class (Operators) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Operators" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldOperator)]
        [Category("AUT Fields")]
        public void AUT_Operators_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Operators) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Operators" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Operators_Is_Instance_Present_Test()
        {
            // Assert
            _operatorsInstanceType.ShouldNotBeNull();
            _operatorsInstance.ShouldNotBeNull();
            _operatorsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Operators) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Operators" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Operators_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _operatorsInstance.ShouldBeAssignableTo<Operators>();
            _operatorsInstanceFixture.ShouldBeAssignableTo<Operators>();
            CurrentInstance.ShouldBeAssignableTo<Operators>();
        }

        #endregion

        #region General Constructor : Class (Operators) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Operators_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Operators instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion
    }
}