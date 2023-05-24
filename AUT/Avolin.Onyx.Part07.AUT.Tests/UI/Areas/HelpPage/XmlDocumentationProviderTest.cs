using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Web.Http.Controllers;
using System.Xml.XPath;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.XmlDocumentationProvider" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class XmlDocumentationProviderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="XmlDocumentationProvider" />)
        /// </summary>
        public XmlDocumentationProviderTest() : base(typeof(XmlDocumentationProvider))
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

        #region General Initializer : Class (XmlDocumentationProvider) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _xmlDocumentationProviderInstanceType;
        private XmlDocumentationProvider _xmlDocumentationProviderInstance;
        private XmlDocumentationProvider _xmlDocumentationProviderInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="XmlDocumentationProvider" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _xmlDocumentationProviderInstanceType = typeof(XmlDocumentationProvider);
            _xmlDocumentationProviderInstanceFixture = this.Create<XmlDocumentationProvider>(false);
            _xmlDocumentationProviderInstance = _xmlDocumentationProviderInstanceFixture ?? this.Create<XmlDocumentationProvider>(true);
            CurrentInstance = _xmlDocumentationProviderInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (XmlDocumentationProvider) Initializer

        #region Methods

        private const string MethodGetDocumentation = "GetDocumentation";
        private const string MethodGetResponseDocumentation = "GetResponseDocumentation";
        private const string MethodGetMethodNode = "GetMethodNode";
        private const string MethodGetMemberName = "GetMemberName";
        private const string MethodGetTagValue = "GetTagValue";
        private const string MethodGetTypeNode = "GetTypeNode";
        private const string MethodGetTypeName = "GetTypeName";

        #endregion

        #region Fields

        private const string Field_documentNavigator = "_documentNavigator";
        private const string FieldTypeExpression = "TypeExpression";
        private const string FieldMethodExpression = "MethodExpression";
        private const string FieldPropertyExpression = "PropertyExpression";
        private const string FieldFieldExpression = "FieldExpression";
        private const string FieldParameterExpression = "ParameterExpression";

        #endregion

        #endregion

        #region General Initializer : Class (XmlDocumentationProvider) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="XmlDocumentationProvider" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlDocumentationProvider_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (XmlDocumentationProvider) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="XmlDocumentationProvider" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_XmlDocumentationProvider_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (XmlDocumentationProvider)

        #region General Initializer : Class (XmlDocumentationProvider) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="XmlDocumentationProvider" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDocumentation, 0)]
        [TestCase(MethodGetDocumentation, 1)]
        [TestCase(MethodGetDocumentation, 2)]
        [TestCase(MethodGetResponseDocumentation, 0)]
        [TestCase(MethodGetDocumentation, 3)]
        [TestCase(MethodGetDocumentation, 4)]
        [TestCase(MethodGetMethodNode, 0)]
        [TestCase(MethodGetMemberName, 0)]
        [TestCase(MethodGetTagValue, 0)]
        [TestCase(MethodGetTypeNode, 0)]
        [TestCase(MethodGetTypeName, 0)]
        public void AUT_XmlDocumentationProvider_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (XmlDocumentationProvider) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="XmlDocumentationProvider" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_documentNavigator)]
        [TestCase(FieldTypeExpression)]
        [TestCase(FieldMethodExpression)]
        [TestCase(FieldPropertyExpression)]
        [TestCase(FieldFieldExpression)]
        [TestCase(FieldParameterExpression)]
        [Category("AUT Fields")]
        public void AUT_XmlDocumentationProvider_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (XmlDocumentationProvider) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="XmlDocumentationProvider" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_XmlDocumentationProvider_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _xmlDocumentationProviderInstance.ShouldBeAssignableTo<XmlDocumentationProvider>();
            _xmlDocumentationProviderInstanceFixture.ShouldBeAssignableTo<XmlDocumentationProvider>();
            CurrentInstance.ShouldBeAssignableTo<XmlDocumentationProvider>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetDocumentation) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var controllerDescriptor = this.CreateType<HttpControllerDescriptor>();

            // Act
            Action executeAction = () => _xmlDocumentationProviderInstance.GetDocumentation(controllerDescriptor);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var controllerDescriptor = this.CreateType<HttpControllerDescriptor>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlDocumentationProviderInstance.GetDocumentation(controllerDescriptor);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var controllerDescriptor = this.CreateType<HttpControllerDescriptor>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpControllerDescriptor) };
            object[] parametersOfGetDocumentation = { controllerDescriptor };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, methodGetDocumentationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlDocumentationProviderInstanceFixture, parametersOfGetDocumentation);
            var result2 = this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var controllerDescriptor = this.CreateType<HttpControllerDescriptor>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpControllerDescriptor) };
            object[] parametersOfGetDocumentation = { controllerDescriptor };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpControllerDescriptor) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpControllerDescriptor) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDocumentationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetDocumentation_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetDocumentationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);
        }

        #endregion
        
        #region Method Call : (GetDocumentation) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var actionDescriptor = this.CreateType<HttpActionDescriptor>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlDocumentationProviderInstance.GetDocumentation(actionDescriptor);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var actionDescriptor = this.CreateType<HttpActionDescriptor>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            object[] parametersOfGetDocumentation = { actionDescriptor };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, methodGetDocumentationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlDocumentationProviderInstanceFixture, parametersOfGetDocumentation);
            var result2 = this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var actionDescriptor = this.CreateType<HttpActionDescriptor>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            object[] parametersOfGetDocumentation = { actionDescriptor };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpActionDescriptor) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDocumentationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetDocumentation_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodGetDocumentationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);
        }

        #endregion
        
        #region Method Call : (GetDocumentation) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_DirectCall_Overloading_Of_2_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var parameterDescriptor = this.CreateType<HttpParameterDescriptor>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlDocumentationProviderInstance.GetDocumentation(parameterDescriptor);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_2_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var parameterDescriptor = this.CreateType<HttpParameterDescriptor>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpParameterDescriptor) };
            object[] parametersOfGetDocumentation = { parameterDescriptor };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, methodGetDocumentationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlDocumentationProviderInstanceFixture, parametersOfGetDocumentation);
            var result2 = this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var parameterDescriptor = this.CreateType<HttpParameterDescriptor>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpParameterDescriptor) };
            object[] parametersOfGetDocumentation = { parameterDescriptor };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpParameterDescriptor) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(HttpParameterDescriptor) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDocumentationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 2);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseDocumentation) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetResponseDocumentation_Method_Call_Internally(Type[] types)
        {
            var methodGetResponseDocumentationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResponseDocumentation, methodGetResponseDocumentationParametersTypes);
        }

        #endregion
        
        #region Method Call : (GetResponseDocumentation) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetResponseDocumentation_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseDocumentation);
            var actionDescriptor = this.CreateType<HttpActionDescriptor>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlDocumentationProviderInstance.GetResponseDocumentation(actionDescriptor);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetResponseDocumentation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseDocumentation);
            var actionDescriptor = this.CreateType<HttpActionDescriptor>();
            var methodGetResponseDocumentationParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            object[] parametersOfGetResponseDocumentation = { actionDescriptor };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseDocumentation, methodGetResponseDocumentationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlDocumentationProviderInstanceFixture, parametersOfGetResponseDocumentation);
            var result2 = this.GetResultOfMethod<string>(MethodGetResponseDocumentation, parametersOfGetResponseDocumentation, methodGetResponseDocumentationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResponseDocumentation.ShouldNotBeNull();
            parametersOfGetResponseDocumentation.Length.ShouldBe(1);
            methodGetResponseDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResponseDocumentation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetResponseDocumentation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseDocumentation);
            var actionDescriptor = this.CreateType<HttpActionDescriptor>();
            var methodGetResponseDocumentationParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            object[] parametersOfGetResponseDocumentation = { actionDescriptor };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetResponseDocumentation, parametersOfGetResponseDocumentation, methodGetResponseDocumentationParametersTypes);

            // Assert
            parametersOfGetResponseDocumentation.ShouldNotBeNull();
            parametersOfGetResponseDocumentation.Length.ShouldBe(1);
            methodGetResponseDocumentationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetResponseDocumentation_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseDocumentation);
            var methodGetResponseDocumentationParametersTypes = new Type[] { typeof(HttpActionDescriptor) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResponseDocumentation, methodGetResponseDocumentationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResponseDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResponseDocumentation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetResponseDocumentation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseDocumentation);
            var methodGetResponseDocumentationParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResponseDocumentation, methodGetResponseDocumentationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResponseDocumentationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseDocumentation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetResponseDocumentation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseDocumentation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseDocumentation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetResponseDocumentation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseDocumentation, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetDocumentation_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodGetDocumentationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_DirectCall_Overloading_Of_3_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var member = this.CreateType<MemberInfo>();

            // Act
            Action executeAction = () => _xmlDocumentationProviderInstance.GetDocumentation(member);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_DirectCall_Overloading_Of_3_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var member = this.CreateType<MemberInfo>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlDocumentationProviderInstance.GetDocumentation(member);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_3_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var member = this.CreateType<MemberInfo>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(MemberInfo) };
            object[] parametersOfGetDocumentation = { member };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, methodGetDocumentationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlDocumentationProviderInstanceFixture, parametersOfGetDocumentation);
            var result2 = this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_3_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var member = this.CreateType<MemberInfo>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(MemberInfo) };
            object[] parametersOfGetDocumentation = { member };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(MemberInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_3_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(MemberInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDocumentationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 3);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 3);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetDocumentation_Method_Overloading_Of_4_Call_Internally(Type[] types)
        {
            var methodGetDocumentationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_DirectCall_Overloading_Of_4_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var type = this.CreateType<Type>();

            // Act
            Action executeAction = () => _xmlDocumentationProviderInstance.GetDocumentation(type);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_DirectCall_Overloading_Of_4_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var type = this.CreateType<Type>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _xmlDocumentationProviderInstance.GetDocumentation(type);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_4_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var type = this.CreateType<Type>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetDocumentation = { type };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, methodGetDocumentationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_xmlDocumentationProviderInstanceFixture, parametersOfGetDocumentation);
            var result2 = this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_4_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var type = this.CreateType<Type>();
            var methodGetDocumentationParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetDocumentation = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDocumentation, parametersOfGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            parametersOfGetDocumentation.ShouldNotBeNull();
            parametersOfGetDocumentation.Length.ShouldBe(1);
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_4_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDocumentationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_4_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var methodGetDocumentationParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDocumentation, methodGetDocumentationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDocumentationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_4_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 4);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDocumentation) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetDocumentation_Method_Call_Overloading_Of_4_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDocumentation);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDocumentation, 4);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMethodNode) (Return Type : XPathNavigator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetMethodNode_Method_Call_Internally(Type[] types)
        {
            var methodGetMethodNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMethodNode, methodGetMethodNodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetMethodNode) (Return Type : XPathNavigator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMethodNode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodNode);
            var actionDescriptor = this.CreateType<HttpActionDescriptor>();
            var methodGetMethodNodeParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            object[] parametersOfGetMethodNode = { actionDescriptor };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodNode, methodGetMethodNodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XPathNavigator>(_xmlDocumentationProviderInstanceFixture, parametersOfGetMethodNode);
            var result2 = this.GetResultOfMethod<XPathNavigator>(MethodGetMethodNode, parametersOfGetMethodNode, methodGetMethodNodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMethodNode.ShouldNotBeNull();
            parametersOfGetMethodNode.Length.ShouldBe(1);
            methodGetMethodNodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMethodNode) (Return Type : XPathNavigator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMethodNode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodNode);
            var actionDescriptor = this.CreateType<HttpActionDescriptor>();
            var methodGetMethodNodeParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            object[] parametersOfGetMethodNode = { actionDescriptor };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XPathNavigator>(MethodGetMethodNode, parametersOfGetMethodNode, methodGetMethodNodeParametersTypes);

            // Assert
            parametersOfGetMethodNode.ShouldNotBeNull();
            parametersOfGetMethodNode.Length.ShouldBe(1);
            methodGetMethodNodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMethodNode) (Return Type : XPathNavigator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMethodNode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodNode);
            var methodGetMethodNodeParametersTypes = new Type[] { typeof(HttpActionDescriptor) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMethodNode, methodGetMethodNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMethodNodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMethodNode) (Return Type : XPathNavigator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMethodNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodNode);
            var methodGetMethodNodeParametersTypes = new Type[] { typeof(HttpActionDescriptor) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMethodNode, methodGetMethodNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMethodNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMethodNode) (Return Type : XPathNavigator) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMethodNode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMethodNode) (Return Type : XPathNavigator) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMethodNode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMethodNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMethodNode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetMemberName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetMemberNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMemberName, methodGetMemberNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMemberName_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var method = this.CreateType<MethodInfo>();
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MethodInfo) };
            object[] parametersOfGetMemberName = { method };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMemberName, methodGetMemberNameParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetMemberName, methodGetMemberNameParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetMemberName, parametersOfGetMemberName, methodGetMemberNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMemberName.ShouldNotBeNull();
            parametersOfGetMemberName.Length.ShouldBe(1);
            methodGetMemberNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetMemberName, parametersOfGetMemberName, methodGetMemberNameParametersTypes));
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMemberName_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var method = this.CreateType<MethodInfo>();
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MethodInfo) };
            object[] parametersOfGetMemberName = { method };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMemberName, methodGetMemberNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlDocumentationProviderInstanceFixture, parametersOfGetMemberName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMemberName.ShouldNotBeNull();
            parametersOfGetMemberName.Length.ShouldBe(1);
            methodGetMemberNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMemberName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var method = this.CreateType<MethodInfo>();
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MethodInfo) };
            object[] parametersOfGetMemberName = { method };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMemberName, parametersOfGetMemberName, methodGetMemberNameParametersTypes);

            // Assert
            parametersOfGetMemberName.ShouldNotBeNull();
            parametersOfGetMemberName.Length.ShouldBe(1);
            methodGetMemberNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMemberName_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MethodInfo) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMemberName, methodGetMemberNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetMemberNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMemberName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var methodGetMemberNameParametersTypes = new Type[] { typeof(MethodInfo) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMemberName, methodGetMemberNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMemberNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMemberName_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMemberName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMemberName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetMemberName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMemberName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMemberName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTagValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetTagValue_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetTagValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTagValue, methodGetTagValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetTagValue) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTagValue_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTagValue);
            var parentNode = this.CreateType<XPathNavigator>();
            var tagName = this.CreateType<string>();
            var methodGetTagValueParametersTypes = new Type[] { typeof(XPathNavigator), typeof(string) };
            object[] parametersOfGetTagValue = { parentNode, tagName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTagValue, methodGetTagValueParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlDocumentationProviderInstanceFixture, parametersOfGetTagValue);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetTagValue.ShouldNotBeNull();
            parametersOfGetTagValue.Length.ShouldBe(2);
            methodGetTagValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTagValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTagValue_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTagValue);
            var parentNode = this.CreateType<XPathNavigator>();
            var tagName = this.CreateType<string>();
            var methodGetTagValueParametersTypes = new Type[] { typeof(XPathNavigator), typeof(string) };
            object[] parametersOfGetTagValue = { parentNode, tagName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTagValue, parametersOfGetTagValue, methodGetTagValueParametersTypes);

            // Assert
            parametersOfGetTagValue.ShouldNotBeNull();
            parametersOfGetTagValue.Length.ShouldBe(2);
            methodGetTagValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTagValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTagValue_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTagValue);
            var methodGetTagValueParametersTypes = new Type[] { typeof(XPathNavigator), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTagValue, methodGetTagValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTagValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetTagValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTagValue_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTagValue);
            var methodGetTagValueParametersTypes = new Type[] { typeof(XPathNavigator), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTagValue, methodGetTagValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTagValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTagValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTagValue_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTagValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTagValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTagValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTagValue_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTagValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTagValue, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTypeNode) (Return Type : XPathNavigator) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetTypeNode_Method_Call_Internally(Type[] types)
        {
            var methodGetTypeNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTypeNode, methodGetTypeNodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetTypeNode) (Return Type : XPathNavigator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeNode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeNode);
            var type = this.CreateType<Type>();
            var methodGetTypeNodeParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeNode = { type };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypeNode, methodGetTypeNodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XPathNavigator>(_xmlDocumentationProviderInstanceFixture, parametersOfGetTypeNode);
            var result2 = this.GetResultOfMethod<XPathNavigator>(MethodGetTypeNode, parametersOfGetTypeNode, methodGetTypeNodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTypeNode.ShouldNotBeNull();
            parametersOfGetTypeNode.Length.ShouldBe(1);
            methodGetTypeNodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTypeNode) (Return Type : XPathNavigator) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeNode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeNode);
            var type = this.CreateType<Type>();
            var methodGetTypeNodeParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeNode = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XPathNavigator>(MethodGetTypeNode, parametersOfGetTypeNode, methodGetTypeNodeParametersTypes);

            // Assert
            parametersOfGetTypeNode.ShouldNotBeNull();
            parametersOfGetTypeNode.Length.ShouldBe(1);
            methodGetTypeNodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTypeNode) (Return Type : XPathNavigator) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeNode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeNode);
            var methodGetTypeNodeParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTypeNode, methodGetTypeNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTypeNodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTypeNode) (Return Type : XPathNavigator) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeNode);
            var methodGetTypeNodeParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTypeNode, methodGetTypeNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTypeNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTypeNode) (Return Type : XPathNavigator) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeNode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypeNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTypeNode) (Return Type : XPathNavigator) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeNode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeNode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypeNode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTypeName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_XmlDocumentationProvider_GetTypeName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetTypeNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTypeName, methodGetTypeNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetTypeName) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeName_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeName);
            var type = this.CreateType<Type>();
            var methodGetTypeNameParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeName = { type };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypeName, methodGetTypeNameParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetTypeName, methodGetTypeNameParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetTypeName, parametersOfGetTypeName, methodGetTypeNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetTypeName.ShouldNotBeNull();
            parametersOfGetTypeName.Length.ShouldBe(1);
            methodGetTypeNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetTypeName, parametersOfGetTypeName, methodGetTypeNameParametersTypes));
        }

        #endregion

        #region Method Call : (GetTypeName) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeName_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeName);
            var type = this.CreateType<Type>();
            var methodGetTypeNameParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeName = { type };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypeName, methodGetTypeNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_xmlDocumentationProviderInstanceFixture, parametersOfGetTypeName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetTypeName.ShouldNotBeNull();
            parametersOfGetTypeName.Length.ShouldBe(1);
            methodGetTypeNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTypeName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeName);
            var type = this.CreateType<Type>();
            var methodGetTypeNameParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetTypeName = { type };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTypeName, parametersOfGetTypeName, methodGetTypeNameParametersTypes);

            // Assert
            parametersOfGetTypeName.ShouldNotBeNull();
            parametersOfGetTypeName.Length.ShouldBe(1);
            methodGetTypeNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTypeName) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeName_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeName);
            var methodGetTypeNameParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTypeName, methodGetTypeNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetTypeNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTypeName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeName);
            var methodGetTypeNameParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTypeName, methodGetTypeNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTypeNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTypeName) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeName_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypeName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetTypeName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_XmlDocumentationProvider_GetTypeName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypeName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypeName, 0);
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