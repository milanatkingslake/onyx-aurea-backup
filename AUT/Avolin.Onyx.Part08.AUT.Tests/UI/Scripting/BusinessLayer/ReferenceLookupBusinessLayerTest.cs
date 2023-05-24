using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.BusinessLayer;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.ReferenceLookupBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReferenceLookupBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReferenceLookupBusinessLayer" />)
        /// </summary>
        public ReferenceLookupBusinessLayerTest() : base(typeof(ReferenceLookupBusinessLayer))
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

        #region General Initializer : Class (ReferenceLookupBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _referenceLookupBusinessLayerInstanceType;
        private ReferenceLookupBusinessLayer _referenceLookupBusinessLayerInstance;
        private ReferenceLookupBusinessLayer _referenceLookupBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReferenceLookupBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _referenceLookupBusinessLayerInstanceType = typeof(ReferenceLookupBusinessLayer);
            _referenceLookupBusinessLayerInstanceFixture = this.Create<ReferenceLookupBusinessLayer>(false);
            _referenceLookupBusinessLayerInstance = _referenceLookupBusinessLayerInstanceFixture ?? this.Create<ReferenceLookupBusinessLayer>(true);
            CurrentInstance = _referenceLookupBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupBusinessLayer) Initializer

        #region Methods

        private const string MethodRetreiveList = "RetreiveList";

        #endregion

        #endregion

        #region General Initializer : Class (ReferenceLookupBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ReferenceLookupBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ReferenceLookupBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReferenceLookupBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ReferenceLookupBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ReferenceLookupBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ReferenceLookupBusinessLayer)

        #region General Initializer : Class (ReferenceLookupBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ReferenceLookupBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRetreiveList, 0)]
        public void AUT_ReferenceLookupBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ReferenceLookupBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ReferenceLookupBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReferenceLookupBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _referenceLookupBusinessLayerInstanceType.ShouldNotBeNull();
            _referenceLookupBusinessLayerInstance.ShouldNotBeNull();
            _referenceLookupBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ReferenceLookupBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ReferenceLookupBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ReferenceLookupBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _referenceLookupBusinessLayerInstance.ShouldBeAssignableTo<ReferenceLookupBusinessLayer>();
            _referenceLookupBusinessLayerInstanceFixture.ShouldBeAssignableTo<ReferenceLookupBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<ReferenceLookupBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ReferenceLookupBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ReferenceLookupBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ReferenceLookupBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (RetreiveList) (Return Type : IList<ReferenceLookupModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupBusinessLayer_RetreiveList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var name = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _referenceLookupBusinessLayerInstance.RetreiveList(name, parentId, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IList<ReferenceLookupModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupBusinessLayer_RetreiveList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var name = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<ReferenceLookupModel>);

            // Act
            Action executeAction = () => returnedValue = _referenceLookupBusinessLayerInstance.RetreiveList(name, parentId, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IList<ReferenceLookupModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupBusinessLayer_RetreiveList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var name = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodRetreiveListParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfRetreiveList = { name, parentId, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetreiveList, methodRetreiveListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ReferenceLookupModel>>(_referenceLookupBusinessLayerInstanceFixture, parametersOfRetreiveList);
            var result2 = this.GetResultOfMethod<IList<ReferenceLookupModel>>(MethodRetreiveList, parametersOfRetreiveList, methodRetreiveListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetreiveList.ShouldNotBeNull();
            parametersOfRetreiveList.Length.ShouldBe(3);
            methodRetreiveListParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IList<ReferenceLookupModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupBusinessLayer_RetreiveList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var name = this.CreateType<string>();
            var parentId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodRetreiveListParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfRetreiveList = { name, parentId, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ReferenceLookupModel>>(MethodRetreiveList, parametersOfRetreiveList, methodRetreiveListParametersTypes);

            // Assert
            parametersOfRetreiveList.ShouldNotBeNull();
            parametersOfRetreiveList.Length.ShouldBe(3);
            methodRetreiveListParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IList<ReferenceLookupModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupBusinessLayer_RetreiveList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var methodRetreiveListParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetreiveList, methodRetreiveListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetreiveListParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IList<ReferenceLookupModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupBusinessLayer_RetreiveList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var methodRetreiveListParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetreiveList, methodRetreiveListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetreiveListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IList<ReferenceLookupModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupBusinessLayer_RetreiveList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var currentMethodInfo = this.GetMethodInfo(MethodRetreiveList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetreiveList) (Return Type : IList<ReferenceLookupModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReferenceLookupBusinessLayer_RetreiveList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetreiveList);
            var currentMethodInfo = this.GetMethodInfo(MethodRetreiveList, 0);
            const int parametersCount = 3;

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