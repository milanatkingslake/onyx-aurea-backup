using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.QueryGroup" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
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

        private const string MethodCreateQueryGroup = "CreateQueryGroup";
        private const string MethodUpdateQueryGroup = "UpdateQueryGroup";
        private const string MethodDeleteQueryGroup = "DeleteQueryGroup";
        private const string MethodDeleteFolder = "DeleteFolder";
        private const string MethodGetQueryGroups = "GetQueryGroups";
        private const string MethodMoveQueryGroup = "MoveQueryGroup";
        private const string MethodUpdateSubFolders = "UpdateSubFolders";
        private const string MethodGetProtectionMode = "GetProtectionMode";
        private const string MethodGetRootFolder = "GetRootFolder";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";

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

        #region General Initializer : Class (QueryGroup) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QueryGroup" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryGroup_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

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
        [TestCase(MethodCreateQueryGroup, 0)]
        [TestCase(MethodUpdateQueryGroup, 0)]
        [TestCase(MethodDeleteQueryGroup, 0)]
        [TestCase(MethodDeleteFolder, 0)]
        [TestCase(MethodGetQueryGroups, 0)]
        [TestCase(MethodMoveQueryGroup, 0)]
        [TestCase(MethodUpdateSubFolders, 0)]
        [TestCase(MethodGetProtectionMode, 0)]
        [TestCase(MethodGetRootFolder, 0)]
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

        #region General Initializer : Class (QueryGroup) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryGroup" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [Category("AUT Fields")]
        public void AUT_QueryGroup_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #region Category : Instance

        #region General Instance : Class (QueryGroup) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryGroup" />) instance type verify test.
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

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CreateQueryGroup) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);

            // Act
            Action executeAction = () => _queryGroupInstance.CreateQueryGroup();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.CreateQueryGroup();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            Type [] methodCreateQueryGroupParametersTypes = null;
            object[] parametersOfCreateQueryGroup = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateQueryGroup, methodCreateQueryGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryGroupInstanceFixture, parametersOfCreateQueryGroup);
            var result2 = this.GetResultOfMethod<string>(MethodCreateQueryGroup, parametersOfCreateQueryGroup, methodCreateQueryGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateQueryGroup.ShouldBeNull();
            methodCreateQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            Type [] methodCreateQueryGroupParametersTypes = null;
            object[] parametersOfCreateQueryGroup = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateQueryGroup, parametersOfCreateQueryGroup, methodCreateQueryGroupParametersTypes);

            // Assert
            parametersOfCreateQueryGroup.ShouldBeNull();
            methodCreateQueryGroupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            Type [] methodCreateQueryGroupParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateQueryGroup, methodCreateQueryGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_CreateQueryGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQueryGroup);
            Type [] methodCreateQueryGroupParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateQueryGroup, methodCreateQueryGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQueryGroup) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (UpdateQueryGroup) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryGroup_UpdateQueryGroup_Method_Call_Internally(Type[] types)
        {
            var methodUpdateQueryGroupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);

            // Act
            Action executeAction = () => _queryGroupInstance.UpdateQueryGroup();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.UpdateQueryGroup();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            Type [] methodUpdateQueryGroupParametersTypes = null;
            object[] parametersOfUpdateQueryGroup = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryGroup, methodUpdateQueryGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryGroupInstanceFixture, parametersOfUpdateQueryGroup);
            var result2 = this.GetResultOfMethod<string>(MethodUpdateQueryGroup, parametersOfUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateQueryGroup.ShouldBeNull();
            methodUpdateQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            Type [] methodUpdateQueryGroupParametersTypes = null;
            object[] parametersOfUpdateQueryGroup = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdateQueryGroup, parametersOfUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);

            // Assert
            parametersOfUpdateQueryGroup.ShouldBeNull();
            methodUpdateQueryGroupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            Type [] methodUpdateQueryGroupParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateQueryGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryGroup);
            Type [] methodUpdateQueryGroupParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateQueryGroup, methodUpdateQueryGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQueryGroup) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (DeleteQueryGroup) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryGroup_DeleteQueryGroup_Method_Call_Internally(Type[] types)
        {
            var methodDeleteQueryGroupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);

            // Act
            Action executeAction = () => _queryGroupInstance.DeleteQueryGroup();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.DeleteQueryGroup();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            Type [] methodDeleteQueryGroupParametersTypes = null;
            object[] parametersOfDeleteQueryGroup = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteQueryGroup, methodDeleteQueryGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryGroupInstanceFixture, parametersOfDeleteQueryGroup);
            var result2 = this.GetResultOfMethod<string>(MethodDeleteQueryGroup, parametersOfDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeleteQueryGroup.ShouldBeNull();
            methodDeleteQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            Type [] methodDeleteQueryGroupParametersTypes = null;
            object[] parametersOfDeleteQueryGroup = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDeleteQueryGroup, parametersOfDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);

            // Assert
            parametersOfDeleteQueryGroup.ShouldBeNull();
            methodDeleteQueryGroupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            Type [] methodDeleteQueryGroupParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeleteQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteQueryGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQueryGroup);
            Type [] methodDeleteQueryGroupParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteQueryGroup, methodDeleteQueryGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQueryGroup) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (DeleteFolder) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryGroup_DeleteFolder_Method_Call_Internally(Type[] types)
        {
            var methodDeleteFolderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteFolder, methodDeleteFolderParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteFolder_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var folderId = this.CreateType<Guid>();
            var methodDeleteFolderParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfDeleteFolder = { folderId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFolder, methodDeleteFolderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryGroupInstanceFixture, parametersOfDeleteFolder);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteFolder.ShouldNotBeNull();
            parametersOfDeleteFolder.Length.ShouldBe(1);
            methodDeleteFolderParametersTypes.Length.ShouldBe(1);
            methodDeleteFolderParametersTypes.Length.ShouldBe(parametersOfDeleteFolder.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteFolder_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var folderId = this.CreateType<Guid>();
            var methodDeleteFolderParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfDeleteFolder = { folderId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteFolder, parametersOfDeleteFolder, methodDeleteFolderParametersTypes);

            // Assert
            parametersOfDeleteFolder.ShouldNotBeNull();
            parametersOfDeleteFolder.Length.ShouldBe(1);
            methodDeleteFolderParametersTypes.Length.ShouldBe(1);
            methodDeleteFolderParametersTypes.Length.ShouldBe(parametersOfDeleteFolder.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteFolder_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFolder, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteFolder_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var methodDeleteFolderParametersTypes = new Type[] { typeof(Guid) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteFolder, methodDeleteFolderParametersTypes);

            // Assert
            methodDeleteFolderParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_DeleteFolder_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFolder, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryGroup_GetQueryGroups_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryGroupsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryGroups, methodGetQueryGroupsParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);

            // Act
            Action executeAction = () => _queryGroupInstance.GetQueryGroups();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.GetQueryGroups();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            Type [] methodGetQueryGroupsParametersTypes = null;
            object[] parametersOfGetQueryGroups = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryGroups, methodGetQueryGroupsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryGroupInstanceFixture, parametersOfGetQueryGroups);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryGroups, parametersOfGetQueryGroups, methodGetQueryGroupsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryGroups.ShouldBeNull();
            methodGetQueryGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            Type [] methodGetQueryGroupsParametersTypes = null;
            object[] parametersOfGetQueryGroups = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryGroups, parametersOfGetQueryGroups, methodGetQueryGroupsParametersTypes);

            // Assert
            parametersOfGetQueryGroups.ShouldBeNull();
            methodGetQueryGroupsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            Type [] methodGetQueryGroupsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryGroups, methodGetQueryGroupsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetQueryGroups_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryGroups);
            Type [] methodGetQueryGroupsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryGroups, methodGetQueryGroupsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryGroupsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryGroups) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (MoveQueryGroup) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryGroup_MoveQueryGroup_Method_Call_Internally(Type[] types)
        {
            var methodMoveQueryGroupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMoveQueryGroup, methodMoveQueryGroupParametersTypes);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);

            // Act
            Action executeAction = () => _queryGroupInstance.MoveQueryGroup();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryGroupInstance.MoveQueryGroup();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            Type [] methodMoveQueryGroupParametersTypes = null;
            object[] parametersOfMoveQueryGroup = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMoveQueryGroup, methodMoveQueryGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryGroupInstanceFixture, parametersOfMoveQueryGroup);
            var result2 = this.GetResultOfMethod<string>(MethodMoveQueryGroup, parametersOfMoveQueryGroup, methodMoveQueryGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMoveQueryGroup.ShouldBeNull();
            methodMoveQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            Type [] methodMoveQueryGroupParametersTypes = null;
            object[] parametersOfMoveQueryGroup = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMoveQueryGroup, parametersOfMoveQueryGroup, methodMoveQueryGroupParametersTypes);

            // Assert
            parametersOfMoveQueryGroup.ShouldBeNull();
            methodMoveQueryGroupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            Type [] methodMoveQueryGroupParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMoveQueryGroup, methodMoveQueryGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMoveQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_MoveQueryGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQueryGroup);
            Type [] methodMoveQueryGroupParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMoveQueryGroup, methodMoveQueryGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMoveQueryGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQueryGroup) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (UpdateSubFolders) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryGroup_UpdateSubFolders_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSubFoldersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSubFolders, methodUpdateSubFoldersParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSubFolders) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateSubFolders_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubFolders);
            var folderId = this.CreateType<Guid>();
            var protectionMode = this.CreateType<bool>();
            var userId = this.CreateType<string>();
            var methodUpdateSubFoldersParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(string) };
            object[] parametersOfUpdateSubFolders = { folderId, protectionMode, userId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubFolders, methodUpdateSubFoldersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryGroupInstanceFixture, parametersOfUpdateSubFolders);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateSubFolders.ShouldNotBeNull();
            parametersOfUpdateSubFolders.Length.ShouldBe(3);
            methodUpdateSubFoldersParametersTypes.Length.ShouldBe(3);
            methodUpdateSubFoldersParametersTypes.Length.ShouldBe(parametersOfUpdateSubFolders.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSubFolders) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateSubFolders_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubFolders);
            var folderId = this.CreateType<Guid>();
            var protectionMode = this.CreateType<bool>();
            var userId = this.CreateType<string>();
            var methodUpdateSubFoldersParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(string) };
            object[] parametersOfUpdateSubFolders = { folderId, protectionMode, userId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateSubFolders, parametersOfUpdateSubFolders, methodUpdateSubFoldersParametersTypes);

            // Assert
            parametersOfUpdateSubFolders.ShouldNotBeNull();
            parametersOfUpdateSubFolders.Length.ShouldBe(3);
            methodUpdateSubFoldersParametersTypes.Length.ShouldBe(3);
            methodUpdateSubFoldersParametersTypes.Length.ShouldBe(parametersOfUpdateSubFolders.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSubFolders) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateSubFolders_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubFolders);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubFolders, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSubFolders) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateSubFolders_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubFolders);
            var methodUpdateSubFoldersParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSubFolders, methodUpdateSubFoldersParametersTypes);

            // Assert
            methodUpdateSubFoldersParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSubFolders) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_UpdateSubFolders_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubFolders);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubFolders, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryGroup_GetProtectionMode_Method_Call_Internally(Type[] types)
        {
            var methodGetProtectionModeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProtectionMode, methodGetProtectionModeParametersTypes);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetProtectionMode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var folderId = this.CreateType<string>();
            var methodGetProtectionModeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProtectionMode = { folderId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProtectionMode, methodGetProtectionModeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryGroupInstanceFixture, parametersOfGetProtectionMode);
            var result2 = this.GetResultOfMethod<bool>(MethodGetProtectionMode, parametersOfGetProtectionMode, methodGetProtectionModeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetProtectionMode.ShouldNotBeNull();
            parametersOfGetProtectionMode.Length.ShouldBe(1);
            methodGetProtectionModeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetProtectionMode_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var folderId = this.CreateType<string>();
            var methodGetProtectionModeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProtectionMode = { folderId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProtectionMode, methodGetProtectionModeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryGroupInstanceFixture, out exception1, parametersOfGetProtectionMode);
            var result2 = this.GetResultOfMethod<bool>(MethodGetProtectionMode, parametersOfGetProtectionMode, methodGetProtectionModeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetProtectionMode.ShouldNotBeNull();
            parametersOfGetProtectionMode.Length.ShouldBe(1);
            methodGetProtectionModeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetProtectionMode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var folderId = this.CreateType<string>();
            var methodGetProtectionModeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProtectionMode = { folderId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetProtectionMode, parametersOfGetProtectionMode, methodGetProtectionModeParametersTypes);

            // Assert
            parametersOfGetProtectionMode.ShouldNotBeNull();
            parametersOfGetProtectionMode.Length.ShouldBe(1);
            methodGetProtectionModeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetProtectionMode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var methodGetProtectionModeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProtectionMode, methodGetProtectionModeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProtectionModeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetProtectionMode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProtectionMode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetProtectionMode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProtectionMode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryGroup_GetRootFolder_Method_Call_Internally(Type[] types)
        {
            var methodGetRootFolderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRootFolder, methodGetRootFolderParametersTypes);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetRootFolder_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var folderId = this.CreateType<string>();
            var methodGetRootFolderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRootFolder = { folderId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootFolder, methodGetRootFolderParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryGroupInstanceFixture, parametersOfGetRootFolder);
            var result2 = this.GetResultOfMethod<string>(MethodGetRootFolder, parametersOfGetRootFolder, methodGetRootFolderParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRootFolder.ShouldNotBeNull();
            parametersOfGetRootFolder.Length.ShouldBe(1);
            methodGetRootFolderParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetRootFolder_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var folderId = this.CreateType<string>();
            var methodGetRootFolderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRootFolder = { folderId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRootFolder, parametersOfGetRootFolder, methodGetRootFolderParametersTypes);

            // Assert
            parametersOfGetRootFolder.ShouldNotBeNull();
            parametersOfGetRootFolder.Length.ShouldBe(1);
            methodGetRootFolderParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetRootFolder_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var methodGetRootFolderParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRootFolder, methodGetRootFolderParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRootFolderParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetRootFolder_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var methodGetRootFolderParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRootFolder, methodGetRootFolderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRootFolderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetRootFolder_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootFolder, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryGroup_GetRootFolder_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootFolder, 0);
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