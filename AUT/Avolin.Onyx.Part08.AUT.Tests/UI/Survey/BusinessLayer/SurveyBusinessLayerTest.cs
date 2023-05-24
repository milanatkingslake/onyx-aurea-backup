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
using Onyx.UI.Survey.BusinessLayer;
using Onyx.UI.Survey.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Survey.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Survey.BusinessLayer.SurveyBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Survey.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SurveyBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SurveyBusinessLayer" />)
        /// </summary>
        public SurveyBusinessLayerTest() : base(typeof(SurveyBusinessLayer))
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

        #region General Initializer : Class (SurveyBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _surveyBusinessLayerInstanceType;
        private SurveyBusinessLayer _surveyBusinessLayerInstance;
        private SurveyBusinessLayer _surveyBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SurveyBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _surveyBusinessLayerInstanceType = typeof(SurveyBusinessLayer);
            _surveyBusinessLayerInstanceFixture = this.Create<SurveyBusinessLayer>(false);
            _surveyBusinessLayerInstance = _surveyBusinessLayerInstanceFixture ?? this.Create<SurveyBusinessLayer>(true);
            CurrentInstance = _surveyBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SurveyBusinessLayer) Initializer

        #region Methods

        private const string MethodGetSurvey = "GetSurvey";
        private const string MethodDeleteSurvey = "DeleteSurvey";
        private const string MethodUpdateSurvey = "UpdateSurvey";
        private const string MethodGetSecurityResources = "GetSecurityResources";

        #endregion

        #endregion

        #region General Initializer : Class (SurveyBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SurveyBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SurveyBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SurveyBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SurveyBusinessLayer)

        #region General Initializer : Class (SurveyBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SurveyBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSurvey, 0)]
        [TestCase(MethodDeleteSurvey, 0)]
        [TestCase(MethodUpdateSurvey, 0)]
        [TestCase(MethodGetSecurityResources, 0)]
        public void AUT_SurveyBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (SurveyBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SurveyBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _surveyBusinessLayerInstanceType.ShouldNotBeNull();
            _surveyBusinessLayerInstance.ShouldNotBeNull();
            _surveyBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SurveyBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SurveyBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _surveyBusinessLayerInstance.ShouldBeAssignableTo<SurveyBusinessLayer>();
            _surveyBusinessLayerInstanceFixture.ShouldBeAssignableTo<SurveyBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<SurveyBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SurveyBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SurveyBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetSurvey) (Return Type : SurveyOwnerAssociation) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSurvey_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var surveyId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _surveyBusinessLayerInstance.GetSurvey(surveyId, ownerId, ownerType, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : SurveyOwnerAssociation) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSurvey_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var surveyId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(SurveyOwnerAssociation);

            // Act
            Action executeAction = () => returnedValue = _surveyBusinessLayerInstance.GetSurvey(surveyId, ownerId, ownerType, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : SurveyOwnerAssociation) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSurvey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var surveyId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetSurveyParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetSurvey = { surveyId, ownerId, ownerType, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSurvey, methodGetSurveyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<SurveyOwnerAssociation>(_surveyBusinessLayerInstanceFixture, parametersOfGetSurvey);
            var result2 = this.GetResultOfMethod<SurveyOwnerAssociation>(MethodGetSurvey, parametersOfGetSurvey, methodGetSurveyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSurvey.ShouldNotBeNull();
            parametersOfGetSurvey.Length.ShouldBe(4);
            methodGetSurveyParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : SurveyOwnerAssociation) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSurvey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var surveyId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetSurveyParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetSurvey = { surveyId, ownerId, ownerType, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SurveyOwnerAssociation>(MethodGetSurvey, parametersOfGetSurvey, methodGetSurveyParametersTypes);

            // Assert
            parametersOfGetSurvey.ShouldNotBeNull();
            parametersOfGetSurvey.Length.ShouldBe(4);
            methodGetSurveyParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : SurveyOwnerAssociation) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSurvey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var methodGetSurveyParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSurvey, methodGetSurveyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSurveyParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : SurveyOwnerAssociation) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSurvey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var methodGetSurveyParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSurvey, methodGetSurveyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSurveyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : SurveyOwnerAssociation) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSurvey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSurvey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : SurveyOwnerAssociation) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSurvey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSurvey, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SurveyBusinessLayer_DeleteSurvey_Method_Call_Internally(Type[] types)
        {
            var methodDeleteSurveyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteSurvey, methodDeleteSurveyParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _surveyBusinessLayerInstance.DeleteSurvey(surveyOwnerAssociation, messageModels);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _surveyBusinessLayerInstance.DeleteSurvey(surveyOwnerAssociation, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };
            object[] parametersOfDeleteSurvey = { surveyOwnerAssociation, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSurvey, methodDeleteSurveyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_surveyBusinessLayerInstanceFixture, parametersOfDeleteSurvey);
            var result2 = this.GetResultOfMethod<string>(MethodDeleteSurvey, parametersOfDeleteSurvey, methodDeleteSurveyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeleteSurvey.ShouldNotBeNull();
            parametersOfDeleteSurvey.Length.ShouldBe(2);
            methodDeleteSurveyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };
            object[] parametersOfDeleteSurvey = { surveyOwnerAssociation, messageModels };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSurvey, methodDeleteSurveyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_surveyBusinessLayerInstanceFixture, parametersOfDeleteSurvey);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteSurvey.ShouldNotBeNull();
            parametersOfDeleteSurvey.Length.ShouldBe(2);
            methodDeleteSurveyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };
            object[] parametersOfDeleteSurvey = { surveyOwnerAssociation, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDeleteSurvey, parametersOfDeleteSurvey, methodDeleteSurveyParametersTypes);

            // Assert
            parametersOfDeleteSurvey.ShouldNotBeNull();
            parametersOfDeleteSurvey.Length.ShouldBe(2);
            methodDeleteSurveyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteSurvey, methodDeleteSurveyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeleteSurveyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteSurvey, methodDeleteSurveyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteSurveyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSurvey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_DeleteSurvey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSurvey, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SurveyBusinessLayer_UpdateSurvey_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSurveyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSurvey, methodUpdateSurveyParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_UpdateSurvey_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _surveyBusinessLayerInstance.UpdateSurvey(surveyOwnerAssociation, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_UpdateSurvey_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(SurveyOwnerAssociation);

            // Act
            Action executeAction = () => returnedValue = _surveyBusinessLayerInstance.UpdateSurvey(surveyOwnerAssociation, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_UpdateSurvey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodUpdateSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };
            object[] parametersOfUpdateSurvey = { surveyOwnerAssociation, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSurvey, methodUpdateSurveyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<SurveyOwnerAssociation>(_surveyBusinessLayerInstanceFixture, parametersOfUpdateSurvey);
            var result2 = this.GetResultOfMethod<SurveyOwnerAssociation>(MethodUpdateSurvey, parametersOfUpdateSurvey, methodUpdateSurveyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateSurvey.ShouldNotBeNull();
            parametersOfUpdateSurvey.Length.ShouldBe(2);
            methodUpdateSurveyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_UpdateSurvey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodUpdateSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };
            object[] parametersOfUpdateSurvey = { surveyOwnerAssociation, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SurveyOwnerAssociation>(MethodUpdateSurvey, parametersOfUpdateSurvey, methodUpdateSurveyParametersTypes);

            // Assert
            parametersOfUpdateSurvey.ShouldNotBeNull();
            parametersOfUpdateSurvey.Length.ShouldBe(2);
            methodUpdateSurveyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_UpdateSurvey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var methodUpdateSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateSurvey, methodUpdateSurveyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateSurveyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_UpdateSurvey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var methodUpdateSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSurvey, methodUpdateSurveyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSurveyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_UpdateSurvey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSurvey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : SurveyOwnerAssociation) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_UpdateSurvey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSurvey, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SurveyBusinessLayer_GetSecurityResources_Method_Call_Internally(Type[] types)
        {
            var methodGetSecurityResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSecurityResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _surveyBusinessLayerInstance.GetSecurityResources(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSecurityResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IDictionary<string, string>);

            // Act
            Action executeAction = () => returnedValue = _surveyBusinessLayerInstance.GetSecurityResources(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSecurityResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetSecurityResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetSecurityResources = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IDictionary<string, string>>(_surveyBusinessLayerInstanceFixture, parametersOfGetSecurityResources);
            var result2 = this.GetResultOfMethod<IDictionary<string, string>>(MethodGetSecurityResources, parametersOfGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSecurityResources.ShouldNotBeNull();
            parametersOfGetSecurityResources.Length.ShouldBe(1);
            methodGetSecurityResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSecurityResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetSecurityResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetSecurityResources = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IDictionary<string, string>>(MethodGetSecurityResources, parametersOfGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            parametersOfGetSecurityResources.ShouldNotBeNull();
            parametersOfGetSecurityResources.Length.ShouldBe(1);
            methodGetSecurityResourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSecurityResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var methodGetSecurityResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSecurityResourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSecurityResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var methodGetSecurityResourcesParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSecurityResourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSecurityResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IDictionary<string, string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyBusinessLayer_GetSecurityResources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, 0);
            const int parametersCount = 1;

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