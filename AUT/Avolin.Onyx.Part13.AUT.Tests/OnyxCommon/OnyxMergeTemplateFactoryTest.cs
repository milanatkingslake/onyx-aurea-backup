using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxCommon;
using Shouldly;

namespace Avolin.Onyx.Part13.AUT.Tests.OnyxCommon
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxCommon.OnyxMergeTemplateFactory" />)
    ///     and namespace <see cref="OnyxCommon"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxMergeTemplateFactoryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxMergeTemplateFactory" />)
        /// </summary>
        public OnyxMergeTemplateFactoryTest() : base(typeof(OnyxMergeTemplateFactory))
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

        #region General Initializer : Class (OnyxMergeTemplateFactory) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxMergeTemplateFactoryInstanceType;
        private OnyxMergeTemplateFactory _onyxMergeTemplateFactoryInstance;
        private OnyxMergeTemplateFactory _onyxMergeTemplateFactoryInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxMergeTemplateFactory" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxMergeTemplateFactoryInstanceType = typeof(OnyxMergeTemplateFactory);
            _onyxMergeTemplateFactoryInstanceFixture = this.Create<OnyxMergeTemplateFactory>(false);
            _onyxMergeTemplateFactoryInstance = _onyxMergeTemplateFactoryInstanceFixture ?? this.Create<OnyxMergeTemplateFactory>(true);
            CurrentInstance = _onyxMergeTemplateFactoryInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxMergeTemplateFactory) Initializer

        #region Methods

        private const string MethodretrieveEmailTemplateTree = "retrieveEmailTemplateTree";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxMergeTemplateFactory) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplateFactory" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxMergeTemplateFactory_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxMergeTemplateFactory)

        #region General Initializer : Class (OnyxMergeTemplateFactory) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplateFactory" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodretrieveEmailTemplateTree, 0)]
        public void AUT_OnyxMergeTemplateFactory_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OnyxMergeTemplateFactory) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplateFactory" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxMergeTemplateFactory_Is_Instance_Present_Test()
        {
            // Assert
            _onyxMergeTemplateFactoryInstanceType.ShouldNotBeNull();
            _onyxMergeTemplateFactoryInstance.ShouldNotBeNull();
            _onyxMergeTemplateFactoryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxMergeTemplateFactory) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxMergeTemplateFactory" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxMergeTemplateFactory_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxMergeTemplateFactoryInstance.ShouldBeAssignableTo<OnyxMergeTemplateFactory>();
            _onyxMergeTemplateFactoryInstanceFixture.ShouldBeAssignableTo<OnyxMergeTemplateFactory>();
            CurrentInstance.ShouldBeAssignableTo<OnyxMergeTemplateFactory>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxMergeTemplateFactory) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxMergeTemplateFactory_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxMergeTemplateFactory instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (retrieveEmailTemplateTree) (Return Type : TreeNode) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplateFactory_retrieveEmailTemplateTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveEmailTemplateTree);
            var targetObjectType = this.CreateType<string>();
            var inputObjectEnums = this.CreateType<List<String>>();

            // Act
            Action executeAction = () => _onyxMergeTemplateFactoryInstance.retrieveEmailTemplateTree(targetObjectType, inputObjectEnums);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (retrieveEmailTemplateTree) (Return Type : TreeNode) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplateFactory_retrieveEmailTemplateTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveEmailTemplateTree);
            var targetObjectType = this.CreateType<string>();
            var inputObjectEnums = this.CreateType<List<String>>();
            var returnedValue = default(TreeNode);

            // Act
            Action executeAction = () => returnedValue = _onyxMergeTemplateFactoryInstance.retrieveEmailTemplateTree(targetObjectType, inputObjectEnums);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveEmailTemplateTree) (Return Type : TreeNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplateFactory_retrieveEmailTemplateTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveEmailTemplateTree);
            var targetObjectType = this.CreateType<string>();
            var inputObjectEnums = this.CreateType<List<String>>();
            var methodretrieveEmailTemplateTreeParametersTypes = new Type[] { typeof(String), typeof(List<String>) };
            object[] parametersOfretrieveEmailTemplateTree = { targetObjectType, inputObjectEnums };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveEmailTemplateTree, methodretrieveEmailTemplateTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<TreeNode>(_onyxMergeTemplateFactoryInstanceFixture, parametersOfretrieveEmailTemplateTree);
            var result2 = this.GetResultOfMethod<TreeNode>(MethodretrieveEmailTemplateTree, parametersOfretrieveEmailTemplateTree, methodretrieveEmailTemplateTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfretrieveEmailTemplateTree.ShouldNotBeNull();
            parametersOfretrieveEmailTemplateTree.Length.ShouldBe(2);
            methodretrieveEmailTemplateTreeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (retrieveEmailTemplateTree) (Return Type : TreeNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplateFactory_retrieveEmailTemplateTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveEmailTemplateTree);
            var targetObjectType = this.CreateType<string>();
            var inputObjectEnums = this.CreateType<List<String>>();
            var methodretrieveEmailTemplateTreeParametersTypes = new Type[] { typeof(String), typeof(List<String>) };
            object[] parametersOfretrieveEmailTemplateTree = { targetObjectType, inputObjectEnums };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TreeNode>(MethodretrieveEmailTemplateTree, parametersOfretrieveEmailTemplateTree, methodretrieveEmailTemplateTreeParametersTypes);

            // Assert
            parametersOfretrieveEmailTemplateTree.ShouldNotBeNull();
            parametersOfretrieveEmailTemplateTree.Length.ShouldBe(2);
            methodretrieveEmailTemplateTreeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (retrieveEmailTemplateTree) (Return Type : TreeNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplateFactory_retrieveEmailTemplateTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveEmailTemplateTree);
            var methodretrieveEmailTemplateTreeParametersTypes = new Type[] { typeof(String), typeof(List<String>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodretrieveEmailTemplateTree, methodretrieveEmailTemplateTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodretrieveEmailTemplateTreeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (retrieveEmailTemplateTree) (Return Type : TreeNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplateFactory_retrieveEmailTemplateTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveEmailTemplateTree);
            var methodretrieveEmailTemplateTreeParametersTypes = new Type[] { typeof(String), typeof(List<String>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodretrieveEmailTemplateTree, methodretrieveEmailTemplateTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodretrieveEmailTemplateTreeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (retrieveEmailTemplateTree) (Return Type : TreeNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplateFactory_retrieveEmailTemplateTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveEmailTemplateTree);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveEmailTemplateTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (retrieveEmailTemplateTree) (Return Type : TreeNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMergeTemplateFactory_retrieveEmailTemplateTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodretrieveEmailTemplateTree);
            var currentMethodInfo = this.GetMethodInfo(MethodretrieveEmailTemplateTree, 0);
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