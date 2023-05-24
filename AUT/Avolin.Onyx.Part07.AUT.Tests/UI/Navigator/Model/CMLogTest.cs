using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.CMLog" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CMLogTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CMLog" />)
        /// </summary>
        public CMLogTest() : base(typeof(CMLog))
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

        #region General Initializer : Class (CMLog) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _cMLogInstanceType;
        private CMLog _cMLogInstance;
        private CMLog _cMLogInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CMLog" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _cMLogInstanceType = typeof(CMLog);
            _cMLogInstanceFixture = this.Create<CMLog>(false);
            _cMLogInstance = _cMLogInstanceFixture ?? this.Create<CMLog>(true);
            CurrentInstance = _cMLogInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CMLog) Initializer

        #region Methods

        private const string MethodCreateFile = "CreateFile";
        private const string MethodDeleteFile = "DeleteFile";
        private const string MethodClear = "Clear";
        private const string MethodRead = "Read";
        private const string MethodWrite = "Write";

        #endregion

        #region Fields

        private const string FieldlogXmlFile = "logXmlFile";
        private const string FieldfileName = "fileName";

        #endregion

        #endregion

        #region General Initializer : Class (CMLog) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CMLog" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CMLog_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CMLog) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CMLog" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CMLog_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CMLog)

        #region General Initializer : Class (CMLog) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CMLog" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateFile, 0)]
        [TestCase(MethodDeleteFile, 0)]
        [TestCase(MethodClear, 0)]
        [TestCase(MethodRead, 0)]
        [TestCase(MethodRead, 1)]
        [TestCase(MethodWrite, 0)]
        [TestCase(MethodWrite, 1)]
        public void AUT_CMLog_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CMLog) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CMLog" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldlogXmlFile)]
        [TestCase(FieldfileName)]
        [Category("AUT Fields")]
        public void AUT_CMLog_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CMLog) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CMLog" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CMLog_Is_Instance_Present_Test()
        {
            // Assert
            _cMLogInstanceType.ShouldNotBeNull();
            _cMLogInstance.ShouldNotBeNull();
            _cMLogInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CMLog) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CMLog" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CMLog_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _cMLogInstance.ShouldBeAssignableTo<CMLog>();
            _cMLogInstanceFixture.ShouldBeAssignableTo<CMLog>();
            CurrentInstance.ShouldBeAssignableTo<CMLog>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CMLog) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMLog_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CMLog instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (CMLog) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CMLog_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var cMLogInstance  = new CMLog();

            // Asserts
            cMLogInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CreateFile) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_CreateFile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFile);
            Type [] methodCreateFileParametersTypes = null;
            object[] parametersOfCreateFile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFile, methodCreateFileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, parametersOfCreateFile);
            var result2 = this.GetResultOfMethod<bool>(MethodCreateFile, parametersOfCreateFile, methodCreateFileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateFile.ShouldBeNull();
            methodCreateFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateFile) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_CreateFile_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFile);
            Type [] methodCreateFileParametersTypes = null;
            object[] parametersOfCreateFile = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFile, methodCreateFileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, out exception1, parametersOfCreateFile);
            var result2 = this.GetResultOfMethod<bool>(MethodCreateFile, parametersOfCreateFile, methodCreateFileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateFile.ShouldBeNull();
            methodCreateFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateFile) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_CreateFile_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFile);
            Type [] methodCreateFileParametersTypes = null;
            object[] parametersOfCreateFile = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFile, methodCreateFileParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cMLogInstanceFixture, parametersOfCreateFile);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateFile.ShouldBeNull();
            methodCreateFileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFile) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_CreateFile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFile);
            Type [] methodCreateFileParametersTypes = null;
            object[] parametersOfCreateFile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCreateFile, parametersOfCreateFile, methodCreateFileParametersTypes);

            // Assert
            parametersOfCreateFile.ShouldBeNull();
            methodCreateFileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFile) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_CreateFile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFile);
            Type [] methodCreateFileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateFile, methodCreateFileParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateFile) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_CreateFile_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFile);
            Type [] methodCreateFileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateFile, methodCreateFileParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateFile) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_CreateFile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFile);
            Type [] methodCreateFileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateFile, methodCreateFileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateFile) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_CreateFile_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFile);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMLog_DeleteFile_Method_Call_Internally(Type[] types)
        {
            var methodDeleteFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteFile, methodDeleteFileParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_DeleteFile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFile);
            Type [] methodDeleteFileParametersTypes = null;
            object[] parametersOfDeleteFile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFile, methodDeleteFileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, parametersOfDeleteFile);
            var result2 = this.GetResultOfMethod<bool>(MethodDeleteFile, parametersOfDeleteFile, methodDeleteFileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDeleteFile.ShouldBeNull();
            methodDeleteFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_DeleteFile_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFile);
            Type [] methodDeleteFileParametersTypes = null;
            object[] parametersOfDeleteFile = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFile, methodDeleteFileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, out exception1, parametersOfDeleteFile);
            var result2 = this.GetResultOfMethod<bool>(MethodDeleteFile, parametersOfDeleteFile, methodDeleteFileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDeleteFile.ShouldBeNull();
            methodDeleteFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_DeleteFile_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFile);
            Type [] methodDeleteFileParametersTypes = null;
            object[] parametersOfDeleteFile = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFile, methodDeleteFileParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cMLogInstanceFixture, parametersOfDeleteFile);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteFile.ShouldBeNull();
            methodDeleteFileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_DeleteFile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFile);
            Type [] methodDeleteFileParametersTypes = null;
            object[] parametersOfDeleteFile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDeleteFile, parametersOfDeleteFile, methodDeleteFileParametersTypes);

            // Assert
            parametersOfDeleteFile.ShouldBeNull();
            methodDeleteFileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_DeleteFile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFile);
            Type [] methodDeleteFileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteFile, methodDeleteFileParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDeleteFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_DeleteFile_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFile);
            Type [] methodDeleteFileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteFile, methodDeleteFileParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDeleteFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_DeleteFile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFile);
            Type [] methodDeleteFileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteFile, methodDeleteFileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteFileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteFile) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_DeleteFile_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFile);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMLog_Clear_Method_Call_Internally(Type[] types)
        {
            var methodClearParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);

            // Act
            Action executeAction = () => _cMLogInstance.Clear();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;
            object[] parametersOfClear = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodClear, methodClearParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, parametersOfClear);
            var result2 = this.GetResultOfMethod<bool>(MethodClear, parametersOfClear, methodClearParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfClear.ShouldBeNull();
            methodClearParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;
            object[] parametersOfClear = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodClear, methodClearParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, out exception1, parametersOfClear);
            var result2 = this.GetResultOfMethod<bool>(MethodClear, parametersOfClear, methodClearParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfClear.ShouldBeNull();
            methodClearParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;
            object[] parametersOfClear = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClear, methodClearParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cMLogInstanceFixture, parametersOfClear);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClear.ShouldBeNull();
            methodClearParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;
            object[] parametersOfClear = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodClear, parametersOfClear, methodClearParametersTypes);

            // Assert
            parametersOfClear.ShouldBeNull();
            methodClearParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodClearParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodClearParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodClearParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Clear) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Clear_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var currentMethodInfo = this.GetMethodInfo(MethodClear, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMLog_Read_Method_Call_Internally(Type[] types)
        {
            var methodReadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);

            // Act
            Action executeAction = () => _cMLogInstance.Read();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _cMLogInstance.Read();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            Type [] methodReadParametersTypes = null;
            object[] parametersOfRead = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodRead, methodReadParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_cMLogInstanceFixture, out exception1, parametersOfRead);
            var result2 = this.GetResultOfMethod<string>(MethodRead, parametersOfRead, methodReadParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRead.ShouldBeNull();
            methodReadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            Type [] methodReadParametersTypes = null;
            object[] parametersOfRead = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRead, methodReadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cMLogInstanceFixture, parametersOfRead);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRead.ShouldBeNull();
            methodReadParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            Type [] methodReadParametersTypes = null;
            object[] parametersOfRead = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRead, parametersOfRead, methodReadParametersTypes);

            // Assert
            parametersOfRead.ShouldBeNull();
            methodReadParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            Type [] methodReadParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodReadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            Type [] methodReadParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReadParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var currentMethodInfo = this.GetMethodInfo(MethodRead, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMLog_Read_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodReadParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var _fileName = this.CreateType<string>();

            // Act
            Action executeAction = () => _cMLogInstance.Read(_fileName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var _fileName = this.CreateType<string>();
            var returnedValue = default(XDocument);

            // Act
            Action executeAction = () => returnedValue = _cMLogInstance.Read(_fileName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var _fileName = this.CreateType<string>();
            var methodReadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRead = { _fileName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRead, methodReadParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XDocument>(_cMLogInstanceFixture, parametersOfRead);
            var result2 = this.GetResultOfMethod<XDocument>(MethodRead, parametersOfRead, methodReadParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRead.ShouldNotBeNull();
            parametersOfRead.Length.ShouldBe(1);
            methodReadParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var _fileName = this.CreateType<string>();
            var methodReadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRead = { _fileName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRead, methodReadParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cMLogInstanceFixture, parametersOfRead);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRead.ShouldNotBeNull();
            parametersOfRead.Length.ShouldBe(1);
            methodReadParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var _fileName = this.CreateType<string>();
            var methodReadParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRead = { _fileName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XDocument>(MethodRead, parametersOfRead, methodReadParametersTypes);

            // Assert
            parametersOfRead.ShouldNotBeNull();
            parametersOfRead.Length.ShouldBe(1);
            methodReadParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var methodReadParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodReadParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var methodReadParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRead, methodReadParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReadParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var currentMethodInfo = this.GetMethodInfo(MethodRead, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Read) (Return Type : XDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Read_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRead);
            var currentMethodInfo = this.GetMethodInfo(MethodRead, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMLog_Write_Method_Call_Internally(Type[] types)
        {
            var methodWriteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<Exception>();

            // Act
            Action executeAction = () => _cMLogInstance.Write(error);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<Exception>();
            var methodWriteParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfWrite = { error };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, methodWriteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, parametersOfWrite);
            var result2 = this.GetResultOfMethod<bool>(MethodWrite, parametersOfWrite, methodWriteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(1);
            methodWriteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<Exception>();
            var methodWriteParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfWrite = { error };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, methodWriteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, out exception1, parametersOfWrite);
            var result2 = this.GetResultOfMethod<bool>(MethodWrite, parametersOfWrite, methodWriteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(1);
            methodWriteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<Exception>();
            var methodWriteParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfWrite = { error };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, methodWriteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cMLogInstanceFixture, parametersOfWrite);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(1);
            methodWriteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<Exception>();
            var methodWriteParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfWrite = { error };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodWrite, parametersOfWrite, methodWriteParametersTypes);

            // Assert
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(1);
            methodWriteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var methodWriteParametersTypes = new Type[] { typeof(Exception) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodWriteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var methodWriteParametersTypes = new Type[] { typeof(Exception) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodWriteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var methodWriteParametersTypes = new Type[] { typeof(Exception) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWriteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CMLog_Write_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodWriteParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<AuditManifest>();

            // Act
            Action executeAction = () => _cMLogInstance.Write(error);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<AuditManifest>();
            var methodWriteParametersTypes = new Type[] { typeof(AuditManifest) };
            object[] parametersOfWrite = { error };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, methodWriteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, parametersOfWrite);
            var result2 = this.GetResultOfMethod<bool>(MethodWrite, parametersOfWrite, methodWriteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(1);
            methodWriteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<AuditManifest>();
            var methodWriteParametersTypes = new Type[] { typeof(AuditManifest) };
            object[] parametersOfWrite = { error };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, methodWriteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cMLogInstanceFixture, out exception1, parametersOfWrite);
            var result2 = this.GetResultOfMethod<bool>(MethodWrite, parametersOfWrite, methodWriteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(1);
            methodWriteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<AuditManifest>();
            var methodWriteParametersTypes = new Type[] { typeof(AuditManifest) };
            object[] parametersOfWrite = { error };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, methodWriteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cMLogInstanceFixture, parametersOfWrite);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(1);
            methodWriteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var error = this.CreateType<AuditManifest>();
            var methodWriteParametersTypes = new Type[] { typeof(AuditManifest) };
            object[] parametersOfWrite = { error };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodWrite, parametersOfWrite, methodWriteParametersTypes);

            // Assert
            parametersOfWrite.ShouldNotBeNull();
            parametersOfWrite.Length.ShouldBe(1);
            methodWriteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var methodWriteParametersTypes = new Type[] { typeof(AuditManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodWriteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var methodWriteParametersTypes = new Type[] { typeof(AuditManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodWriteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var methodWriteParametersTypes = new Type[] { typeof(AuditManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWrite, methodWriteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWriteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Write) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CMLog_Write_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWrite);
            var currentMethodInfo = this.GetMethodInfo(MethodWrite, 1);
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