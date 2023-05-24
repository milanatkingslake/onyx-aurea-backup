using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.LboResultXmlHelper" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LboResultXmlHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LboResultXmlHelper" />)
        /// </summary>
        public LboResultXmlHelperTest() : base(typeof(LboResultXmlHelper))
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

        #region General Initializer : Class (LboResultXmlHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _lboResultXmlHelperInstanceType;
        private LboResultXmlHelper _lboResultXmlHelperInstance;
        private LboResultXmlHelper _lboResultXmlHelperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LboResultXmlHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _lboResultXmlHelperInstanceType = typeof(LboResultXmlHelper);
            _lboResultXmlHelperInstanceFixture = this.Create<LboResultXmlHelper>(false);
            _lboResultXmlHelperInstance = _lboResultXmlHelperInstanceFixture ?? this.Create<LboResultXmlHelper>(true);
            CurrentInstance = _lboResultXmlHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LboResultXmlHelper) Initializer

        #region Methods

        private const string MethodGetColumnValue = "GetColumnValue";
        private const string MethodGetColumnListValues = "GetColumnListValues";
        private const string MethodGetColumnOrdinalFieldName = "GetColumnOrdinalFieldName";
        private const string MethodGetFieldValue = "GetFieldValue";
        private const string MethodGetCollectionFieldValue = "GetCollectionFieldValue";
        private const string MethodGetNodeValue = "GetNodeValue";
        private const string MethodCreateRetriveListInputXml = "CreateRetriveListInputXml";
        private const string MethodGetLBOFieldValue = "GetLBOFieldValue";

        #endregion

        #region Fields

        private const string FieldXResultDoc = "XResultDoc";
        private const string FieldXResultcolumnDefinitions = "XResultcolumnDefinitions";

        #endregion

        #endregion

        #region General Initializer : Class (LboResultXmlHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LboResultXmlHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboResultXmlHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (LboResultXmlHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LboResultXmlHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LboResultXmlHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LboResultXmlHelper)

        #region General Initializer : Class (LboResultXmlHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LboResultXmlHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetColumnValue, 0)]
        [TestCase(MethodGetColumnListValues, 0)]
        [TestCase(MethodGetColumnOrdinalFieldName, 0)]
        [TestCase(MethodGetFieldValue, 0)]
        [TestCase(MethodGetCollectionFieldValue, 0)]
        [TestCase(MethodGetNodeValue, 0)]
        [TestCase(MethodCreateRetriveListInputXml, 0)]
        [TestCase(MethodGetLBOFieldValue, 0)]
        public void AUT_LboResultXmlHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (LboResultXmlHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LboResultXmlHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldXResultDoc)]
        [TestCase(FieldXResultcolumnDefinitions)]
        [Category("AUT Fields")]
        public void AUT_LboResultXmlHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (LboResultXmlHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LboResultXmlHelper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LboResultXmlHelper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _lboResultXmlHelperInstance.ShouldBeAssignableTo<LboResultXmlHelper>();
            _lboResultXmlHelperInstanceFixture.ShouldBeAssignableTo<LboResultXmlHelper>();
            CurrentInstance.ShouldBeAssignableTo<LboResultXmlHelper>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetColumnValue) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnValue);
            var columnOrdinalName = this.CreateType<string>();

            // Act
            Action executeAction = () => _lboResultXmlHelperInstance.GetColumnValue(columnOrdinalName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetColumnValue) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnValue);
            var columnOrdinalName = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _lboResultXmlHelperInstance.GetColumnValue(columnOrdinalName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetColumnValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnValue);
            var columnOrdinalName = this.CreateType<string>();
            var methodGetColumnValueParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetColumnValue = { columnOrdinalName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnValue, methodGetColumnValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_lboResultXmlHelperInstanceFixture, parametersOfGetColumnValue);
            var result2 = this.GetResultOfMethod<String>(MethodGetColumnValue, parametersOfGetColumnValue, methodGetColumnValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetColumnValue.ShouldNotBeNull();
            parametersOfGetColumnValue.Length.ShouldBe(1);
            methodGetColumnValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetColumnValue) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnValue);
            var columnOrdinalName = this.CreateType<string>();
            var methodGetColumnValueParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetColumnValue = { columnOrdinalName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodGetColumnValue, parametersOfGetColumnValue, methodGetColumnValueParametersTypes);

            // Assert
            parametersOfGetColumnValue.ShouldNotBeNull();
            parametersOfGetColumnValue.Length.ShouldBe(1);
            methodGetColumnValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetColumnValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnValue);
            var methodGetColumnValueParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetColumnValue, methodGetColumnValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetColumnValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetColumnValue) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnValue);
            var methodGetColumnValueParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetColumnValue, methodGetColumnValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetColumnValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetColumnValue) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetColumnValue) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboResultXmlHelper_GetColumnListValues_Method_Call_Internally(Type[] types)
        {
            var methodGetColumnListValuesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetColumnListValues, methodGetColumnListValuesParametersTypes);
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnListValues_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnListValues);
            var columnOrdinalName = this.CreateType<string>();

            // Act
            Action executeAction = () => _lboResultXmlHelperInstance.GetColumnListValues(columnOrdinalName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnListValues_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnListValues);
            var columnOrdinalName = this.CreateType<string>();
            var returnedValue = default(List<String>);

            // Act
            Action executeAction = () => returnedValue = _lboResultXmlHelperInstance.GetColumnListValues(columnOrdinalName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnListValues_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnListValues);
            var columnOrdinalName = this.CreateType<string>();
            var methodGetColumnListValuesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetColumnListValues = { columnOrdinalName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnListValues, methodGetColumnListValuesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<String>>(_lboResultXmlHelperInstanceFixture, parametersOfGetColumnListValues);
            var result2 = this.GetResultOfMethod<List<String>>(MethodGetColumnListValues, parametersOfGetColumnListValues, methodGetColumnListValuesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetColumnListValues.ShouldNotBeNull();
            parametersOfGetColumnListValues.Length.ShouldBe(1);
            methodGetColumnListValuesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnListValues_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnListValues);
            var columnOrdinalName = this.CreateType<string>();
            var methodGetColumnListValuesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetColumnListValues = { columnOrdinalName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<String>>(MethodGetColumnListValues, parametersOfGetColumnListValues, methodGetColumnListValuesParametersTypes);

            // Assert
            parametersOfGetColumnListValues.ShouldNotBeNull();
            parametersOfGetColumnListValues.Length.ShouldBe(1);
            methodGetColumnListValuesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnListValues_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnListValues);
            var methodGetColumnListValuesParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetColumnListValues, methodGetColumnListValuesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetColumnListValuesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnListValues_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnListValues);
            var methodGetColumnListValuesParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetColumnListValues, methodGetColumnListValuesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetColumnListValuesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnListValues_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnListValues);
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnListValues, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetColumnListValues) (Return Type : List<String>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnListValues_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnListValues);
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnListValues, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_Call_Internally(Type[] types)
        {
            var methodGetColumnOrdinalFieldNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetColumnOrdinalFieldName, methodGetColumnOrdinalFieldNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnOrdinalFieldName);
            var columnName = this.CreateType<string>();

            // Act
            Action executeAction = () => _lboResultXmlHelperInstance.GetColumnOrdinalFieldName(columnName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnOrdinalFieldName);
            var columnName = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _lboResultXmlHelperInstance.GetColumnOrdinalFieldName(columnName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnOrdinalFieldName);
            var columnName = this.CreateType<string>();
            var methodGetColumnOrdinalFieldNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetColumnOrdinalFieldName = { columnName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnOrdinalFieldName, methodGetColumnOrdinalFieldNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboResultXmlHelperInstanceFixture, parametersOfGetColumnOrdinalFieldName);
            var result2 = this.GetResultOfMethod<string>(MethodGetColumnOrdinalFieldName, parametersOfGetColumnOrdinalFieldName, methodGetColumnOrdinalFieldNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetColumnOrdinalFieldName.ShouldNotBeNull();
            parametersOfGetColumnOrdinalFieldName.Length.ShouldBe(1);
            methodGetColumnOrdinalFieldNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnOrdinalFieldName);
            var columnName = this.CreateType<string>();
            var methodGetColumnOrdinalFieldNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetColumnOrdinalFieldName = { columnName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetColumnOrdinalFieldName, parametersOfGetColumnOrdinalFieldName, methodGetColumnOrdinalFieldNameParametersTypes);

            // Assert
            parametersOfGetColumnOrdinalFieldName.ShouldNotBeNull();
            parametersOfGetColumnOrdinalFieldName.Length.ShouldBe(1);
            methodGetColumnOrdinalFieldNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnOrdinalFieldName);
            var methodGetColumnOrdinalFieldNameParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetColumnOrdinalFieldName, methodGetColumnOrdinalFieldNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetColumnOrdinalFieldNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnOrdinalFieldName);
            var methodGetColumnOrdinalFieldNameParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetColumnOrdinalFieldName, methodGetColumnOrdinalFieldNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetColumnOrdinalFieldNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnOrdinalFieldName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnOrdinalFieldName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetColumnOrdinalFieldName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetColumnOrdinalFieldName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetColumnOrdinalFieldName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetColumnOrdinalFieldName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboResultXmlHelper_GetFieldValue_Method_Call_Internally(Type[] types)
        {
            var methodGetFieldValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFieldValue, methodGetFieldValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetFieldValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldValue);
            var ColumnDetail = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _lboResultXmlHelperInstance.GetFieldValue(ColumnDetail);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetFieldValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldValue);
            var ColumnDetail = this.CreateType<XElement>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _lboResultXmlHelperInstance.GetFieldValue(ColumnDetail);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetFieldValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldValue);
            var ColumnDetail = this.CreateType<XElement>();
            var methodGetFieldValueParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetFieldValue = { ColumnDetail };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldValue, methodGetFieldValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboResultXmlHelperInstanceFixture, parametersOfGetFieldValue);
            var result2 = this.GetResultOfMethod<string>(MethodGetFieldValue, parametersOfGetFieldValue, methodGetFieldValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetFieldValue.ShouldNotBeNull();
            parametersOfGetFieldValue.Length.ShouldBe(1);
            methodGetFieldValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetFieldValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldValue);
            var ColumnDetail = this.CreateType<XElement>();
            var methodGetFieldValueParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetFieldValue = { ColumnDetail };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetFieldValue, parametersOfGetFieldValue, methodGetFieldValueParametersTypes);

            // Assert
            parametersOfGetFieldValue.ShouldNotBeNull();
            parametersOfGetFieldValue.Length.ShouldBe(1);
            methodGetFieldValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetFieldValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldValue);
            var methodGetFieldValueParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFieldValue, methodGetFieldValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetFieldValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetFieldValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldValue);
            var methodGetFieldValueParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFieldValue, methodGetFieldValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFieldValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetFieldValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFieldValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetFieldValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_Call_Internally(Type[] types)
        {
            var methodGetCollectionFieldValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCollectionFieldValue, methodGetCollectionFieldValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionFieldValue);
            var profileXml = this.CreateType<XDocument>();

            // Act
            Action executeAction = () => _lboResultXmlHelperInstance.GetCollectionFieldValue(profileXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionFieldValue);
            var profileXml = this.CreateType<XDocument>();
            var returnedValue = default(XDocument);

            // Act
            Action executeAction = () => returnedValue = _lboResultXmlHelperInstance.GetCollectionFieldValue(profileXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionFieldValue);
            var profileXml = this.CreateType<XDocument>();
            var methodGetCollectionFieldValueParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfGetCollectionFieldValue = { profileXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCollectionFieldValue, methodGetCollectionFieldValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XDocument>(_lboResultXmlHelperInstanceFixture, parametersOfGetCollectionFieldValue);
            var result2 = this.GetResultOfMethod<XDocument>(MethodGetCollectionFieldValue, parametersOfGetCollectionFieldValue, methodGetCollectionFieldValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCollectionFieldValue.ShouldNotBeNull();
            parametersOfGetCollectionFieldValue.Length.ShouldBe(1);
            methodGetCollectionFieldValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionFieldValue);
            var profileXml = this.CreateType<XDocument>();
            var methodGetCollectionFieldValueParametersTypes = new Type[] { typeof(XDocument) };
            object[] parametersOfGetCollectionFieldValue = { profileXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XDocument>(MethodGetCollectionFieldValue, parametersOfGetCollectionFieldValue, methodGetCollectionFieldValueParametersTypes);

            // Assert
            parametersOfGetCollectionFieldValue.ShouldNotBeNull();
            parametersOfGetCollectionFieldValue.Length.ShouldBe(1);
            methodGetCollectionFieldValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionFieldValue);
            var methodGetCollectionFieldValueParametersTypes = new Type[] { typeof(XDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCollectionFieldValue, methodGetCollectionFieldValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCollectionFieldValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionFieldValue);
            var methodGetCollectionFieldValueParametersTypes = new Type[] { typeof(XDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCollectionFieldValue, methodGetCollectionFieldValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCollectionFieldValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionFieldValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCollectionFieldValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCollectionFieldValue) (Return Type : XDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetCollectionFieldValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCollectionFieldValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCollectionFieldValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboResultXmlHelper_GetNodeValue_Method_Call_Internally(Type[] types)
        {
            var methodGetNodeValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetNodeValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var NodeDetail = this.CreateType<string>();

            // Act
            Action executeAction = () => _lboResultXmlHelperInstance.GetNodeValue(NodeDetail);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetNodeValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var NodeDetail = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _lboResultXmlHelperInstance.GetNodeValue(NodeDetail);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetNodeValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var NodeDetail = this.CreateType<string>();
            var methodGetNodeValueParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNodeValue = { NodeDetail };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, methodGetNodeValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboResultXmlHelperInstanceFixture, parametersOfGetNodeValue);
            var result2 = this.GetResultOfMethod<string>(MethodGetNodeValue, parametersOfGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNodeValue.ShouldNotBeNull();
            parametersOfGetNodeValue.Length.ShouldBe(1);
            methodGetNodeValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetNodeValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var NodeDetail = this.CreateType<string>();
            var methodGetNodeValueParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNodeValue = { NodeDetail };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNodeValue, parametersOfGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            parametersOfGetNodeValue.ShouldNotBeNull();
            parametersOfGetNodeValue.Length.ShouldBe(1);
            methodGetNodeValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetNodeValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var methodGetNodeValueParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNodeValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetNodeValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var methodGetNodeValueParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNodeValue, methodGetNodeValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNodeValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetNodeValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNodeValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetNodeValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNodeValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNodeValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRetriveListInputXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboResultXmlHelper_CreateRetriveListInputXml_Method_Call_Internally(Type[] types)
        {
            var methodCreateRetriveListInputXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRetriveListInputXml, methodCreateRetriveListInputXmlParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRetriveListInputXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_CreateRetriveListInputXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRetriveListInputXml);

            // Act
            Action executeAction = () => _lboResultXmlHelperInstance.CreateRetriveListInputXml();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateRetriveListInputXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_CreateRetriveListInputXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRetriveListInputXml);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _lboResultXmlHelperInstance.CreateRetriveListInputXml();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRetriveListInputXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_CreateRetriveListInputXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRetriveListInputXml);
            Type [] methodCreateRetriveListInputXmlParametersTypes = null;
            object[] parametersOfCreateRetriveListInputXml = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRetriveListInputXml, methodCreateRetriveListInputXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_lboResultXmlHelperInstanceFixture, parametersOfCreateRetriveListInputXml);
            var result2 = this.GetResultOfMethod<string>(MethodCreateRetriveListInputXml, parametersOfCreateRetriveListInputXml, methodCreateRetriveListInputXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateRetriveListInputXml.ShouldBeNull();
            methodCreateRetriveListInputXmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRetriveListInputXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_CreateRetriveListInputXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRetriveListInputXml);
            Type [] methodCreateRetriveListInputXmlParametersTypes = null;
            object[] parametersOfCreateRetriveListInputXml = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateRetriveListInputXml, parametersOfCreateRetriveListInputXml, methodCreateRetriveListInputXmlParametersTypes);

            // Assert
            parametersOfCreateRetriveListInputXml.ShouldBeNull();
            methodCreateRetriveListInputXmlParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRetriveListInputXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_CreateRetriveListInputXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRetriveListInputXml);
            Type [] methodCreateRetriveListInputXmlParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateRetriveListInputXml, methodCreateRetriveListInputXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateRetriveListInputXmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRetriveListInputXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_CreateRetriveListInputXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRetriveListInputXml);
            Type [] methodCreateRetriveListInputXmlParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRetriveListInputXml, methodCreateRetriveListInputXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateRetriveListInputXmlParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateRetriveListInputXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_CreateRetriveListInputXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRetriveListInputXml);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRetriveListInputXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLBOFieldValue) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_LboResultXmlHelper_GetLBOFieldValue_Method_Call_Internally(Type[] types)
        {
            var methodGetLBOFieldValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLBOFieldValue, methodGetLBOFieldValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetLBOFieldValue) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetLBOFieldValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLBOFieldValue);
            var FieldDetail = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _lboResultXmlHelperInstance.GetLBOFieldValue(FieldDetail);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLBOFieldValue) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetLBOFieldValue_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLBOFieldValue);
            var FieldDetail = this.CreateType<XElement>();
            var methodGetLBOFieldValueParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetLBOFieldValue = { FieldDetail };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLBOFieldValue, methodGetLBOFieldValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_lboResultXmlHelperInstanceFixture, parametersOfGetLBOFieldValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetLBOFieldValue.ShouldNotBeNull();
            parametersOfGetLBOFieldValue.Length.ShouldBe(1);
            methodGetLBOFieldValueParametersTypes.Length.ShouldBe(1);
            methodGetLBOFieldValueParametersTypes.Length.ShouldBe(parametersOfGetLBOFieldValue.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetLBOFieldValue) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetLBOFieldValue_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLBOFieldValue);
            var FieldDetail = this.CreateType<XElement>();
            var methodGetLBOFieldValueParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetLBOFieldValue = { FieldDetail };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetLBOFieldValue, parametersOfGetLBOFieldValue, methodGetLBOFieldValueParametersTypes);

            // Assert
            parametersOfGetLBOFieldValue.ShouldNotBeNull();
            parametersOfGetLBOFieldValue.Length.ShouldBe(1);
            methodGetLBOFieldValueParametersTypes.Length.ShouldBe(1);
            methodGetLBOFieldValueParametersTypes.Length.ShouldBe(parametersOfGetLBOFieldValue.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLBOFieldValue) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetLBOFieldValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLBOFieldValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLBOFieldValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLBOFieldValue) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetLBOFieldValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLBOFieldValue);
            var methodGetLBOFieldValueParametersTypes = new Type[] { typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLBOFieldValue, methodGetLBOFieldValueParametersTypes);

            // Assert
            methodGetLBOFieldValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLBOFieldValue) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LboResultXmlHelper_GetLBOFieldValue_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLBOFieldValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLBOFieldValue, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}