using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.Extensions" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ExtensionsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Extensions" />)
        /// </summary>
        public ExtensionsTest() : base(typeof(Extensions))
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

        #region General Initializer : Class (Extensions) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _extensionsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Extensions" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _extensionsInstanceType = typeof(Extensions);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Extensions) Initializer

        #region Methods

        private const string MethodY = "Y";
        private const string MethodTraverse = "Traverse";

        #endregion

        #endregion

        #region General Initializer : Class (Extensions) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Extensions" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Extensions_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Extensions)

        #region General Initializer : Class (Extensions) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Extensions" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodY, 0)]
        [TestCase(MethodTraverse, 0)]
        public void AUT_Extensions_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (Extensions) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Extensions" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Extensions_Is_Static_Type_Present_Test()
        {
            // Assert
            _extensionsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Traverse) (Return Type : IEnumerable<TreeData>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Extensions_Traverse_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTraverse);
            var source = this.CreateType<dynamic>();
            var predicate = this.CreateType<dynamic>();

            // Act
            Action executeAction = () => Extensions.Traverse(source, predicate);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Traverse) (Return Type : IEnumerable<TreeData>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Extensions_Traverse_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTraverse);
            var source = this.CreateType<dynamic>();
            var predicate = this.CreateType<dynamic>();
            var returnedValue = default(IEnumerable<TreeData>);

            // Act
            Action executeAction = () => returnedValue = Extensions.Traverse(source, predicate);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Traverse) (Return Type : IEnumerable<TreeData>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Extensions_Traverse_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTraverse);
            var source = this.CreateType<dynamic>();
            var predicate = this.CreateType<dynamic>();
            var methodTraverseParametersTypes = new Type[] { typeof(IEnumerable<TreeData>), typeof(Func<TreeData, bool>) };
            object[] parametersOfTraverse = { source, predicate };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IEnumerable<TreeData>>(MethodTraverse, parametersOfTraverse, methodTraverseParametersTypes);

            // Assert
            parametersOfTraverse.ShouldNotBeNull();
            parametersOfTraverse.Length.ShouldBe(2);
            methodTraverseParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Traverse) (Return Type : IEnumerable<TreeData>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Extensions_Traverse_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTraverse);
            var methodTraverseParametersTypes = new Type[] { typeof(IEnumerable<TreeData>), typeof(Func<TreeData, bool>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTraverse, methodTraverseParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodTraverseParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Traverse) (Return Type : IEnumerable<TreeData>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Extensions_Traverse_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTraverse);
            var methodTraverseParametersTypes = new Type[] { typeof(IEnumerable<TreeData>), typeof(Func<TreeData, bool>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTraverse, methodTraverseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTraverseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Traverse) (Return Type : IEnumerable<TreeData>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Extensions_Traverse_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTraverse);
            var currentMethodInfo = this.GetMethodInfo(MethodTraverse, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Traverse) (Return Type : IEnumerable<TreeData>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Extensions_Traverse_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTraverse);
            var currentMethodInfo = this.GetMethodInfo(MethodTraverse, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}