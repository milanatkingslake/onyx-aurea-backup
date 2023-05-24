using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.QueryGroup" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\QueryGroup.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class QueryGroupTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryGroup" />)
        /// </summary>
        public QueryGroupTest() : base(typeof(QueryGroup))
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

        #region General Initializer : Class (QueryGroup) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryGroupInstanceType;
        private QueryGroup _queryGroupInstance;
        private QueryGroup _queryGroupInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="QueryGroup" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryGroupInstanceType = typeof(QueryGroup);
            _queryGroupInstanceFixture = this.Create<QueryGroup>(false);
            _queryGroupInstance = _queryGroupInstanceFixture ?? this.Create<QueryGroup>(true);
            CurrentInstance = _queryGroupInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QueryGroup) Initializer

        #region Methods

        private const string MethodGetQueryGroups = "GetQueryGroups";
        private const string MethodCreateQueryGroup = "CreateQueryGroup";
        private const string MethodUpdateQueryGroup = "UpdateQueryGroup";
        private const string MethodDeleteQueryGroup = "DeleteQueryGroup";
        private const string MethodMoveQueryGroup = "MoveQueryGroup";

        #endregion

        #endregion

        #region General Initializer : Class (QueryGroup) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QueryGroup" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryGroup_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QueryGroup)

        #region General Initializer : Class (QueryGroup) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="QueryGroup" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetQueryGroups, 0)]
        [TestCase(MethodCreateQueryGroup, 0)]
        [TestCase(MethodUpdateQueryGroup, 0)]
        [TestCase(MethodDeleteQueryGroup, 0)]
        [TestCase(MethodMoveQueryGroup, 0)]
        public void AUT_QueryGroup_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (QueryGroup) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="QueryGroup" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryGroup_Is_Instance_Present_Test()
        {
            // Assert
            _queryGroupInstanceType.ShouldNotBeNull();
            _queryGroupInstance.ShouldNotBeNull();
            _queryGroupInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (QueryGroup) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryGroup" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryGroup_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _queryGroupInstance.ShouldBeAssignableTo<QueryGroup>();
            _queryGroupInstanceFixture.ShouldBeAssignableTo<QueryGroup>();
            CurrentInstance.ShouldBeAssignableTo<QueryGroup>();
        }

        #endregion

        #region General Constructor : Class (QueryGroup) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QueryGroup_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            QueryGroup instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryGroupInstance.GetQueryGroups(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.GetQueryGroups(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var message = this.CreateType<Message>();
            var methodGetQueryGroupsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetQueryGroups = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryGroups, methodGetQueryGroupsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryGroupInstanceFixture, parametersOfGetQueryGroups);
            var result2 = this.GetResultOfMethod<Message>(MethodGetQueryGroups, parametersOfGetQueryGroups, methodGetQueryGroupsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryGroups.ShouldNotBeNull();
            parametersOfGetQueryGroups.Length.ShouldBe(1);
            methodGetQueryGroupsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var message = this.CreateType<Message>();
            var methodGetQueryGroupsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetQueryGroups = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetQueryGroups, parametersOfGetQueryGroups, methodGetQueryGroupsParametersTypes);

            // Assert
            parametersOfGetQueryGroups.ShouldNotBeNull();
            parametersOfGetQueryGroups.Length.ShouldBe(1);
            methodGetQueryGroupsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var methodGetQueryGroupsParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryGroups, methodGetQueryGroupsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryGroupsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var methodGetQueryGroupsParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryGroups, methodGetQueryGroupsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryGroupsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryGroups, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryGroups, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryGroupInstance.CreateQueryGroup(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.CreateQueryGroup(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var message = this.CreateType<Message>();
            var methodCreateQueryGroupParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCreateQueryGroup = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateQueryGroup, methodCreateQueryGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryGroupInstanceFixture, parametersOfCreateQueryGroup);
            var result2 = this.GetResultOfMethod<Message>(MethodCreateQueryGroup, parametersOfCreateQueryGroup, methodCreateQueryGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateQueryGroup.ShouldNotBeNull();
            parametersOfCreateQueryGroup.Length.ShouldBe(1);
            methodCreateQueryGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var message = this.CreateType<Message>();
            var methodCreateQueryGroupParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCreateQueryGroup = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodCreateQueryGroup, parametersOfCreateQueryGroup, methodCreateQueryGroupParametersTypes);

            // Assert
            parametersOfCreateQueryGroup.ShouldNotBeNull();
            parametersOfCreateQueryGroup.Length.ShouldBe(1);
            methodCreateQueryGroupParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var methodCreateQueryGroupParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateQueryGroup, methodCreateQueryGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateQueryGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var methodCreateQueryGroupParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateQueryGroup, methodCreateQueryGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateQueryGroupParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateQueryGroup, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateQueryGroup, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryGroupInstance.UpdateQueryGroup(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.UpdateQueryGroup(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var message = this.CreateType<Message>();
            var methodUpdateQueryGroupParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfUpdateQueryGroup = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryGroup, methodUpdateQueryGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryGroupInstanceFixture, parametersOfUpdateQueryGroup);
            var result2 = this.GetResultOfMethod<Message>(MethodUpdateQueryGroup, parametersOfUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateQueryGroup.ShouldNotBeNull();
            parametersOfUpdateQueryGroup.Length.ShouldBe(1);
            methodUpdateQueryGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var message = this.CreateType<Message>();
            var methodUpdateQueryGroupParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfUpdateQueryGroup = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodUpdateQueryGroup, parametersOfUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);

            // Assert
            parametersOfUpdateQueryGroup.ShouldNotBeNull();
            parametersOfUpdateQueryGroup.Length.ShouldBe(1);
            methodUpdateQueryGroupParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var methodUpdateQueryGroupParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateQueryGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var methodUpdateQueryGroupParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateQueryGroupParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryGroup, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryGroup, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryGroupInstance.DeleteQueryGroup(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.DeleteQueryGroup(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var message = this.CreateType<Message>();
            var methodDeleteQueryGroupParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfDeleteQueryGroup = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteQueryGroup, methodDeleteQueryGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryGroupInstanceFixture, parametersOfDeleteQueryGroup);
            var result2 = this.GetResultOfMethod<Message>(MethodDeleteQueryGroup, parametersOfDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeleteQueryGroup.ShouldNotBeNull();
            parametersOfDeleteQueryGroup.Length.ShouldBe(1);
            methodDeleteQueryGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var message = this.CreateType<Message>();
            var methodDeleteQueryGroupParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfDeleteQueryGroup = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodDeleteQueryGroup, parametersOfDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);

            // Assert
            parametersOfDeleteQueryGroup.ShouldNotBeNull();
            parametersOfDeleteQueryGroup.Length.ShouldBe(1);
            methodDeleteQueryGroupParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var methodDeleteQueryGroupParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeleteQueryGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var methodDeleteQueryGroupParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteQueryGroupParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteQueryGroup, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteQueryGroup, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryGroupInstance.MoveQueryGroup(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.MoveQueryGroup(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var message = this.CreateType<Message>();
            var methodMoveQueryGroupParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfMoveQueryGroup = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMoveQueryGroup, methodMoveQueryGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryGroupInstanceFixture, parametersOfMoveQueryGroup);
            var result2 = this.GetResultOfMethod<Message>(MethodMoveQueryGroup, parametersOfMoveQueryGroup, methodMoveQueryGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMoveQueryGroup.ShouldNotBeNull();
            parametersOfMoveQueryGroup.Length.ShouldBe(1);
            methodMoveQueryGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var message = this.CreateType<Message>();
            var methodMoveQueryGroupParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfMoveQueryGroup = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodMoveQueryGroup, parametersOfMoveQueryGroup, methodMoveQueryGroupParametersTypes);

            // Assert
            parametersOfMoveQueryGroup.ShouldNotBeNull();
            parametersOfMoveQueryGroup.Length.ShouldBe(1);
            methodMoveQueryGroupParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var methodMoveQueryGroupParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMoveQueryGroup, methodMoveQueryGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMoveQueryGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var methodMoveQueryGroupParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMoveQueryGroup, methodMoveQueryGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMoveQueryGroupParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodMoveQueryGroup, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodMoveQueryGroup, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}