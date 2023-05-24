using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ReportingService2005" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReportingService20052Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20052Test() : base(typeof(ReportingService2005))
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

        #region General Initializer : Class (ReportingService2005) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private ReportingService2005 _reportingService2005Instance;
        private ReportingService2005 _reportingService2005InstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReportingService2005" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _reportingService2005InstanceFixture = this.Create<ReportingService2005>(false);
            _reportingService2005Instance = _reportingService2005InstanceFixture ?? this.Create<ReportingService2005>(true);
            CurrentInstance = _reportingService2005Instance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReportingService2005) Initializer
        
        #region Methods

        private const string MethodListChildren = "ListChildren";
        private const string MethodOnListChildrenOperationCompleted = "OnListChildrenOperationCompleted";
        private const string MethodListDependentItems = "ListDependentItems";
        private const string MethodOnListDependentItemsOperationCompleted = "OnListDependentItemsOperationCompleted";
        private const string MethodGetProperties = "GetProperties";
        private const string MethodOnGetPropertiesOperationCompleted = "OnGetPropertiesOperationCompleted";
        private const string MethodSetProperties = "SetProperties";
        private const string MethodOnSetPropertiesOperationCompleted = "OnSetPropertiesOperationCompleted";
        private const string MethodGetItemType = "GetItemType";
        private const string MethodOnGetItemTypeOperationCompleted = "OnGetItemTypeOperationCompleted";
        private const string MethodCreateFolder = "CreateFolder";

        #endregion
        
        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (ListChildren) (Return Type : CatalogItem[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListChildren_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListChildren);
            var Item = this.CreateType<string>();
            var Recursive = this.CreateType<bool>();
            var returnedValue = default(CatalogItem[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListChildren(Item, Recursive);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListChildren) (Return Type : CatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListChildren_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListChildren);
            var Item = this.CreateType<string>();
            var Recursive = this.CreateType<bool>();
            var methodListChildrenParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfListChildren = { Item, Recursive };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListChildren, methodListChildrenParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<CatalogItem[]>(_reportingService2005InstanceFixture, parametersOfListChildren);
            var result2 = this.GetResultOfMethod<CatalogItem[]>(MethodListChildren, parametersOfListChildren, methodListChildrenParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListChildren.ShouldNotBeNull();
            parametersOfListChildren.Length.ShouldBe(2);
            methodListChildrenParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ListChildren) (Return Type : CatalogItem[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListChildren_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListChildren);
            var Item = this.CreateType<string>();
            var Recursive = this.CreateType<bool>();
            var methodListChildrenParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfListChildren = { Item, Recursive };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CatalogItem[]>(MethodListChildren, parametersOfListChildren, methodListChildrenParametersTypes);

            // Assert
            parametersOfListChildren.ShouldNotBeNull();
            parametersOfListChildren.Length.ShouldBe(2);
            methodListChildrenParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListChildren) (Return Type : CatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListChildren_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListChildren);
            var methodListChildrenParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListChildren, methodListChildrenParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListChildrenParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ListChildren) (Return Type : CatalogItem[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListChildren_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListChildren);
            var methodListChildrenParametersTypes = new Type[] { typeof(string), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListChildren, methodListChildrenParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListChildrenParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListChildren) (Return Type : CatalogItem[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListChildren_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListChildren);
            var currentMethodInfo = this.GetMethodInfo(MethodListChildren, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListChildren) (Return Type : CatalogItem[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListChildren_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListChildren);
            var currentMethodInfo = this.GetMethodInfo(MethodListChildren, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListChildrenOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListChildrenOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListChildrenOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListChildrenOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListChildrenOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListChildrenOperationCompleted, parametersOfOnListChildrenOperationCompleted, methodOnListChildrenOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListChildrenOperationCompleted.ShouldNotBeNull();
            parametersOfOnListChildrenOperationCompleted.Length.ShouldBe(1);
            methodOnListChildrenOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListChildrenOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListChildrenOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListChildrenOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListChildrenOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListChildrenOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListChildrenOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListChildrenOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListChildrenOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListChildrenOperationCompleted);
            var methodOnListChildrenOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListChildrenOperationCompleted, methodOnListChildrenOperationCompletedParametersTypes);

            // Assert
            methodOnListChildrenOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListChildrenOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListChildrenOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListChildrenOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListChildrenOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListDependentItems) (Return Type : CatalogItem[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListDependentItems_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListDependentItems);
            var Item = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListDependentItems(Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListDependentItems) (Return Type : CatalogItem[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListDependentItems_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListDependentItems);
            var Item = this.CreateType<string>();
            var returnedValue = default(CatalogItem[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListDependentItems(Item);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListDependentItems) (Return Type : CatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListDependentItems_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListDependentItems);
            var Item = this.CreateType<string>();
            var methodListDependentItemsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListDependentItems = { Item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListDependentItems, methodListDependentItemsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<CatalogItem[]>(_reportingService2005InstanceFixture, parametersOfListDependentItems);
            var result2 = this.GetResultOfMethod<CatalogItem[]>(MethodListDependentItems, parametersOfListDependentItems, methodListDependentItemsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListDependentItems.ShouldNotBeNull();
            parametersOfListDependentItems.Length.ShouldBe(1);
            methodListDependentItemsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListDependentItems) (Return Type : CatalogItem[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListDependentItems_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListDependentItems);
            var Item = this.CreateType<string>();
            var methodListDependentItemsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListDependentItems = { Item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CatalogItem[]>(MethodListDependentItems, parametersOfListDependentItems, methodListDependentItemsParametersTypes);

            // Assert
            parametersOfListDependentItems.ShouldNotBeNull();
            parametersOfListDependentItems.Length.ShouldBe(1);
            methodListDependentItemsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListDependentItems) (Return Type : CatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListDependentItems_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListDependentItems);
            var methodListDependentItemsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListDependentItems, methodListDependentItemsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListDependentItemsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListDependentItems) (Return Type : CatalogItem[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListDependentItems_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListDependentItems);
            var methodListDependentItemsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListDependentItems, methodListDependentItemsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListDependentItemsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListDependentItems) (Return Type : CatalogItem[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListDependentItems_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListDependentItems);
            var currentMethodInfo = this.GetMethodInfo(MethodListDependentItems, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListDependentItems) (Return Type : CatalogItem[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListDependentItems_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListDependentItems);
            var currentMethodInfo = this.GetMethodInfo(MethodListDependentItems, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListDependentItemsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListDependentItemsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListDependentItemsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListDependentItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListDependentItemsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListDependentItemsOperationCompleted, parametersOfOnListDependentItemsOperationCompleted, methodOnListDependentItemsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListDependentItemsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListDependentItemsOperationCompleted.Length.ShouldBe(1);
            methodOnListDependentItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListDependentItemsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListDependentItemsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListDependentItemsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListDependentItemsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListDependentItemsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListDependentItemsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListDependentItemsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListDependentItemsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListDependentItemsOperationCompleted);
            var methodOnListDependentItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListDependentItemsOperationCompleted, methodOnListDependentItemsOperationCompletedParametersTypes);

            // Assert
            methodOnListDependentItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListDependentItemsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListDependentItemsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListDependentItemsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListDependentItemsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetProperties) (Return Type : Property[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var Item = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetProperties(Item, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : Property[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetProperties_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var Item = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var returnedValue = default(Property[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetProperties(Item, Properties);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : Property[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var Item = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodGetPropertiesParametersTypes = new Type[] { typeof(string), typeof(Property[]) };
            object[] parametersOfGetProperties = { Item, Properties };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperties, methodGetPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Property[]>(_reportingService2005InstanceFixture, parametersOfGetProperties);
            var result2 = this.GetResultOfMethod<Property[]>(MethodGetProperties, parametersOfGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProperties.ShouldNotBeNull();
            parametersOfGetProperties.Length.ShouldBe(2);
            methodGetPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : Property[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var Item = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodGetPropertiesParametersTypes = new Type[] { typeof(string), typeof(Property[]) };
            object[] parametersOfGetProperties = { Item, Properties };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Property[]>(MethodGetProperties, parametersOfGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            parametersOfGetProperties.ShouldNotBeNull();
            parametersOfGetProperties.Length.ShouldBe(2);
            methodGetPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : Property[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var methodGetPropertiesParametersTypes = new Type[] { typeof(string), typeof(Property[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPropertiesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : Property[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var methodGetPropertiesParametersTypes = new Type[] { typeof(string), typeof(Property[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProperties, methodGetPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : Property[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProperties) (Return Type : Property[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProperties, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetPropertiesOperationCompleted, parametersOfOnGetPropertiesOperationCompleted, methodOnGetPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertiesOperationCompleted);
            var methodOnGetPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetPropertiesOperationCompleted, methodOnGetPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnGetPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetProperties) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetProperties);
            var Item = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetProperties(Item, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetProperties);
            var Item = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodSetPropertiesParametersTypes = new Type[] { typeof(string), typeof(Property[]) };
            object[] parametersOfSetProperties = { Item, Properties };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetProperties, methodSetPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetProperties.ShouldNotBeNull();
            parametersOfSetProperties.Length.ShouldBe(2);
            methodSetPropertiesParametersTypes.Length.ShouldBe(2);
            methodSetPropertiesParametersTypes.Length.ShouldBe(parametersOfSetProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetProperties);
            var Item = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodSetPropertiesParametersTypes = new Type[] { typeof(string), typeof(Property[]) };
            object[] parametersOfSetProperties = { Item, Properties };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetProperties, parametersOfSetProperties, methodSetPropertiesParametersTypes);

            // Assert
            parametersOfSetProperties.ShouldNotBeNull();
            parametersOfSetProperties.Length.ShouldBe(2);
            methodSetPropertiesParametersTypes.Length.ShouldBe(2);
            methodSetPropertiesParametersTypes.Length.ShouldBe(parametersOfSetProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetProperties, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetProperties);
            var methodSetPropertiesParametersTypes = new Type[] { typeof(string), typeof(Property[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetProperties, methodSetPropertiesParametersTypes);

            // Assert
            methodSetPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetPropertiesOperationCompleted, parametersOfOnSetPropertiesOperationCompleted, methodOnSetPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnSetPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetPropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetPropertiesOperationCompleted);
            var methodOnSetPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetPropertiesOperationCompleted, methodOnSetPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnSetPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetItemType) (Return Type : ItemTypeEnum) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemType_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemType);
            var Item = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetItemType(Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetItemType) (Return Type : ItemTypeEnum) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemType_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemType);
            var Item = this.CreateType<string>();
            var returnedValue = default(ItemTypeEnum);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetItemType(Item);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion
        
        #region Method Call : (GetItemType) (Return Type : ItemTypeEnum) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemType);
            var Item = this.CreateType<string>();
            var methodGetItemTypeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetItemType = { Item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ItemTypeEnum>(MethodGetItemType, parametersOfGetItemType, methodGetItemTypeParametersTypes);

            // Assert
            parametersOfGetItemType.ShouldNotBeNull();
            parametersOfGetItemType.Length.ShouldBe(1);
            methodGetItemTypeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetItemType) (Return Type : ItemTypeEnum) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemType);
            var methodGetItemTypeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetItemType, methodGetItemTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetItemTypeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetItemType) (Return Type : ItemTypeEnum) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemType);
            var methodGetItemTypeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetItemType, methodGetItemTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetItemTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetItemType) (Return Type : ItemTypeEnum) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetItemType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetItemType) (Return Type : ItemTypeEnum) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetItemType, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetItemTypeOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemTypeOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemTypeOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetItemTypeOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetItemTypeOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetItemTypeOperationCompleted, parametersOfOnGetItemTypeOperationCompleted, methodOnGetItemTypeOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetItemTypeOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetItemTypeOperationCompleted.Length.ShouldBe(1);
            methodOnGetItemTypeOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetItemTypeOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetItemTypeOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetItemTypeOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemTypeOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemTypeOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetItemTypeOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetItemTypeOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemTypeOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemTypeOperationCompleted);
            var methodOnGetItemTypeOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetItemTypeOperationCompleted, methodOnGetItemTypeOperationCompletedParametersTypes);

            // Assert
            methodOnGetItemTypeOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetItemTypeOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemTypeOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemTypeOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetItemTypeOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateFolder) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateFolder_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var Folder = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateFolder(Folder, Parent, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateFolder_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var Folder = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateFolderParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Property[]) };
            object[] parametersOfCreateFolder = { Folder, Parent, Properties };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFolder, methodCreateFolderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfCreateFolder);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateFolder.ShouldNotBeNull();
            parametersOfCreateFolder.Length.ShouldBe(3);
            methodCreateFolderParametersTypes.Length.ShouldBe(3);
            methodCreateFolderParametersTypes.Length.ShouldBe(parametersOfCreateFolder.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateFolder_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var Folder = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateFolderParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Property[]) };
            object[] parametersOfCreateFolder = { Folder, Parent, Properties };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateFolder, parametersOfCreateFolder, methodCreateFolderParametersTypes);

            // Assert
            parametersOfCreateFolder.ShouldNotBeNull();
            parametersOfCreateFolder.Length.ShouldBe(3);
            methodCreateFolderParametersTypes.Length.ShouldBe(3);
            methodCreateFolderParametersTypes.Length.ShouldBe(parametersOfCreateFolder.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateFolder_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFolder, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateFolder_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var methodCreateFolderParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Property[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateFolder, methodCreateFolderParametersTypes);

            // Assert
            methodCreateFolderParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFolder) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateFolder_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFolder, 0);

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