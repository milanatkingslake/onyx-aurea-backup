using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ReferenceLookupComparer" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ReferenceLookupComparerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReferenceLookupComparer" />)
        /// </summary>
        public ReferenceLookupComparerTest() : base(typeof(ReferenceLookupComparer))
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

        #region General Initializer : Class (ReferenceLookupComparer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _referenceLookupComparerInstanceType;
        private ReferenceLookupComparer _referenceLookupComparerInstance;
        private ReferenceLookupComparer _referenceLookupComparerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReferenceLookupComparer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _referenceLookupComparerInstanceType = typeof(ReferenceLookupComparer);
            _referenceLookupComparerInstanceFixture = this.Create<ReferenceLookupComparer>(false);
            _referenceLookupComparerInstance = _referenceLookupComparerInstanceFixture ?? this.Create<ReferenceLookupComparer>(true);
            CurrentInstance = _referenceLookupComparerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupComparer) Initializer

        #region Methods

        private const string MethodEquals = "Equals";
        private const string MethodGetHashCode = "GetHashCode";

        #endregion

        #endregion

        #region General Initializer : Class (ReferenceLookupComparer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ReferenceLookupComparer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupComparer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ReferenceLookupComparer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ReferenceLookupComparer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReferenceLookupComparer_Is_Instance_Present_Test()
        {
            // Assert
            _referenceLookupComparerInstanceType.ShouldNotBeNull();
            _referenceLookupComparerInstance.ShouldNotBeNull();
            _referenceLookupComparerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ReferenceLookupComparer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ReferenceLookupComparer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReferenceLookupComparer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _referenceLookupComparerInstance.ShouldBeAssignableTo<ReferenceLookupComparer>();
            _referenceLookupComparerInstanceFixture.ShouldBeAssignableTo<ReferenceLookupComparer>();
            CurrentInstance.ShouldBeAssignableTo<ReferenceLookupComparer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ReferenceLookupComparer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ReferenceLookupComparer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ReferenceLookupComparer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetHashCode) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ReferenceLookupComparer_GetHashCode_Method_Call_Internally(Type[] types)
        {
            var methodGetHashCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHashCode, methodGetHashCodeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}