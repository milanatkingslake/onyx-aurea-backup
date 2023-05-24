using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using System.Xml.Linq;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Customer" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CustomerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Customer" />)
        /// </summary>
        public CustomerTest() : base(typeof(Customer))
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

        #region General Initializer : Class (Customer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customerInstanceType;
        private Customer _customerInstance;
        private Customer _customerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Customer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customerInstanceType = typeof(Customer);
            _customerInstanceFixture = this.Create<Customer>(false);
            _customerInstance = _customerInstanceFixture ?? this.Create<Customer>(true);
            CurrentInstance = _customerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Customer) Initializer

        #region Methods

        private const string MethodMerge = "Merge";
        private const string MethodRetrieveFavoriteCompanies = "RetrieveFavoriteCompanies";
        private const string MethodRetrieveFavoriteIndividual = "RetrieveFavoriteIndividual";
        private const string MethodRecentCustomers = "RecentCustomers";
        private const string MethodSearchForMobile = "SearchForMobile";
        private const string MethodgetSortByField = "getSortByField";
        private const string MethodconvertNodesToAttribute = "convertNodesToAttribute";
        private const string MethodconvertCustomerNodesToAttribute = "convertCustomerNodesToAttribute";
        private const string MethodconvertRecentCustomerNodesToAttribute = "convertRecentCustomerNodesToAttribute";
        private const string MethodGenerateRetriveListInputXml = "GenerateRetriveListInputXml";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (Customer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Customer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Customer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Customer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Customer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Customer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Customer)

        #region General Initializer : Class (Customer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Customer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodMerge, 0)]
        [TestCase(MethodRetrieveFavoriteCompanies, 0)]
        [TestCase(MethodRetrieveFavoriteIndividual, 0)]
        [TestCase(MethodRecentCustomers, 0)]
        [TestCase(MethodSearchForMobile, 0)]
        [TestCase(MethodgetSortByField, 0)]
        [TestCase(MethodconvertNodesToAttribute, 0)]
        [TestCase(MethodconvertCustomerNodesToAttribute, 0)]
        [TestCase(MethodconvertRecentCustomerNodesToAttribute, 0)]
        [TestCase(MethodGenerateRetriveListInputXml, 0)]
        public void AUT_Customer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Customer) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Customer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_Customer_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Customer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Customer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Customer_Is_Instance_Present_Test()
        {
            // Assert
            _customerInstanceType.ShouldNotBeNull();
            _customerInstance.ShouldNotBeNull();
            _customerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Customer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Customer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Customer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _customerInstance.ShouldBeAssignableTo<Customer>();
            _customerInstanceFixture.ShouldBeAssignableTo<Customer>();
            CurrentInstance.ShouldBeAssignableTo<Customer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Customer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Customer_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Customer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Customer(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _customerInstance.ShouldNotBeNull();
            _customerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Customer>();
        }

        #endregion

        #region General Constructor : Class (Customer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Customer_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Customer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Customer(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _customerInstance.ShouldNotBeNull();
            _customerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Merge) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);

            // Act
            Action executeAction = () => _customerInstance.Merge();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.Merge();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            Type [] methodMergeParametersTypes = null;
            object[] parametersOfMerge = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, methodMergeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_customerInstanceFixture, parametersOfMerge);
            var result2 = this.GetResultOfMethod<string>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMerge.ShouldBeNull();
            methodMergeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            Type [] methodMergeParametersTypes = null;
            object[] parametersOfMerge = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            parametersOfMerge.ShouldBeNull();
            methodMergeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            Type [] methodMergeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMergeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            Type [] methodMergeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveFavoriteCompaniesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);

            // Act
            Action executeAction = () => _customerInstance.RetrieveFavoriteCompanies();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.RetrieveFavoriteCompanies();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            Type [] methodRetrieveFavoriteCompaniesParametersTypes = null;
            object[] parametersOfRetrieveFavoriteCompanies = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_customerInstanceFixture, parametersOfRetrieveFavoriteCompanies);
            var result2 = this.GetResultOfMethod<string>(MethodRetrieveFavoriteCompanies, parametersOfRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveFavoriteCompanies.ShouldBeNull();
            methodRetrieveFavoriteCompaniesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            Type [] methodRetrieveFavoriteCompaniesParametersTypes = null;
            object[] parametersOfRetrieveFavoriteCompanies = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRetrieveFavoriteCompanies, parametersOfRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);

            // Assert
            parametersOfRetrieveFavoriteCompanies.ShouldBeNull();
            methodRetrieveFavoriteCompaniesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            Type [] methodRetrieveFavoriteCompaniesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveFavoriteCompaniesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            Type [] methodRetrieveFavoriteCompaniesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveFavoriteCompaniesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFavoriteCompanies, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_Internally(Type[] types)
        {
            var methodRetrieveFavoriteIndividualParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);

            // Act
            Action executeAction = () => _customerInstance.RetrieveFavoriteIndividual();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.RetrieveFavoriteIndividual();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            Type [] methodRetrieveFavoriteIndividualParametersTypes = null;
            object[] parametersOfRetrieveFavoriteIndividual = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_customerInstanceFixture, parametersOfRetrieveFavoriteIndividual);
            var result2 = this.GetResultOfMethod<string>(MethodRetrieveFavoriteIndividual, parametersOfRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveFavoriteIndividual.ShouldBeNull();
            methodRetrieveFavoriteIndividualParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            Type [] methodRetrieveFavoriteIndividualParametersTypes = null;
            object[] parametersOfRetrieveFavoriteIndividual = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRetrieveFavoriteIndividual, parametersOfRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);

            // Assert
            parametersOfRetrieveFavoriteIndividual.ShouldBeNull();
            methodRetrieveFavoriteIndividualParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            Type [] methodRetrieveFavoriteIndividualParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveFavoriteIndividualParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            Type [] methodRetrieveFavoriteIndividualParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveFavoriteIndividualParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFavoriteIndividual, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_RecentCustomers_Method_Call_Internally(Type[] types)
        {
            var methodRecentCustomersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRecentCustomers, methodRecentCustomersParametersTypes);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);

            // Act
            Action executeAction = () => _customerInstance.RecentCustomers();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.RecentCustomers();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            Type [] methodRecentCustomersParametersTypes = null;
            object[] parametersOfRecentCustomers = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRecentCustomers, methodRecentCustomersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_customerInstanceFixture, parametersOfRecentCustomers);
            var result2 = this.GetResultOfMethod<string>(MethodRecentCustomers, parametersOfRecentCustomers, methodRecentCustomersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRecentCustomers.ShouldBeNull();
            methodRecentCustomersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            Type [] methodRecentCustomersParametersTypes = null;
            object[] parametersOfRecentCustomers = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRecentCustomers, parametersOfRecentCustomers, methodRecentCustomersParametersTypes);

            // Assert
            parametersOfRecentCustomers.ShouldBeNull();
            methodRecentCustomersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            Type [] methodRecentCustomersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRecentCustomers, methodRecentCustomersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRecentCustomersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            Type [] methodRecentCustomersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRecentCustomers, methodRecentCustomersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRecentCustomersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var currentMethodInfo = this.GetMethodInfo(MethodRecentCustomers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_SearchForMobile_Method_Call_Internally(Type[] types)
        {
            var methodSearchForMobileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSearchForMobile, methodSearchForMobileParametersTypes);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);

            // Act
            Action executeAction = () => _customerInstance.SearchForMobile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.SearchForMobile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            Type [] methodSearchForMobileParametersTypes = null;
            object[] parametersOfSearchForMobile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSearchForMobile, methodSearchForMobileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_customerInstanceFixture, parametersOfSearchForMobile);
            var result2 = this.GetResultOfMethod<string>(MethodSearchForMobile, parametersOfSearchForMobile, methodSearchForMobileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSearchForMobile.ShouldBeNull();
            methodSearchForMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            Type [] methodSearchForMobileParametersTypes = null;
            object[] parametersOfSearchForMobile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSearchForMobile, parametersOfSearchForMobile, methodSearchForMobileParametersTypes);

            // Assert
            parametersOfSearchForMobile.ShouldBeNull();
            methodSearchForMobileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            Type [] methodSearchForMobileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSearchForMobile, methodSearchForMobileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSearchForMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            Type [] methodSearchForMobileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSearchForMobile, methodSearchForMobileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSearchForMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodSearchForMobile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getSortByField) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_getSortByField_Method_Call_Internally(Type[] types)
        {
            var methodgetSortByFieldParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodgetSortByField, methodgetSortByFieldParametersTypes);
        }

        #endregion

        #region Method Call : (getSortByField) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_getSortByField_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSortByField);
            var fileName = this.CreateType<string>();
            var nodeName = this.CreateType<string>();
            var isNumeric = this.CreateType<bool>();
            var isAscending = this.CreateType<bool>();
            var methodgetSortByFieldParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfgetSortByField = { fileName, nodeName, isNumeric, isAscending };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodgetSortByField, methodgetSortByFieldParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_customerInstanceFixture, parametersOfgetSortByField);
            var result2 = this.GetResultOfMethod<string>(MethodgetSortByField, parametersOfgetSortByField, methodgetSortByFieldParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfgetSortByField.ShouldNotBeNull();
            parametersOfgetSortByField.Length.ShouldBe(4);
            methodgetSortByFieldParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (getSortByField) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_getSortByField_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSortByField);
            var fileName = this.CreateType<string>();
            var nodeName = this.CreateType<string>();
            var isNumeric = this.CreateType<bool>();
            var isAscending = this.CreateType<bool>();
            var methodgetSortByFieldParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(bool) };
            object[] parametersOfgetSortByField = { fileName, nodeName, isNumeric, isAscending };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodgetSortByField, parametersOfgetSortByField, methodgetSortByFieldParametersTypes);

            // Assert
            parametersOfgetSortByField.ShouldNotBeNull();
            parametersOfgetSortByField.Length.ShouldBe(4);
            methodgetSortByFieldParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (getSortByField) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_getSortByField_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSortByField);
            var methodgetSortByFieldParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodgetSortByField, methodgetSortByFieldParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodgetSortByFieldParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (getSortByField) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_getSortByField_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSortByField);
            var methodgetSortByFieldParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(bool) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodgetSortByField, methodgetSortByFieldParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodgetSortByFieldParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (getSortByField) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_getSortByField_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSortByField);
            var currentMethodInfo = this.GetMethodInfo(MethodgetSortByField, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (getSortByField) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_getSortByField_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodgetSortByField);
            var currentMethodInfo = this.GetMethodInfo(MethodgetSortByField, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertNodesToAttribute) (Return Type : XmlDocument) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_convertNodesToAttribute_Method_Call_Internally(Type[] types)
        {
            var methodconvertNodesToAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconvertNodesToAttribute, methodconvertNodesToAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (convertNodesToAttribute) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertNodesToAttribute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var isIndividual = this.CreateType<bool>();
            var methodconvertNodesToAttributeParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfconvertNodesToAttribute = { xmlString, isIndividual };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodconvertNodesToAttribute, methodconvertNodesToAttributeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlDocument>(_customerInstanceFixture, parametersOfconvertNodesToAttribute);
            var result2 = this.GetResultOfMethod<XmlDocument>(MethodconvertNodesToAttribute, parametersOfconvertNodesToAttribute, methodconvertNodesToAttributeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfconvertNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertNodesToAttribute.Length.ShouldBe(2);
            methodconvertNodesToAttributeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (convertNodesToAttribute) (Return Type : XmlDocument) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertNodesToAttribute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var isIndividual = this.CreateType<bool>();
            var methodconvertNodesToAttributeParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfconvertNodesToAttribute = { xmlString, isIndividual };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlDocument>(MethodconvertNodesToAttribute, parametersOfconvertNodesToAttribute, methodconvertNodesToAttributeParametersTypes);

            // Assert
            parametersOfconvertNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertNodesToAttribute.Length.ShouldBe(2);
            methodconvertNodesToAttributeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (convertNodesToAttribute) (Return Type : XmlDocument) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertNodesToAttribute);
            var methodconvertNodesToAttributeParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconvertNodesToAttribute, methodconvertNodesToAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodconvertNodesToAttributeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (convertNodesToAttribute) (Return Type : XmlDocument) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertNodesToAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertNodesToAttribute);
            var methodconvertNodesToAttributeParametersTypes = new Type[] { typeof(string), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconvertNodesToAttribute, methodconvertNodesToAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconvertNodesToAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertNodesToAttribute) (Return Type : XmlDocument) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertNodesToAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertNodesToAttribute) (Return Type : XmlDocument) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertNodesToAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertNodesToAttribute, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertCustomerNodesToAttribute) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_convertCustomerNodesToAttribute_Method_Call_Internally(Type[] types)
        {
            var methodconvertCustomerNodesToAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconvertCustomerNodesToAttribute, methodconvertCustomerNodesToAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (convertCustomerNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertCustomerNodesToAttribute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertCustomerNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodconvertCustomerNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertCustomerNodesToAttribute = { xmlString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodconvertCustomerNodesToAttribute, methodconvertCustomerNodesToAttributeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_customerInstanceFixture, parametersOfconvertCustomerNodesToAttribute);
            var result2 = this.GetResultOfMethod<XElement>(MethodconvertCustomerNodesToAttribute, parametersOfconvertCustomerNodesToAttribute, methodconvertCustomerNodesToAttributeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfconvertCustomerNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertCustomerNodesToAttribute.Length.ShouldBe(1);
            methodconvertCustomerNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertCustomerNodesToAttribute) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertCustomerNodesToAttribute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertCustomerNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodconvertCustomerNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertCustomerNodesToAttribute = { xmlString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodconvertCustomerNodesToAttribute, parametersOfconvertCustomerNodesToAttribute, methodconvertCustomerNodesToAttributeParametersTypes);

            // Assert
            parametersOfconvertCustomerNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertCustomerNodesToAttribute.Length.ShouldBe(1);
            methodconvertCustomerNodesToAttributeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (convertCustomerNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertCustomerNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertCustomerNodesToAttribute);
            var methodconvertCustomerNodesToAttributeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconvertCustomerNodesToAttribute, methodconvertCustomerNodesToAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodconvertCustomerNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertCustomerNodesToAttribute) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertCustomerNodesToAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertCustomerNodesToAttribute);
            var methodconvertCustomerNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconvertCustomerNodesToAttribute, methodconvertCustomerNodesToAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconvertCustomerNodesToAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertCustomerNodesToAttribute) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertCustomerNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertCustomerNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertCustomerNodesToAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertCustomerNodesToAttribute) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertCustomerNodesToAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertCustomerNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertCustomerNodesToAttribute, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertRecentCustomerNodesToAttribute) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_convertRecentCustomerNodesToAttribute_Method_Call_Internally(Type[] types)
        {
            var methodconvertRecentCustomerNodesToAttributeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodconvertRecentCustomerNodesToAttribute, methodconvertRecentCustomerNodesToAttributeParametersTypes);
        }

        #endregion

        #region Method Call : (convertRecentCustomerNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertRecentCustomerNodesToAttribute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentCustomerNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodconvertRecentCustomerNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertRecentCustomerNodesToAttribute = { xmlString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodconvertRecentCustomerNodesToAttribute, methodconvertRecentCustomerNodesToAttributeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_customerInstanceFixture, parametersOfconvertRecentCustomerNodesToAttribute);
            var result2 = this.GetResultOfMethod<XElement>(MethodconvertRecentCustomerNodesToAttribute, parametersOfconvertRecentCustomerNodesToAttribute, methodconvertRecentCustomerNodesToAttributeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfconvertRecentCustomerNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertRecentCustomerNodesToAttribute.Length.ShouldBe(1);
            methodconvertRecentCustomerNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertRecentCustomerNodesToAttribute) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertRecentCustomerNodesToAttribute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentCustomerNodesToAttribute);
            var xmlString = this.CreateType<string>();
            var methodconvertRecentCustomerNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfconvertRecentCustomerNodesToAttribute = { xmlString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodconvertRecentCustomerNodesToAttribute, parametersOfconvertRecentCustomerNodesToAttribute, methodconvertRecentCustomerNodesToAttributeParametersTypes);

            // Assert
            parametersOfconvertRecentCustomerNodesToAttribute.ShouldNotBeNull();
            parametersOfconvertRecentCustomerNodesToAttribute.Length.ShouldBe(1);
            methodconvertRecentCustomerNodesToAttributeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (convertRecentCustomerNodesToAttribute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertRecentCustomerNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentCustomerNodesToAttribute);
            var methodconvertRecentCustomerNodesToAttributeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodconvertRecentCustomerNodesToAttribute, methodconvertRecentCustomerNodesToAttributeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodconvertRecentCustomerNodesToAttributeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (convertRecentCustomerNodesToAttribute) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertRecentCustomerNodesToAttribute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentCustomerNodesToAttribute);
            var methodconvertRecentCustomerNodesToAttributeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodconvertRecentCustomerNodesToAttribute, methodconvertRecentCustomerNodesToAttributeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodconvertRecentCustomerNodesToAttributeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (convertRecentCustomerNodesToAttribute) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertRecentCustomerNodesToAttribute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentCustomerNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertRecentCustomerNodesToAttribute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (convertRecentCustomerNodesToAttribute) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_convertRecentCustomerNodesToAttribute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodconvertRecentCustomerNodesToAttribute);
            var currentMethodInfo = this.GetMethodInfo(MethodconvertRecentCustomerNodesToAttribute, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateRetriveListInputXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Customer_GenerateRetriveListInputXml_Method_Call_Internally(Type[] types)
        {
            var methodGenerateRetriveListInputXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateRetriveListInputXml, methodGenerateRetriveListInputXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateRetriveListInputXml) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GenerateRetriveListInputXml_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRetriveListInputXml);
            var resultXml = this.CreateType<XmlDocument>();
            var methodGenerateRetriveListInputXmlParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfGenerateRetriveListInputXml = { resultXml };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateRetriveListInputXml, methodGenerateRetriveListInputXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_customerInstanceFixture, out exception1, parametersOfGenerateRetriveListInputXml);
            var result2 = this.GetResultOfMethod<string>(MethodGenerateRetriveListInputXml, parametersOfGenerateRetriveListInputXml, methodGenerateRetriveListInputXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGenerateRetriveListInputXml.ShouldNotBeNull();
            parametersOfGenerateRetriveListInputXml.Length.ShouldBe(1);
            methodGenerateRetriveListInputXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateRetriveListInputXml) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GenerateRetriveListInputXml_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRetriveListInputXml);
            var resultXml = this.CreateType<XmlDocument>();
            var methodGenerateRetriveListInputXmlParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfGenerateRetriveListInputXml = { resultXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateRetriveListInputXml, methodGenerateRetriveListInputXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_customerInstanceFixture, parametersOfGenerateRetriveListInputXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateRetriveListInputXml.ShouldNotBeNull();
            parametersOfGenerateRetriveListInputXml.Length.ShouldBe(1);
            methodGenerateRetriveListInputXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateRetriveListInputXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GenerateRetriveListInputXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRetriveListInputXml);
            var resultXml = this.CreateType<XmlDocument>();
            var methodGenerateRetriveListInputXmlParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfGenerateRetriveListInputXml = { resultXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGenerateRetriveListInputXml, parametersOfGenerateRetriveListInputXml, methodGenerateRetriveListInputXmlParametersTypes);

            // Assert
            parametersOfGenerateRetriveListInputXml.ShouldNotBeNull();
            parametersOfGenerateRetriveListInputXml.Length.ShouldBe(1);
            methodGenerateRetriveListInputXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateRetriveListInputXml) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GenerateRetriveListInputXml_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRetriveListInputXml);
            var methodGenerateRetriveListInputXmlParametersTypes = new Type[] { typeof(XmlDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateRetriveListInputXml, methodGenerateRetriveListInputXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGenerateRetriveListInputXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GenerateRetriveListInputXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GenerateRetriveListInputXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRetriveListInputXml);
            var methodGenerateRetriveListInputXmlParametersTypes = new Type[] { typeof(XmlDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateRetriveListInputXml, methodGenerateRetriveListInputXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateRetriveListInputXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateRetriveListInputXml) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GenerateRetriveListInputXml_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRetriveListInputXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateRetriveListInputXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GenerateRetriveListInputXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GenerateRetriveListInputXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateRetriveListInputXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateRetriveListInputXml, 0);
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