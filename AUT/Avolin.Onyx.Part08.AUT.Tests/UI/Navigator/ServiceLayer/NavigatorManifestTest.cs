using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.ServiceLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.NavigatorManifest" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorManifestTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorManifest" />)
        /// </summary>
        public NavigatorManifestTest() : base(typeof(NavigatorManifest))
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

        #region General Initializer : Class (NavigatorManifest) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorManifestInstanceType;
        private NavigatorManifest _navigatorManifestInstance;
        private NavigatorManifest _navigatorManifestInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorManifest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorManifestInstanceType = typeof(NavigatorManifest);
            _navigatorManifestInstanceFixture = this.Create<NavigatorManifest>(false);
            _navigatorManifestInstance = _navigatorManifestInstanceFixture ?? this.Create<NavigatorManifest>(true);
            CurrentInstance = _navigatorManifestInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorManifest) Initializer

        #region Properties

        private const string PropertyResourceUriRoot = "ResourceUriRoot";
        private const string PropertyCurrentResource = "CurrentResource";
        private const string PropertyServiceEndPoint = "ServiceEndPoint";
        private const string PropertyQueryString = "QueryString";
        private const string PropertyParameterCollection = "ParameterCollection";
        private const string PropertyHttpVerb = "HttpVerb";
        private const string PropertyIncomingHttpWebRequest = "IncomingHttpWebRequest";
        private const string PropertyContent = "Content";

        #endregion

        #region Methods

        private const string MethodToString = "ToString";

        #endregion

        #region Fields

        private const string FieldserviceGatewayEndPoint = "serviceGatewayEndPoint";

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorManifest) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorManifest" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorManifest_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorManifest) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NavigatorManifest" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorManifest_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorManifest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorManifest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorManifest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorManifest)

        #region General Initializer : Class (NavigatorManifest) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorManifest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodToString, 0)]
        public void AUT_NavigatorManifest_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NavigatorManifest) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorManifest" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResourceUriRoot)]
        [TestCase(PropertyCurrentResource)]
        [TestCase(PropertyServiceEndPoint)]
        [TestCase(PropertyQueryString)]
        [TestCase(PropertyParameterCollection)]
        [TestCase(PropertyHttpVerb)]
        [TestCase(PropertyIncomingHttpWebRequest)]
        [TestCase(PropertyContent)]
        [Category("AUT Property")]
        public void AUT_NavigatorManifest_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (NavigatorManifest) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorManifest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldserviceGatewayEndPoint)]
        [Category("AUT Fields")]
        public void AUT_NavigatorManifest_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NavigatorManifest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorManifest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorManifest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorManifestInstance.ShouldBeAssignableTo<NavigatorManifest>();
            _navigatorManifestInstanceFixture.ShouldBeAssignableTo<NavigatorManifest>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorManifest>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NavigatorManifest) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResourceUriRoot)]
        [TestCase(PropertyCurrentResource)]
        [TestCase(PropertyServiceEndPoint)]
        [TestCase(PropertyQueryString)]
        [TestCase(PropertyParameterCollection)]
        [TestCase(PropertyHttpVerb)]
        [TestCase(PropertyIncomingHttpWebRequest)]
        [TestCase(PropertyContent)]
        public void AUT_NavigatorManifest_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NavigatorManifest) => Property (Content) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorManifest_Public_Class_Content_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContent);
            var propertyInfo = this.GetPropertyInfo(PropertyContent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorManifest) => Property (CurrentResource) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorManifest_Public_Class_CurrentResource_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCurrentResource);
            var propertyInfo = this.GetPropertyInfo(PropertyCurrentResource);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorManifest) => Property (HttpVerb) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorManifest_Public_Class_HttpVerb_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHttpVerb);
            var propertyInfo = this.GetPropertyInfo(PropertyHttpVerb);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorManifest) => Property (IncomingHttpWebRequest) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorManifest_Public_Class_IncomingHttpWebRequest_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncomingHttpWebRequest);
            var propertyInfo = this.GetPropertyInfo(PropertyIncomingHttpWebRequest);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorManifest) => Property (ParameterCollection) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorManifest_Public_Class_ParameterCollection_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterCollection);
            var propertyInfo = this.GetPropertyInfo(PropertyParameterCollection);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorManifest) => Property (QueryString) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorManifest_Public_Class_QueryString_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryString);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryString);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorManifest) => Property (ResourceUriRoot) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorManifest_Public_Class_ResourceUriRoot_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceUriRoot);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceUriRoot);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorManifest) => Property (ServiceEndPoint) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorManifest_Public_Class_ServiceEndPoint_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyServiceEndPoint);
            var propertyInfo = this.GetPropertyInfo(PropertyServiceEndPoint);

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

        #region Method Call : (ToString) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorManifest_ToString_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);

            // Act
            Action executeAction = () => _navigatorManifestInstance.ToString();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorManifest_ToString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorManifestInstance.ToString();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorManifest_ToString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;
            object[] parametersOfToString = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodToString, methodToStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorManifestInstanceFixture, parametersOfToString);
            var result2 = this.GetResultOfMethod<string>(MethodToString, parametersOfToString, methodToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfToString.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorManifest_ToString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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

        #region Method Call : (ToString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorManifest_ToString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            Type [] methodToStringParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodToString, methodToStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodToStringParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorManifest_ToString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (ToString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorManifest_ToString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodToString);
            var currentMethodInfo = this.GetMethodInfo(MethodToString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}