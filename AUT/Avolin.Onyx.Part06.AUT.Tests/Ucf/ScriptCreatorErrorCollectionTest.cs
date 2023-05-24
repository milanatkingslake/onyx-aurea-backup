using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.ScriptCreatorErrorCollection" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptCreatorErrorCollectionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptCreatorErrorCollection" />)
        /// </summary>
        public ScriptCreatorErrorCollectionTest() : base(typeof(ScriptCreatorErrorCollection))
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

        #region General Initializer : Class (ScriptCreatorErrorCollection) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptCreatorErrorCollectionInstanceType;
        private ScriptCreatorErrorCollection _scriptCreatorErrorCollectionInstance;
        private ScriptCreatorErrorCollection _scriptCreatorErrorCollectionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptCreatorErrorCollection" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptCreatorErrorCollectionInstanceType = typeof(ScriptCreatorErrorCollection);
            _scriptCreatorErrorCollectionInstanceFixture = this.Create<ScriptCreatorErrorCollection>(false);
            _scriptCreatorErrorCollectionInstance = _scriptCreatorErrorCollectionInstanceFixture ?? this.Create<ScriptCreatorErrorCollection>(true);
            CurrentInstance = _scriptCreatorErrorCollectionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptCreatorErrorCollection) Initializer

        #region Methods

        private const string MethodAdd = "Add";
        private const string MethodInsert = "Insert";
        private const string MethodRemove = "Remove";
        private const string MethodContains = "Contains";
        private const string MethodIndexOf = "IndexOf";
        private const string MethodCopyTo = "CopyTo";
        private const string MethodToString = "ToString";
        private const string MethodToXmlString = "ToXmlString";
        private const string MethodGetErrorItem = "GetErrorItem";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptCreatorErrorCollection) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptCreatorErrorCollection" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptCreatorErrorCollection_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptCreatorErrorCollection) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptCreatorErrorCollection" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptCreatorErrorCollection_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptCreatorErrorCollection)

        #region General Initializer : Class (ScriptCreatorErrorCollection) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptCreatorErrorCollection" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAdd, 0)]
        [TestCase(MethodInsert, 0)]
        [TestCase(MethodRemove, 0)]
        [TestCase(MethodContains, 0)]
        [TestCase(MethodIndexOf, 0)]
        [TestCase(MethodCopyTo, 0)]
        [TestCase(MethodToString, 0)]
        [TestCase(MethodToXmlString, 0)]
        [TestCase(MethodGetErrorItem, 0)]
        public void AUT_ScriptCreatorErrorCollection_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ScriptCreatorErrorCollection) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptCreatorErrorCollection" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptCreatorErrorCollection_Is_Instance_Present_Test()
        {
            // Assert
            _scriptCreatorErrorCollectionInstanceType.ShouldNotBeNull();
            _scriptCreatorErrorCollectionInstance.ShouldNotBeNull();
            _scriptCreatorErrorCollectionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptCreatorErrorCollection) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptCreatorErrorCollection" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptCreatorErrorCollection_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptCreatorErrorCollectionInstance.ShouldBeAssignableTo<ScriptCreatorErrorCollection>();
            _scriptCreatorErrorCollectionInstanceFixture.ShouldBeAssignableTo<ScriptCreatorErrorCollection>();
            CurrentInstance.ShouldBeAssignableTo<ScriptCreatorErrorCollection>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptCreatorErrorCollection) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptCreatorErrorCollection_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptCreatorErrorCollection instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Add) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var item = this.CreateType<ScriptCreatorError>();

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.Add(item);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var item = this.CreateType<ScriptCreatorError>();
            var methodAddParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfAdd = { item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAdd, methodAddParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_scriptCreatorErrorCollectionInstanceFixture, parametersOfAdd);
            var result2 = this.GetResultOfMethod<int>(MethodAdd, parametersOfAdd, methodAddParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAdd.ShouldNotBeNull();
            parametersOfAdd.Length.ShouldBe(1);
            methodAddParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var item = this.CreateType<ScriptCreatorError>();
            var methodAddParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfAdd = { item };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAdd, methodAddParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_scriptCreatorErrorCollectionInstanceFixture, out exception1, parametersOfAdd);
            var result2 = this.GetResultOfMethod<int>(MethodAdd, parametersOfAdd, methodAddParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAdd.ShouldNotBeNull();
            parametersOfAdd.Length.ShouldBe(1);
            methodAddParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var item = this.CreateType<ScriptCreatorError>();
            var methodAddParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfAdd = { item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAdd, methodAddParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfAdd);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAdd.ShouldNotBeNull();
            parametersOfAdd.Length.ShouldBe(1);
            methodAddParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var item = this.CreateType<ScriptCreatorError>();
            var methodAddParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfAdd = { item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodAdd, parametersOfAdd, methodAddParametersTypes);

            // Assert
            parametersOfAdd.ShouldNotBeNull();
            parametersOfAdd.Length.ShouldBe(1);
            methodAddParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var methodAddParametersTypes = new Type[] { typeof(ScriptCreatorError) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAdd, methodAddParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var methodAddParametersTypes = new Type[] { typeof(ScriptCreatorError) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAdd, methodAddParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAddParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var methodAddParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAdd, methodAddParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var currentMethodInfo = this.GetMethodInfo(MethodAdd, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Add) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Add_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var currentMethodInfo = this.GetMethodInfo(MethodAdd, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCreatorErrorCollection_Insert_Method_Call_Internally(Type[] types)
        {
            var methodInsertParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsert, methodInsertParametersTypes);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Insert_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var index = this.CreateType<int>();
            var item = this.CreateType<ScriptCreatorError>();

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.Insert(index, item);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Insert_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var index = this.CreateType<int>();
            var item = this.CreateType<ScriptCreatorError>();
            var methodInsertParametersTypes = new Type[] { typeof(int), typeof(ScriptCreatorError) };
            object[] parametersOfInsert = { index, item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInsert, methodInsertParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfInsert);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsert.ShouldNotBeNull();
            parametersOfInsert.Length.ShouldBe(2);
            methodInsertParametersTypes.Length.ShouldBe(2);
            methodInsertParametersTypes.Length.ShouldBe(parametersOfInsert.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Insert_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var index = this.CreateType<int>();
            var item = this.CreateType<ScriptCreatorError>();
            var methodInsertParametersTypes = new Type[] { typeof(int), typeof(ScriptCreatorError) };
            object[] parametersOfInsert = { index, item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsert, parametersOfInsert, methodInsertParametersTypes);

            // Assert
            parametersOfInsert.ShouldNotBeNull();
            parametersOfInsert.Length.ShouldBe(2);
            methodInsertParametersTypes.Length.ShouldBe(2);
            methodInsertParametersTypes.Length.ShouldBe(parametersOfInsert.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Insert_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var currentMethodInfo = this.GetMethodInfo(MethodInsert, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Insert_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var methodInsertParametersTypes = new Type[] { typeof(int), typeof(ScriptCreatorError) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsert, methodInsertParametersTypes);

            // Assert
            methodInsertParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Insert) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Insert_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsert);
            var currentMethodInfo = this.GetMethodInfo(MethodInsert, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCreatorErrorCollection_Remove_Method_Call_Internally(Type[] types)
        {
            var methodRemoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Remove_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var item = this.CreateType<ScriptCreatorError>();

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.Remove(item);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Remove_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var item = this.CreateType<ScriptCreatorError>();
            var methodRemoveParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfRemove = { item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, methodRemoveParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfRemove);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(parametersOfRemove.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Remove_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var item = this.CreateType<ScriptCreatorError>();
            var methodRemoveParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfRemove = { item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemove, parametersOfRemove, methodRemoveParametersTypes);

            // Assert
            parametersOfRemove.ShouldNotBeNull();
            parametersOfRemove.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(1);
            methodRemoveParametersTypes.Length.ShouldBe(parametersOfRemove.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Remove_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Remove_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var methodRemoveParametersTypes = new Type[] { typeof(ScriptCreatorError) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);

            // Assert
            methodRemoveParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Remove_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_Internally(Type[] types)
        {
            var methodContainsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodContains, methodContainsParametersTypes);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ScriptCreatorError>();

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.Contains(item);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ScriptCreatorError>();
            var methodContainsParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfContains = { item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodContains, methodContainsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_scriptCreatorErrorCollectionInstanceFixture, parametersOfContains);
            var result2 = this.GetResultOfMethod<bool>(MethodContains, parametersOfContains, methodContainsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContains.ShouldNotBeNull();
            parametersOfContains.Length.ShouldBe(1);
            methodContainsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ScriptCreatorError>();
            var methodContainsParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfContains = { item };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodContains, methodContainsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_scriptCreatorErrorCollectionInstanceFixture, out exception1, parametersOfContains);
            var result2 = this.GetResultOfMethod<bool>(MethodContains, parametersOfContains, methodContainsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContains.ShouldNotBeNull();
            parametersOfContains.Length.ShouldBe(1);
            methodContainsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ScriptCreatorError>();
            var methodContainsParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfContains = { item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodContains, methodContainsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfContains);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfContains.ShouldNotBeNull();
            parametersOfContains.Length.ShouldBe(1);
            methodContainsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var item = this.CreateType<ScriptCreatorError>();
            var methodContainsParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfContains = { item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodContains, parametersOfContains, methodContainsParametersTypes);

            // Assert
            parametersOfContains.ShouldNotBeNull();
            parametersOfContains.Length.ShouldBe(1);
            methodContainsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var methodContainsParametersTypes = new Type[] { typeof(ScriptCreatorError) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContains, methodContainsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodContainsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var methodContainsParametersTypes = new Type[] { typeof(ScriptCreatorError) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContains, methodContainsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodContainsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var methodContainsParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodContains, methodContainsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodContainsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var currentMethodInfo = this.GetMethodInfo(MethodContains, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Contains) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_Contains_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContains);
            var currentMethodInfo = this.GetMethodInfo(MethodContains, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_Internally(Type[] types)
        {
            var methodIndexOfParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIndexOf, methodIndexOfParametersTypes);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ScriptCreatorError>();

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.IndexOf(item);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ScriptCreatorError>();
            var methodIndexOfParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfIndexOf = { item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIndexOf, methodIndexOfParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_scriptCreatorErrorCollectionInstanceFixture, parametersOfIndexOf);
            var result2 = this.GetResultOfMethod<int>(MethodIndexOf, parametersOfIndexOf, methodIndexOfParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIndexOf.ShouldNotBeNull();
            parametersOfIndexOf.Length.ShouldBe(1);
            methodIndexOfParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ScriptCreatorError>();
            var methodIndexOfParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfIndexOf = { item };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIndexOf, methodIndexOfParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_scriptCreatorErrorCollectionInstanceFixture, out exception1, parametersOfIndexOf);
            var result2 = this.GetResultOfMethod<int>(MethodIndexOf, parametersOfIndexOf, methodIndexOfParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIndexOf.ShouldNotBeNull();
            parametersOfIndexOf.Length.ShouldBe(1);
            methodIndexOfParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ScriptCreatorError>();
            var methodIndexOfParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfIndexOf = { item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIndexOf, methodIndexOfParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfIndexOf);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIndexOf.ShouldNotBeNull();
            parametersOfIndexOf.Length.ShouldBe(1);
            methodIndexOfParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var item = this.CreateType<ScriptCreatorError>();
            var methodIndexOfParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            object[] parametersOfIndexOf = { item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodIndexOf, parametersOfIndexOf, methodIndexOfParametersTypes);

            // Assert
            parametersOfIndexOf.ShouldNotBeNull();
            parametersOfIndexOf.Length.ShouldBe(1);
            methodIndexOfParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var methodIndexOfParametersTypes = new Type[] { typeof(ScriptCreatorError) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIndexOf, methodIndexOfParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIndexOfParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var methodIndexOfParametersTypes = new Type[] { typeof(ScriptCreatorError) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIndexOf, methodIndexOfParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIndexOfParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var methodIndexOfParametersTypes = new Type[] { typeof(ScriptCreatorError) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIndexOf, methodIndexOfParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIndexOfParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var currentMethodInfo = this.GetMethodInfo(MethodIndexOf, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IndexOf) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_IndexOf_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndexOf);
            var currentMethodInfo = this.GetMethodInfo(MethodIndexOf, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCreatorErrorCollection_CopyTo_Method_Call_Internally(Type[] types)
        {
            var methodCopyToParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCopyTo, methodCopyToParametersTypes);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_CopyTo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<ScriptCreatorError[]>();
            var index = this.CreateType<int>();

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.CopyTo(array, index);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_CopyTo_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<ScriptCreatorError[]>();
            var index = this.CreateType<int>();
            var methodCopyToParametersTypes = new Type[] { typeof(ScriptCreatorError[]), typeof(int) };
            object[] parametersOfCopyTo = { array, index };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCopyTo, methodCopyToParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfCopyTo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCopyTo.ShouldNotBeNull();
            parametersOfCopyTo.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(parametersOfCopyTo.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_CopyTo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<ScriptCreatorError[]>();
            var index = this.CreateType<int>();
            var methodCopyToParametersTypes = new Type[] { typeof(ScriptCreatorError[]), typeof(int) };
            object[] parametersOfCopyTo = { array, index };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCopyTo, parametersOfCopyTo, methodCopyToParametersTypes);

            // Assert
            parametersOfCopyTo.ShouldNotBeNull();
            parametersOfCopyTo.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(parametersOfCopyTo.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_CopyTo_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var currentMethodInfo = this.GetMethodInfo(MethodCopyTo, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_CopyTo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var methodCopyToParametersTypes = new Type[] { typeof(ScriptCreatorError[]), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCopyTo, methodCopyToParametersTypes);

            // Assert
            methodCopyToParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_CopyTo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var currentMethodInfo = this.GetMethodInfo(MethodCopyTo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCreatorErrorCollection_ToString_Method_Call_Internally(Type[] types)
        {
            var methodToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.ToString();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToString_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _scriptCreatorErrorCollectionInstance.ToString();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_scriptCreatorErrorCollectionInstanceFixture, out exception1, parametersOfToString);
            var result2 = this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var currentMethodInfo = this.GetMethodInfo(MethodToString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_Call_Internally(Type[] types)
        {
            var methodToXmlStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodToXmlString, methodToXmlStringParametersTypes);
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlString);

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.ToXmlString();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlString);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _scriptCreatorErrorCollectionInstance.ToXmlString();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlString);
            Type [] methodToXmlStringParametersTypes = null;
            object[] parametersOfToXmlString = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodToXmlString, methodToXmlStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_scriptCreatorErrorCollectionInstanceFixture, out exception1, parametersOfToXmlString);
            var result2 = this.GetResultOfMethod<string>(MethodToXmlString, parametersOfToXmlString, methodToXmlStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfToXmlString.ShouldBeNull();
            methodToXmlStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlString);
            Type [] methodToXmlStringParametersTypes = null;
            object[] parametersOfToXmlString = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToXmlString, methodToXmlStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfToXmlString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfToXmlString.ShouldBeNull();
            methodToXmlStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlString);
            Type [] methodToXmlStringParametersTypes = null;
            object[] parametersOfToXmlString = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodToXmlString, parametersOfToXmlString, methodToXmlStringParametersTypes);

            // Assert
            parametersOfToXmlString.ShouldBeNull();
            methodToXmlStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlString);
            Type [] methodToXmlStringParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToXmlString, methodToXmlStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodToXmlStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlString);
            Type [] methodToXmlStringParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodToXmlString, methodToXmlStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodToXmlStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToXmlString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_ToXmlString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToXmlString);
            var currentMethodInfo = this.GetMethodInfo(MethodToXmlString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_Call_Internally(Type[] types)
        {
            var methodGetErrorItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetErrorItem, methodGetErrorItemParametersTypes);
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var errorIndex = this.CreateType<int>();

            // Act
            Action executeAction = () => _scriptCreatorErrorCollectionInstance.GetErrorItem(errorIndex);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var errorIndex = this.CreateType<int>();
            var returnedValue = default(ScriptCreatorError);

            // Act
            Action executeAction = () => returnedValue = _scriptCreatorErrorCollectionInstance.GetErrorItem(errorIndex);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var errorIndex = this.CreateType<int>();
            var methodGetErrorItemParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetErrorItem = { errorIndex };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetErrorItem, methodGetErrorItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ScriptCreatorError>(_scriptCreatorErrorCollectionInstanceFixture, out exception1, parametersOfGetErrorItem);
            var result2 = this.GetResultOfMethod<ScriptCreatorError>(MethodGetErrorItem, parametersOfGetErrorItem, methodGetErrorItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetErrorItem.ShouldNotBeNull();
            parametersOfGetErrorItem.Length.ShouldBe(1);
            methodGetErrorItemParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var errorIndex = this.CreateType<int>();
            var methodGetErrorItemParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetErrorItem = { errorIndex };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetErrorItem, methodGetErrorItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptCreatorErrorCollectionInstanceFixture, parametersOfGetErrorItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetErrorItem.ShouldNotBeNull();
            parametersOfGetErrorItem.Length.ShouldBe(1);
            methodGetErrorItemParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var errorIndex = this.CreateType<int>();
            var methodGetErrorItemParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetErrorItem = { errorIndex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ScriptCreatorError>(MethodGetErrorItem, parametersOfGetErrorItem, methodGetErrorItemParametersTypes);

            // Assert
            parametersOfGetErrorItem.ShouldNotBeNull();
            parametersOfGetErrorItem.Length.ShouldBe(1);
            methodGetErrorItemParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var methodGetErrorItemParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetErrorItem, methodGetErrorItemParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetErrorItemParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var methodGetErrorItemParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetErrorItem, methodGetErrorItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetErrorItemParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetErrorItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetErrorItem) (Return Type : ScriptCreatorError) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptCreatorErrorCollection_GetErrorItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetErrorItem);
            var currentMethodInfo = this.GetMethodInfo(MethodGetErrorItem, 0);
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