using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.PageContext" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PageContextTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PageContext" />)
        /// </summary>
        public PageContextTest() : base(typeof(PageContext))
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

        #region General Initializer : Class (PageContext) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _pageContextInstanceType;
        private PageContext _pageContextInstance;
        private PageContext _pageContextInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="PageContext" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _pageContextInstanceType = typeof(PageContext);
            _pageContextInstanceFixture = this.Create<PageContext>(false);
            _pageContextInstance = _pageContextInstanceFixture ?? this.Create<PageContext>(true);
            CurrentInstance = _pageContextInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PageContext) Initializer

        #region Properties

        private const string PropertyCount = "Count";

        #endregion

        #region Methods

        private const string MethodToString = "ToString";
        private const string MethodAdd = "Add";
        private const string MethodClear = "Clear";
        private const string MethodContainsKey = "ContainsKey";
        private const string MethodContainsValue = "ContainsValue";
        private const string MethodCopyTo = "CopyTo";
        private const string MethodRemove = "Remove";
        private const string MethodGetCacheFilePrefix = "GetCacheFilePrefix";
        private const string MethodGetCacheFilePath = "GetCacheFilePath";
        private const string MethodParseContextString = "ParseContextString";
        private const string MethodBuildContextString = "BuildContextString";

        #endregion

        #region Fields

        private const string Field_itemDelimiter = "_itemDelimiter";
        private const string Field_itemDelimiterString = "_itemDelimiterString";
        private const string Field_itemDelimiterReplacement = "_itemDelimiterReplacement";
        private const string Field_subItemDelimiter = "_subItemDelimiter";
        private const string Field_itemNameStart = "_itemNameStart";
        private const string Field_itemNameEnd = "_itemNameEnd";

        #endregion

        #endregion

        #region General Initializer : Class (PageContext) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PageContext" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PageContext_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PageContext) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="PageContext" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PageContext_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PageContext) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PageContext" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PageContext_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PageContext)

        #region General Initializer : Class (PageContext) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PageContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodToString, 0)]
        [TestCase(MethodAdd, 0)]
        [TestCase(MethodClear, 0)]
        [TestCase(MethodContainsKey, 0)]
        [TestCase(MethodContainsValue, 0)]
        [TestCase(MethodCopyTo, 0)]
        [TestCase(MethodRemove, 0)]
        [TestCase(MethodGetCacheFilePrefix, 0)]
        [TestCase(MethodGetCacheFilePath, 0)]
        [TestCase(MethodParseContextString, 0)]
        [TestCase(MethodBuildContextString, 0)]
        public void AUT_PageContext_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (PageContext) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="PageContext" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCount)]
        [Category("AUT Property")]
        public void AUT_PageContext_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (PageContext) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PageContext" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_itemDelimiter)]
        [TestCase(Field_itemDelimiterString)]
        [TestCase(Field_itemDelimiterReplacement)]
        [TestCase(Field_subItemDelimiter)]
        [TestCase(Field_itemNameStart)]
        [TestCase(Field_itemNameEnd)]
        [Category("AUT Fields")]
        public void AUT_PageContext_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (PageContext) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="PageContext" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PageContext_Is_Instance_Present_Test()
        {
            // Assert
            _pageContextInstanceType.ShouldNotBeNull();
            _pageContextInstance.ShouldNotBeNull();
            _pageContextInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (PageContext) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="PageContext" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PageContext_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _pageContextInstance.ShouldBeAssignableTo<PageContext>();
            _pageContextInstanceFixture.ShouldBeAssignableTo<PageContext>();
            CurrentInstance.ShouldBeAssignableTo<PageContext>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (PageContext) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PageContext_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            PageContext instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (PageContext) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PageContext_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var contextString = this.CreateType<string>();
            PageContext instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new PageContext(contextString);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _pageContextInstance.ShouldNotBeNull();
            _pageContextInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<PageContext>();
        }

        #endregion

        #region General Constructor : Class (PageContext) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PageContext_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var contextString = this.CreateType<string>();
            PageContext instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new PageContext(contextString);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _pageContextInstance.ShouldNotBeNull();
            _pageContextInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (PageContext) instance created

        /// <summary>
        ///     Class (<see cref="PageContext" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PageContext_Is_Created_Test()
        {
            // Assert
            _pageContextInstance.ShouldNotBeNull();
            _pageContextInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (PageContext) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="PageContext" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_PageContext_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion
        
        #region General Constructor : Class (PageContext) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="PageContext" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PageContext_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (PageContext) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PageContext" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PageContext_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodPageContextParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPageContextParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PageContext) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PageContext" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PageContext_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPageContextParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPageContextParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (PageContext) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCount)]
        public void AUT_PageContext_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (PageContext) => Property (Count) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PageContext_Public_Class_Count_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCount);
            var propertyInfo = this.GetPropertyInfo(PropertyCount);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ToString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);

            // Act
            Action executeAction = () => _pageContextInstance.ToString();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ToString_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _pageContextInstance.ToString();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ToString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_pageContextInstanceFixture, out exception1, parametersOfToString);
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
        public void AUT_PageContext_ToString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfToString);

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
        public void AUT_PageContext_ToString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_PageContext_ToString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_PageContext_ToString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_PageContext_ToString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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

        #region Method Call : (Add) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_Add_Method_Call_Internally(Type[] types)
        {
            var methodAddParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAdd, methodAddParametersTypes);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Add_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var id = this.CreateType<string>();
            var value = this.CreateType<string>();

            // Act
            Action executeAction = () => _pageContextInstance.Add(id, value);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Add_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var id = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodAddParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAdd = { id, value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAdd, methodAddParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfAdd);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAdd.ShouldNotBeNull();
            parametersOfAdd.Length.ShouldBe(2);
            methodAddParametersTypes.Length.ShouldBe(2);
            methodAddParametersTypes.Length.ShouldBe(parametersOfAdd.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Add_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var id = this.CreateType<string>();
            var value = this.CreateType<string>();
            var methodAddParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfAdd = { id, value };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAdd, parametersOfAdd, methodAddParametersTypes);

            // Assert
            parametersOfAdd.ShouldNotBeNull();
            parametersOfAdd.Length.ShouldBe(2);
            methodAddParametersTypes.Length.ShouldBe(2);
            methodAddParametersTypes.Length.ShouldBe(parametersOfAdd.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Add_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var currentMethodInfo = this.GetMethodInfo(MethodAdd, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Add_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var methodAddParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAdd, methodAddParametersTypes);

            // Assert
            methodAddParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Add) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Add_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAdd);
            var currentMethodInfo = this.GetMethodInfo(MethodAdd, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_Clear_Method_Call_Internally(Type[] types)
        {
            var methodClearParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Clear_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);

            // Act
            Action executeAction = () => _pageContextInstance.Clear();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Clear_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;
            object[] parametersOfClear = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodClear, methodClearParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfClear);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfClear.ShouldBeNull();
            methodClearParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Clear_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;
            object[] parametersOfClear = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodClear, parametersOfClear, methodClearParametersTypes);

            // Assert
            parametersOfClear.ShouldBeNull();
            methodClearParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Clear_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            Type [] methodClearParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodClear, methodClearParametersTypes);

            // Assert
            methodClearParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Clear) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Clear_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodClear);
            var currentMethodInfo = this.GetMethodInfo(MethodClear, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_ContainsKey_Method_Call_Internally(Type[] types)
        {
            var methodContainsKeyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodContainsKey, methodContainsKeyParametersTypes);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var id = this.CreateType<string>();

            // Act
            Action executeAction = () => _pageContextInstance.ContainsKey(id);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var id = this.CreateType<string>();
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsKey = { id };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, methodContainsKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_pageContextInstanceFixture, parametersOfContainsKey);
            var result2 = this.GetResultOfMethod<bool>(MethodContainsKey, parametersOfContainsKey, methodContainsKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContainsKey.ShouldNotBeNull();
            parametersOfContainsKey.Length.ShouldBe(1);
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var id = this.CreateType<string>();
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsKey = { id };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, methodContainsKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_pageContextInstanceFixture, out exception1, parametersOfContainsKey);
            var result2 = this.GetResultOfMethod<bool>(MethodContainsKey, parametersOfContainsKey, methodContainsKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContainsKey.ShouldNotBeNull();
            parametersOfContainsKey.Length.ShouldBe(1);
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var id = this.CreateType<string>();
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsKey = { id };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, methodContainsKeyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfContainsKey);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfContainsKey.ShouldNotBeNull();
            parametersOfContainsKey.Length.ShouldBe(1);
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var id = this.CreateType<string>();
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsKey = { id };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodContainsKey, parametersOfContainsKey, methodContainsKeyParametersTypes);

            // Assert
            parametersOfContainsKey.ShouldNotBeNull();
            parametersOfContainsKey.Length.ShouldBe(1);
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContainsKey, methodContainsKeyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContainsKey, methodContainsKeyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodContainsKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var methodContainsKeyParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodContainsKey, methodContainsKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodContainsKeyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ContainsKey) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsKey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsKey);
            var currentMethodInfo = this.GetMethodInfo(MethodContainsKey, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_ContainsValue_Method_Call_Internally(Type[] types)
        {
            var methodContainsValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodContainsValue, methodContainsValueParametersTypes);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var value = this.CreateType<string>();

            // Act
            Action executeAction = () => _pageContextInstance.ContainsValue(value);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var value = this.CreateType<string>();
            var methodContainsValueParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsValue = { value };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodContainsValue, methodContainsValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_pageContextInstanceFixture, parametersOfContainsValue);
            var result2 = this.GetResultOfMethod<bool>(MethodContainsValue, parametersOfContainsValue, methodContainsValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContainsValue.ShouldNotBeNull();
            parametersOfContainsValue.Length.ShouldBe(1);
            methodContainsValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var value = this.CreateType<string>();
            var methodContainsValueParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsValue = { value };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodContainsValue, methodContainsValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_pageContextInstanceFixture, out exception1, parametersOfContainsValue);
            var result2 = this.GetResultOfMethod<bool>(MethodContainsValue, parametersOfContainsValue, methodContainsValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfContainsValue.ShouldNotBeNull();
            parametersOfContainsValue.Length.ShouldBe(1);
            methodContainsValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var value = this.CreateType<string>();
            var methodContainsValueParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsValue = { value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodContainsValue, methodContainsValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfContainsValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfContainsValue.ShouldNotBeNull();
            parametersOfContainsValue.Length.ShouldBe(1);
            methodContainsValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var value = this.CreateType<string>();
            var methodContainsValueParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfContainsValue = { value };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodContainsValue, parametersOfContainsValue, methodContainsValueParametersTypes);

            // Assert
            parametersOfContainsValue.ShouldNotBeNull();
            parametersOfContainsValue.Length.ShouldBe(1);
            methodContainsValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var methodContainsValueParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContainsValue, methodContainsValueParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodContainsValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var methodContainsValueParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodContainsValue, methodContainsValueParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodContainsValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var methodContainsValueParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodContainsValue, methodContainsValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodContainsValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var currentMethodInfo = this.GetMethodInfo(MethodContainsValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ContainsValue) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ContainsValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodContainsValue);
            var currentMethodInfo = this.GetMethodInfo(MethodContainsValue, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_CopyTo_Method_Call_Internally(Type[] types)
        {
            var methodCopyToParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCopyTo, methodCopyToParametersTypes);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_CopyTo_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<Array>();
            var index = this.CreateType<int>();

            // Act
            Action executeAction = () => _pageContextInstance.CopyTo(array, index);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_CopyTo_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<Array>();
            var index = this.CreateType<int>();
            var methodCopyToParametersTypes = new Type[] { typeof(Array), typeof(int) };
            object[] parametersOfCopyTo = { array, index };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCopyTo, methodCopyToParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfCopyTo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCopyTo.ShouldNotBeNull();
            parametersOfCopyTo.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(2);
            methodCopyToParametersTypes.Length.ShouldBe(parametersOfCopyTo.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CopyTo) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_CopyTo_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var array = this.CreateType<Array>();
            var index = this.CreateType<int>();
            var methodCopyToParametersTypes = new Type[] { typeof(Array), typeof(int) };
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
        public void AUT_PageContext_CopyTo_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_PageContext_CopyTo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCopyTo);
            var methodCopyToParametersTypes = new Type[] { typeof(Array), typeof(int) };

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
        public void AUT_PageContext_CopyTo_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (Remove) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_Remove_Method_Call_Internally(Type[] types)
        {
            var methodRemoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemove, methodRemoveParametersTypes);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Remove_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var id = this.CreateType<string>();

            // Act
            Action executeAction = () => _pageContextInstance.Remove(id);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Remove) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_Remove_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var id = this.CreateType<string>();
            var methodRemoveParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemove = { id };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemove, methodRemoveParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfRemove);

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
        public void AUT_PageContext_Remove_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var id = this.CreateType<string>();
            var methodRemoveParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemove = { id };

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
        public void AUT_PageContext_Remove_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_PageContext_Remove_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemove);
            var methodRemoveParametersTypes = new Type[] { typeof(string) };

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
        public void AUT_PageContext_Remove_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_GetCacheFilePrefix_Method_Call_Internally(Type[] types)
        {
            var methodGetCacheFilePrefixParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCacheFilePrefix, methodGetCacheFilePrefixParametersTypes);
        }

        #endregion

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePrefix_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePrefix);

            // Act
            Action executeAction = () => _pageContextInstance.GetCacheFilePrefix();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePrefix_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePrefix);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _pageContextInstance.GetCacheFilePrefix();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePrefix_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePrefix);
            Type [] methodGetCacheFilePrefixParametersTypes = null;
            object[] parametersOfGetCacheFilePrefix = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheFilePrefix, methodGetCacheFilePrefixParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_pageContextInstanceFixture, out exception1, parametersOfGetCacheFilePrefix);
            var result2 = this.GetResultOfMethod<string>(MethodGetCacheFilePrefix, parametersOfGetCacheFilePrefix, methodGetCacheFilePrefixParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCacheFilePrefix.ShouldBeNull();
            methodGetCacheFilePrefixParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePrefix_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePrefix);
            Type [] methodGetCacheFilePrefixParametersTypes = null;
            object[] parametersOfGetCacheFilePrefix = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheFilePrefix, methodGetCacheFilePrefixParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfGetCacheFilePrefix);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCacheFilePrefix.ShouldBeNull();
            methodGetCacheFilePrefixParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePrefix_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePrefix);
            Type [] methodGetCacheFilePrefixParametersTypes = null;
            object[] parametersOfGetCacheFilePrefix = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCacheFilePrefix, parametersOfGetCacheFilePrefix, methodGetCacheFilePrefixParametersTypes);

            // Assert
            parametersOfGetCacheFilePrefix.ShouldBeNull();
            methodGetCacheFilePrefixParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePrefix_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePrefix);
            Type [] methodGetCacheFilePrefixParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheFilePrefix, methodGetCacheFilePrefixParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCacheFilePrefixParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePrefix_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePrefix);
            Type [] methodGetCacheFilePrefixParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheFilePrefix, methodGetCacheFilePrefixParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheFilePrefixParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheFilePrefix) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePrefix_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePrefix);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheFilePrefix, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_GetCacheFilePath_Method_Call_Internally(Type[] types)
        {
            var methodGetCacheFilePathParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCacheFilePath, methodGetCacheFilePathParametersTypes);
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var sourceUri = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var profileId = this.CreateType<string>();

            // Act
            Action executeAction = () => _pageContextInstance.GetCacheFilePath(sourceUri, rootPath, profileId);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var sourceUri = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _pageContextInstance.GetCacheFilePath(sourceUri, rootPath, profileId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var sourceUri = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var methodGetCacheFilePathParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetCacheFilePath = { sourceUri, rootPath, profileId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheFilePath, methodGetCacheFilePathParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_pageContextInstanceFixture, out exception1, parametersOfGetCacheFilePath);
            var result2 = this.GetResultOfMethod<string>(MethodGetCacheFilePath, parametersOfGetCacheFilePath, methodGetCacheFilePathParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCacheFilePath.ShouldNotBeNull();
            parametersOfGetCacheFilePath.Length.ShouldBe(3);
            methodGetCacheFilePathParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var sourceUri = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var methodGetCacheFilePathParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetCacheFilePath = { sourceUri, rootPath, profileId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheFilePath, methodGetCacheFilePathParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfGetCacheFilePath);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCacheFilePath.ShouldNotBeNull();
            parametersOfGetCacheFilePath.Length.ShouldBe(3);
            methodGetCacheFilePathParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var sourceUri = this.CreateType<string>();
            var rootPath = this.CreateType<string>();
            var profileId = this.CreateType<string>();
            var methodGetCacheFilePathParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetCacheFilePath = { sourceUri, rootPath, profileId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCacheFilePath, parametersOfGetCacheFilePath, methodGetCacheFilePathParametersTypes);

            // Assert
            parametersOfGetCacheFilePath.ShouldNotBeNull();
            parametersOfGetCacheFilePath.Length.ShouldBe(3);
            methodGetCacheFilePathParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var methodGetCacheFilePathParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheFilePath, methodGetCacheFilePathParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCacheFilePathParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var methodGetCacheFilePathParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheFilePath, methodGetCacheFilePathParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheFilePathParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheFilePath, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCacheFilePath) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_GetCacheFilePath_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheFilePath);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheFilePath, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ParseContextString) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_ParseContextString_Method_Call_Internally(Type[] types)
        {
            var methodParseContextStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodParseContextString, methodParseContextStringParametersTypes);
        }

        #endregion

        #region Method Call : (ParseContextString) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ParseContextString_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodParseContextString);
            var contextString = this.CreateType<string>();
            var methodParseContextStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfParseContextString = { contextString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodParseContextString, methodParseContextStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfParseContextString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfParseContextString.ShouldNotBeNull();
            parametersOfParseContextString.Length.ShouldBe(1);
            methodParseContextStringParametersTypes.Length.ShouldBe(1);
            methodParseContextStringParametersTypes.Length.ShouldBe(parametersOfParseContextString.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ParseContextString) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ParseContextString_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodParseContextString);
            var contextString = this.CreateType<string>();
            var methodParseContextStringParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfParseContextString = { contextString };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodParseContextString, parametersOfParseContextString, methodParseContextStringParametersTypes);

            // Assert
            parametersOfParseContextString.ShouldNotBeNull();
            parametersOfParseContextString.Length.ShouldBe(1);
            methodParseContextStringParametersTypes.Length.ShouldBe(1);
            methodParseContextStringParametersTypes.Length.ShouldBe(parametersOfParseContextString.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ParseContextString) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ParseContextString_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodParseContextString);
            var currentMethodInfo = this.GetMethodInfo(MethodParseContextString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ParseContextString) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ParseContextString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodParseContextString);
            var methodParseContextStringParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodParseContextString, methodParseContextStringParametersTypes);

            // Assert
            methodParseContextStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ParseContextString) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_ParseContextString_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodParseContextString);
            var currentMethodInfo = this.GetMethodInfo(MethodParseContextString, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildContextString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PageContext_BuildContextString_Method_Call_Internally(Type[] types)
        {
            var methodBuildContextStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuildContextString, methodBuildContextStringParametersTypes);
        }

        #endregion

        #region Method Call : (BuildContextString) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_BuildContextString_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextString);
            Type [] methodBuildContextStringParametersTypes = null;
            object[] parametersOfBuildContextString = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildContextString, methodBuildContextStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_pageContextInstanceFixture, out exception1, parametersOfBuildContextString);
            var result2 = this.GetResultOfMethod<string>(MethodBuildContextString, parametersOfBuildContextString, methodBuildContextStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBuildContextString.ShouldBeNull();
            methodBuildContextStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BuildContextString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_BuildContextString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextString);
            Type [] methodBuildContextStringParametersTypes = null;
            object[] parametersOfBuildContextString = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildContextString, methodBuildContextStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_pageContextInstanceFixture, parametersOfBuildContextString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBuildContextString.ShouldBeNull();
            methodBuildContextStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildContextString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_BuildContextString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextString);
            Type [] methodBuildContextStringParametersTypes = null;
            object[] parametersOfBuildContextString = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBuildContextString, parametersOfBuildContextString, methodBuildContextStringParametersTypes);

            // Assert
            parametersOfBuildContextString.ShouldBeNull();
            methodBuildContextStringParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildContextString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_BuildContextString_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextString);
            Type [] methodBuildContextStringParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBuildContextString, methodBuildContextStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodBuildContextStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BuildContextString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_BuildContextString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextString);
            Type [] methodBuildContextStringParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuildContextString, methodBuildContextStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBuildContextStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BuildContextString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PageContext_BuildContextString_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildContextString);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildContextString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}