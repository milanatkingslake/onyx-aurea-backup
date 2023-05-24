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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.CampaignTreeDataSource" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CampaignTreeDataSourceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CampaignTreeDataSource" />)
        /// </summary>
        public CampaignTreeDataSourceTest() : base(typeof(CampaignTreeDataSource))
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

        #region General Initializer : Class (CampaignTreeDataSource) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _campaignTreeDataSourceInstanceType;
        private CampaignTreeDataSource _campaignTreeDataSourceInstance;
        private CampaignTreeDataSource _campaignTreeDataSourceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CampaignTreeDataSource" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _campaignTreeDataSourceInstanceType = typeof(CampaignTreeDataSource);
            _campaignTreeDataSourceInstanceFixture = this.Create<CampaignTreeDataSource>(false);
            _campaignTreeDataSourceInstance = _campaignTreeDataSourceInstanceFixture ?? this.Create<CampaignTreeDataSource>(true);
            CurrentInstance = _campaignTreeDataSourceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CampaignTreeDataSource) Initializer

        #region Properties

        private const string PropertyTreeSource = "TreeSource";

        #endregion

        #region Methods

        private const string MethodGetCampaignPickerXML = "GetCampaignPickerXML";
        private const string MethodIsChildExists = "IsChildExists";
        private const string MethodGetCampaignTreeItems = "GetCampaignTreeItems";

        #endregion

        #endregion

        #region General Initializer : Class (CampaignTreeDataSource) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CampaignTreeDataSource" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CampaignTreeDataSource_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CampaignTreeDataSource) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CampaignTreeDataSource" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CampaignTreeDataSource_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CampaignTreeDataSource) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CampaignTreeDataSource" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CampaignTreeDataSource_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CampaignTreeDataSource)

        #region General Initializer : Class (CampaignTreeDataSource) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CampaignTreeDataSource" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCampaignPickerXML, 0)]
        [TestCase(MethodIsChildExists, 0)]
        [TestCase(MethodGetCampaignTreeItems, 0)]
        public void AUT_CampaignTreeDataSource_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CampaignTreeDataSource) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CampaignTreeDataSource" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTreeSource)]
        [Category("AUT Property")]
        public void AUT_CampaignTreeDataSource_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (CampaignTreeDataSource) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CampaignTreeDataSource" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CampaignTreeDataSource_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _campaignTreeDataSourceInstance.ShouldBeAssignableTo<CampaignTreeDataSource>();
            _campaignTreeDataSourceInstanceFixture.ShouldBeAssignableTo<CampaignTreeDataSource>();
            CurrentInstance.ShouldBeAssignableTo<CampaignTreeDataSource>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CampaignTreeDataSource) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTreeSource)]
        public void AUT_CampaignTreeDataSource_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CampaignTreeDataSource) => Property (TreeSource) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CampaignTreeDataSource_Public_Class_TreeSource_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTreeSource);
            var propertyInfo = this.GetPropertyInfo(PropertyTreeSource);

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

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignPickerXML_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);

            // Act
            Action executeAction = () => CampaignTreeDataSource.GetCampaignPickerXML();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignPickerXML_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = CampaignTreeDataSource.GetCampaignPickerXML();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignPickerXML_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;
            object[] parametersOfGetCampaignPickerXML = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetCampaignPickerXML, parametersOfGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCampaignPickerXML.ShouldBeNull();
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetCampaignPickerXML, parametersOfGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes));
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignPickerXML_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;
            object[] parametersOfGetCampaignPickerXML = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_campaignTreeDataSourceInstanceFixture, parametersOfGetCampaignPickerXML);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCampaignPickerXML.ShouldBeNull();
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignPickerXML_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;
            object[] parametersOfGetCampaignPickerXML = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCampaignPickerXML, parametersOfGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);

            // Assert
            parametersOfGetCampaignPickerXML.ShouldBeNull();
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignPickerXML_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignPickerXML_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            Type [] methodGetCampaignPickerXMLParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCampaignPickerXML, methodGetCampaignPickerXMLParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCampaignPickerXMLParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignPickerXML) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignPickerXML_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignPickerXML);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignPickerXML, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_Internally(Type[] types)
        {
            var methodIsChildExistsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var pickerName = this.CreateType<string>();
            var cacheName = this.CreateType<XDocument>();
            var typeNode = this.CreateType<XName>();
            var parentIdNode = this.CreateType<XName>();
            var typeNodeValue = this.CreateType<string>();
            var parentIdNodeValue = this.CreateType<string>();
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };
            object[] parametersOfIsChildExists = { pickerName, cacheName, typeNode, parentIdNode, typeNodeValue, parentIdNodeValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsChildExists, methodIsChildExistsParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodIsChildExists, parametersOfIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsChildExists.ShouldNotBeNull();
            parametersOfIsChildExists.Length.ShouldBe(6);
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodIsChildExists, parametersOfIsChildExists, methodIsChildExistsParametersTypes));
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var pickerName = this.CreateType<string>();
            var cacheName = this.CreateType<XDocument>();
            var typeNode = this.CreateType<XName>();
            var parentIdNode = this.CreateType<XName>();
            var typeNodeValue = this.CreateType<string>();
            var parentIdNodeValue = this.CreateType<string>();
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };
            object[] parametersOfIsChildExists = { pickerName, cacheName, typeNode, parentIdNode, typeNodeValue, parentIdNodeValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsChildExists, methodIsChildExistsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_campaignTreeDataSourceInstanceFixture, parametersOfIsChildExists);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsChildExists.ShouldNotBeNull();
            parametersOfIsChildExists.Length.ShouldBe(6);
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var pickerName = this.CreateType<string>();
            var cacheName = this.CreateType<XDocument>();
            var typeNode = this.CreateType<XName>();
            var parentIdNode = this.CreateType<XName>();
            var typeNodeValue = this.CreateType<string>();
            var parentIdNodeValue = this.CreateType<string>();
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };
            object[] parametersOfIsChildExists = { pickerName, cacheName, typeNode, parentIdNode, typeNodeValue, parentIdNodeValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsChildExists, parametersOfIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            parametersOfIsChildExists.ShouldNotBeNull();
            parametersOfIsChildExists.Length.ShouldBe(6);
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsChildExistsParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var methodIsChildExistsParametersTypes = new Type[] { typeof(string), typeof(XDocument), typeof(XName), typeof(XName), typeof(string), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsChildExists, methodIsChildExistsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsChildExistsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var currentMethodInfo = this.GetMethodInfo(MethodIsChildExists, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsChildExists) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_IsChildExists_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsChildExists);
            var currentMethodInfo = this.GetMethodInfo(MethodIsChildExists, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CampaignTreeDataSource_GetCampaignTreeItems_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetCampaignTreeItemsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCampaignTreeItems, methodGetCampaignTreeItemsParametersTypes);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var treeItem = this.CreateType<TreeData>();
            var methodGetCampaignTreeItemsParametersTypes = new Type[] { typeof(TreeData) };
            object[] parametersOfGetCampaignTreeItems = { treeItem };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTreeItems, methodGetCampaignTreeItemsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_campaignTreeDataSourceInstanceFixture, parametersOfGetCampaignTreeItems);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetCampaignTreeItems.ShouldNotBeNull();
            parametersOfGetCampaignTreeItems.Length.ShouldBe(1);
            methodGetCampaignTreeItemsParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignTreeItems_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var treeItem = this.CreateType<TreeData>();
            var methodGetCampaignTreeItemsParametersTypes = new Type[] { typeof(TreeData) };
            object[] parametersOfGetCampaignTreeItems = { treeItem };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetCampaignTreeItems, parametersOfGetCampaignTreeItems, methodGetCampaignTreeItemsParametersTypes);

            // Assert
            parametersOfGetCampaignTreeItems.ShouldNotBeNull();
            parametersOfGetCampaignTreeItems.Length.ShouldBe(1);
            methodGetCampaignTreeItemsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignTreeItems_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTreeItems, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignTreeItems_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var methodGetCampaignTreeItemsParametersTypes = new Type[] { typeof(TreeData) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCampaignTreeItems, methodGetCampaignTreeItemsParametersTypes);

            // Assert
            methodGetCampaignTreeItemsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignTreeItems) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CampaignTreeDataSource_GetCampaignTreeItems_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTreeItems);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTreeItems, 0);

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