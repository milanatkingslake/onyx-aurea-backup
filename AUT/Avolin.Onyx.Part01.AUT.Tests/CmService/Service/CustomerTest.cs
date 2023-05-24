using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.ServiceModel.Channels;
using System.Xml;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Customer" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Customer.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Customer" />)
        /// </summary>
        public CustomerTest() : base(typeof(Customer))
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
        private const string MethodGetSearchMetaData = "GetSearchMetaData";
        private const string MethodGetSearchDataLbo = "GetSearchDataLbo";
        private const string MethodGetSearchResultMetaData = "GetSearchResultMetaData";
        private const string MethodRetrieveFavoriteCompanies = "RetrieveFavoriteCompanies";
        private const string MethodRetrieveFavoriteIndividual = "RetrieveFavoriteIndividual";
        private const string MethodRecentCustomers = "RecentCustomers";
        private const string MethodSearchForMobile = "SearchForMobile";
        private const string MethodSortbyNode = "SortbyNode";

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

        #region Explore Class for Coverage Gain : Class (Customer)

        #region General Initializer : Class (Customer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Customer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodMerge, 0)]
        [TestCase(MethodGetSearchMetaData, 0)]
        [TestCase(MethodGetSearchDataLbo, 0)]
        [TestCase(MethodGetSearchResultMetaData, 0)]
        [TestCase(MethodRetrieveFavoriteCompanies, 0)]
        [TestCase(MethodRetrieveFavoriteIndividual, 0)]
        [TestCase(MethodRecentCustomers, 0)]
        [TestCase(MethodSearchForMobile, 0)]
        [TestCase(MethodSortbyNode, 0)]
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

        #endregion

        #region General Instance : Class (Customer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Customer" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
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
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
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

        #region General Constructor : Class (Customer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Customer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Customer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _customerInstance.Merge(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.Merge(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Merge) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var message = this.CreateType<Message>();
            var methodMergeParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfMerge = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, methodMergeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_customerInstanceFixture, parametersOfMerge);
            var result2 = this.GetResultOfMethod<Message>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(1);
            methodMergeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var message = this.CreateType<Message>();
            var methodMergeParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfMerge = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodMerge, parametersOfMerge, methodMergeParametersTypes);

            // Assert
            parametersOfMerge.ShouldNotBeNull();
            parametersOfMerge.Length.ShouldBe(1);
            methodMergeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var methodMergeParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMergeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var methodMergeParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMerge, methodMergeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Merge) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (Merge) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_Merge_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMerge);
            var currentMethodInfo = this.GetMethodInfo(MethodMerge, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchMetaData) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchMetaData);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _customerInstance.GetSearchMetaData(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchMetaData) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchMetaData);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.GetSearchMetaData(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchMetaData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchMetaData);
            var message = this.CreateType<Message>();
            var methodGetSearchMetaDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetSearchMetaData = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchMetaData, methodGetSearchMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_customerInstanceFixture, parametersOfGetSearchMetaData);
            var result2 = this.GetResultOfMethod<Message>(MethodGetSearchMetaData, parametersOfGetSearchMetaData, methodGetSearchMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchMetaData.ShouldNotBeNull();
            parametersOfGetSearchMetaData.Length.ShouldBe(1);
            methodGetSearchMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchMetaData) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchMetaData);
            var message = this.CreateType<Message>();
            var methodGetSearchMetaDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetSearchMetaData = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetSearchMetaData, parametersOfGetSearchMetaData, methodGetSearchMetaDataParametersTypes);

            // Assert
            parametersOfGetSearchMetaData.ShouldNotBeNull();
            parametersOfGetSearchMetaData.Length.ShouldBe(1);
            methodGetSearchMetaDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchMetaData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchMetaData);
            var methodGetSearchMetaDataParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchMetaData, methodGetSearchMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchMetaData) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchMetaData);
            var methodGetSearchMetaDataParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchMetaData, methodGetSearchMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchMetaDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchMetaData) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchMetaData) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchMetaData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchMetaData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchDataLbo) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchDataLbo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchDataLbo);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _customerInstance.GetSearchDataLbo(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchDataLbo) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchDataLbo_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchDataLbo);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.GetSearchDataLbo(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchDataLbo) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchDataLbo_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchDataLbo);
            var message = this.CreateType<Message>();
            var methodGetSearchDataLboParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetSearchDataLbo = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchDataLbo, methodGetSearchDataLboParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_customerInstanceFixture, parametersOfGetSearchDataLbo);
            var result2 = this.GetResultOfMethod<Message>(MethodGetSearchDataLbo, parametersOfGetSearchDataLbo, methodGetSearchDataLboParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchDataLbo.ShouldNotBeNull();
            parametersOfGetSearchDataLbo.Length.ShouldBe(1);
            methodGetSearchDataLboParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchDataLbo) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchDataLbo_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchDataLbo);
            var message = this.CreateType<Message>();
            var methodGetSearchDataLboParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetSearchDataLbo = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetSearchDataLbo, parametersOfGetSearchDataLbo, methodGetSearchDataLboParametersTypes);

            // Assert
            parametersOfGetSearchDataLbo.ShouldNotBeNull();
            parametersOfGetSearchDataLbo.Length.ShouldBe(1);
            methodGetSearchDataLboParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchDataLbo) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchDataLbo_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchDataLbo);
            var methodGetSearchDataLboParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchDataLbo, methodGetSearchDataLboParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchDataLboParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchDataLbo) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchDataLbo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchDataLbo);
            var methodGetSearchDataLboParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchDataLbo, methodGetSearchDataLboParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchDataLboParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchDataLbo) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchDataLbo_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchDataLbo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchDataLbo, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchDataLbo) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchDataLbo_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchDataLbo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchDataLbo, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchResultMetaData) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchResultMetaData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchResultMetaData);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _customerInstance.GetSearchResultMetaData(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchResultMetaData) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchResultMetaData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchResultMetaData);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.GetSearchResultMetaData(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchResultMetaData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchResultMetaData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchResultMetaData);
            var message = this.CreateType<Message>();
            var methodGetSearchResultMetaDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetSearchResultMetaData = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchResultMetaData, methodGetSearchResultMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_customerInstanceFixture, parametersOfGetSearchResultMetaData);
            var result2 = this.GetResultOfMethod<Message>(MethodGetSearchResultMetaData, parametersOfGetSearchResultMetaData, methodGetSearchResultMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchResultMetaData.ShouldNotBeNull();
            parametersOfGetSearchResultMetaData.Length.ShouldBe(1);
            methodGetSearchResultMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchResultMetaData) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchResultMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchResultMetaData);
            var message = this.CreateType<Message>();
            var methodGetSearchResultMetaDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetSearchResultMetaData = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetSearchResultMetaData, parametersOfGetSearchResultMetaData, methodGetSearchResultMetaDataParametersTypes);

            // Assert
            parametersOfGetSearchResultMetaData.ShouldNotBeNull();
            parametersOfGetSearchResultMetaData.Length.ShouldBe(1);
            methodGetSearchResultMetaDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchResultMetaData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchResultMetaData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchResultMetaData);
            var methodGetSearchResultMetaDataParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchResultMetaData, methodGetSearchResultMetaDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchResultMetaDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSearchResultMetaData) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchResultMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchResultMetaData);
            var methodGetSearchResultMetaDataParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchResultMetaData, methodGetSearchResultMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchResultMetaDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchResultMetaData) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchResultMetaData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchResultMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchResultMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchResultMetaData) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_GetSearchResultMetaData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchResultMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchResultMetaData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _customerInstance.RetrieveFavoriteCompanies(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.RetrieveFavoriteCompanies(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var message = this.CreateType<Message>();
            var methodRetrieveFavoriteCompaniesParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRetrieveFavoriteCompanies = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_customerInstanceFixture, parametersOfRetrieveFavoriteCompanies);
            var result2 = this.GetResultOfMethod<Message>(MethodRetrieveFavoriteCompanies, parametersOfRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveFavoriteCompanies.ShouldNotBeNull();
            parametersOfRetrieveFavoriteCompanies.Length.ShouldBe(1);
            methodRetrieveFavoriteCompaniesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var message = this.CreateType<Message>();
            var methodRetrieveFavoriteCompaniesParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRetrieveFavoriteCompanies = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodRetrieveFavoriteCompanies, parametersOfRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);

            // Assert
            parametersOfRetrieveFavoriteCompanies.ShouldNotBeNull();
            parametersOfRetrieveFavoriteCompanies.Length.ShouldBe(1);
            methodRetrieveFavoriteCompaniesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var methodRetrieveFavoriteCompaniesParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveFavoriteCompaniesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var methodRetrieveFavoriteCompaniesParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteCompanies, methodRetrieveFavoriteCompaniesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveFavoriteCompaniesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (RetrieveFavoriteCompanies) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteCompanies_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteCompanies);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFavoriteCompanies, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _customerInstance.RetrieveFavoriteIndividual(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.RetrieveFavoriteIndividual(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var message = this.CreateType<Message>();
            var methodRetrieveFavoriteIndividualParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRetrieveFavoriteIndividual = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_customerInstanceFixture, parametersOfRetrieveFavoriteIndividual);
            var result2 = this.GetResultOfMethod<Message>(MethodRetrieveFavoriteIndividual, parametersOfRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveFavoriteIndividual.ShouldNotBeNull();
            parametersOfRetrieveFavoriteIndividual.Length.ShouldBe(1);
            methodRetrieveFavoriteIndividualParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var message = this.CreateType<Message>();
            var methodRetrieveFavoriteIndividualParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRetrieveFavoriteIndividual = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodRetrieveFavoriteIndividual, parametersOfRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);

            // Assert
            parametersOfRetrieveFavoriteIndividual.ShouldNotBeNull();
            parametersOfRetrieveFavoriteIndividual.Length.ShouldBe(1);
            methodRetrieveFavoriteIndividualParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var methodRetrieveFavoriteIndividualParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveFavoriteIndividualParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var methodRetrieveFavoriteIndividualParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveFavoriteIndividual, methodRetrieveFavoriteIndividualParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveFavoriteIndividualParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (RetrieveFavoriteIndividual) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RetrieveFavoriteIndividual_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveFavoriteIndividual);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveFavoriteIndividual, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _customerInstance.RecentCustomers(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.RecentCustomers(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var message = this.CreateType<Message>();
            var methodRecentCustomersParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRecentCustomers = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRecentCustomers, methodRecentCustomersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_customerInstanceFixture, parametersOfRecentCustomers);
            var result2 = this.GetResultOfMethod<Message>(MethodRecentCustomers, parametersOfRecentCustomers, methodRecentCustomersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRecentCustomers.ShouldNotBeNull();
            parametersOfRecentCustomers.Length.ShouldBe(1);
            methodRecentCustomersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var message = this.CreateType<Message>();
            var methodRecentCustomersParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRecentCustomers = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodRecentCustomers, parametersOfRecentCustomers, methodRecentCustomersParametersTypes);

            // Assert
            parametersOfRecentCustomers.ShouldNotBeNull();
            parametersOfRecentCustomers.Length.ShouldBe(1);
            methodRecentCustomersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var methodRecentCustomersParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRecentCustomers, methodRecentCustomersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRecentCustomersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var methodRecentCustomersParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRecentCustomers, methodRecentCustomersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRecentCustomersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RecentCustomers) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (RecentCustomers) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_RecentCustomers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecentCustomers);
            var currentMethodInfo = this.GetMethodInfo(MethodRecentCustomers, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var message = this.CreateType<Stream>();

            // Act
            Action executeAction = () => _customerInstance.SearchForMobile(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var message = this.CreateType<Stream>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _customerInstance.SearchForMobile(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var message = this.CreateType<Stream>();
            var methodSearchForMobileParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfSearchForMobile = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSearchForMobile, methodSearchForMobileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_customerInstanceFixture, parametersOfSearchForMobile);
            var result2 = this.GetResultOfMethod<Message>(MethodSearchForMobile, parametersOfSearchForMobile, methodSearchForMobileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSearchForMobile.ShouldNotBeNull();
            parametersOfSearchForMobile.Length.ShouldBe(1);
            methodSearchForMobileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var message = this.CreateType<Stream>();
            var methodSearchForMobileParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfSearchForMobile = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodSearchForMobile, parametersOfSearchForMobile, methodSearchForMobileParametersTypes);

            // Assert
            parametersOfSearchForMobile.ShouldNotBeNull();
            parametersOfSearchForMobile.Length.ShouldBe(1);
            methodSearchForMobileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var methodSearchForMobileParametersTypes = new Type[] { typeof(Stream) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSearchForMobile, methodSearchForMobileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSearchForMobileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var methodSearchForMobileParametersTypes = new Type[] { typeof(Stream) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSearchForMobile, methodSearchForMobileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSearchForMobileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SearchForMobile) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (SearchForMobile) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SearchForMobile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSearchForMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodSearchForMobile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SortbyNode) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SortbyNode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyNode);
            var xmlDoc = this.CreateType<XmlDocument>();
            var columnName = this.CreateType<string>();
            var methodSortbyNodeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfSortbyNode = { xmlDoc, columnName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSortbyNode, methodSortbyNodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_customerInstanceFixture, parametersOfSortbyNode);
            var result2 = this.GetResultOfMethod<string>(MethodSortbyNode, parametersOfSortbyNode, methodSortbyNodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSortbyNode.ShouldNotBeNull();
            parametersOfSortbyNode.Length.ShouldBe(2);
            methodSortbyNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SortbyNode) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SortbyNode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyNode);
            var xmlDoc = this.CreateType<XmlDocument>();
            var columnName = this.CreateType<string>();
            var methodSortbyNodeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfSortbyNode = { xmlDoc, columnName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSortbyNode, parametersOfSortbyNode, methodSortbyNodeParametersTypes);

            // Assert
            parametersOfSortbyNode.ShouldNotBeNull();
            parametersOfSortbyNode.Length.ShouldBe(2);
            methodSortbyNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SortbyNode) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SortbyNode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyNode);
            var methodSortbyNodeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSortbyNode, methodSortbyNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSortbyNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SortbyNode) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SortbyNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyNode);
            var methodSortbyNodeParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSortbyNode, methodSortbyNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSortbyNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SortbyNode) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SortbyNode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyNode);
            var currentMethodInfo = this.GetMethodInfo(MethodSortbyNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SortbyNode) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Customer_SortbyNode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSortbyNode);
            var currentMethodInfo = this.GetMethodInfo(MethodSortbyNode, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}